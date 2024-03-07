using CasinoForms.Controllers;
using CasinoForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CasinoForms.Testing;

namespace CasinoForms.Views
{
    public partial class TitleScreen : Form
    {
        ApplicationManager app = new ApplicationManager();
        public TitleScreen()
        {

            InitializeComponent();
        }


        public TitleScreen(ApplicationManager a)
        {

            this.app = a;
            this.app.titleScreen = this;
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

        private void blackjackbutton_Click(object sender, EventArgs e)
        {
            Blackjack blackjack = new Blackjack(app);
            app.AddScreen(blackjack);
            blackjack.Show();
            this.Hide();

        }

        private void pokerbutton_Click(object sender, EventArgs e)
        {
            Poker poker = new Poker(app);
            app.AddScreen(poker);
            poker.Show();
            this.Hide();
        }

        private void unitTestingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestView unitTesting = new TestView();
            app.AddScreen(unitTesting);
            unitTesting.Show();
            this.Hide();

        }
    }
}
