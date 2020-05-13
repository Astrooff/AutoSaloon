using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSaloon
{
    public partial class Deal : Form
    {
        public Deal()
        {
            InitializeComponent();
            ShowCar();
            ShowWorkers();
            Deduction();
            ShowDeals();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void ShowCar()
        {
            comboBoxCar.Items.Clear();
            foreach (CarSet carSet in Program.ASdb.CarSet)
            {
                string[] item =
                {
                    carSet.Id.ToString()+ ". ",
                    carSet.SRN +" "+ carSet.Type,
                };
                comboBoxCar.Items.Add(string.Join(" ", item));
            }
        }
        void ShowWorkers()
        {
            comboBoxWorkers.Items.Clear();
            foreach (WorkersSet workSet in Program.ASdb.WorkersSet)
            {
                string[] item =
                {
                    workSet.Id.ToString()+ ". ",
                    workSet.SurName +" "+ workSet.Name + " " + workSet.Special ,
                };
                comboBoxWorkers.Items.Add(string.Join(" ", item));
            }
        }
        void Deduction()
        {
                if (comboBoxWorkers.SelectedItem != null && comboBoxCar.SelectedItem != null)
                {
                CarSet carSet = Program.ASdb.CarSet.Find(Convert.ToInt32(comboBoxCar.SelectedItem.ToString().Split('.')[0]));
                WorkersSet worker = Program.ASdb.WorkersSet.Find(Convert.ToInt32(comboBoxWorkers.SelectedItem.ToString().Split('.')[0]));
                textBoxPriceClient.Text = Convert.ToString(carSet.Price + carSet.Price*worker.DealShare/100);
                textBoxPriceWorker.Text = Convert.ToString(carSet.Price * worker.DealShare / 100);
            }
                else
                {
                    comboBoxWorkers.Text = "";
                    comboBoxCar.Text = "";
                }
        }
        void ShowDeals()
        {
            listViewDeals.Items.Clear();
            foreach (DealSet deal in Program.ASdb.DealSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    deal.Id.ToString(),
                    deal.WorkersSet.Name,
                    deal.WorkersSet.SurName,
                    deal.CarSet.SRN,
                    deal.CarSet.Type,
                }) ;
                item.Tag = deal;
                listViewDeals.Items.Add(item);
            }
        }
        private void comboBoxWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deduction();
        }

        private void comboBoxCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deduction();
        }

        private void textBoxPriceClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxCar.SelectedItem != null && comboBoxWorkers.SelectedItem != null)
            {
                DealSet deal = new DealSet();
                deal.IdSupply = Convert.ToInt32(comboBoxCar.SelectedItem.ToString().Split('.')[0]);
                deal.IdDemand = Convert.ToInt32(comboBoxWorkers.SelectedItem.ToString().Split('.')[0]);
                Program.ASdb.DealSet.Add(deal);
                Program.ASdb.SaveChanges();
                ShowDeals();
            }
            else MessageBox.Show("данные не выбраны", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewDeals.SelectedItems.Count == 1)
            {
                DealSet deal = listViewDeals.SelectedItems[0].Tag as DealSet;
                deal.IdSupply = Convert.ToInt32(comboBoxCar.SelectedItem.ToString().Split('.')[0]);
                deal.IdDemand = Convert.ToInt32(comboBoxWorkers.SelectedItem.ToString().Split('.')[0]);
                Program.ASdb.SaveChanges();
                ShowDeals();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDeals.SelectedItems.Count == 1)
                {
                    DealSet deal = listViewDeals.SelectedItems[0].Tag as DealSet;
                    Program.ASdb.DealSet.Remove(deal);
                    Program.ASdb.SaveChanges();
                    ShowDeals();
                }
                comboBoxCar.SelectedItem = null;
                comboBoxWorkers.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("не возможно удалить", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
