namespace Section
{
    public static class InputValidator
    {
        // Метод для проверки, является ли строка действ. числом
        public static bool isValidDouble(string input, out double value)
        {
            return double.TryParse(input, out value);  // 1 если правда 
        }
    }
}