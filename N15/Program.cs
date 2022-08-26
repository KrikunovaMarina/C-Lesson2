Console.Write("Введите цифру, которая соответствует дню недели: ");
 // 1-monday, 2-tuesday...//
int a=int.Parse(Console.ReadLine());
if (a==6 || a==7)
{
Console.WriteLine(a + "->" + "Weekend");
}
else
{
  Console.WriteLine(a + "->" + "Weekday");  
}
