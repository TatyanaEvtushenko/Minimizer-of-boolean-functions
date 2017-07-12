using System.Windows;
using System.Windows.Controls;
using DiscreteMathematics;

namespace Минимизатор_булевых_функций
{
    public partial class MainWindow
    {
        private int _countOfBrackets;
        private readonly Calculator _calculator = new Calculator();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddToTextBox(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            TextBoxResult.Text += button.Content;
        }

        private void ClickClear(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = "";
            _countOfBrackets = 0;
        }

        private void ClickEsc(object sender, RoutedEventArgs e)
        {
            var lastIndex = TextBoxResult.Text.Length - 1;
            var symbol = TextBoxResult.Text[lastIndex];
            if (symbol == AvailableSymbols.OpenBracket)
                _countOfBrackets--;
            if (symbol == AvailableSymbols.CloseBracket)
                _countOfBrackets++;
            TextBoxResult.Text = TextBoxResult.Text.Substring(0, lastIndex);
        }

        private void ClickCount(object sender, RoutedEventArgs e)
        {
            var str = TextBoxResult.Text;
            TextBoxResult.Text = _calculator.Minimization(str);
            TextBoxOldResult.Text = str + $"\n {AvailableSymbols.Equally} ";
        }

        private void ChangeEnabled(bool operandEnabled, bool operationEnabled, bool notEnabled, bool bracketOpenEnabled, bool bracketCloseEnabled)
        {
            ButtonOperand0.IsEnabled = ButtonOperand1.IsEnabled = ButtonOperand2.IsEnabled = ButtonOperand3.IsEnabled = ButtonOperand4.IsEnabled
                = ButtonOperand5.IsEnabled = ButtonOperand6.IsEnabled = ButtonOperand7.IsEnabled = ButtonOperand8.IsEnabled = ButtonOperand9.IsEnabled = operandEnabled;
            ButtonOperation0.IsEnabled = ButtonOperation1.IsEnabled = operationEnabled;
            ButtonNot.IsEnabled = notEnabled;
            ButtonBracketOpen.IsEnabled = bracketOpenEnabled;
            ButtonBracketClose.IsEnabled = bracketCloseEnabled && _countOfBrackets > 0;
        }

        private void TextBoxResultChanged(object sender, TextChangedEventArgs e)
        {
            var length = TextBoxResult.Text.Length;
            if (length == 0)
            {
                ButtonEsc.IsEnabled = ButtonClear.IsEnabled = ButtonCount.IsEnabled = false;
                ChangeEnabled(true, false, true, true, false);
            }
            else
            {
                ButtonEsc.IsEnabled = ButtonClear.IsEnabled = true;
                var symbol = TextBoxResult.Text[TextBoxResult.Text.Length - 1];
                if (symbol == '(')
                    _countOfBrackets++;
                if (symbol == ')')
                    _countOfBrackets--;
                if (symbol == '*' || symbol == '+' || symbol == '¬' || symbol == '(')
                    ChangeEnabled(true, false, true, true, false);
                else
                    ChangeEnabled(false, true, false, false, true);
                ButtonCount.IsEnabled = _countOfBrackets == 0 && symbol != '*' && symbol != '+' && symbol != '¬';
            }
            TextBoxOldResult.Text = "";
        }
    }
}
