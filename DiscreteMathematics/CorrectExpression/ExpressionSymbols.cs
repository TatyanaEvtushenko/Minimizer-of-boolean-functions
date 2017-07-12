namespace DiscreteMathematics.CorrectExpression
{
    public static class ExpressionSymbols
    {
        public const string Not = "¬";
        public const string And = "*";
        public const string Or = "+";
        public const string OpeningBracket = "(";
        public const string ClosingBracket = ")";
        public const string Equally = "=";
        public const string True = "1";
        public const string False = "0";
        public const string Letters =
            "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNMЁЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮёйцукенгшщзхъфывапролджэячсмитьбю";

        public static readonly string Operands = True + False + Letters;
        public static readonly string Operations = And + Or;
    }
}
