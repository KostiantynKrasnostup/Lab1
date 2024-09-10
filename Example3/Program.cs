string s = "біологія алгебра історія географія геометрія"; 
string c = "і"; 
string[] a;

a = s.Split(' '); 

for (int i = 0; i < a.Length; i++)
{
    int t = a[i].IndexOf(c); 
    if (t != -1) 
    {
        Console.WriteLine(a[i]); 
    }
}

Console.ReadKey(); 
