int RomanToInt(string s) 
    {
        Dictionary<char, int> Romans = new Dictionary<char, int>();
            Romans.Add('M', 1000);
            Romans.Add('D', 500);
            Romans.Add('C', 100);
            Romans.Add('L', 50);
            Romans.Add('X', 10);
            Romans.Add('V', 5);
            Romans.Add('I', 1);
        
 
            int sum = 0;
            for (int i = 0; i < s.Length-1; i++)
            {
                if (Romans[s[i]] < Romans[s[i + 1]])
                    sum -= Romans[s[i]];
                else
                    sum += Romans[s[i]];
            }
            return sum += Romans[s[s.Length - 1]];
    }

Console.Write("Введите число в римских цифрах: ");
string romanNumber = Console.ReadLine()!;
int number = RomanToInt(romanNumber);
Console.WriteLine(number);