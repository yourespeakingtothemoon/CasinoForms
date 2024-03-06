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
    public partial class TitleScreen : Form
    {
        public TitleScreen()
        {
            InitializeComponent();
        }

        private void TitleScreen_Load(object sender, EventArgs e)
        {
            label2.Text = user.balanceToString();
            label3.Text = user.name;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
