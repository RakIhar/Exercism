import java.util.Objects;

class CalculatorConundrum {
    public String calculate(int operand1, int operand2, String operation) {
        int res = 0;
        if (operation == null)
            throw new IllegalArgumentException("Operation cannot be null");
        else if (operation.isEmpty())
            throw new IllegalArgumentException("Operation cannot be empty");

        switch (operation) {
            case "+" -> res = operand1 + operand2;
            case "*" -> res = operand1 * operand2;
            case "/" -> {
                try {
                    res = operand1 / operand2;
                } catch (ArithmeticException e) {
                    throw new IllegalOperationException("Division by zero is not allowed", e);
                }
            }
            default -> throw new IllegalOperationException("Operation '" + operation + "' does not exist");
        }

        return String.format("%d %s %d = %d", operand1, operation, operand2, res);
    }
}
