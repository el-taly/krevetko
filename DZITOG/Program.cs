// из имеющегося массива строк
// сделать массив меньше либо равным 3-ем символам


Console.Clear();

string[] strings = { "hello", "2", ":-"}; 
var result = strings.Where(s => s.Length <= 3).ToArray(); 
Console.WriteLine(string.Join(", ", result)); 
Console.ReadLine();