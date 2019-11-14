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
    public partial class ViewAllmMemberForm : Form
    {
        public ViewAllmMemberForm()
        {
            InitializeComponent();
            this.Load += ViewAllmMemberForm_Load;
        }

        void ViewAllmMemberForm_Load(object sender, EventArgs e)
        {
            this.ViewAllMembers();
        }

        private void ViewAllMembers()
        {
            var db = new OOPCSEntities();
            var members = db.Members.ToArray();

            var memberViews = new MemberView[members.Length];
            for (int i = 0; i < members.Length; i++)
                memberViews[i] = new MemberView(members[i]);
            this.grdMembers.DataSource = memberViews;
        }
    }
}
