
namespace GoFPatterns.Interpreter {
    public class NumericExpression : IExpression {
        private string _value;

        public NumericExpression(string token) {
            _value = token;
        }

        public void interpret(Context context) {
            context.setOperator(context.getInteger(_value));
            context.calculate();
        }
    }
}