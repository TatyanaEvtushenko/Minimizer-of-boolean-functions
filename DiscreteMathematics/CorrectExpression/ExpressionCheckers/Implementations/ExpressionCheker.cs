using System.Collections.Generic;
using System.Linq;

namespace DiscreteMathematics.CorrectExpression.ExpressionCheckers.Implementations
{
    public class ExpressionCheker : IExpressionCheker
    {  
        private static readonly IDictionary<string, string> AvailableSymbolsAfterThis = new Dictionary<string, string>()
        {
            {
                string.Empty + ExpressionSymbols.OpeningBracket + ExpressionSymbols.Operations + ExpressionSymbols.Not,
                ExpressionSymbols.OpeningBracket + ExpressionSymbols.Operands + ExpressionSymbols.Not
            },
            {
                ExpressionSymbols.Operands + ExpressionSymbols.ClosingBracket,
                ExpressionSymbols.ClosingBracket + ExpressionSymbols.Operations + ExpressionSymbols.Equally
            }
        };

        private int _countOfBrackets;

        public void Clear()
        {
            _countOfBrackets = 0;
        }

        public void Push(string symbol)
        {
            if (symbol == ExpressionSymbols.OpeningBracket)
                _countOfBrackets++;
            if (symbol == ExpressionSymbols.ClosingBracket)
                _countOfBrackets--;
        }

        public void Pop(string lastSymbol)
        {
            if (lastSymbol == ExpressionSymbols.OpeningBracket)
                _countOfBrackets--;
            if (lastSymbol == ExpressionSymbols.ClosingBracket)
                _countOfBrackets++;
        }

        public string GetAvailableSymbols(string lastSymbol)
        {
            var availableSymbols = (from pair in AvailableSymbolsAfterThis
                where pair.Key.Contains(lastSymbol)
                select pair.Value).FirstOrDefault();
            if (_countOfBrackets <= 0)
            {
                availableSymbols = availableSymbols?.Replace(ExpressionSymbols.ClosingBracket, string.Empty);
            }
            if (_countOfBrackets != 0)
            {
                availableSymbols = availableSymbols?.Replace(ExpressionSymbols.Equally, string.Empty);
            }
            return availableSymbols;
        }
    }
}
