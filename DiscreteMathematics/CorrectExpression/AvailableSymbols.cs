using System.Linq;

namespace DiscreteMathematics
{
    class AvailabilityOfCategory
    {
        public bool OperandsAvailability;

        bool operationEnabled, bool notEnabled, bool bracketOpenEnabled,
        private bool bracketCloseEnabled;

        public AvailabilityOfCategory()
    }

    static class AvailableSymbols
    {
        public const char Not = '¬';
        public const char And = '*';
        public const char Or = '+';
        public const char True = '1';
        public const char False = '0';
        public const char OpenBracket = '(';
        public const char CloseBracket = ')';
        public const char Equally = '=';
        public const string Letters =
            "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNMЁЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮёйцукенгшщзхъфывапролджэячсмитьбю";

        public static readonly char[] OpeningSymbols = {Not, And, Or, OpenBracket};
        public static readonly char[] SymbolsOfOperands = {True, False};

        public static AvailabilityOfCategory GetAvailabilityOfCategory(char lastSymbol)
        {
            return OpeningSymbols.Contains(lastSymbol) ? new AvailabilityOfCategory {} : new AvailabilityOfCategory();
        }
    }
}
