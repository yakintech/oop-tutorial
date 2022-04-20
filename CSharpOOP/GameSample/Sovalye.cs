using System;
namespace CSharpOOP.GameSample
{
    public class Sovalye : BaseGameChar
    {
       

        string zirh = "Ölümcül Plaka";

        public string Zirh {
            get
            {
                return zirh;
                    
            }
            set
            {
                zirh = value.ToUpper();
            }
        }

        public string No { get; set; }

        public Sovalye(string name) : base(name)
        {
            string country = "TR";
        }

        public override void Hello()
        {
            Console.WriteLine("Şovalye");
            base.Hello();
          
        }


        double point = 0;

        public double Point {
            get
            {
                return CalcPoint(point);
            }
            set
            {
                point = value;
            }
        }
    }
}
