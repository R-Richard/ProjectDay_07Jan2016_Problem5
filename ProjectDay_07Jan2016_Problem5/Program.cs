using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDay_07Jan2016_Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            string compNameAsString = "XYZ Company";
            string propertyNumberAsString = "1234";
            int propertyNumberAsInt = Convert.ToInt32(propertyNumberAsString);
            string streetAndDesigAsString = "Commerce Drive";
            string ZipAsString = "44110";
            int ZipAsInt = Convert.ToInt32(ZipAsString);
            string cityAsString = "Cleveland";
            string stateAsString = "Ohio";
            string webAddressAsString = "www.xyz.com";
            string PhoneNbrAsString = "(216) 123-9876";
            string FaxNbrAsString = "(216) 987-1234";
            string ManagerFirstNameAsString = "Andi";
            string ManagerSurnameAsString = "Public";
            string ManagerPhoneAsString = "(216) 789-4321";

            Console.Write("{0,-20}", ManagerFirstNameAsString);
            Console.Write("{0,-20}", ManagerSurnameAsString);
            Console.WriteLine("{0,20}", ManagerPhoneAsString);
        }
    }
}
