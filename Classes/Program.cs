using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();//Инициализация пользователя туристического агентства
            student.Id = 1;
            student.Name = "Name";
            student.Email = "email";
            student.Password= "password";
            student.Curator = "Curator";
            student.SetPassword("password11");
            Console.WriteLine(student.GetPassword());
            Console.ReadKey();
        }
    }


    public class User 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PersonAge { get; set; }
        public virtual int Age //Виртуальный метод
        {
            get => PersonAge;
            set { if(value > 0 && value < 110) PersonAge= value; }
        }
    }

    public class Student : User
    {
        public string Group { get; set; }
        public string Curator { get; set; }
        public int Course { get; set; }

        public string GetPassword()
        {
            return Password.Substring(0, Password.Length - "_Cipher".Length);
        }                                                                                           //Проявление Инкапсуляции
        public void SetPassword(string password)
        {
            Password = password + "_Cipher";
        }
    }
}
