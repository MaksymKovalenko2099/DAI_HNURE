using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAI.Forms;

namespace DAI.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Nomera { get; set; }
        public string Author { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }   
        public string Type { get; set; }    
        public int Year { get; set; }
        public DateTime EventDateTime { get; set; }

        public string InfoCar;

        public string selectedDate;

        public DateTime ZapysDate;
        
        public bool Zapys = false ;

    }

}
