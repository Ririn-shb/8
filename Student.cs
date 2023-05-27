/*Задание 2
По аналогии с заданием 1 создать класс Student, добавить в 
него данные об имени, поле, цвете волос, возрасте и многом 
другом. Создать метод (или функцию) сложения двух студентов. 
Или даже трех! Интересно, что получится из этого!? Прояви как 
можно больше фантазии! Чем больше фантазии - тем больше баллов!!!*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab1
{
    class Student
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public string HairColor { get; set; }
        public double Age { get; set; }
        //добавлено
        public string City { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public void Sum3Stud(Student y, Student z)
        {
            Name = Name + " " + y.Name + " " + z.Name;
            Sex = Sex + " " + y.Sex + " " + z.Sex;
            HairColor = HairColor + " " + y.HairColor + " " + z.HairColor;
            Age += y.Age + z.Age;

            //добавлено
            City = City + " " + y.City + " " + z.City;
            Height += y.Height + z.Height;
            Weight += y.Weight + z.Weight;

        }
    }
}
