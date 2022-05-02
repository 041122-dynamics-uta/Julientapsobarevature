using System;

namespace _4_MethodsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /**
                YOUR CODE HERE.
            **/
        }

        public static string GetName()
        {
            Console.WriteLine("What is your Name?");

            string userName = Console.ReadLine();

            return userName;

            
            
            //throw new NotImplementedException("GetName() is not implemented yet0");
        }

        public static string GreetFriend(string name)
        {
            return "Hello, " + name + ". " + "You are my friend.";

            
            //throw new NotImplementedException("GreetFriend() is not implemented yet");
        }

        public static double GetNumber()
        { Double num = Convert.ToDouble(Console.ReadLine);
        return num;
            
            //throw new NotImplementedException("GetNumber() is not implemented yet");

        }

        public static int GetAction()
        {
            int action = Convert.ToInt32(Console.ReadLine());
            return action;

            //throw new NotImplementedException("GetAction() is not implemented yet");
        }

        public static double DoAction(double x, double y, int action)
        {
           switch(action)
            {
              case 1:
                return x + y;
              case 2:
                return Math.Abs(x - y);
              case 3:
                return x * y;
              case 4:
                return x / y;
              default:
                throw new FormatException("Wrong Format");  
            }

           
           
           
           
           
           
           
           //throw new NotImplementedException("DoAction() is not implemented yet");
        }
    }
}

