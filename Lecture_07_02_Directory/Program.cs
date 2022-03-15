// Как посмотреть содержимое папки 20:00

string path = "/Users/Evgeny Turilov/OneDrive/Документы/Adobe";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i<fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
