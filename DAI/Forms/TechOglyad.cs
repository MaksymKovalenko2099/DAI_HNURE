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
using System.Text.Json;
using System.IO;
using System.Globalization;
using System.Xml;


namespace DAI.Forms
{
    public partial class TechOglyad : Form
    {
        Car car = new Car();
        Library library = new Library();
       /* private Dictionary<string, List<string>> carData = new Dictionary<string, List<string>>();*/
        private Dictionary<string, List<Dictionary<string, string>>> datedata;

        public TechOglyad(Car Car, Library library)
        {
            InitializeComponent();
            car = Car;
            
            listBox1.Items.Add(car.EventDateTime);

            infocarlabel.Text = $"{Car.Nomera}, {Car.Marka} {Car.Model}, {Car.Color}";

            LoadDataFromFile("data.json");
            
            
        }
      
        public void LoadDataFromFile(string filePath)
        {
                 var jsonString = File.ReadAllText(filePath);
                datedata = JsonSerializer.Deserialize<Dictionary<string, List<Dictionary<string, string>>>>(jsonString);
            
            
        }

        
        
        private List<Dictionary<string, string>> GenerateDefaultData()
        {
            return new List<Dictionary<string, string>>()
            {
                new Dictionary<string, string>() { { "Time", "8:00" }, { "Event", string.Empty } },
                new Dictionary<string, string>() { { "Time", "9:00" }, { "Event", string.Empty } },
                new Dictionary<string, string>() { { "Time", "10:00" }, { "Event", string.Empty } },
                new Dictionary<string, string>() { { "Time", "11:00" }, { "Event", string.Empty } },
                new Dictionary<string, string>() { { "Time", "12:00" }, { "Event", string.Empty } },
                new Dictionary<string, string>() { { "Time", "13:00" }, { "Event", string.Empty } },
                new Dictionary<string, string>() { { "Time", "14:00" }, { "Event", string.Empty } },
                new Dictionary<string, string>() { { "Time", "15:00" }, { "Event", string.Empty } },
                new Dictionary<string, string>() { { "Time", "16:00" }, { "Event", string.Empty } }
            };
        }

        public bool IsTermFound(string searchTerm)
        {
            foreach (var key in datedata.Keys)
            {
                var data = datedata[key];
                foreach (var row in data)
                {
                    foreach (var value in row.Values)
                    {
                        if (value == searchTerm)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public DateTime FindCarDate(string carInfo)
        {
            foreach (var dataEntry in datedata)
            {
                foreach (var row in dataEntry.Value)
                {
                    foreach (var value in row.Values)
                    {
                        if (value == carInfo && DateTime.TryParse(dataEntry.Key + " " + row["Time"], out DateTime carDateTime))
                        {
                            return carDateTime;
                        }
                    }
                }
            }
            return new DateTime(1970, 1, 1, 0, 0, 0);
        }

        public void DisplayDataForDate(string date)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            if (!datedata.TryGetValue(date, out var data))
            {
                data = GenerateDefaultData();
                datedata[date] = data;
            }

            foreach (var key in data.First().Keys)
            {
                dataGridView1.Columns.Add(key, key);
            }

            foreach (var row in data)
            {
                var rowData = row.Values.ToArray();
                var cellValue = row["Event"];

                if (!string.IsNullOrWhiteSpace(cellValue) && !cellValue.Contains("(пройдено)"))
                {
                    if (DateTime.TryParseExact(date + " " + row["Time"], "yyyy-MM-dd H:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime eventDateTime) && eventDateTime < DateTime.Now)
                    {
                        rowData[1] += " (пройдено)";
                    }
                }

                dataGridView1.Rows.Add(rowData);
            }
        }

        public void CreateEmptyTable()
        {
            var defaultColumns = new[] { "Час", "Запис" };
            foreach (var column in defaultColumns)
            {
                dataGridView1.Columns.Add(column, column);
            }
        }

        private void UpdateDataFromGridView()
        {
            if (dataGridView1.Columns.Count == 0 || dataGridView1.Rows.Count == 0)
                return;

            var currentData = new List<Dictionary<string, string>>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    var rowData = new Dictionary<string, string>();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        rowData[dataGridView1.Columns[cell.ColumnIndex].Name] = cell.Value?.ToString() ?? string.Empty;
                    }
                    currentData.Add(rowData);
                }
            }

            var selectedDate = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            datedata[selectedDate] = currentData;
        }

        public void SaveData(string path)
        {
            UpdateDataFromGridView();
            var jsonString = JsonSerializer.Serialize(datedata, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, jsonString);
        }

       

        

        public void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (e.Start < DateTime.Now)
            {
                zapysButton.Hide();
                cancelZapysButton.Hide();
            }
            else
            {
                zapysButton.Show();
                cancelZapysButton.Show();
            }
            car.selectedDate = e.Start.ToString("yyyy-MM-dd");
            DisplayDataForDate(car.selectedDate);
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 325;

            textBox1.Text = e.Start.ToString("dd MMMM, yyyy, dddd,");
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SaveData("data.json");
            
        }

        private void zapysButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count == 0 || dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Таблиця ще не завантажилась");
                return;
            }
            if (IsTermFound(infocarlabel.Text) == true)
            {
                car.ZapysDate = FindCarDate(infocarlabel.Text);
                MessageBox.Show($"Цей транспортний засіб вже записаний на {car.ZapysDate}");
            }

            if (dataGridView1.CurrentCell.ColumnIndex != 0 && !IsTermFound(infocarlabel.Text))
            {
                dataGridView1.CurrentCell.Value = infocarlabel.Text;
                SaveData("data.json");
                LoadDataFromFile("data.json");
                MessageBox.Show("Успішно записано");
            }
        }

        private void cancelZapysButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count == 0 || dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Таблиця ще не завантажилась");
                return;
            }
            dataGridView1.CurrentCell.Value = null;
            SaveData("data.json");
            LoadDataFromFile("data.json");
        }

      

        
    }
}