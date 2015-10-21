using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee1
{
    public partial class Form1 : Form
    {
        int aantalTeerlingen = 5;

        List<TeerlingController> teerlingen = new List<TeerlingController>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int teerlingNummer = 0; teerlingNummer < aantalTeerlingen; teerlingNummer++)
            {
                TeerlingController tijdelijkeTeerling = new TeerlingController();

                teerlingen.Add(tijdelijkeTeerling);
            }

            

            for (int teerlingNummer = 0; teerlingNummer < teerlingen.Count; teerlingNummer++)
            {
                TeerlingView teerlingView = teerlingen[teerlingNummer].GetView();

                int horizontalPosition = teerlingNummer * teerlingView.Width;

                teerlingView.Location = new System.Drawing.Point(horizontalPosition, 0);

                Controls.Add(teerlingView);
            }

            TeerlingController teerling1 = new TeerlingController();

            Controls.Add(teerling1.GetView());
        }

        
        

        public void buttonAll_Click(object sender, EventArgs e)
        {
            
            for (int teerlingNummer = 0; teerlingNummer < aantalTeerlingen; teerlingNummer++)
            {
                
                teerlingen[teerlingNummer].view.ButtonRoll.PerformClick();
                

                Console.WriteLine(teerlingen[teerlingNummer].model.AantalOgen);

            }

        }

        
    }
}
