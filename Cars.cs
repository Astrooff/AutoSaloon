using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSaloon
{
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
            ShowCars();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxCarMake.Text) ||
                String.IsNullOrEmpty(textBoxModel.Text) ||
                String.IsNullOrEmpty(textBoxColor.Text) ||
                String.IsNullOrEmpty(textBoxSRN.Text) ||
                comboBoxType.SelectedItem == null) 
            { 
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CarSet cars = new CarSet();
                cars.CarMake = textBoxCarMake.Text;
                cars.Model = textBoxModel.Text;
                cars.Color = textBoxColor.Text;
                cars.SRN = textBoxSRN.Text;
                cars.Type = comboBoxType.Text;
                if (comboBoxType.SelectedIndex == 0 ||
                    comboBoxType.SelectedIndex == 3 ||
                    comboBoxType.SelectedIndex == 6 ||
                    comboBoxType.SelectedIndex == 8)
                {

                    cars.Price = 2000;
                }
                else
                {

                    cars.Price = 4000;
                }
                Program.ASdb.CarSet.Add(cars);
                Program.ASdb.SaveChanges();
                ShowCars();
            }
        }
        void ShowCars()
        {
            listViewCars.Items.Clear();
            foreach (CarSet cars in Program.ASdb.CarSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                     cars.Id.ToString(),
                     cars.Type,
                     cars.CarMake,
                     cars.Model,
                     cars.Color,
                     cars.SRN
                });
                item.Tag = cars;
                listViewCars.Items.Add(item);
            }
            listViewCars.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewCars.SelectedItems.Count == 1)
            {
                CarSet cars = listViewCars.SelectedItems[0].Tag as CarSet;
                cars.CarMake = textBoxCarMake.Text;
                cars.Model   = textBoxModel.Text;
                cars.Color   = textBoxColor.Text;
                cars.SRN     = textBoxSRN.Text;
                cars.Type    = comboBoxType.Text;
                Program.ASdb.SaveChanges();
                ShowCars();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCars.SelectedItems.Count == 1)
                {
                    CarSet cars = listViewCars.SelectedItems[0].Tag as CarSet;
                    Program.ASdb.CarSet.Remove(cars);
                    Program.ASdb.SaveChanges();
                    ShowCars();
                }
                textBoxCarMake.Text = "";
                textBoxModel.Text = "";
                textBoxColor.Text = "";
                textBoxSRN.Text = "";
                comboBoxType.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта кнопка используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
