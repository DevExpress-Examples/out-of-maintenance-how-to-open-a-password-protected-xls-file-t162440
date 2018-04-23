using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordToOpenSample {
    public partial class PasswordForm : Form {
        public PasswordForm() {
            InitializeComponent();
        }

        public string Password {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
    }
}
