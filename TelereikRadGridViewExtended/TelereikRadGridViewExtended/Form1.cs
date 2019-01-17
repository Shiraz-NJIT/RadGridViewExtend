using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelereikRadGridViewExtended
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Test
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Test> lstt = new List<Test>();
            for (int i = 0; i < 10; i++)
            {
                Test t = new Test();
                t.Id = i;
                t.Name = "محمد 1";
                lstt.Add(t);
            }
            radGridViewExtended1.DataSource = lstt;
        }
    }
}
