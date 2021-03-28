using System;
using System.Collections.Generic; //제네릭 코렌션 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console2 = System.Console;

public enum job
{
    전사=0,
    도적,
    마법사,
    사제
       
}

namespace 수업_2주차
{
    interface some 
    {
        void somebehavior();
    }

    class Program
    {
        static void Main(string[] args)
        {






            //List 배열
            List<int> someList = new List<int>();
            someList.Add(1);
            someList.Add(2);
            someList.Add(3);
            someList.Add(4);
            someList.Add(5);
            foreach (int item in someList)  //someList에 있는걸 하니씩 가져와 반복
            {
                Console.WriteLine(item);

            }
            someList.Remove(4);//배열중 4를 제거
            //someList.RemoveAll(4); 모든 4의배열을 지움
            //someList.Clear();//모든 베열을 지움

            for(int i = 0;i<someList.Count; i++)//배열에선 Length
            {
                Console.WriteLine(someList[i]);
            }

            //
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict["사과"] = "빨간 사과네";
            dict.Add("배", "노란색깔 계통의 과일");
            foreach(KeyValuePair<string,string> item in dict)//var: 거기에 알맞는 코드를 자동으로 넣어줌-> KeyValuePair<string,string>를 var로
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            Queue<int> someQueue = new Queue<int>();
            someQueue.Enqueue(5);
            someQueue.Enqueue(4);
            someQueue.Enqueue(3);
            someQueue.Enqueue(2);
            someQueue.Enqueue(1);
            while(someQueue.Count > 0)
            {
                Console.WriteLine(someQueue.Dequeue());
            }


            //계산기
            calculator cal = new calculator();
            for (int i = 0 ;i<5 ;i++ ){
                Console.Write("0: 더하기\n1: 빼기 \n2: 곱하기\n3: 나누기\n4: 나눠서 나머지\n어떤 계산을 하시겠습니까?: ");
                int c = Convert.ToInt32(Console.ReadLine());
                if (c == 0)
                {
                    Console.WriteLine("두수를 입력하시오: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    int m = Convert.ToInt32(Console.ReadLine());
                    cal.sum(n, m);
                    Console.WriteLine($"{cal.sum(n, m)}입니다.");

                }
                else if (c == 1)
                {
                    Console.WriteLine("두수를 입력하시오: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    int m = Convert.ToInt32(Console.ReadLine());
                    cal.subtract(n, m);
                    Console.WriteLine($"{cal.subtract(n, m)}입니다.");

                }
                else if (c == 2)
                {
                    Console.WriteLine("두수를 입력하시오: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    int m = Convert.ToInt32(Console.ReadLine());
                    cal.divide(n, m);
                    Console.WriteLine($"{cal.divide(n, m)}입니다.");

                                 }
                else if (c == 3)
                {
                    Console.WriteLine("두수를 입력하시오: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    int m = Convert.ToInt32(Console.ReadLine());
                    cal.multiply(n, m);
                    Console.WriteLine($"{cal.multiply(n, m)}입니다.");

                }
                else if (c == 4)
                {
                    Console.WriteLine("두수를 입력하시오: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    int m = Convert.ToInt32(Console.ReadLine());
                    cal.module(n, m);
                    Console.WriteLine($"{cal.module(n, m)}입니다.");

                }
                else
                {
                    Console.WriteLine("잘못 입력하셨습니다.");
                }
                cal.Print();
            }
            /*
            for (int n = 0; n < 5; n++)
            {
                Console2.Write("암호를 입력하시요: ");
                int code = Convert.ToInt32(Console.ReadLine());//Convert.ToInt32 : string(문자열)을 int형으로 바꿈(32는 short, 64은 long)

                if (code == 454)
                {
                    Console2.Write("환영합니다.");
                    break;
                }
                else if (code != 454)
                {
                    Console2.Write("틀렸습니다. 다시 입력하십시오\n");
                }
            }
            */
        }
    }

    abstract class SomeClass 
    {
        public abstract void A();

    }
    class child : SomeClass
    {
        public override void A()
        {
            
        }
    }


    /*
     *계산기 클래스
    */

    class calculator
    {
        int calccount = 0;
        public int sum(int a, int b)
        {
            calccount++;
            return a + b;
        }

        public int subtract(int a, int b)
        {
            calccount++;
            return a - b;
        }

        public int divide(int a, int b)
        {
            calccount++;
            return a * b;
        }

        public int multiply(int a, int b)
        {
            calccount++;
            return a / b;
        }

        public int module(int a, int b)
        {
            calccount++;
            return a % b;
        }

        public void Print()
        {
            Console.WriteLine($"총 {calccount}회 계산되었습니다");
            Console.WriteLine("총"+ calccount + "회 계산되었습니다");
            Console.WriteLine(string.Format("총 {0}회 계산되었습니다", calccount ));
        }
    }

          

}
