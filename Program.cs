using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Лабораторная №1 - Инкапсуляция");
            
            //Создадим комплексные числа и сразу присвоим значения
            //действительной и мнимой частям
            Complex a = new Complex() { Real = 3, Imag = 0.5 };
            Complex b = new Complex() { Real =2, Imag= 0.8 };

            Console.WriteLine("a = {0} + {1}i", a.Real, a.Imag);
            Console.WriteLine("b = {0} + {1}i\n", b.Real, b.Imag);

            //К числу a прибавим число b
            a.Add(b);
            Console.WriteLine("Сложение a+b");
            Console.WriteLine("a = {0} + {1}i\n", a.Real, a.Imag);

            //Из числа b вычтем число a
            Console.WriteLine("Вычитание b-a");
            b.Subtract(a);
            Console.WriteLine("b = {0} + {1}i\n", b.Real, b.Imag);

            //Число a умножим на число b
            Console.WriteLine("Умножение a*b");
            a.Multiply(b);
            Console.WriteLine("a = {0} + {1}i\n", a.Real, a.Imag);

            //Число a разделим на число b
            Console.WriteLine("Деление a/b");
            a.Divide(b);
            Console.WriteLine("a = {0} + {1}i\n", a.Real, a.Imag);

            
            //Создадим трех студентов и присвоим значения

            Student s1 = new Student() { Name = "Alex", Sex = "m", HairColor = "Broun", Age = 20, City = "Rostov-on-Don", Height = 175, Weight = 68};
            Student s2 = new Student() { Name = "Olga", Sex = "f", HairColor = "Blonde", Age = 19, City = "Krasnodar", Height = 166, Weight = 49 };
            Student s3 = new Student() { Name ="Max", Sex = "m", HairColor = "Shoten", Age = 21, City = "Novocherkassk", Height = 190, Weight = 85 };

            //Выведем студентов
            Console.WriteLine("Student 1\nName - {0}\nSex - {1}\nHair color - {2}\nAge - {3}\nCity - {4}\nHeight - {5}\nWeight - {6}\n",
                s1.Name, s1.Sex, s1.HairColor, s1.Age, s1.City, s1.Height, s1.Weight);
            Console.WriteLine("Student 2\nName - {0}\nSex - {1}\nHair color - {2}\nAge - {3}\nCity - {4}\nHeight - {5}\nWeight - {6}\n",
                s2.Name, s2.Sex, s2.HairColor, s2.Age, s2.City, s2.Height, s2.Weight);
            Console.WriteLine("Student 3\nName - {0}\nSex - {1}\nHair color - {2}\nAge - {3}\nCity - {4}\nHeight - {5}\nWeight - {6}\n",
                s3.Name, s3.Sex, s3.HairColor, s3.Age, s3.City, s3.Height, s3.Weight);

            //Произведем сложение трех студентов
            Console.WriteLine("Сложение 3х студентов");
            s1.Sum3Stud(s2, s3);
            Console.WriteLine("Student 1\nName - {0}\nSex - {1}\nHair color - {2}\nAge - {3}\nCity - {4}\nHeight - {5}\nWeight - {6}\n",
               s1.Name, s1.Sex, s1.HairColor, s1.Age, s1.City, s1.Height, s1.Weight);

        }
    }
}
