using DAI.Forms;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DAI.Models
{
    public class Library
    {
         string PATH_DO_DATA;
        Car car = new Car();
        
        public Library()
        {
            Cars = new List<Car>();
            
        }

        public List<Car> Cars { get; set; }


        public List<Car> Search(string type, string Nomera, string author)
        {
            var result = new List<Car>();

            foreach (var b in Cars)
            {
                if (b.Nomera.Contains(Nomera) &&
                    b.Author.Contains(author) &&
                    b.Type.Contains(type))
                {
                    result.Add(b);
                }
            }
            return result;
        }
        

        public void SaveData(string path)
        {
            using StreamWriter writer = new(path);
            foreach (var b in Cars)
            {
                writer.WriteLine(b.Id);
                writer.WriteLine(b.Nomera);
                writer.WriteLine(b.Author);
                writer.WriteLine(b.Year);
                writer.WriteLine(b.Type);
                writer.WriteLine(b.Marka);
                writer.WriteLine(b.Model);
                writer.WriteLine(b.Color);
                writer.WriteLine(b.EventDateTime);
            }
        }
        public void LoadData(string path)
        {
            var lines = File.ReadAllLines(path);
            Cars.Clear();
            for (var i = 0; i < lines.Length; i += 9)
            {
                var Car = new Car()
                {
                    Id = Convert.ToInt32(lines[i]),
                    Nomera = lines[i + 1],
                    Author = lines[i + 2],
                    Year = Convert.ToInt32(lines[i + 3]),
                    Type = lines[i + 4],
                    Marka = lines[i + 5],
                    Model = lines[i + 6],
                    Color = lines[i + 7],
                    EventDateTime = Convert.ToDateTime(lines[i + 8]) 
            };
                Cars.Add(Car);
            }
            
        }
        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
        public bool FindDublicateNomer(string Nomera)
        {
            foreach (var car in Cars)
            {
                if (car.Nomera == Nomera)
                {
                    return true;
                }
            }
            return false;
        }
        public void RemoveCar(Car car)
        {
            var carToRemove = Cars.FirstOrDefault(c => c.Nomera == car.Nomera);
            if (carToRemove != null)
            {
                Cars.Remove(carToRemove);
            }
        }
        

    }
}
