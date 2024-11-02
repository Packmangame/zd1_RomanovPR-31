using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cat
{
    internal class Cats
    {
        string name;
        public string Name 
        {
            // получение значения
            get { return name; }
            // установка значения
            set
            {
                bool OnlyLetters = true;
                // ключ. слово value - это то, что хотят свойству присвоить
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }

                //условие проверяет на то что в перемнной буквы и она не пустая
                if (OnlyLetters&&value!="")
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine($"{value} - неправильное имя!!!");
                }
               
            } 
        }
        
        string ves;
        public string Ves
        {
            get 
            {
                return ves;
            }
            set
            {
                //проверка на некоректность ввода и число не бесконечнность и 0<x!=0
                if (Convert.ToDouble(value)>0)
                {
                    ves = value;
                }
                else
                {
                    Console.WriteLine("Weight is not correct");
                }
            }
        }
        

        public void CName(string CatName)
        {
            Name = CatName;
        }

        public void Meow()
        {
            Console.WriteLine($"{name}: МЯЯЯЯУ!!!!");
        }

        public void CatInfo()
        {
            Console.WriteLine($"{name}-{ves}");
        }
    }
}
