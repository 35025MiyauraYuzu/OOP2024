using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addsa {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void authorsBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.authorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202415DataSet);

        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202415DataSet.Books' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.booksTableAdapter.Fill(this.infosys202415DataSet.Books);
            // TODO: このコード行はデータを 'infosys202415DataSet.Authors' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.authorsTableAdapter.Fill(this.infosys202415DataSet.Authors);

        }
    }
}
