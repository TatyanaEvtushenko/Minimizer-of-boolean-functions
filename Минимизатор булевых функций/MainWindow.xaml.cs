using System.Windows;
using System.Windows.Controls;
using DiscreteMathematics.CorrectExpression.ExpressionCheckers;
using DiscreteMathematics.CorrectExpression.ExpressionCheckers.Implementations;
using DiscreteMathematics.Operations;

namespace Минимизатор_булевых_функций
{
    public partial class MainWindow
    {
        private readonly FunctionsMinimizer _calculator = new FunctionsMinimizer();
        private readonly IExpressionCheker _expressionCheker = new ExpressionCheker();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddToTextBox(object sender, RoutedEventArgs e)
        {
            var content = (sender as Button)?.Content.ToString();
            _expressionCheker.Push(content);
            TextBoxResult.Text += content;
        }

        private void ClickClear(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = "";
            _expressionCheker.Clear();
        }

        private void ClickEsc(object sender, RoutedEventArgs e)
        {
            var lastIndex = TextBoxResult.Text.Length - 1;
            var lastSymbol = TextBoxResult.Text[lastIndex].ToString();
            _expressionCheker.Pop(lastSymbol);
            TextBoxResult.Text = TextBoxResult.Text.Substring(0, lastIndex);
        }

        private void ClickCount(object sender, RoutedEventArgs e)
        {
            var str = TextBoxResult.Text;
            TextBoxResult.Text = _calculator.Minimization(str);
            TextBoxOldResult.Text = str + "\n =";
            _expressionCheker.Clear();
        }

        private void ChangeEnabled(string lastSymbol)
        {
            var availableSymbols = _expressionCheker.GetAvailableSymbols(lastSymbol);
            foreach (var child in GridSymbols.Children)
            {
                var button = child as Button;
                if (button == null) continue;
                var content = button.Content.ToString();
                button.IsEnabled = availableSymbols?.Contains(content) ?? false;
            }
        }

        private void TextBoxResultChanged(object sender, TextChangedEventArgs e)
        {
            var length = TextBoxResult.Text.Length;
            if (length > 0)
            {
                var lastSymbol = TextBoxResult.Text[length - 1].ToString();
                ChangeEnabled(lastSymbol);
                ButtonEsc.IsEnabled = ButtonClear.IsEnabled = true;
            }
            else
            {
                ChangeEnabled(string.Empty);
                ButtonEsc.IsEnabled = ButtonClear.IsEnabled = false;
            }
            TextBoxOldResult.Text = "";
        }
    }
}
