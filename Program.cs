using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Car> cars = new List<Car>
            {
                new Car { Name = "BMV i5", Price = "200000", Year = "2022", Manufacturer = "BMV", color = "Blue", Speed = "230km", Mass = "2740kg" },
                new Car { Name = "Mercedes C300", Price = "99000", Year = "1989", Manufacturer = "Mercedes", color = "White", Speed = "230km", Mass = "2740kg" },
                new Car { Name = "BMV i7", Price = "225000", Year = "2021", Manufacturer = "BMV", color = "White", Speed = "230km", Mass = "2740kg" },                               
                new Car { Name = "Mercedes C200", Price = "120000", Year = "2018", Manufacturer = "Mercedes", color = "White", Speed = "230km", Mass = "2740kg" },
                new Car { Name = "BMV X3", Price = "185000", Year = "1992", Manufacturer = "BMV", color = "White", Speed = "230km", Mass = "2740kg" },
                new Car { Name = "Mercedes AMG", Price = "200000", Year = "2022", Manufacturer = "Mercedes", color = "White", Speed = "230km", Mass = "2740kg" },
                new Car { Name = "BMV X6", Price = "175000", Year = "1988", Manufacturer = "BMV", color = "White", Speed = "230km", Mass = "2740kg" },


            };
            List<Truck> trucks = new List<Truck>
            {
                new Truck { Name = "Hyunhdai Porter", Price = "30000", Year = "2019", Manufacturer = "Hyunhdai", color = "White", Speed = "190km", Mass = "3000kg" },
                new Truck { Name = "Isuzu QKR", Price = "185000", Year = "2020", Manufacturer = "Isuzu", color = "Blue", Speed = "185km", Mass = "3200kg" },
                new Truck { Name = "Isuzu QRK", Price = "125000", Year = "2021", Manufacturer = "Isuzu", color = "White", Speed = "185km", Mass = "3200kg" },
                new Truck { Name = "Isuzu QNT", Price = "115000", Year = "2018", Manufacturer = "Isuzu", color = "White", Speed = "185km", Mass = "3200kg" },
                new Truck { Name = "Toyota V1", Price = "115000", Year = "2018", Manufacturer = "Toyota", color = "White", Speed = "185km", Mass = "3200kg" },
                new Truck { Name = "Toyota V2", Price = "115000", Year = "2018", Manufacturer = "Toyota", color = "White", Speed = "185km", Mass = "3200kg" },
                new Truck { Name = "Suzuki TT1", Price = "115000", Year = "2018", Manufacturer = "Suzuki", color = "White", Speed = "185km", Mass = "3200kg" },




            };
            var flprice = cars.Where(gia => int.Parse(gia.Price) >= 100000 && int.Parse(gia.Price) <= 250000);
            Console.WriteLine("Danh sách Car:");
            Console.WriteLine();
            foreach (var car in cars)
            {
                Console.WriteLine($"Name: {car.Name} / Price: {car.Price} / Year: {car.Year} / Manufacturer: {car.Manufacturer} / Color: {car.color} / Speed: {car.Speed} / Mass: {car.Mass}");
            }
            Console.WriteLine();
            Console.WriteLine("các xe có giá trong khoảng 100.000 đến 200.000");
            Console.WriteLine();
            foreach (var car in flprice)
            {
                Console.WriteLine($"Name: {car.Name} / Price: {car.Price} / Year: {car.Year} / Manufacturer: {car.Manufacturer} / Color: {car.color} / Speed: {car.Speed} / Mass: {car.Mass}");
            }
            var flyear = cars.Where(nam => int.Parse(nam.Year) > 1990);
            Console.WriteLine();
            Console.WriteLine("Các xe có năm sản xuất > 1990:");
            Console.WriteLine();
            foreach (var car in flyear)
            {
                Console.WriteLine($"Name: {car.Name} / Price: {car.Price} / Year: {car.Year} / Manufacturer: {car.Manufacturer} / Color: {car.color} / Speed: {car.Speed} / Mass: {car.Mass}");
            }
            var flmanufacturer = cars.Where(hang => hang.Manufacturer == "BMV");
            Console.WriteLine();
            Console.WriteLine("Các xe hãng BMV:");
            var giabmv = 0;
            foreach (var car in flmanufacturer)
            {
                
                Console.WriteLine($"Name: {car.Name} / Price: {car.Price} / Year: {car.Year} / Manufacturer: {car.Manufacturer} / Color: {car.color} / Speed: {car.Speed} / Mass: {car.Mass}");
               
                giabmv = giabmv + int.Parse(car.Price);
            }
            Console.WriteLine($"tổng giá là : {giabmv}");
            Console.WriteLine();
            Console.WriteLine("Các xe hãng Mercedes:");
            var flmanufacturer1 = cars.Where(hang1 => hang1.Manufacturer == "Mercedes");
            var giamer = 0;
            foreach (var car in flmanufacturer1)
            {

                Console.WriteLine($"Name: {car.Name} / Price: {car.Price} / Year: {car.Year} / Manufacturer: {car.Manufacturer} / Color: {car.color} / Speed: {car.Speed} / Mass: {car.Mass}");

                giamer = giamer + int.Parse(car.Price);
            }
            Console.WriteLine($"tổng giá là : {giamer}");
            Console.WriteLine("______________________________");
            Console.WriteLine("Danh sách Truck:");
            Console.WriteLine();
            foreach (var Truck in trucks)
            {
                Console.WriteLine($"Name: {Truck.Name} / Price: {Truck.Price} / Year: {Truck.Year} / Manufacturer: {Truck.Manufacturer} / Color: {Truck.color} / Speed: {Truck.Speed} / Mass: {Truck.Mass}");
            }
            var flnewyear = trucks.OrderByDescending(newyear => newyear.Year);
            Console.WriteLine();
            Console.WriteLine("Danh sách sắp xếp theo năm sản xuất mới nhất:");
            Console.WriteLine();

            foreach (var Truck in flnewyear)
            {
                Console.WriteLine($"Name: {Truck.Name} / Price: {Truck.Price} / Year: {Truck.Year} / Manufacturer: {Truck.Manufacturer} / Color: {Truck.color} / Speed: {Truck.Speed} / Mass: {Truck.Mass}");

            }
            var flnewManufacturer = trucks.Select(chu => chu.Manufacturer).Distinct();
            Console.WriteLine();
            Console.WriteLine("Các công ty chủ quản của Truck:");
            Console.WriteLine();

            foreach (var Truck in flnewManufacturer)
            {
                Console.WriteLine($" Manufacturer: {Truck}");

            }

            Console.ReadKey();
        }
        public class Vehicle
        {
            public String Name { get; set; }
            public String Price { get; set; }
            public String Year { get; set; }
            public String Manufacturer { get; set; }
        }
        public class Car:Vehicle
        {
            public String color { get; set; }
            public String Speed { get; set; }
            public String Mass { get; set; }

            
        }
        public class Truck : Vehicle
        {
            public String color { get; set; }
            public String Speed { get; set; }
            public String Mass { get; set; }
        }
    }
}
