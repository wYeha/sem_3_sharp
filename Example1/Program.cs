// void M()
// {
//     Console.WriteLine("...");
// }

// M();

// void M2(string s)
// {
//     Console.WriteLine(s);
// }

// M2("...");

// void M21(string s, int count)
// {
//     int i = 0;
//     while (i<count){
//         Console.WriteLine(s);
//         i++;
//     }  
// }


// M21(count: 4, s: "TTT");

// int Method()
// {
//     return DateTime.Now.Year;
// }

// int year = Method();
// Console.WriteLine(year);


// string M4(int count, string c)
// {
//     string result = String.Empty;
//     for (int i = 0; i< count; i++)
//     {
//         result += c;
//     }

//     return result;
// }

// string s = M4(c: "zvwe", count: 2);
// Console.WriteLine(s);


string text = "kkk KKK CCC ccc";

string Replace(string text, char Old, char New)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i]==Old) result += New;
        else result += text[i];
    }

    return result;
}

string new_text = Replace(text, 'k', 'K');
Console.WriteLine();
Console.WriteLine(new_text);
new_text = Replace(new_text, 'c', 'C');
Console.WriteLine(new_text);
