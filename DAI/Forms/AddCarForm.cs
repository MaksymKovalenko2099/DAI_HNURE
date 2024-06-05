using DAI.Models;
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
    public partial class AddCarForm : Form
    {
        Car car = new Car();
        Library library = new Library();
        
        const string PATH_DO_DATA = ".\\library.txt";
        public Car NewCar { get; private set; }
        public AddCarForm()
        {
            
            InitializeComponent();
        
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            library.LoadData(PATH_DO_DATA);
            if (title1Box.Text == "" ||
                authorBox.Text == "" ||
                yearBox.Text == "" ||
                typeBox.Text == "" ||
                markaBox.Text == "" ||
                modelBox.Text == "" ||
                colorBox.Text == "" ||
                eventDateTimeBox.Text == "")
            {
                MessageBox.Show("Ви не заповнили всі поля");
                return;
            }
            if (!int.TryParse(yearBox.Text, out _))
            {
                MessageBox.Show("Неправильний формат року");
                return;
            }
            if (int.Parse(yearBox.Text) > DateTime.Now.Year)
            {
                 MessageBox.Show("Введений рік не може знаходитись в майбутньому.");
                return;
            }

            DateTime eventDate;
            if (!DateTime.TryParse(eventDateTimeBox.Text, out eventDate))
            {
                MessageBox.Show("Неправильний формат дати");
                return;
            }

            if (eventDate > DateTime.Now)
            {
                MessageBox.Show("Дата останнього техогляду не може бути в майбутньому");
                return;
            }


            if (library.FindDublicateNomer(title1Box.Text) == false)
            {

                NewCar = new Car
                {
                    Nomera = title1Box.Text,
                    Author = authorBox.Text,
                    Year = int.Parse(yearBox.Text),
                    Type = typeBox.Text,
                    Marka = markaBox.Text,
                    Model = modelBox.Text,
                    Color = colorBox.Text,
                    EventDateTime = eventDate
                };
            }
            else
            {
                MessageBox.Show("Авто з таким номером вже існує");
                return;
            }


            DialogResult = DialogResult.OK;

            Close();
        }
        
    }
}
