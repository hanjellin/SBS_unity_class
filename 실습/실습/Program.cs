using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 실습
{
    enum choose
    {
        공격 = 1,
        방어,
        기술,
        아이템,
        후퇴
    }
    class Program
    {
        public int damage;
        public int hitdamage;

        static void Main(string[] args)
        {
            Random ran = new Random(); //무작위 수
            int randomValue = ran.Next(0, 101);//0~100
            
            Dictionary<string, string> item = new Dictionary<string, string>();
                item["포션"] = "HP10 회복한다.";
                item.Add("폭탄", "적에게 30의 피해를 준다.");
                

            for (int i = 0; ;)
            {
                Character ch = new Character();//아군 클래스
                int cho;
                Console.WriteLine("1.공격\n2.방어\n3.기술\n4.아이템\n5.후퇴\n무엇을 하시겠습니까?");
                coo = Convert.ToInt32(Console.ReadLine());
                if(cho == 1)
                {
                    if (ran.Next(0, 11) != 1)
                    {
                        damage = ch.hit(ran.Next(atk1-3, atk1+3));
                    }
                    else if((ran.Next(0, 11) == 10)){
                        Console.WriteLine("크리티걸!");
                        damage = ch.hit(ran.Next(16, 28));
                    }
                    else
                    {
                        Console.WriteLine("공격이 빚나갔다!");
                    }

                }
                else if(cho == 2)
                {
                    Console.WriteLine($"들어오는 피해를 줄였다.");
                    hitdamage = hitdamage * 2 / 10;

                }
                else if (cho == 3)
                {
                    Console.WriteLine("배운 게 없습니다.");
                }
                else if (cho == 4)
                {
                    foreach(KeyValuePair<string, string> tem in item)
                    {
                        Console.WriteLine($"{tem.Key} - {tem.Value}");

                    }
                    Console.Write("아이템을 입력하시오: ");
                    Console.ReadLine();
                    if()
                    {


                    }

                }
                else if (cho == 5)
                {

                }
                else
                {


                }


            }




        }
            

        

        
    }
    class iitem
        {
            void ded()
            {
                Dictionary<string, string> plan = new Dictionary<string, string>();
                plan["포션"] = "HP10 회복한다.";
                plan.Add("폭탄", "적에게 30의 피해를 준다.");

                Dictionary<string, int> item = new Dictionary<string, int>();
                item.Add("포션", 10);
                item["폭탄"] = 30;
            }
            
        }

    class Character
        {
            public int Hp1 = 100;
            public int atk1 = 10;
            public int mp1 = 10;
            public void attck(Character target)
            {
                
            }
            public void hit(int damage)
            {
                Console.WriteLine($"{damage}의 데미지를 입었다!");

            }
        }
        class monster
        {
            public int Hp2 = 100;
            public void attck(Character target)
            {

            }
            public void hit(int damage)
            {
                Console.WriteLine($"{damage}의 데미지를 주었다!");
                Hp2 -= 10;
            }
        }
}
