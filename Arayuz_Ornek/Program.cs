using System;
namespace Arayuz_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Veyron v1=new Veyron();
            Console.WriteLine(v1.MarkasiNe().ToString());
            Console.WriteLine(v1.RengiNe().ToString());
            Console.WriteLine(v1.KacKapili());

            Broadway b1 =new Broadway();
            Console.WriteLine(b1.MarkasiNe().ToString());
            Console.WriteLine(b1.RengiNe().ToString());
            Console.WriteLine(b1.KacKapili());


            Veyron1_1 v2=new Veyron1_1();
            Console.WriteLine(v2.MarkasiNe().ToString());
            Console.WriteLine(v2.RengiNe().ToString());
            Console.WriteLine(v2.KacKapili());

            Mustang1_1 m2= new Mustang1_1();
            Console.WriteLine(m2.MarkasiNe().ToString());
            Console.WriteLine(m2.RengiNe().ToString());
            Console.WriteLine(m2.KacKapili());
        }
    }
}