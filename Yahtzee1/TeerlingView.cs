using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee1
{
    public partial class TeerlingView : UserControl
    {
        private int aantal_worpen = 3;
        private TeerlingController controller;

        public Button ButtonRoll { get { return button1; } }

        public TeerlingView(TeerlingController c)
        {
            InitializeComponent();
            
            controller = c;
        }

        /*public TeerlingView()
        {
            InitializeComponent();
        }*/

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void TeerlingView_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            controller.Werp();
            label1.Text = controller.model.AantalOgen.ToString();
            aantal_worpen--;
            if (aantal_worpen <= 0)
            {
                button1.Visible = false;
            }
            
        }

        
    }
}
