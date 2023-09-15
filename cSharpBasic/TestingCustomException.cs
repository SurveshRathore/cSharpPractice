using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBasic
{
    public class TestingCustomException
    {
        public int divide (int numerator, int denominator)
        {
			
				if(denominator == 0)
				{
					throw new CustomException("Denominator cannot be zero");
                    // throw new Exception("Denominator cannot be zero");
                }

				return numerator / denominator;
			
        }

        public void calculations(int numerator, int denominator)
        {
            try
            {
                int result = divide(numerator, denominator);
                Console.WriteLine(result);
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Custom Exception: " + ex.Message);
            //}
            catch (CustomException ex)
            {
                //Console.WriteLine ("Custom Exception: " + ex.Message);
                throw new CustomException(CustomException.ExceptionType.INVALID_INPUT, "This is an invalid input");
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine("General Exception: " + ex.Message);
            //}
        }
    }
}
