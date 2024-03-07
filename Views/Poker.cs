using CasinoForms.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasinoForms.Views
{
    public partial class Poker : Form
    {
        ApplicationManager app = new ApplicationManager();
        public Poker(ApplicationManager a)
        {
            this.app = a;
            InitializeComponent();
        }
        public Poker()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            app.titleScreen.Show();

        }
    }
}
