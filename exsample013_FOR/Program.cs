// FOR
// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i =0; i<count; i++)
//     {
//         result = result + text;
//     }
//     return result;

// }

// string res = Method4(10, "asdf ");
// Console.WriteLine(res);

//FOR FOR


// for (int i = 1; i <= 10; i++)
// {
//     for (int j = 0; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

// Дан текст, нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить на большие, а большие "С"
// заменить на маленькие "с"

string text = "— Я думаю, — сказал князь улыбаясь, — что, "
               + "ежели бы вас послали вместо нашего милого Винценгероде,"
               + "вы бы взяли приступом согласие прусского короля. "
               + "Вы так красноречивы. Вы дадите мне чаю?"; 
string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i]==oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
        
    }
    return result;
}

string newText = Replase (text, ' ', '|');
  newText = Replase (newText, 'к', 'К');
  string newText1 = Replase (newText, 'с', 'С');
   Console.WriteLine(newText1);
