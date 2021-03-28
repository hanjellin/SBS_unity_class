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
        static void Main(string[] args)
        {
            Random ran = new Random();
            int randomValue = ran.Next(0, 101);//0~100

            

            Console.WriteLine("몬스터가 나타났다!");

            for (int i = 0; ;)
            {
                Character ch = new Character();
                int coo;
                Console.WriteLine("1.공격\n2.방어\n3.기술\n4.아이템\n5.후퇴\n무엇을 하시겠습니까?");
                coo = Convert.ToInt32(Console.ReadLine());
                if(coo== 1)
                {
                    if (ran.Next(0, 11) != 1)
                    {
                        ch.hit(ran.Next(8, 14));
                    }
                    else if((ran.Next(0, 11) == 10)){
                        Console.WriteLine("크리티걸!");
                        ch.hit(ran.Next(16, 28));
                    }
                    else
                    {
                        Console.WriteLine("공격이 빚나갔다!");
                    }

                }
                else if(coo == 2)
                {
                    Console.WriteLine($"");
                    ch.hit(100);

                }
                else if (coo == 3)
                {

                }
                else if (coo == 4)
                {

                }
                else if (coo == 5)
                {

                }
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
}
