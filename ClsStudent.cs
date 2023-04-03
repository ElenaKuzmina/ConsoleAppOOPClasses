using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPClasses //пространство имен проекта
{
    internal class ClsStudent
    {
        //поля
        private string fio;
        private DateTime birthday;
        private string adress;
        private byte kurs;
        private string group;
        private string phone;
        private double scholarship;
        // свойства для доступа к полям
        public string FIO 
        {
            get { return fio; }//возвращает значение поля
            set { fio = value; } //устанавливает значение поля
        }
        public byte Kurs
        {
            get { return kurs; }
            set { kurs = value; }
        }
        public string Group
        {
            get { return group; }
            set { group = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public double Scholarship
        {
            get { return scholarship; }
            set { scholarship = value; }
        }
        public DateTime Birthday
        {
            get { return birthday; }
                set { birthday = value; }
        }
        public string Adress
        {
            get { return adress; } //возвращает значение поля
            set { adress = value; } //устанавливает значение поля
        }
        //методы 
        //конструктор без параметров задает значения полей по умолчанию
        public ClsStudent() 
        {
            kurs = 2;
            group = "ИСП.21.2А";
            phone = "+79991234567";
            fio = "Лебедев М.Д.";
            adress = "Ликино-Дулево";
            birthday = new DateTime(2005, 02, 01);
            scholarship = 100000.00;
        }
        //конструктор с параметрами
        public ClsStudent(string f, DateTime d, string ad, 
            string ph, byte k,
            string g, double s)
        {
            fio = f;
            birthday = d;
            adress = ad;
            phone= ph;
            kurs = k;
            group = g;
            scholarship = s;
        }
        //метод вывода на экран
        public void PrintToScreen()
        {
            Console.WriteLine($"Студент {fio} дата рождения {birthday}");
            Console.WriteLine($"Учится на {kurs} курсе в группе {group}");
            Console.WriteLine($"Проживает по адресу {adress}, номер телефона {phone}");
            Console.WriteLine($"Получает стипендию в размере {scholarship} рублей");
        }
        public void SaveToFile(string filename)
        {
            StreamWriter streamWriter= new StreamWriter(filename);
            streamWriter.WriteLine("Личные данные студента");
            streamWriter.WriteLine($"ФИО: {fio}");
            streamWriter.WriteLine($"Адрес проживания: {adress}");
            streamWriter.WriteLine($"Телефон: {phone}");
            streamWriter.WriteLine($"Курс: {kurs}");
            streamWriter.WriteLine($"Группа:{group}");
            streamWriter.Close();
        }
    }
}
