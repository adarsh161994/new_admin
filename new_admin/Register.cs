using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace new_admin
{
    public partial class Register : Form
    {
        IFirebaseConfig Config = new FirebaseConfig
        {
            AuthSecret = FireSharpConfig.AuthSecret,
            BasePath = FireSharpConfig.BasePath
        };
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            Close();
        }

        private void lab_reg_click
    }
}
