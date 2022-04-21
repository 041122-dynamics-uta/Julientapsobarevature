using System;
public class calculator

{
 public static int Sum(int num1, int num2)
 {
   int total;
   total= num1 + num2;
   return total;
 } 
  
 public static void public static void Main() 
 {
    console.write("\n\nFunction to calculate the sum of two numbers:\n");
    console.write("-----------------------------------------------------\n");
    console.write(" Enter a number:");
    int n1= Convert.ToInt32(Console.ReadLine());   
    console.write(" Enter another number:");
    int n2= Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("\nSum of two number is : {0} \n", Sum(n1, n2));
 } 
}