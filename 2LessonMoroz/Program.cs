Console.WriteLine("Hello, World!");
string LocalFun()
{
    string name = "GEPY";
    string surname = "NONO";
    string FullName = $"{name} {surname}";
    return FullName;
}
Console.WriteLine(LocalFun());