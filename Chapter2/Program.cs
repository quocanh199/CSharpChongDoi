using System;
using System.Text.RegularExpressions;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bai1();
            // Bai2();
            // Bai3();
        }
        static void Bai1(){
            Console.WriteLine("\n\nExcercise 1: ");

            string[] student = new string[3];
            for (int i = 0; i < student.Length; i++){
                Console.Write("input student[{0}]: ",i);
                student[i] = Console.ReadLine();
                student[i] = student[i].Trim();
                while (student[i].IndexOf("  ") != -1){
                    student[i] = student[i].Replace("  "," ");
                }
            }
            Console.WriteLine("Student with last name \"Nguyen\": ");
            foreach (string nameStudent in student){
                if (Regex.IsMatch(nameStudent.ToLower(),"^nguyen"))
                    Console.WriteLine(nameStudent);
            }
        }
        static void Bai2(){
            int even = 0;
            Console.WriteLine("\n\nExcercise 2: ");
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++){
                Console.Write("numbers[{0}]: ",i);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            foreach (int number in numbers){
                if (number % 2 == 0){
                    even++;
                }
            }
            Console.WriteLine("\nEven number: " + even);
        }
        static void Bai3(){
            Console.WriteLine("\n\nExcercise3: ");

            string[] info = new string[4]; 
            string input;
            bool valid = true;
            int ageCount = 0;
            for (int i = 1; i <= 3; i++){
                Console.Write("Input for student number {0}: ",i);
                input = Console.ReadLine();
                info = input.Split(",");
                if  (!NameValidation(info[0]))
                    valid = false; 
                if  (!DateValidation(info[1],0))
                    valid = false;
                if  (!NameValidation(info[2]))
                    valid = false;
                if  (!ClassValidation(info[3]))
                    valid = false; 
                if (DateValidation(info[1],1))
                    if (AgeValidation(info[1]))
                        ageCount++;    
            }
            if (valid)
                Console.WriteLine("\nGood job, your input are correct!");
            Console.WriteLine("\nNumber of student at age between 19 and 22: " + ageCount);
        }
        static string DeleteFirstSpace(string info){
            if (info[0] == ' ')
                return info.Remove(0,1);
            
            return info;
        }
        static bool NameValidation(string info){
            info = DeleteFirstSpace(info);
            if (!Regex.IsMatch(info,"^[A-Z][a-zA-Z]*")){
                Console.WriteLine("Invalid Name: " + info);
                return false;
            }
            return true;                                
        }
        static bool DateValidation(string info,int idNum){
            info = DeleteFirstSpace(info);
            if (!Regex.IsMatch(info,@"^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/(19|20)\d\d$")){
                if (idNum == 0)
                    Console.WriteLine("Invalid Date: " + info);
                return false;
            }
            return true;
        }
        static bool ClassValidation(string info){
            info = DeleteFirstSpace(info);
            if (!Regex.IsMatch(info,@"^\w+$")){
                Console.WriteLine("Invalid Class: " + info);
                return false;
            }
            return true;
        }
        static bool AgeValidation(string info){        
            info = DeleteFirstSpace(info); 
            int age = 2020 - int.Parse(info.Substring(6));
            if (age >= 19 && age <= 22)
                return true;
            return false;
        }
    }
}

