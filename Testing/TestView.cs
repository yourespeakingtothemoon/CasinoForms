using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasinoForms.Testing
{
    public partial class TestView : Form
    {

        TestingSuite testSuite = new TestingSuite();

        public TestView()
        {
            InitializeComponent();
            testSuite.view = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            testSuite.execute();
        }

    
    }
}
