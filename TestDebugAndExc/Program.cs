// See https://aka.ms/new-console-template for more information
using TestDebugAndExc;

Console.WriteLine("Hello, World!");

Driver driver = new Driver { Id = 234, Name = "Alex Dobrea",  Licence = true, Age = 17 };
Driver driver2 = new Driver { Id = 235, Name = "Aleco Russo",  Licence = true, Age = 25 };
Driver driver3 = new Driver { Id = 236, Name = "Aleco Russo",  Licence = true, Age = 25 };

Bus bus = new Bus { Id = 111, Driver = driver , Year = 2012 };
Bus bus2 = new Bus { Id = 112, Driver = driver2 , Year = 2014 };
Bus bus3 = new Bus { Id = 113, Driver = driver3 , Year = 2015 };

BusCompany comp1 = new BusCompany("ARTEC");
comp1.HireDriver(driver, bus);
comp1.HireDriver(driver2, bus2);
comp1.HireDriver(driver3, bus3);

comp1.PrintData();
