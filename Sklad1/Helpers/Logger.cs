namespace Sklad1.Helpers
{
    /// <summary>
    /// Класс для логирования ошибок в файл
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// Записывает сообщение об ошибке в файл лога
        /// </summary>
        public static void LogError(string message, Exception ex = null)
        {
            var fullMessage = $"[{DateTime.Now}] {message}" + (ex != null ? $": {ex.Message}" : string.Empty);
            File.AppendAllText("errors.txt", fullMessage + Environment.NewLine);
        }
    }
}