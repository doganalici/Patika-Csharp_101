
string degisken = "Dersimiz C#, Hoşgeldiniz!";
string degisken2 = "Dersimiz C#";
string degisken3 = "dersimiz C#, Hoşgeldiniz!";


//length
Console.WriteLine(degisken.Length);
Console.WriteLine();

//ToUpper , ToLower
Console.WriteLine(degisken.ToUpper());
Console.WriteLine(degisken.ToLower());
Console.WriteLine();

//Concat
Console.WriteLine(string.Concat(degisken, " Merhaba"));
Console.WriteLine();

//Compare , CompareTo
Console.WriteLine(degisken.CompareTo(degisken2));  //0,1,-1
Console.WriteLine(string.Compare(degisken, degisken2, true));
Console.WriteLine(string.Compare(degisken, degisken3, false));
Console.WriteLine();

//Contains
Console.WriteLine(degisken.Contains(degisken2));
Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
Console.WriteLine(degisken.StartsWith("Merhaba!"));
Console.WriteLine();

//IndexOf
Console.WriteLine(degisken.IndexOf("C#"));
Console.WriteLine(degisken.IndexOf("Doğan"));
Console.WriteLine(degisken.LastIndexOf('i'));
Console.WriteLine();

//Insert
Console.WriteLine(degisken.Insert(0, "Merhaba! "));
Console.WriteLine();

//PadLeft , PadRight
Console.WriteLine(degisken + degisken2.PadLeft(30));
Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
Console.WriteLine();
Console.WriteLine(degisken.PadRight(50) + degisken2);
Console.WriteLine(degisken.PadRight(50,'*') + degisken2);
Console.WriteLine();

//Remove
Console.WriteLine(degisken.Remove(7));
Console.WriteLine(degisken.Remove(5,3));
Console.WriteLine(degisken.Remove(0,2));
Console.WriteLine();

//Replace
Console.WriteLine(degisken.Replace("C#","CSharp"));
Console.WriteLine(degisken.Replace(" ","*"));
Console.WriteLine();

//Split
Console.WriteLine(degisken.Split(' ')[1]);
Console.WriteLine();

//Substring
Console.WriteLine(degisken.Substring(4));
Console.WriteLine(degisken.Substring(4,6));