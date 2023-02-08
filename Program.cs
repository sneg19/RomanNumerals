// Написать программу, которая проведет конвертацию римских чисел в арабские

int RomanToInt(string s) // Основной метод конвертации
{
    Dictionary<char, int> Romans = new Dictionary<char, int>(); // Создание словаря (тип идентификатора, тип искомого значения)
        Romans.Add('M', 1000); 
        Romans.Add('D', 500);
        Romans.Add('C', 100);
        Romans.Add('L', 50);
        Romans.Add('X', 10);
        Romans.Add('V', 5);
        Romans.Add('I', 1);
        
 
    int sum = 0;
    for (int index = 0; index < s.Length-1; index++) // Сопоставление введенного пользователем значения со словарем
    {
        if (Romans[s[index]] < Romans[s[index + 1]]) sum -= Romans[s[index]]; // Если следующий элемент меньше предыдущего они вычитаются
        else sum += Romans[s[index]];  // В противном случае складываются
    }
    return sum += Romans[s[s.Length - 1]];  // Вывод искомого значения
}

void Main()
{
Console.Write("Введите число в римских цифрах: ");
string romanNumber = Console.ReadLine()!;
int number = RomanToInt(romanNumber);
Console.WriteLine(number);
}

Main();