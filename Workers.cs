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
    public partial class Workers : Form
    {
        public Workers()
        {
            InitializeComponent();
            ShowWorkers();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listViewWorkers.Items.Clear();
            if (String.IsNullOrEmpty(textBoxAdress.Text) ||
                String.IsNullOrEmpty(textBoxName.Text) ||
                String.IsNullOrEmpty(textBoxSecondName.Text) ||
                String.IsNullOrEmpty(textBoxSurName.Text) ||
                String.IsNullOrEmpty(textBoxPhone.Text) ||
                comboBoxSpecial.SelectedItem == null)
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                WorkersSet workers = new WorkersSet();
                workers.Name = textBoxName.Text;
                workers.SurName = textBoxSurName.Text;
                workers.SecondName = textBoxSecondName.Text;
                workers.Phone = textBoxPhone.Text;
                workers.Adress = textBoxAdress.Text;
                workers.Special = comboBoxSpecial.Text;
                if (comboBoxSpecial.SelectedIndex == 0 ||
                    comboBoxSpecial.SelectedIndex == 2 ||
                    comboBoxSpecial.SelectedIndex == 4 ||
                    comboBoxSpecial.SelectedIndex == 6 ||
                    comboBoxSpecial.SelectedIndex == 8)
                {

                    workers.DealShare = 30;

                }
                else
                {
                    workers.DealShare = 50;
                }
                Program.ASdb.WorkersSet.Add(workers);
                Program.ASdb.SaveChanges();
                ShowWorkers();
            }
        }
        void ShowWorkers()
        {
           
                foreach (WorkersSet workers in Program.ASdb.WorkersSet)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                     workers.Id.ToString(),
                     workers.Name,
                     workers.SurName,
                     workers.SecondName,
                     workers.Phone,
                     workers.Adress,
                     workers.Special
                    });
                    item.Tag = workers;
                    listViewWorkers.Items.Add(item);
                }
                listViewWorkers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            if (listViewWorkers.SelectedItems.Count == 1)
            {
                WorkersSet workers = listViewWorkers.SelectedItems[0].Tag as WorkersSet;
                workers.Name = textBoxName.Text;
                workers.SurName = textBoxSurName.Text;
                workers.SecondName = textBoxSecondName.Text;
                workers.Phone = textBoxPhone.Text;
                workers.Adress = textBoxAdress.Text;
                workers.Special = comboBoxSpecial.Text;
                Program.ASdb.SaveChanges();
                ShowWorkers();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewWorkers.SelectedItems.Count == 1)
                {
                    WorkersSet workers = listViewWorkers.SelectedItems[0].Tag as WorkersSet;
                    Program.ASdb.WorkersSet.Remove(workers);
                    Program.ASdb.SaveChanges();
                    ShowWorkers();
                }
                textBoxName.Text = "";
                textBoxSurName.Text = "";
                textBoxSecondName.Text = "";
                textBoxPhone.Text = "";
                textBoxAdress.Text = "";
                comboBoxSpecial.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта кнопка используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) //калькулятор
            {
                e.Handled = true;
            }
        }
    }
}
