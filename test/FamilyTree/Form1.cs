using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnViewFamilyMem.Click += btnViewFamilyMem_Click;
        }

        void btnViewFamilyMem_Click(object sender, EventArgs e)
        {
            (new ViewAllmMemberForm()).ShowDialog();
        }
    }
}
