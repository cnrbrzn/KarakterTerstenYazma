string str = Console.ReadLine();
string[] arr = str.Split(" ");
for (int i = 0; i < arr.Length; i++)
{
    string s = arr[i].ToString();
    string news = "";
    string h = "";
    for (int j = 0; j <= s.Length; j++)
    {
        if (j == 0)
            h = s[j].ToString();
        else if (j == s.Length)
            news += h;
        else if (s[j].ToString() == " ")
        {
            news += h + " ";
            h = s[j + 1].ToString();
        }
        else
            news += s[j].ToString();
    }
    Console.Write(news + " ");
}