using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BottleImp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deck deck = new Deck();
            deck.Shuffle();

            listBox1.Items.Clear();
            
            foreach (Card c in deck.GetCards().Where(x => x.ColorValue == Color.Yellow).OrderBy(x => x.CoinValue))
            {
                listBox1.Items.Add(c);
            }

        }
    }
}
