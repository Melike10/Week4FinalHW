using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4FinalHW
{
    public abstract class BaseMachine
    {
        // create common properties for inheritance
        public DateTime ProductionDate { get; set; }
        public int SerialNumber { get; set; }
        public string Descprition { get; set; }
        public string Name { get; set; }
        public string OperatingSystem { get; set; }

        // Base ctor
        public BaseMachine(string name,int serialnumber,string operatingSystem,string descprition)
        {
            Name = name;
            SerialNumber = serialnumber;
            Descprition = descprition;
            OperatingSystem = operatingSystem;
            ProductionDate = DateTime.Now;
        }

        // show machine info with virtual function
        public virtual void WriteInfo()
        {
            Console.WriteLine("Ürün Adı: "+ Name+"\n Ürün Tanımı: "+ Descprition+"\n Seri Numaraları: "+SerialNumber+"\n İşletim Sistemi: "+OperatingSystem+"\n Üretim Tarihi: "+ProductionDate);
        }

        // show Machine name with abstract function
        public abstract void GetNameMachine();
    }
}
