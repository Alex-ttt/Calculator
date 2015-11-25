using System.Collections.Generic;

namespace Calculator {

    public enum Operation : ushort {
            Plus = '+',
            Minus = '-',
            Mult = '*',
            Div = '÷',
            ChangeSign = '~',
            Clear = 'C',
            Empty = 'E'
        };

    class Handler {

        private List<double> numbers;
        private List<Operation> operations;

        public Handler() {
            numbers = new List<double>();
            operations = new List<Operation>();
        }

        private double Calculate(Operation op, double left, double right) {
            switch (op) {
                case Operation.Plus:
                    return left + right;

                case Operation.Minus:
                    return left - right;

                case Operation.Mult:
                    return left * right;

                case Operation.Div:
                    return left / right;

                default:
                    return double.PositiveInfinity;
            }
        }

        public bool HasNumbers() {
            return numbers.Count != 0;
        }

        public void ChangeLastOperation(Operation op) {
            if(operations.Count != 0)
                operations[operations.Count - 1] = op;
        }

        public void AddNumber(double number) {
            numbers.Add(number);
        }

        public void AddOperation(Operation op) {
            operations.Add(op);
        }

        public void Clear() {
            numbers.Clear();
            operations.Clear();
        }

        public double Calculate(bool final = false) {
            
            if (numbers.Count == 0)
                return 0;
            if (operations.Count == 0)
                return numbers[0];

            for (int i = 0; i < numbers.Count - 1; i++) {
                if(operations[i] == Operation.Mult || operations[i] == Operation.Div){
                    numbers[i] = Calculate(operations[i], numbers[i], numbers[i + 1]);
                    numbers.RemoveAt(i + 1);
                    operations.RemoveAt(i);
                }
            }

            double result = numbers[0];
            for (int i = 1; i < numbers.Count; i++) {
                int sign = operations[i - 1] == Operation.Plus ? 1 : -1;
                result += numbers[i] * sign;
            }

            if (final && operations.Count == numbers.Count) {
                result = Calculate(operations[operations.Count - 1], result, result);
            }

            return result;
        }
    }
}
