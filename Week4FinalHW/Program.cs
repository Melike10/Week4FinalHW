// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

namespace Week4FinalHW
{
    public class Program
    {

     
            public static void Main(string[] args)
        {
            bool devam ;
            
            
            do
            {
                Console.WriteLine("Hangi Ürünün girişini yapmak istiyorsunuz? \n Bilgisayar için 1 yazın. \n Telefon için 2 yazın.");
                int urun;
                bool urundeger;

                do
                {
                    Console.Write("Ürün Değer : ");
                    urundeger = int.TryParse(Console.ReadLine(), out urun);
                    if(urundeger == false || (urun != 1 && urun != 2) )
                        Console.WriteLine("Yanlış değer girdiniz. Bilgisayar için 1 , Telefon için 2 değerini giriniz: ");
                } while(urundeger == false || (urun != 1 && urun != 2));
                // get common variables from a function
                (string name, string description, int serialnum, string op) = UrunVariables(urun);


                if (urun== 1)
                {
                    Console.WriteLine("USB Giriş Sayısı:");
                    int usb= int.Parse(Console.ReadLine());
                    Console.WriteLine("Bluetooth var mı ? (true/false)");
                    bool hasBluetooth = bool.Parse(Console.ReadLine());

                    Computer computer= new Computer(name,serialnum,op, description, usb,hasBluetooth);
                    computer.GetNameMachine();
                    computer.WriteInfo();
                    


                }
                else
                {
                    Console.WriteLine("TR Lisansı var mı? (true/false)");
                    bool isTr=bool.Parse(Console.ReadLine());

                    Phone phone = new Phone(name,serialnum,op,description,isTr);
                    phone.GetNameMachine();
                    phone.WriteInfo();


                }
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Ürün kaydı yapmaya devam etmek istiyor musunuz? (true/false)");
                devam = bool.Parse(Console.ReadLine());

            } while(devam);

            if (devam == false)
            {
                Console.WriteLine("Çıkışınız yapılmıştır teşekkür ederiz.");
            }
            

        }
        // get common information from a function
        public static (string, string, int, string) UrunVariables(int urun)
        {
            string machine = urun > 1 ? "Telefon" : "Bilgisayar";
            Console.WriteLine(machine+" adı:");
            string name = Console.ReadLine();
            Console.WriteLine(machine+" tanımı:");
            string description = Console.ReadLine();
            Console.WriteLine(machine+" Seri No:");
            int serialnum = int.Parse(Console.ReadLine());
            Console.WriteLine(machine+" işletim Sistemi:");
            string op = Console.ReadLine();

            return (name, description, serialnum, op);
        }

    }
}
