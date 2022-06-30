// Вид 1 ничего не принимают и ничего не возвращают.
void Method1()
{
    Console.WriteLine("Name of author");
}
//Method1(); // вызываем метод так!



// Вид 2 принимают аргументы, но не возвращают.

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg:"Text of the message");

// void Method21(string msg, int count)
// {
//     int  i = 0; 
//     while ( i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     } 
// }
// //Method21(msg: "Text of the message", count: 4);
// Method21(count: 4, msg: "New text");


// Вид 3 возвращают , но ничего не принимают.

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);




// Вид 4 принимают и возвращают.
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while(i<count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "Q");
// Console.WriteLine(res);



// Добавили информацию о цикле for.

string Method4(int count, string text)
{

    string result = String.Empty;
    for (int i = 0; i < count; i++)
        {
            result = result + text;

        }
    return result;
}
string res = Method4(10, "Q");
Console.WriteLine(res);