
using System;

namespace GoFPatterns.Interpreter {
    public class Context {
        private string _nextOp = "";
        private int _rightOperand = 0;
        private int _result = 0;

        public int getInteger(string input) {
            var switchExpr = input.ToLower();
            switch (switchExpr) {
                case "cero": {
                        return 0;
                    }

                case "uno": {
                        return 1;
                    }

                case "dos": {
                        return 2;
                    }

                case "tres": {
                        return 3;
                    }

                case "cuatro": {
                        return 4;
                    }

                case "cinco": {
                        return 5;
                    }

                case "seis": {
                        return 6;
                    }

                case "siete": {
                        return 7;
                    }

                case "ocho": {
                        return 8;
                    }

                case "nueve": {
                        return 9;
                    }

                default: {
                        return -1;
                    }
            }
        }

        public void setOperator(int op) {
            _rightOperand = op;
        }

        public void setOperation(string operation) {
            if (operation.ToLower().Equals("mas")) {
                _nextOp = "+";
            } else if (operation.ToLower().Equals("menos")) {
                _nextOp = "-";
            } else if (operation.ToLower().Equals("por")) {
                _nextOp = "*";
            } else if (operation.ToLower().Equals("dividido")) {
                _nextOp = "/";
            }
        }

        public void calculate() {
            if (_nextOp.Equals("+")||
                //first operand
                _nextOp.Equals("") ) {
                _result += _rightOperand;
            } else if (_nextOp.Equals("-")) {
                _result -= _rightOperand;
            } else if (_nextOp.Equals("*")) {
                _result *= _rightOperand;
            } else if (_nextOp.Equals("/")) {
                _result /= _rightOperand;
            } else {
                throw new Exception($"Operation not handled: {_nextOp}");
            }
        }

        public int getResult() {
            return _result;
        }
    }
}