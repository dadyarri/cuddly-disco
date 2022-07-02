namespace ConsoleApp1
{
    /// <summary>
    /// Простой класс
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Точка входа. Вызывает Program.SomeMethodWithParams.
        /// </summary>
        public static void Main()
        {
            var res = SomeMethodWithParams(true);
        }

        /// <summary>
        /// Метод-заглушка, возвращающий переданный параметр.
        /// </summary>
        /// <param name="param">Просто какой-то параметр.</param>
        /// <returns>Переданный параметр без изменений.</returns>
        public static bool SomeMethodWithParams(bool param)
        {
            return param;
        }
    }   
}
