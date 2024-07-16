using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CarReportSystem {
    public partial class fmVersion : Form {
        public fmVersion() {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e) {

        }

        private void btVersionOK_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void fmVersion_Load(object sender, EventArgs e) {
            var asm = Assembly.GetExecutingAssembly();
            var ver = asm.GetName().Version;
            lbVersion.Text = "ver" + (ver.Minor + "." + ver.Minor + "." + ver.Build + "." + ver.Revision).ToString();

        }
    }
}
