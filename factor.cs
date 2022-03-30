using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace primefactor
{
    public class factor
    {
        public void primefactors(int n)
        {
            

            while(n % 2==0)
            {
                n = n / 2;
            }

            for(int i=3; i<=(n);i++)
            {
                while(n%1==0)
                {
                    n = n / i;

                }
            }
                
        }

        //private int sqrt(int n)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
