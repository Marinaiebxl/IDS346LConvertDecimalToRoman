using System;


namespace ConvertToRoman
{
   class program
{
 static void Main(string[] args)
{
            Console.WriteLine("Enter a decimal");
            int decimalNumber = int.Parse(Console.ReadLine());

            try
            {
                string romanNumeral= DecimalToRoman(decimalNumber);
                Console.WriteLine(decimalNumber + "in Roman numbers is" + romanNumeral); 
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

            static string DecimalToRoman(int num)
            {
                if(num <= 0)
                {
                    throw new ArgumentOutOfRangeException("The number must be positive");

                }    

                if( num > 3999)
                {
                    throw new ArgumentOutOfRangeException("Number can't exceed 3999");
                }
                string[] thousands = { "", "M", "MM", "MMM" };
                string[] hundreds = { "", "C","CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "DM" };
                string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};
                string[] ones = {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };   

                return thousands[num/1000] + hundreds[(num%1000)/100] + tens[(num%100)/10] + ones[num%10];
            }
        }

    }


}

