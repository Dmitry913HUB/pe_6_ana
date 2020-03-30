using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pe6
{
    public partial class FormMain : Form
    {
        const string MODE_CREATE = "Mode: create";
        const string MODE_VIEW = "Mode: view";
        const string MODE_EDIT = "Mode: edit";
        const string REALLY_CREATE_NEW = "Are you really want create new collection? Current collection will be removed.";
        ArrayList list = new ArrayList();
        public FormMain()
        {
            InitializeComponent();
            //dataGridView1.RowHeadersVisible = false;//disable first column
            dataGridView1.Columns.Add("abs", "abs");
            dataGridView1.Columns.Add("fi", "fi");
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            collView();

            String[] arr1 = { "1", "1" };
            dataGridView1.Rows.Add(arr1);
            String[] arr2 = { "2", "2" };
            dataGridView1.Rows.Add(arr2);

        }
        //--------------------------------------------------------------------------------------------service
        private bool stringIsNumber(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c)) { return false; }
            }
            return true;
        }
        //--------------------------------------------------------------------------------------------
        bool tableValidation()
        {
            //string s = "";
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                if(dataGridView1.Rows[i].Cells["abs"].Value != null &&
                    dataGridView1.Rows[i].Cells["fi"].Value != null )
                {
                    if (!stringIsNumber(dataGridView1.Rows[i].Cells["abs"].Value.ToString()) &&
                        !stringIsNumber(dataGridView1.Rows[i].Cells["fi"].Value.ToString()) )
                    {
                        //s += dataGridView1.Rows[i].Cells["abs"].Value.ToString() + " ";
                        //s += dataGridView1.Rows[i].Cells["fi"].Value.ToString() + "\n";
                        return false;
                    }
                }
            }
            //MessageBox.Show(s);
            return true;
        }
        void tableToList()
        {
            CoTrigonometric ct = new CoTrigonometric();
            if (tableValidation())
            {
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    ct.abs = Convert.ToDouble(dataGridView1.Rows[i].Cells["abs"].Value);
                    ct.fi = Convert.ToDouble(dataGridView1.Rows[i].Cells["fi"].Value);
                    list.Add(ct);
                }
            }
        }
        void showList()
        {
            string s = "";
            foreach (CoTrigonometric ct in list)
            {
                s += ct.ToString() + "\n";
            }
            MessageBox.Show(s);
        }
        //----------------------------------------------------------------------------------------------
        void collCreate()
        {
            DialogResult result = MessageBox.Show(REALLY_CREATE_NEW, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes) {
                dataGridView1.Rows.Clear();
                labelCollMode.Text = MODE_CREATE;
                dataGridView1.Columns["abs"].ReadOnly = false;
                dataGridView1.Columns["fi"].ReadOnly = false;
            }        
        }
        void collView()
        {
            labelCollMode.Text = MODE_VIEW;
            dataGridView1.Columns["abs"].ReadOnly = true;
            dataGridView1.Columns["fi"].ReadOnly = true;
            
        }
        void collEdit()
        {
            labelCollMode.Text = MODE_EDIT;
            dataGridView1.Columns["abs"].ReadOnly = false;
            dataGridView1.Columns["fi"].ReadOnly = false;
            
        }
        
        //-----------------------------------------------------------------------------------------------

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Developed by TenNM", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
            showList();
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            collCreate();
        }

        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            collView();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            collEdit();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableToList();
            //tableValidation();
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
