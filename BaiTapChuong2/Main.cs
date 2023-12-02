using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FCFS;
namespace BaiTapChuong2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void SJFbtn_Click(object sender, EventArgs e)
        {
            SJFform sfjform = new SJFform();
            sfjform.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FCFS.Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
