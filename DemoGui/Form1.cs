using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoGui
{
    // CODE-BEHIND
    // chargement des données & les evenements
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();

            this.button1.Click += MyMethod;
           
            // méthode anonyme
            this.button1.Click += delegate (object sender, EventArgs myEventArgs)
            {
                MessageBox.Show("hello button 1 from anonymous");
            };

            // lambda 1
            this.button1.Click += (object sender, EventArgs myEventArgs) =>
            {
                MessageBox.Show("hello button 1 from lambda 1");
            };

            // lambda 2
            this.button1.Click += (sender, myEventArgs) =>
            {
                MessageBox.Show("hello button 1 from lambda 2");
            };

            // lambda 3 (lambda java/c#, arrow functions js/ts)
            this.button1.Click += (sender, myEventArgs) => MessageBox.Show("hello button 1 from lambda 3");
        }

        public void MyMethod(object sender, EventArgs myEventArgs)
        {
            MessageBox.Show("hello button 1");
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Hello world");
        //}

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void myButtonClick(object sender, EventArgs e)
        {

        }

        //public void Test(object toto, EventArgs z, int a)
        //{

        //}
    }
}
