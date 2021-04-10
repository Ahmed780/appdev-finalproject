using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace appdev_finalproject
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            // Implement a read from file method that runs every time the app starts
        }

        private void debugButton_Click(object sender, EventArgs e)
        {
            // FIXME: Do not let the user create an Admin whenever he wants. Have predefined Admin.csv file
            // or something similar.
            Admin admin = new Admin("name", "password");
            admin.addUser(admin.generateId(),"Dharmin","123456");
        }
    }
}
