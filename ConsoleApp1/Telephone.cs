using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface ITelephone
    {
        void Call(string telno);
        void Receive();
    }

    interface IMobile
    {
        void Power(bool isOn);
        void LaunchApp(string appName);
        int ElectronicMoney { get; set; }
    }

    class WindowsPhone : ITelephone, IMobile
    {
        public void Call(string telno)
        {
            throw new NotImplementedException();
        }

        public void Power(bool isOn)
        {
            throw new NotImplementedException();
        }

        public void LaunchApp(string appName)
        {
            throw new NotImplementedException();
        }

        public void Receive()
        {
            throw new NotImplementedException();
        }

        public int ElectronicMoney
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }

    class MyFunc<T>
    {
        private T value;

        public void save(T value)
        {
            this.value = value;
        }

        public T load()
        {
            return this.value;
        }
        /*
        //int[] value;
        public void SaveValue(int x)
        {
            // do something
        }

        //int[] double
        public void SaveValue(double x)
        {
            // do something
        }
        */
    }
}
