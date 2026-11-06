using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp11.Pages;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        HomePage homePage = null;
        ParamsPage paramsPage = new ParamsPage();
        ShopPage shopPage = new ShopPage();

        public Form1()
        {
            InitializeComponent();
            homePage = new HomePage(new Player("Player", 100));

            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(homePage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(homePage);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(paramsPage);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(shopPage);
        }
    }

    public class Player
    {
        public string name = "Player";
        public int score = 0;

        public Player(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
    }
}
