using System.Text.RegularExpressions;

// Класс Program представляет точку входа в приложение
internal class Program
{
    private static void Main(string[] args)
    {
        // Исходная строка, в которой нужно найти IP-адреса
        string str = "qw234.55.7.8eqwweqwq99999.23.99.0 qweqweqwqwwq";

        // Создание объекта Regex для поиска IP-адресов
        Regex regex = new Regex(@"((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)");

        // Поиск всех совпадений в строке
        MatchCollection matches = regex.Matches(str);

        // Перебор всех совпадений и вывод найденных IP-адресов
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}