using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.Utils
{
    public class ConvertNumber
    {

        public static string ConvertToView(int number)
        {
            string convertedNumber;

            if (number > 1 && number <= 15) convertedNumber = "B"+Convert.ToString(number);
            else if(number > 15 && number <= 30) convertedNumber = "I"+Convert.ToString(number);
            else if( number > 30 && number <= 45) convertedNumber = "N"+Convert.ToString(number);
            else if( number > 45 && number <= 60) convertedNumber = "G"+Convert.ToString(number);
            else if( number > 60 && number <= 75) convertedNumber = "O"+Convert.ToString(number);
            else
            {
                MessageBox.Show("Número fora do padrão exigido!","Bingo",MessageBoxButtons.OK);
                convertedNumber = "BINGO";
            }
            return convertedNumber;
        }

    }
}
