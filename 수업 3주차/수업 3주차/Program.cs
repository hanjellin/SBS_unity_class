using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 수업_3주차
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> pass = new List<int>();
            
            Console.Write("암호를 입력하시오: ");
            pass[0] = Convert.ToInt32(Console.ReadLine());
            
            foreach(int item in pass)//문자열의 수를 하나씩 꺼내 반복한다
            {
                
            }
            */
            Person me = new Person();
            Calculator calc = new Calculator();


            DoSomething(me);
            DoSomething(calc);
             
            
        }

        static void DoSomething(isum target)
        {
            int result = target.Sum(100, 100);
            Console.WriteLine(result);
        }
    }
    class Person : isum
    {
        public int Sum(int a, int b)
        {
            return a + b + 1;
        }
    }

    class Calculator : isum
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }

    interface isum //연관없는 클래스에 동일한 코드를 사용하기위한
    {
        int Sum(int a, int b);
    }
}
