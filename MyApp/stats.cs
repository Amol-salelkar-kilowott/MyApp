using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
	internal class stats
	{

        internal int[] Numbers { private get; set; }



        internal int Calculatesum()
        {
            int sum = 0;
            foreach (int i in Numbers)
            {
                sum = sum + i;
            }
            return sum;
        }

        internal double Calculatemean()
        {
            double mean = 0;
            for (int i = 0; i < Numbers.Length; i++)
            {
                mean = mean + Numbers[i];
            }
            return mean/ Numbers.Length;
        }
        
        internal double Calculatemedian()
        {
            int n = Numbers.Length;
            
            if (n % 2 != 0)
                return (double)Numbers[n / 2];
            
            return (double)(Numbers[(n - 1) / 2] + Numbers[n / 2]) / 2.0;
        }

        internal double Calculatemode()
        {
            int n = Numbers.Length;
          
            int max = Numbers.Max();
            int t = max + 1;
            int[] count = new int[t];
            for (int i = 0; i < t; i++)
                count[i] = 0;
            
            for (int i = 0; i < n; i++)
                count[Numbers[i]]++;
           
            int mode = 0;
            int k = count[0];
            for (int i = 1; i < t; i++)
            {
                if (count[i] > k)
                {
                    k = count[i];
                    mode = i;
                }
            }
            return mode;
        }
         



          
          

    }


}



