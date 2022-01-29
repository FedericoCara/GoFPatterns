using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using GoFPatterns.Shared;

namespace GoFPatterns.Interpreter {
    public class InterpreterDemo : IGoFPatternDemo {

        public void Run() {
            string[] tree;
            string[] expressions = new string[] {
                "tres más ocho menos cinco por cinco",
                "nueve menos cuatro",
                "nueve por nueve por nueve",
                "ocho por seis dividido tres"
            };
            //(operators precedence and numbers greater than 9, don't work)
            foreach (string expression in expressions) {
                Context context = new Context();
                tree = expression.Split(' ');
                IExpression exp;
                foreach (var node in tree) {
                    if (Operators.ConditionalCompareObjectGreaterEqual(context.getInteger(node), 0, false)) {
                        exp = new NumericExpression(node);
                    } else {
                        exp = new OperatorExpression(node);
                    }

                    exp.interpret(context);
                }

                Console.WriteLine($"The result for '{expression} ' is {context.getResult()}");
            }

        }
    }
}