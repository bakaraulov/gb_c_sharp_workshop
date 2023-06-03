// Задача возвести в число A в степень B(оптимизация выполнена с выводом степени в юникоде)
const string superscriptDigits = "\u207B\u2070\u00b9\u00b2\u00b3\u2074\u2075\u2076\u2077\u2078\u2079";
double numberA = 0;
int tryCount = 3, numberB = 0;
string inputStr = string.Empty;
string[] inputNumbers = { };
bool resInputCheck = false;
double result = 1;

while (!resInputCheck)
{
    Console.WriteLine($"\r\nВведите число А (основание степени) и натуральное число В (показатель степени) (количество попыток: {tryCount}):");
    inputStr = Console.ReadLine()!;
    inputNumbers = inputStr.Split(new char[] { ' ', ';', '.', '/' });

    resInputCheck = inputNumbers.Length == 2 && double.TryParse(inputNumbers[0], out numberA) && int.TryParse(inputNumbers[1], out numberB) && numberB > 0;

    if (!resInputCheck)
    {
        tryCount--;

        if (tryCount == 0)
        {
            Console.WriteLine("\r\nВы исчерпали все попытки.\r\nВыполнение программы будет остановлено.");
            return;
        }
    }
}

result = Pow(numberA, numberB);

Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine($"{numberA}{NumberToSuperscript(numberB)} -> {Math.Round(result, 4)}");

double Pow(double number, int degree)
{
    double res = 1;
    for (int i = 0; i < numberB; i++)
    {
        res *= numberA;
    }

    return res;
}

string NumberToSuperscript(int number)
{
    string result = string.Empty;

    bool isNegative = number < 0;

    int n = Math.Abs(number);
    while (n > 0)
    {
        result = superscriptDigits[n % 10 + 1] + result;
        n /= 10;
    }

    return isNegative ? superscriptDigits[0] + result : result;
}