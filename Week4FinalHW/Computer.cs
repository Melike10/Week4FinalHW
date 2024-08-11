using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4FinalHW
{
    internal class Computer : BaseMachine
    {
        private int usbEntryNum;
        public bool HasBluetooth { get; set; }

        // encapsulation example
        public int UsbEntryNum
        {
            get { return usbEntryNum; }
            set
            {
                if (value != 2 && value != 4)
                {
                    usbEntryNum = -1;
                    Console.WriteLine("Geçersiz giriş yaptınız. 2 ve 4 değeri kabul edilir.");
                }
                else
                {
                    usbEntryNum = value;
                }


            }
        }
        public Computer(string name, int serialnumber, string operatingSystem, string descprition,int usbEntryNum, bool hasBluetooth) : base(name, serialnumber, operatingSystem, descprition)
        {
            UsbEntryNum = usbEntryNum;
            HasBluetooth = hasBluetooth;
        }

        // abstract class polymorphism
        public override void GetNameMachine()

        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Bilgisayarınızın adı: "+ base.Name);
        }

        // virtual class polymorphism
        public override void WriteInfo()
        {
            Console.WriteLine("-----------------------------");
            base.WriteInfo();
            Console.WriteLine("USB Girişi:" + UsbEntryNum + "\n Bluetooth özelliği " + (HasBluetooth ? "Var" : "Yok")); 
        }

      
    }
}
