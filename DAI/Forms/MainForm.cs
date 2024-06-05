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
    public partial class MainForm : Form
    {
        Library library = new Library();
        public MainForm()
        {
            InitializeComponent();
            library.LoadData(PATH_DO_DATA);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var result = library.Search(typeBox.Text, titleBox.Text, authorBox.Text);
            bookBindingSource.DataSource = result;
        }
        const string PATH_DO_DATA = ".\\library.txt";
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            library.SaveData(PATH_DO_DATA);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            library.LoadData(PATH_DO_DATA);
        }

        private void resultList_DoubleClick(object sender, EventArgs e)
        {
            if (resultList.SelectedItems.Count > 0)
            {
                Car Car = resultList.SelectedItem as Car;
                var CarEditDialog = new CarEditDialog(Car, library);
                if (CarEditDialog.ShowDialog() == DialogResult.OK)
                {
                    searchButton_Click(null, null);
                }
            }
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            var addCarForm = new AddCarForm();
            if (addCarForm.ShowDialog() == DialogResult.OK)
            {
                Car newCar = addCarForm.NewCar;
                library.AddCar(newCar);
                library.SaveData(PATH_DO_DATA);
                searchButton_Click(null, null); 
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (resultList.SelectedItems.Count > 0)
            {
                Car selectedCar = resultList.SelectedItem as Car;
                if (selectedCar != null)
                {
                    library.RemoveCar(selectedCar);
                    library.SaveData(PATH_DO_DATA);
                    searchButton_Click(null, null); 
                }
            }
            else
            {
                MessageBox.Show("Виберіть Транспортний засіб для видалення");
            }
        }
    }
}
