using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4FinalHW
{
    internal class Phone : BaseMachine
    {
        public bool IsTrLicence { get; set; }
        public Phone(string name, int serialnumber, string operatingSystem, string descprition,bool isTrLicence) : base(name, serialnumber, operatingSystem, descprition)
        {
            IsTrLicence = isTrLicence;
        }
        // abstract function polymorphism
        public override void GetNameMachine()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Telefonunuz adı: "+ base.Name);
        }
        // virtual function polymorphism
        public override void WriteInfo()
        {
            Console.WriteLine("-----------------------------");
            base.WriteInfo();
            Console.WriteLine("TR Lisanslı mı : " + (IsTrLicence?"Evet":"Hayır"));
        }
    }
}
