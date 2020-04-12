using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace pe6
{
    public partial class FormMain : Form
    {
        //const string PATH_SAVED_LIST = "savedList.txt";
        const string PATH_SAVED_LIST = "XMLFile1.xml";

        const string MODE_CREATE = "Mode: create";
        const string MODE_VIEW = "Mode: view";
        const string MODE_EDIT = "Mode: edit";
        
        const string REALLY_CREATE_NEW = "Are you really want create new collection? Current collection will be removed.";
        
        const string ERR_WRONG_TEXTBOX = "Input data is not number";
        const string ERR_FILE_IO = "File IO error";

        BindingList<CoTrigonometric> bList = new BindingList<CoTrigonometric>();

       
        public FormMain()
        {
            InitializeComponent();

            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            //dataGridView1.AllowUserToAddRows = true;

            //ds.c
            CoTrigonometric ct1 = new CoTrigonometric(1, 1);
            CoTrigonometric ct2 = new CoTrigonometric(2, 2);
            CoTrigonometric ct3 = new CoTrigonometric(3, 3);


            bList.Add(ct1);
            bList.Add(ct2);
            bList.Add(ct3);

            dataGridView1.DataSource = bList;

            //stateView();
            stateEdit();
        }
        //---------------------------------------------------------------------------------------service
        private bool stringIsNumber(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c)) { return false; }
            }
            return true;
        }
        //----------------------------------------------------------------------------------process
        void showList()
        {
            string s = "";
            foreach (CoTrigonometric ct in bList)//list
            {
                s += ct.ToString() + "\n";
            }
            MessageBox.Show(s);
        }
        void addRecord()
        {
            string abs = textBoxAbs.Text;
            string fi = textBoxFi.Text;
            if (stringIsNumber(abs) && stringIsNumber(fi))
            {
                double absD = Convert.ToDouble(abs);
                double fiD = Convert.ToDouble(fi);
                CoTrigonometric ct = new CoTrigonometric(absD, fiD);
                bList.Add(ct);
                //MessageBox.Show("yeah");
            }
            else MessageBox.Show(ERR_WRONG_TEXTBOX);
        }
        //void saveListToFile()
        //{
        //    StreamWriter sw = new StreamWriter(SAVED_LIST_PATH);

        //    try
        //    {
        //        sw.Write(bList);
        //    }
        //    catch
        //    {
        //        MessageBox.Show(ERR_FILE_IO);
        //    }

        //    sw.Close();
        //}
        //void loadListFromFile()
        //{
        //    StreamReader sr = new StreamReader(SAVED_LIST_PATH);

        //    try
        //    {
        //        //sr.Re(bList);
        //    }
        //    catch
        //    {
        //        MessageBox.Show(ERR_FILE_IO);
        //    }

        //    sr.Close();
        //}      
        //--------------------------------------------------------------------------------------states
        void stateCreate()
        {
            DialogResult result = MessageBox.Show(REALLY_CREATE_NEW, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes) {
                
                labelState.Text = MODE_CREATE;

                groupBox1.Text = MODE_CREATE;

                dataGridView1.Rows.Clear();
                dataGridView1.RowHeadersVisible = true;
                dataGridView1.ReadOnly = false;

                textBoxAbs.ReadOnly = false;
                textBoxFi.ReadOnly = false;
                textBoxEps.ReadOnly = true;

                buttonProcess.Enabled = true;
                buttonProcess.Text = "Add";
            }        
        }
        void stateView()
        {
            labelState.Text = MODE_VIEW;

            groupBox1.Text = MODE_VIEW;

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;

            textBoxAbs.ReadOnly = true;
            textBoxFi.ReadOnly = true;
            textBoxEps.ReadOnly = true;

            buttonProcess.Enabled = false;
            buttonProcess.Text = "Not available";
        }
        void stateEdit()
        {
            labelState.Text = MODE_EDIT;

            groupBox1.Text = MODE_EDIT;

            dataGridView1.RowHeadersVisible = true;
            dataGridView1.ReadOnly = false;

            textBoxAbs.ReadOnly = false;
            textBoxFi.ReadOnly = false;
            textBoxEps.ReadOnly = true;

            buttonProcess.Enabled = true;
            buttonProcess.Text = "Add";
        }       
        //---------------------------------------------------------------------------------------GUI
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Developed by TenNM", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
            showList();
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e){ stateCreate(); }
        private void ViewToolStripMenuItem_Click(object sender, EventArgs e){ stateView(); }
        private void EditToolStripMenuItem_Click(object sender, EventArgs e){ stateEdit(); }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e){
            CoTrSave cts = new CoTrSave(bList);
            cts.save();
        }
        private void LoadToolStripMenuItem_Click(object sender, EventArgs e){
            CoTrSave cts = new CoTrSave();
            bList = cts.load();
            dataGridView1.DataSource = bList;
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e){ Application.Exit(); }
        private void buttonProcess_Click(object sender, EventArgs e)
        {
            addRecord();
        }
        //-------------------------------------------------------------------------------------------end
    }
}
