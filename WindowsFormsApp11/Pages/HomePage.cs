using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11.Pages
{
    public partial class HomePage : UserControl
    {
        Player player;
        public HomePage(Player player)
        {
            InitializeComponent();
            this.player = player;

            this.label1.Text = $"Welcome, {player.name}!";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
