// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

Console.WriteLine("Write a number: ");
string s_a = Console.ReadLine();

int a = int.Parse(s_a);
{ if (a == 6 || a == 7)
 Console.WriteLine("YES");
 else {
   Console.WriteLine("no"); 
 }

}
