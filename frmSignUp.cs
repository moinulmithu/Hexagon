using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hexagon
{
    public partial class frmSignUp : Form
    {
        HexagonDBEntities db = new HexagonDBEntities();
        User entity;
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            User entity = new User();
            entity.LogInName = txtLogInName.Text;
            entity.LoginId = txtLogInId.Text;
            entity.Password = txtPassword.Text;
            db.Users.Add(entity);
            db.SaveChanges();
            MessageBox.Show("User created successfully");

        }
    }
}
