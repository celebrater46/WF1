using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Label lb;

        // public static void Main()
        // {
        //     Application.Run(new Form1());
        // }
        public Form1()
        {
            InitializeComponent();
            
            this.Text = "サンプル";
            this.Width = 250;
            this.Height = 200;

            lb = new Label();
            lb.Text = "ようこそ";

            lb.Parent = this;

            this.Click += new EventHandler(fm_Click);
        }

        public void fm_Click(Object sender, EventArgs e)
        {
            lb.Text = "こんにちわ";
        }
    }
}