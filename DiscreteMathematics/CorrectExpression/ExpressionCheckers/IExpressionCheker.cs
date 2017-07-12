namespace DiscreteMathematics.CorrectExpression.ExpressionCheckers
{
    public interface IExpressionCheker
    {
        void Clear();
        void Push(string symbol);
        void Pop(string lastSymbol);
        string GetAvailableSymbols(string lastSymbol);
    }
}
