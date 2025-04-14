using System.Text;

namespace Evaluator.Logic;

public class FunctionEvaluator
{
    public static double Evaluate(string infix)
    {
        var postfix = ToPostfix(infix);
        return Calculate(postfix);
    }

    private static double Calculate(string postfix)
    {
        var stack = new Stack<double>();
        string numberBuffer = "";

        foreach (var item in postfix)
        {
            if (char.IsDigit(item) || item == '.')
            {
                numberBuffer += item;
            }
            else
            {
                if (numberBuffer != "")
                {
                    stack.Push(double.Parse(numberBuffer));
                    numberBuffer = "";
                }

                if (IsOperator(item))
                {
                    var operand2 = stack.Pop();
                    var operand1 = stack.Pop();
                    stack.Push(Compute(operand1, item, operand2));
                }
            }
        }

        
        if (numberBuffer != "")
        {
            stack.Push(double.Parse(numberBuffer));
        }

        return stack.Pop();
    }

    private static double Compute(double operand1, char op, double operand2)
    {
        return op switch
        {
            '+' => operand1 + operand2,
            '-' => operand1 - operand2,
            '*' => operand1 * operand2,
            '/' => operand1 / operand2,
            '^' => Math.Pow(operand1, operand2),
            _ => throw new Exception("Invalid operator"),
        };
    }

    private static string ToPostfix(string infix)
    {
        var stack = new Stack<char>();
        var postfix = new StringBuilder();
        string numberBuffer = "";

        foreach (var item in infix)
        {
            if (char.IsDigit(item) || item == '.')
            {
                numberBuffer += item;
            }
            else
            {
                if (numberBuffer != "")
                {
                    postfix.Append(numberBuffer + " ");
                    numberBuffer = "";
                }

                if (IsOperator(item))
                {
                    if (item == '(')
                    {
                        stack.Push(item);
                    }
                    else if (item == ')')
                    {
                        while (stack.Count > 0 && stack.Peek() != '(')
                        {
                            postfix.Append(stack.Pop() + " ");
                        }
                        stack.Pop(); 
                    }
                    else
                    {
                        while (stack.Count > 0 && Priority(stack.Peek()) >= Priority(item))
                        {
                            postfix.Append(stack.Pop() + " ");
                        }
                        stack.Push(item);
                    }
                }
            }
        }

        
        if (numberBuffer != "")
        {
            postfix.Append(numberBuffer + " ");
        }

        
        while (stack.Count > 0)
        {
            postfix.Append(stack.Pop() + " ");
        }

        return postfix.ToString().Trim();
    }

    private static int Priority(char op)
    {
        return op switch
        {
            '^' => 4,
            '*' => 3,
            '/' => 3,
            '+' => 2,
            '-' => 2,
            '(' => 1,
            _ => throw new Exception("Invalid operator"),
        };
    }

    private static bool IsOperator(char item) => "+-*/^()".Contains(item);
}