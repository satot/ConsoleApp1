using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        private const double TAX = 1.08;
        private enum DayOfWeek { Sun, Mon, Tue };
        static void Main(string[] args)
        {

            int[,,] nums = new int[,,] {
                { { 1, 3, 5 }, { 3, 9, 15 } },
                { { 2, 4, 6 }, { 4, 8, 12 } }
            };
            Console.WriteLine(nums.Length);
            /*
            for (int i = 0; i < 2; i ++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(nums[i,j, 0]);
                }
            }
            */

            // String
            Console.WriteLine("************* String **************");
            int age = 24;
            string msg = String.Format("My name is {0}, {1} years old.", "Henry", age);
                        
            Console.WriteLine(msg.IndexOf("M"));
            Console.WriteLine(msg.Replace("My", "Your"));
            Console.WriteLine(msg.Split(',')[0]);
            Console.WriteLine(msg.Substring(5, 2));

            int total = 10;
            int i = 1;

            do
            {
                total += i;
                i++;
            } while (i < 10);
            Console.WriteLine(total);

            Console.WriteLine("*********** foreach **********");
            foreach (var data in nums)
            {
                Console.WriteLine(data);
            }

            // Employee
            Console.WriteLine("************* Employee **************");
            Employee emp = new Employee();
            Console.WriteLine(emp.Empno);
            emp.Empno = "1234";
            Console.WriteLine(emp.Empno);

            // os
            Console.WriteLine("************* os **************");
            WinPC win = new WinPC("this is memo");
            win.ShowOS();

            // generic class
            Console.WriteLine("************* generic **************");
            MyFunc<int> mfInt = new MyFunc<int>();
            mfInt.save(3);
            Console.WriteLine(mfInt.load());

            MyFunc<double> mfDouble = new MyFunc<double>();
            mfDouble.save(2.0);
            Console.WriteLine(mfDouble.load());

            // list
            Console.WriteLine("************* list **************");
            List<int> ls = new List<int>();
            ls.Add(1);
            ls.Add(3);
            ls.Add(5);

            ls.Insert(1, 2);
            ls.Insert(3, 4);
            ls.RemoveAt(0);

            foreach(var num in ls)
            {
                Console.WriteLine(num);
            }

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("0001", "Adrian");
            dict.Add("0002", "Nathan");
            Console.WriteLine(dict["0001"]);

            foreach(string key in dict.Keys)
            {
                Console.WriteLine(key);
            }
            foreach(string val in dict.Values)
            {
                Console.WriteLine(val);
            }
            foreach(KeyValuePair<string, string> kvp in dict)
            {
                Console.WriteLine($"Key={kvp.Key}, Value={kvp.Value}");
            }

            try
            {
                throw new DataNotFoundException("Cannot find data");
                //throw new IOException();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Terminate the process");
            }
        }
    }
}
