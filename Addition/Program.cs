using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTests
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        //Сложение 2-ух чисел
        public static double MyAddition(double num1, double num2)
        {
            return num1 + num2;
        }

        //Наибольшее число в массиве
        public static double BiggestNumber(double[] arr)
        {
            if (arr.Length > 0) //Проверка на пустоту массива
            {
                return arr.Max();
            }
            else
            {
                return 0;
            }
            //------------(Нормальный метод в одну строчку)



            //if (arr.Length > 0)
            //{
            //    double temp = arr[0];       
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (temp < arr[i])
            //        {
            //            temp = arr[i];
            //        }
            //    }
            //    return temp;
            //}
            //else
            //{
            //    return 0;
            //}
        }
        public static double MyMax(double number1, double number2, double number3)
        {
            if (number1 > number2)
            {
                if (number1 > number3)
                {
                    return number1;
                }
                else
                {
                    return number3;
                }
            }
            else
            {
                if (number2 > number3)
                {
                    return number2;
                }
                else
                {
                    return number3;
                }
            }

        }
        public static int CountLitters(string word)
        {
            //if (word != null || word == "")
            //{
            //    string[] arrW = word.Split(' '); 
            //    word = "";
            //    for (int i = 0; i < arrW.Length; i++)
            //    {
            //        word += arrW[i];
            //    }
            //    return word.Length;
            //}
            //else
            //{
            //    return 0;
            //}

            int count = 0;
            foreach (char c in word)
            {
                if (Char.IsLetter(c))
                {
                    count++;
                }
            }
            return count;
        }
        public static int Nums(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (Char.IsDigit(c))
                {
                    count++;
                }
            }
            return count;
        }
        public static int SpecialSymbol(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
