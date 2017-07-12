using System.Collections.Generic;

namespace DiscreteMathematics
{
    class Calculator
    {
        private List<string> tokens;

        public string Minimization(string expression)
        {
            //ConvertStrToTokens(expression);
            //Count();
            //var result = ConvertTokensToStr();
            //return result;
            return "erty";
        }

        //private void ConvertStrToTokens(string expression)
        //{
        //    int index;
        //    tokens = new List<string>();

        //    while ((index = expression.IndexOfAny(TOKENS)) >= 0)
        //    {
        //        if (index != 0)
        //            tokens.Add(expression.Substring(0, index));
        //        tokens.Add(expression.Substring(index, 1));
        //        expression = expression.Substring(index + 1);
        //    }

        //    if (expression.Length > 0)
        //        tokens.Add(expression.Substring(0));
        //}

        //private string ConvertTokensToStr()
        //{
        //    string result = "";
        //    foreach (var str in tokens)
        //        result += str;
        //    return result;
        //}

        //private void Count()
        //{
        //    DeleteTrash();
        //}

        //private void DeleteTrash()
        //{
        //    DeleteNegationsTrash();
        //   // DeleteBracketsTrash();
        //}

        //private void DeleteNegationsTrash()
        //{
        //    for (int i = 0; i < tokens.Count; i++)
        //        tokens[i] = DeleteTwiceNegation(tokens[i]);
        //    while (tokens.Remove("")) { }
        //}

        //private string DeleteTwiceNegation(string expr)
        //{
        //    while (expr.Length >= 2 && expr[0] == NOT && expr[1] == NOT)
        //    {
        //        expr = expr.Substring(2);
        //    }
        //    return expr;
        //}
    }
}


        //private void DeleteTwoBrackets(int startIndex, int finishIndex)
        //{
        //    tokens.RemoveAt(startIndex);
        //    tokens.RemoveAt(finishIndex - 1);
        //}
//        private void buuum(ref int startIndex, ref int finishIndex)
//        {
//            int start = 0, finish;
//            bool result = false;
//            while ((finish = FindFirstIndex(start, OR.ToString())) != -1 && !result)
//            {
//                bem(ref start, ref finish, ref result, ref startIndex, ref finishIndex);
//            }

//            finish = tokens.Count;
//            bem(ref start, ref finish, ref result, ref startIndex, ref finishIndex);

//            if (result)
//                startIndex = 0;
//            else
//                startIndex = finishIndex + 1;
//        }

//        private void bem(ref int start, ref int finish, ref bool result, ref int startIndex, ref int finishIndex)
//        {
//            bool resultIn;
//            int r = 0, r1 = 0;
//            if (start != startIndex)
//            {
//                result = false;
//                for (int i = startIndex; i < finishIndex && !result; i++)
//                    for (int j = start; j < finish && !result; j++)
//                    {
//                        result = tokens[i] == NOT + tokens[j] || tokens[j] == NOT + tokens[i];
//                        r = j;
//                        r1 = i;
//                    }

//                for (int i = startIndex; i < finishIndex && result; i++)
//                    if (r1 != i)
//                    {
//                        resultIn = false;
//                        for (int j = start; j < finish && !resultIn; j++)
//                            if (j != r)
//                                resultIn = tokens[i] == tokens[j];
//                        result = resultIn;
//                    }                        

//                if (result)
//                {
//                    tokens[r] = "1";
//                    start = startIndex;
//                    finish = finishIndex;
//                    if (start > 0 && tokens[start - 1] == OR.ToString())
//                    {
//                        tokens.RemoveAt(start - 1);
//                        start--;
//                        finish--;
//                    }
//                    else
//                        tokens.RemoveAt(finish);
//                    tokens.RemoveRange(start, finish - start);
//                    if (start < startIndex)
//                    {
//                        startIndex -= finish - start + 1;
//                        finishIndex -= finish - start + 1;
//                    }
//                }
//            }
//            start = finish + 1;
//        }


//        private void StickTogetherInverse()
//        {
//            int startIndex = 0, finishIndex;
//            while ((finishIndex = FindFirstIndex(startIndex, OR.ToString())) != -1)
//            {
//                buuum(ref startIndex, ref finishIndex);
//            }
//            finishIndex = tokens.Count;
//            buuum(ref startIndex, ref finishIndex);
//        }



//        private void bam(ref int startIndex, ref int finishIndex)
//        {
//            int start = 0, finish;
//            bool result = false;
//            while ((finish = FindFirstIndex(start, OR.ToString())) != -1 && !result)
//            {
//                boom(ref start, ref finish, ref result, ref startIndex, ref finishIndex);
//            }

//            finish = tokens.Count;
//            boom(ref start, ref finish, ref result, ref startIndex, ref finishIndex);

//            if (result)
//                startIndex = 0;
//            else
//                startIndex = finishIndex + 1;
//        }

//        private void boom(ref int start, ref int finish, ref bool result, ref int startIndex, ref int finishIndex)
//        {
//            bool resultIn;
//            if (start != startIndex)
//            {
//                result = true;
//                for (int i = startIndex; i < finishIndex && result; i++)
//                    if (tokens[i] != AND.ToString())
//                    {
//                        resultIn = false;
//                        for (int j = start; j < finish && !resultIn; j++)
//                            resultIn = tokens[i] == tokens[j];
//                        result = resultIn;
//                    }
//                if (result)
//                {
//                    if (start > 0 && tokens[start - 1] == OR.ToString())
//                    {
//                        tokens.RemoveAt(start - 1);
//                        start--;
//                        finish--;
//                    }
//                    else
//                        tokens.RemoveAt(finish);
//                    tokens.RemoveRange(start, finish - start);
//                    if (start < startIndex)
//                    {
//                        startIndex -= finish - start + 1;
//                        finishIndex -= finish - start + 1;
//                    }
//                }
//            }
//            start = finish + 1;
//        }


//        private void StickTogetherOther()
//        {
//            int startIndex = 0, finishIndex;
//            while ((finishIndex = FindFirstIndex(startIndex, OR.ToString())) != -1)
//            {
//                bam(ref startIndex, ref finishIndex);
//            }
//            finishIndex = tokens.Count;
//            bam(ref startIndex, ref finishIndex);
//        }

//        private void StickTogether()
//        {
//            int startIndex = 0, finishIndex, start, finish;
//            string result;
//            while ((finishIndex = FindFirstIndex(startIndex, OR.ToString())) != -1)
//            {
//                for (int i = startIndex; i < finishIndex; i++)
//                    if (tokens[i] != AND.ToString())
//                        for (int j = i+1; j < finishIndex; j++)
//                            if (CheckLawsForTwoExpressions(tokens[i], tokens[j], AND, out result))
//                            {
//                                tokens[j] = result;
//                                tokens.RemoveRange(i, 2);
//                                i = startIndex - 1;
//                                finishIndex -= 2;
//                                break;
//                            }                            
//                startIndex = finishIndex + 1;

//                //while ((finish = FindFirstIndex(start, OR.ToString()) != -1)
//                //{
//                //    for (int i = startIndex; i < finishIndex; i++)
//                //        if (tokens[i] != AND.ToString())
//                //            for (int j = start; j < finish; j++)
//                //                if (tokens[i] == tokens[j])
//                //}
//            }
//            finishIndex = tokens.Count;
//            for (int i = startIndex; i < finishIndex; i++)
//                if (tokens[i] != AND.ToString())
//                    for (int j = i + 1; j < finishIndex; j++)
//                        if (CheckLawsForTwoExpressions(tokens[i], tokens[j], AND, out result))
//                        {
//                            tokens[j] = result;
//                            tokens.RemoveRange(i, 2);
//                            i = startIndex - 1;
//                            finishIndex -= 2;
//                            break;
//                        }
//        }

//        private void RemoveBrackets()
//        {
//            DeleteTrash();
//            int startIndex, finishIndex = 0, priority, i;
//            while ((startIndex = FindFirstIndex(finishIndex, "(")) != -1)
//            {
//                finishIndex = GoToBracketClose(startIndex);
//                priority = GetPriority(startIndex, finishIndex);
//                if (GetPriorityOperation(startIndex - 1) < priority)
//                {
//                    for (i = startIndex - 1; i >= 0 && GetPriorityOperation(i) < priority; i--) { }
//                    if (i != 0)
//                        i++;
//                    for (int j = startIndex; j < finishIndex; j++)
//                        if (j == startIndex || GetPriorityOperation(j) == priority)
//                        {
//                            for (int k = startIndex - 1; k >= i; k--)
//                                AddToken(j + 1, tokens[k]);
//                            finishIndex += startIndex - i;
//                        }
//                    tokens.RemoveRange(i, startIndex - i);
//                    finishIndex = i;
//                }
//                else
//                    if (priority > GetPriorityOperation(finishIndex + 1))
//                    {
//                        for (i = finishIndex + 1; i < tokens.Count && GetPriorityOperation(i) < priority; i++) 
//                        {
//                            if (tokens[i] == "(")
//                                i = GoToBracketClose(i);
//                        }
//                        if (i != tokens.Count - 1)
//                            i--;
//                        for (int j = finishIndex; j > startIndex; j--)
//                            if (j == finishIndex || GetPriorityOperation(j) == priority)
//                            {
//                                for (int k = i; k > finishIndex; k--)
//                                    AddToken(j, tokens[i]);
//                                int length = i - finishIndex;
//                                finishIndex += length;
//                                i += length;
//                            }
//                        tokens.RemoveRange(finishIndex + 1, i - finishIndex);
//                        finishIndex = startIndex;
//                    }

//                DeleteBrackets();
//            }
//        }

//        private int GetPriority(int startIndex, int finishIndex)
//        {
//            int priority = 0;
//            for (int i = startIndex + 1; i < finishIndex; i++)
//                if (tokens[i] == "(")
//                    i = GoToBracketClose(i);
//                else
//                {
//                    if (tokens[i] == AND.ToString())
//                        priority = Math.Max(priority, 1);
//                    if (tokens[i] == OR.ToString())
//                        priority = Math.Max(priority, 2);
//                }
//            return priority;
//        }

//        private int GetPriorityOperation(int index)
//        {
//            if (index < 0 || index > tokens.Count - 1)
//                return 3;
//            if (tokens[index] == AND.ToString())
//                return 1;
//            if (tokens[index] == OR.ToString())
//                return 2;
//            return 0;
//        }

//        private void DeleteBrackets()
//        {
//            int startIndex, finishIndex = 0;
//            while ((startIndex = FindFirstIndex(finishIndex, "(")) != -1)
//            {
//                finishIndex = GoToBracketClose(startIndex);
//                int priority = GetPriority(startIndex, finishIndex);
//                if (startIndex == 0 && finishIndex == tokens.Count - 1)
//                    DeleteTwoBrackets(startIndex, finishIndex);
//                else
//                    if (GetPriorityOperation(startIndex - 1) >= priority && priority <= GetPriorityOperation(finishIndex + 1))
//                        DeleteTwoBrackets(startIndex, finishIndex);
//            }
//        }

//        private int GoToBracketClose(int startIndex)
//        {
//            int count = 0, i;
//            for (i = startIndex + 1; !(tokens[i] == ")" && count == 0); i++)
//            {
//                if (tokens[i] == "(")
//                    count++;
//                if (tokens[i] == ")")
//                    count--;
//            }
//            return i;
//        }

//        private void AddToken(int index, string token)
//        {
//            tokens.Add(tokens[tokens.Count - 1]);
//            for (int i = tokens.Count - 2; i > index; i--)
//                tokens[i] = tokens[i - 1];
//            tokens[index] = token;
//        }

//        private void ReplaceOperation(int index)
//        {
//            if (tokens[index] == AND.ToString())
//                tokens[index] = OR.ToString();
//            else
//                tokens[index] = AND.ToString();
//        }

//        private int FindFirstIndex(int startIndex, string token)
//        {
//            for (int i = startIndex; i < tokens.Count; i++)
//                if (tokens[i] == token)
//                    return i;
//            return -1;
//        }

//        private void CheckDemorgan()
//        {
//            int index, i;
//            DeleteAllNegations();
//            while ((index = FindFirstIndex(0, NOT.ToString())) != -1)
//            {
//                for (i = index + 2; i < tokens.Count && tokens[i] != ")"; i++)
//                {
//                    if (tokens[i] != AND.ToString() && tokens[i] != OR.ToString())
//                        if (tokens[i] == "(")
//                        {
//                            if (i == 0 || i > 0 && tokens[i - 1][0] != NOT)
//                                AddToken(i, NOT.ToString());
//                            i = GoToBracketClose(i);
//                        }
//                        else
//                            tokens[i] = NOT + tokens[i];
//                    else
//                        ReplaceOperation(i);
//                }
//                tokens.RemoveAt(index);
//                DeleteTrash();
//            }
//        }

//        private bool CheckLawsForTwoExpressions(string expr1, string expr2, char operation, out string result)
//        {
//            if (CheckIdempotency(expr1, expr2, out result))
//                return true;

//            if (operation == AND)
//            {
//                if (CheckAnd(expr1, expr2, out result))
//                    return true;
//            }
//            else
//            {
//                if (CheckOr(expr1, expr2, out result))
//                    return true;
//            }

//            return false;
//        }

//        private bool CheckAnd(string expr1, string expr2, out string result)
//        {
//            if (CheckContradiction(expr1, expr2, out result))
//                return true;
//            if (expr1 == TRUE || expr1 == FALSE || expr2 == TRUE || expr2 == FALSE)
//            {
//                if (expr1 == FALSE || expr2 == FALSE)
//                    result = FALSE;
//                else
//                {
//                    if (expr1 == TRUE)
//                        result = expr2;
//                    else
//                        result = expr1;
//                }
//                return true;
//            }
//            return false;
//        }

//        private bool CheckOr(string expr1, string expr2, out string result)
//        {
//            if (CheckExcludedMiddle(expr1, expr2, out result))
//                return true;
//            if (expr1 == TRUE || expr1 == FALSE || expr2 == TRUE || expr2 == FALSE)
//            {
//                if (expr1 == TRUE || expr2 == TRUE)
//                    result = TRUE;
//                else
//                {
//                    if (expr1 == FALSE)
//                        result = expr2;
//                    else
//                        result = expr1;
//                }
//                return true;
//            }
//            return false;
//        }

//        private bool CheckIdempotency(string expr1, string expr2, out string result)
//        {
//            result = expr1;
//            if (expr1 == expr2)
//            {
//                return true;
//            }
//            return false;
//        }

//        private bool CheckContradiction(string expr1, string expr2, out string result)
//        {
//            result = "0";
//            if (expr1 == expr2.Substring(1) && expr2[0] == NOT || expr2 == expr1.Substring(1) && expr1[0] == NOT)
//            {
//                return true;
//            }
//            return false;
//        }

//        private bool CheckExcludedMiddle(string expr1, string expr2, out string result)
//        {
//            result = "1";
//            if (expr1 == expr2.Substring(1) && expr2[0] == NOT || expr2 == expr1.Substring(1) && expr1[0] == NOT)
//            {
//                return true;
//            }
//            return false;
//        }
//    }
//}
