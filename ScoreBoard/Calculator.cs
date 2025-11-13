using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreBoard
{
    public class Calculator
    {
        private static int adition = 10;
        private static int bonus = 20;

        public int calculate (int requested, int received)
        {
            int result = 0;
            if (requested == received){
			    result = bonus + (received * adition);
            }else{
                if (received > requested)
				    result = -((received -requested) * adition);
                else
				    result = (received -requested) * adition;
            }
            return result;
        }
    }
}
