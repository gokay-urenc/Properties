using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Properties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         /* Button btn = new Button();
            btn.Text = "523";
            btn.ForeColor = Color.Lime;
            btn.BackColor = Color.Green;
            this.Controls.Add(btn); */
            Ders ders1 = new Ders();
            ders1.adi = "C#";
            ders1.kodu = "YMS4117"; // Set bloğu çalıştı.
            ders1.kredi = 4; // Set bloğu çalıştı.
            MessageBox.Show(ders1.adi + " " + ders1.kodu + " " + ders1.kredi); // Get bloğu çalıştı.
        }
    }
}