using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ICT3101_Calculator
{
    public class Calculator
    {
        private FileReader getTheMagic;
        public Calculator()
        {
            // Lab 4 Q4
            getTheMagic = new FileReader();
        }
        public double DoOperation(double num1, double num2, double num3, string op)
        {
            double result = double.NaN; // Default value
                                        // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                case "f":
                    // Ask the user to enter a non-zero divisor.
                    result = Factorial(num1);
                    break;
                case "g":
                    // Ask the user to enter a non-zero divisor.
                    result = AreaTriangle(num1, num2);
                    break;
                case "h":
                    // Ask the user to enter a non-zero divisor.
                    result = AreaCircle(num1);
                    break;
                case "i":
                    // Ask the user to enter a non-zero divisor.
                    result = UnknownFunctionA(num1, num2);
                    break;
                case "j":
                    // Ask the user to enter a non-zero divisor.
                    result = UnknownFunctionB(num1, num2);
                    break;
                case "mtbf":
                    // Get result of MTBF
                    result = MTBF(num1, num2);
                    break;
                case "availability":
                    // Get result of Availability
                    result = Availability(num1, num2);
                    break;
                case "cfi":
                    // Get result of current failure intensity using Basic Musa Model
                    result = CurrentFailureIntensity(num1, num2, num3);
                    break;
                case "nef":
                    // Get result of average number of expected failures using Basic Musa Model
                    result = AverageNumberofExpectedFailures(num1, num2, num3);
                    break;
                case "dd":
                    // Get result of defect density 
                    result = DefectDensity(num1, num2);
                    break;
                case "ssi":
                    // Get result of SSI for second release
                    result = SSISecondRelease(num1, num2, num3);
                    break;
                case "magic":
                    // Get result of SSI for second release
                    result = GenMagicNum(num1,getTheMagic);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
        public double Add(double num1, double num2)
        {
            //if input not binary
            if (!(Regex.IsMatch(num1.ToString(), "^[01]+$") && Regex.IsMatch(num2.ToString(), "^[01]+$")))
            {
                return (num1 + num2);
            }
            else
            {
                string strResult = num1.ToString() + num2.ToString();
                return Convert.ToDouble(Convert.ToInt32(strResult, 2));
            }
            //string str1 = num1.ToString()+"00";
            //string str2 = num2.ToString();
            //double double1 = Convert.ToDouble(Convert.ToInt32(str1, 2));
            //double double2 = Convert.ToDouble(Convert.ToInt32(str2, 2));
            //return (double1 + double2);
        }
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {
            if (num1 == 0 && num2 != 0)
            {
                return 0;
            }
            else if (num1 != 0 && num2 == 0)
            {
                return Double.PositiveInfinity;
            }
            else if (num1 == 0 && num2 == 0)
            {
                return 1;
            }
            return num1 / num2;
        }
        public double Factorial(double num)
        {
            //if (num < 0) {
            //    throw new ArgumentException();
            //}
            //double output = 1;
            //double i;
            //for (i = num; i > 0; i--) {
            //    output *= i;
            //}
            //return output;
            // Lab 2.2 Q16
            double result = 1;
            while (num != 0)
            {
                result *= num;
                num--;
            }
            return result;
        }


        public double AreaTriangle(double height, double len)
        {
            if (height <= 0 || len <= 0)
            {
                throw new ArgumentException();
            }


            return (height * len) / 2;
        }
        public double AreaCircle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException();
            }


            return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        }
        public double UnknownFunctionA(double num1, double num2)
        {
            if ((num1 < 0) || (num1 < num2))
            {
                throw new ArgumentException();
            }
            try
            {
                return Factorial(num1) / Factorial(Subtract(num1, num2));
            }
            catch (Exception)
            {
                throw new ArgumentException();
            }
        }

        public double UnknownFunctionB(double num1, double num2)
        {
            if ((num1 < 0) || num1 < num2)
            {
                throw new ArgumentException();
            }
            try
            {
                return Factorial(num1) / (Factorial(num2) * Factorial(Subtract(num1, num2)));
            }
            catch (Exception)
            {
                throw new ArgumentException();
            }
        }

        // Lab 2.2 Q17
        public double MTBF(double MTTF, double MTTR)
        {
            return MTTF + MTTR;
        }

        public double Availability(double MTTF, double MTBF)
        {
            return (MTTF / MTBF);
        }

        // Lab 2.2 Q18
        public double CurrentFailureIntensity(double num1, double num2, double num3)
        {
            return (Multiply(num1, 1 - Divide(num2, num3)));
        }
        public double AverageNumberofExpectedFailures(double num1, double num2, double num3)
        {
            return (Multiply(num1, 1 - Math.Pow(Math.E, Divide(Multiply(-num2, num3), num1))));
        }
        // Lab 2.3 Q22
        // Logarithmic Model
        public decimal CurrentFailureIntensityLogModel(double initialFailure, double decayParam, double avgExptFailure)
        {
            return decimal.Round((decimal)Multiply(initialFailure, Math.Exp(Multiply(-decayParam, avgExptFailure))), 2);
        }

        public int LogAverageNumberofExpectedFailures(double time, double decayParam, double initialFailure)
        {
            return (int)Multiply(Math.Log(Add(Multiply(initialFailure, decayParam * time), 1)), Divide(1, decayParam));
        }

        // Lab 2.3 Q22
        public double DefectDensity(double defects, double CSI)
        {
            return (defects / CSI);
        }
        public double SSISecondRelease(double SSIOld, double CSI, double changedCode)
        {
            return (Subtract((SSIOld + CSI), changedCode));
        }
        // Lab 4
        public double GenMagicNum(double input, IFileReader fileReader)
        {
            double result = 0;
            int choice = Convert.ToInt16(input);

            // Lab 4 Q1
            //Dependency------------------------------
            //FileReader getTheMagic = new FileReader();
            //----------------------------------------
            //string[] magicStrings = getTheMagic.Read(@"Your file name");

            string[] magicStrings = fileReader.Read(@"MagicNumbers.txt");
            if ((choice >= 0) && (choice < magicStrings.Length))
            {
                result = Convert.ToDouble(magicStrings[choice]);
            }
            result = (result > 0) ? (2 * result) : (-2 * result);
            return result;
        }

    }
}
