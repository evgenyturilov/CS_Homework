// Дана некоторая сторка, требуется переписать ее в обратном порядке

string s = Console.ReadLine();
string s1 = String.Empty;

//for (int i = 0; i < s.Length; i++)
for (int i = s.Length - 1; i >= 0; i--)
{
    s1=s1+s[i];
    //Console.Write(s[i]);
}
System.Console.WriteLine(s1);