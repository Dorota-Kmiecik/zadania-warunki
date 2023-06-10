using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tydzien2_Warunki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            int number1 = 5;
            int number2 = 5;
            if (number1 == number2)
            {
                Console.WriteLine($"{number1} i {number2} sa rowne");
            }
            else
            {
                Console.WriteLine("Liczby nie sa rowne");
            }

            //Zadanie 2
            int number3 = 15;
            if (number3 % 2 == 0)
            {
                Console.WriteLine("Podana liczba jest parzysta");
            }
            else
            {
                Console.WriteLine($"{number3} jest liczba nieparzysta");
            }

            //Zadanie 3           
            int number4 = 14;
            if (number4 > 0)
            {
                Console.WriteLine($"{number4} jest liczba dodatnia");
            }
            else
            {
                Console.WriteLine($"{number4} jest liczba ujemna");
            }

            //Zadanie 4
            int year = 2016;
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} jest rokiem przestepnym");
            }
            else
            {
                Console.WriteLine($"{year}nie jest rokiem przestepnym");
            }

            //Zadanie 5
            int age = 21;
            if (age >= 35)
            {
                Console.WriteLine("Mozesz zostac prezydentem");
            }
            else if (age >= 30)
            {
                Console.WriteLine("Mozesz zostac senatorem");
            }
            else if (age >= 21)
            {
                Console.WriteLine("Mozesz zostac poslem");
            }
            else
            {
                Console.WriteLine("Jestes za mlody");
            }

            //Zadanie 6
            int height = 140;
            if (height >= 170)
            {
                Console.WriteLine("Jestes wysoki");
            }
            else if (height < 170 && height > 140)
            {
                Console.WriteLine("Nie jestes az taki maly");
            }
            else
            {
                Console.WriteLine("Jestes krasnoludem");
            }

            //Zadanie 7
            int number5 = 25;
            int number6 = 63;
            int number7 = 79;            
            int max = Math.Max( number5, Math.Max(number6, number7) );
            Console.WriteLine($"{max} jest najwiekszy");

            //Zadanie 8
            int math = 80;
            int physics = 71;
            int chemistry = 0;

            if ((math > 70 && physics > 55 && chemistry > 45) && math + physics + chemistry > 180 || (math + physics > 150) || (math + chemistry > 150))
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Kandydat nie dopuszczony do rekrutacji");
            }

            //Zadanie 9
            var temp = 41; 
            if (temp < 0)
            {
                Console.WriteLine("cholernie piździ");
            }
            else if (temp >=0 && temp <=10)
            {
                Console.WriteLine("zimno");
            }
            else if (temp > 10 && temp <= 20) 
            {
                Console.WriteLine("chłodno");
            }

            else if (temp > 20 && temp <= 30)
            {
                Console.WriteLine("w sam raz");
            }
            else if (temp > 30 && temp <= 40)
            {
                Console.WriteLine("zaczyna być słabo, bo gorąco");
            }
            else
            {
                Console.WriteLine("a weź wyprowadzam się na Alaskę");
            }

            //Zadanie 10 
            int a = 40;
            int b = 55;
            int c = 65;

            if (a>c && a>b && b + c >a  || b>a && b>c && a + c > b || c>b && c>a && b + a > c)
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else 
            {
                Console.WriteLine("Nie można zbudować trójkąta");
            }

            //Zadanie 11
            var grade = 3; 
            switch (grade) 
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");  
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujący");
                    break;
                default:
                    Console.WriteLine("Wybrales nieprawidlowe dane");
                    break;
            }

            //Zadanie 12
            int day = 4; 
            switch (day)
            {
                case 1:
                    Console.WriteLine("Poniedzialek");
                    break; 
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Sroda");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                 case 5:
                    Console.WriteLine("Piatek");    
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                break;
                case 7:
                    Console.WriteLine("Niedziela");
                break;
                default:
                    Console.WriteLine("Wybrales nieprawidlowe dane");
                    break;
            }

            //Zadanie 13
            Console.WriteLine("Podaj pierwsza liczbe");
            int nr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe");
            int nr2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj numer operacji do wykonania: \r\n1. Dodawanie\r\n2. Odejmowanie\r\n3. Mnożenie\r\n4. Dzielenie");
            int operation = int.Parse(Console.ReadLine());
            double outcome;
            switch (operation) 
            {
                case 1:                   
                    outcome = nr1 + nr2;
                    Console.WriteLine($"Twoj wynik to: {outcome}");
                    break;
                case 2:
                    outcome = nr1 - nr2;
                    Console.WriteLine($"Twoj wynik to: {outcome}");
                    break;
                case 3:
                    outcome = nr1 * nr2;
                    Console.WriteLine($"Twoj wynik to: {outcome}");
                    break;
                case 4:
                    outcome = (double)nr1 / nr2;
                    Console.WriteLine($"Twoj wynik to: {outcome}");
                    break;
                default:
                    Console.WriteLine("Wybrales nieprawidlowe dane");
                    break;
            }
            
        }

    }
}
