using DAI.Models;
using DAI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAI.Forms
{
    public partial class CarEditDialog : Form
    {
         Car Car = new Car();

        Library library = new Library();
        public void TOexpired()
        {
            TimeSpan interval = DateTime.Now - Car.EventDateTime;

            if (interval.Days < 360)
            {
                eventDateTimeBox.BackColor = Color.Green;
            }
            else if (interval.Days >= 360 && interval.Days < 366)
            {
                eventDateTimeBox.BackColor = Color.Orange;
            }
            else
            {
                eventDateTimeBox.BackColor = Color.Red;
            }
        }



        public CarEditDialog(Car Car, Library library)
        {
            InitializeComponent();

            this.Car = Car;
            this.library = library;
            idBox.Text = Car.Id.ToString();
            titleBox.Text = Car.Nomera;
            authorBox.Text = Car.Author;
            yearBox.Text = Car.Year.ToString();
            typeBox.Text = Car.Type;
            markaBox.Text = Car.Marka;
            modelBox.Text = Car.Model;
            colorBox.Text = Car.Color;
            


            eventDateTimeBox.Text = Car.EventDateTime.ToString();
            TOexpired();
        }
        const string PATH_DO_DATA = ".\\library.txt";
        private void OKButton_Click(object sender, EventArgs e)
        {
            Car.Nomera = titleBox.Text;
            Car.Author = authorBox.Text;
            Car.Year = Convert.ToInt32(yearBox.Text);
            Car.Type = typeBox.Text;
            Car.Marka = markaBox.Text;
            Car.Model = modelBox.Text;
            Car.Color = colorBox.Text;
            Car.EventDateTime = Convert.ToDateTime(eventDateTimeBox.Text);
            
            library.SaveData(PATH_DO_DATA);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car.EventDateTime = Convert.ToDateTime(eventDateTimeBox.Text);
            library.SaveData(PATH_DO_DATA);
            var dialog = new TechOglyad(Car,library);
            dialog.ShowDialog();
        }
    }
}
