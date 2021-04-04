using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 실습_생태계
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class world
    {
        public void life()
        {
            List<string> life = new List<string>();
            life.Add(NewMonkey);
        }

    }


    abstract class Craeture
    {

    }

    abstract class Mammal : Craeture
    {
        public string Monkey ;
        public string Whale;
        public string Dolphin;
    }
    abstract class Birds : Craeture
    {
        public string Eagles;
        public string Sparrow;
        public string Pigeon;
        public string penguin;
    }
    abstract class Fish : Craeture
    {
        public string Goldfish;
        public string Eel;
    }


}
