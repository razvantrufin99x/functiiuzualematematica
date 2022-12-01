using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace functiiuzualematematica
{
    public class natural
    {
        public int a;

        public bool epar()
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool eimpar()
        {
            if (a % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            } 
        }

        public bool edivizibil(natural b)
        {
            if ( b.a % a== 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool emultiplu(natural b)
        {
            
            natural x = new natural();
            x.a = 0;
            
            x.a = a / b.a ;

            if ((x.a * b.a) == a && a > b.a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool esubmultiplu(natural b)
        {

            if (b.a % a == 0 && a < b.a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool eprim()
        {
            for(int i = 2;i<=a/2;i++)
            {
                if (a % i==0)
              {
                return false;
               }
             }
            return true;
        }

        public bool eegal(natural b)
        {
            if (b.a == a )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ediferit(natural b)
        {
            if (b.a != a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool emaimare(natural b)
        {
            if (b.a < a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool emaimic(natural b)
        {
            if (b.a > a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //de adaugat codul urmator
        public natural cmmdc(natural b)
        {
            natural nrcmmdc = new natural();
            nrcmmdc.a = 0;
            // de adaugat codul aici
            return nrcmmdc;
        }

        public natural cmmmc(natural b)
        {
            natural nrcmmmc = new natural();
            nrcmmmc.a = 0;
            // de adaugat codul aici
            return nrcmmmc;
        }

        public void sumacifrelor() { }
        public void sumacifrepare() { }
        public void sumacifreimpare() { }

        public void produscifrelor() { }
        public void produscifrepare() { }
        public void produscifreimpare() { }


        public void contorcifrenumar() { }

        public void emaimaresauegal() { }
        public void emaimicsauegal() { }
        public void evid() { }
        public void enull() { }
        public void einfinit() { }
        public void ezero() { }
        public void eintre() { }
        //de adaugat alte functii specifice numerelor naturale
        //public void () { }
    }
}
