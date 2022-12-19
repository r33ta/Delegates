using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Delegates.Form1;

namespace Delegates
{
    public partial class Form2 : Form
    {
        AddToList_ AddToList;
        public Form2(AddToList_ AddToList)
        {
            InitializeComponent();

            this.AddToList = AddToList;
        }

        private void text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddToList(text.Text);
                Close();
            }
        }
    }
}
