using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TestDebugAndExc
{
    public class BusCompany
    {
        public string Name { get; set; }    
        public Dictionary<int,int> BusDriverPair { get; set; }

        public BusCompany(string name)
        {
            Name = name;
            BusDriverPair = new Dictionary<int,int>();  

        }

        public void HireDriver(Driver driver , Bus bus)
        {
            try
            {
                CheckDriver(driver.Age,driver.Licence);
                BusDriverPair.Add(driver.Id, bus.Id);

            }
            catch(InvalidDriverAgeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch(LicenceNotFoundException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Executed Finally block");
            }
        }
        private void CheckDriver(int age , bool licence)
        {
#if DEBUG
            if(age < 18)
            {
                throw new InvalidDriverAgeException("Driver must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Driver age is valid");
            }
#endif


            if (!licence)
            {
                throw new LicenceNotFoundException("Driver should have driver licence");
            }
            else
            {
                Console.WriteLine("Driver licence is valid");
            }
        }

        public void PrintData()
        {
            Console.WriteLine($"Company Name: {Name}");

            if (BusDriverPair.Count <= 0)
            {
                Console.WriteLine("The BusDriverPair is empty");
            }
            else
            {
                foreach(var item in BusDriverPair)
                {
                    Console.WriteLine($"Bus Id: {item.Key} | Driver Id : {item.Value}");
                }
            }
                             
        }
    }
}
