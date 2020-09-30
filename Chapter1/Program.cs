using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bai1();
            // Bai2();
            // Bai3();
            // Bai4();
            // Bai5();
        }
        static void Bai1(){
            Console.WriteLine("Excercise 1: ");

            int sum = 0, negative = 0, positive = 0;
            string line = null;
            StringBuilder buffer = new StringBuilder();
            Console.WriteLine("Start typing...");
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Escape){
                Console.Write(info.KeyChar);
                buffer.Append(info.KeyChar);    
                info = Console.ReadKey(true);
            }
            line = buffer.ToString();
            
            string[] nums = line.Split(' ');
            foreach (string num in nums){
                sum += int.Parse(num);
                if (int.Parse(num) >= 0){
                    positive++;
                }
                else{
                    negative++;
                }
            }
            
            Console.WriteLine("\nSum: " + sum);
            Console.WriteLine("Positive: " + positive);
            Console.WriteLine("Negative: " + negative);
        }
        static void Bai2(){
            Console.WriteLine("\n\nExcercise 2: ");

            bool check = true;
            int triCount = 0, fiveCount = 0;
            int sum = 0, negative = 0, positive = 0;
            ConsoleKeyInfo keyInfo;
            string line = null;
            StringBuilder buffer = new StringBuilder();

            Console.WriteLine("Start typing...");       
            while (check){      
                keyInfo = Console.ReadKey(true);
                if (keyInfo.KeyChar == ' ' || keyInfo.KeyChar == '-' ||int.TryParse(keyInfo.KeyChar.ToString(),out int number)){
                    buffer.Append(keyInfo.KeyChar);
                    Console.Write(keyInfo.KeyChar);
                    triCount = 0;
                }
                else{
                    triCount++;
                    fiveCount++;
                }
                if (triCount == 3 || fiveCount == 5)
                    check = false;
            }
            line = buffer.ToString();
            
            
            Regex trimmer = new Regex(@"\s+"); 
            line = trimmer.Replace(line, " ");
            

            // Console.WriteLine("\n" + line + "end");
            string[] nums = line.Split(' ');
            foreach (string num in nums){
                sum += int.Parse(num);
                if (int.Parse(num) >= 0){
                    positive++;
                }
                else{
                    negative++;
                }
            }
             Console.WriteLine("\nSum: " + sum);
             Console.WriteLine("Negative: " + negative);
             Console.WriteLine("Positive: " + positive);
        }
        static void Bai3(){
            Console.WriteLine("\n\nExcercise 3: ");

            int max = 0, temp = 0;
            Console.Write("Type your first number: ");
            max = int.Parse(Console.ReadLine());
            
            Console.Write("Then the second one: ");
            temp = int.Parse(Console.ReadLine());
            max = (max < temp) ? temp : max;
            Console.Write("And finally, the last number please: ");
            temp = int.Parse(Console.ReadLine());
            max = (max < temp) ? temp : max;

            Console.WriteLine("The maxium number in all three ones you've just type is...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("It's  {0}",max); 
            
        }
        static void Bai4(){
            Console.WriteLine("\n\nExcercise 4:");
            Console.Write("Input N: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i += 2){
                sum += i;
            }
            if (n % 2 == 0)
                sum += n;
            
            Console.WriteLine("The final result: {0}",sum);
        }
        static void Bai5(){
            Console.WriteLine("\n\nExcercise 5: ");
            Console.Write("Type the number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Divisors of {0} are: ",n);
            for (int i = 1; i <= n/2; i++){
                if (n % i == 0){
                    Console.Write(i + " ");
                    System.Threading.Thread.Sleep(200);
                }
            }
            Console.WriteLine(n);
        }

    }
}
