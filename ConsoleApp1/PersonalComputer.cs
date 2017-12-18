using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class PersonalComputer
    {
        private string memo;
        protected string os;
        protected int hdd;

        abstract public void ShowOS();

        public string Memo
        {
            get { return memo; }
            set { memo = value; }
        }
    }

    class WinPC : PersonalComputer
    {
        public WinPC(string memo)
        {
            os = "Windows 10";
            hdd = 1000;
            base.Memo = memo;
        }

        public override void ShowOS()
        {
            Console.WriteLine($"Os on this machine is {os}.");
        }
    }
}
