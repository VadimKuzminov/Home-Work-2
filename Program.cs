using System;
using static System.Console;
namespace Home_Work__2
{
    class Program
    {
     
        static void Main(string[] args)
        {
            
            string firstName = "Василий";///Имя
            string lastName = "Пупкин";///Фамилия
            string Patronymic = "Иванович";///Отчество
            string eMail = "vasiaPup@mail.ru";///email

            byte age = 69;///Возраст

            ///Объявление переменных
            double a = 80.123;
            double b = 50.5;
            double c = 77.84;

            ///Предметы
            int Programming = (int)a;///Программирование
            int Math = (int)b;///Математика
            int Physics = (int)c;///Физика

            

            int summ = (int)(a + b + c);///Суммарный бал за все предметы

            int separat = summ / 3;///Средней бал 




            DateTime date = DateTime.Now;///Вывод даты на момент выполнения операции.

            string pattern = "Имя: {0} \nФамилия: {1} \nОтчество: {2} \nЭлектронная почта: {3} \nВозраст: {4} \nПрограммирование: {5}  \nМатематика: {6} \nФизика: {7} \nСумма баллов {8} \nСредний балл: {9} \nТекущая дата: {10} ";

            WriteLine(pattern,
                      firstName,
                      lastName,
                      Patronymic,
                      eMail,
                      age,
                      a.ToString("#.###"),
                      b.ToString("#.###"),
                      c.ToString("#.###"),
                      summ.ToString("#.###"),
                      separat.ToString("#.###"),
                      date);
            ReadKey();





        }
    }
}
