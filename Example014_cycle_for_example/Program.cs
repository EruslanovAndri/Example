// Задача: Заменить все пробелы в данном тексте чертой, 
// все маленькое буквы "к" на большую "К", а большие "С" на маленькие "с".


string text = "– Да, я думал, – невольно отчего-то краснея, сказал Борис,"
+ "– просить главнокомандующего; к нему было письмо обо мне от князя Курагина;"
+ "я хотел просить только потому, – прибавил он, как бы извиняясь, – что, боюсь,"
+ "гвардия не будет в деле.";

// string s = "qwerty"
//             012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }



    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'C', 'c');
Console.WriteLine(newText);
