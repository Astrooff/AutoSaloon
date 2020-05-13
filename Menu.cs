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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (Autorization.users.type == "user")
            {
                buttonCars.Enabled = false;
                button4.Enabled = false;
            }

        }

        private void buttonCars_Click(object sender, EventArgs e)
        {
            Form cars = new Cars();
            cars.Show();
        }
        private void buttonWorkers_Click(object sender, EventArgs e)
        {
            Form workers = new Workers();
            workers.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form deal = new Deal();
            deal.Show();
        }

      
    }
}
