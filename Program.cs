using System;
string name;
int age;
Console.Write("Enter your Name");
name= Console.ReadLine();
Console.Write("Enter your age ");
    age = int.Parse(Console.ReadLine());
   if (age < 18){
    Console.WriteLine("Under Age");
   }else{
    Console.WriteLine("qualified Age");
   }
