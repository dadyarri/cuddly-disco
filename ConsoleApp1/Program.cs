namespace ConsoleApp1
{
    /// <summary>
    /// Простой класс
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Точка входа. Вызывает Program.SomeMethodWithParams.
        /// @todo Добавить переключатель темы
        /// @warning some warning
        /// </summary>
        public static void Main()
        {
            var res = SomeMethodWithParams(true);
            var res2 = SomeMethodWithParams(2);
        }

        /// <summary>
        /// Метод-заглушка, возвращающий переданный параметр.
        /// @since 1.0
        /// @bug some ugly bug
        /// @throws ArgumentException ...
        /// </summary>
        /// <param name="param">Просто какой-то параметр.</param>
        /// <returns>Переданный параметр без изменений.</returns>
        public static bool SomeMethodWithParams(bool param)
        {
            if (param)
                return param;
            throw new ArgumentException("Аргумент не может быть ложным");
        }

        /// <summary>
        /// Метод-заглушка, возвращающий переданный параметр.
        /// @since 1.0
        /// </summary>
        /// <param name="param">Целочисленный параметр.</param>
        /// <returns>Переданный параметр без изменений.</returns>
        public static int SomeMethodWithParams(int param)
        {
            return param;
        }
    }   
}
