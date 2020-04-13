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
        const string PATH_SAVED_LIST = "test.bin";

        const string MODE_CREATE = "Mode: create";
        const string MODE_VIEW = "Mode: view";
        const string MODE_EDIT = "Mode: edit";
        const string MODE_SEARCH_LINEAR = "Mode: linear search";
        const string MODE_SEARCH_BINARY = "Mode: binaty search";

        const string REALLY_CREATE_NEW = "Are you really want create new collection? Current collection will be removed.";
        
        const string ERR_WRONG_TEXTBOX = "Input data is not number";
        const string ERR_FILE_IO = "File IO error";
        
        BindingList<CoTrigonometric> bList = new BindingList<CoTrigonometric>();
        char stateNow = 'x';
     
        public FormMain()
        {
            InitializeComponent();

            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            CoTrigonometric ct1 = new CoTrigonometric(1, 1);//base test values
            CoTrigonometric ct2 = new CoTrigonometric(2, 2);
            CoTrigonometric ct3 = new CoTrigonometric(3, 3);

            bList.Add(ct1);
            bList.Add(ct2);
            bList.Add(ct3);

            dataGridView1.DataSource = bList;

            //stateView();
            stateSearchLinear();
        }
        //---------------------------------------------------------------------------------------service
        private bool stringIsNumber(string s)
        {
            foreach (char c in s)
            {
                if (char.IsDigit(c) || ',' == c) { continue; }
                else return false;
            }
            return true;
        }
        private string dotsToCommas(string withCommasStr)
        {
            string tempStr = "";
            foreach(char c in withCommasStr)
            {
                if ('.' == c) { tempStr += ','; }
                else tempStr += c;
            }
            return tempStr;
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
            //string abs = textBoxAbs.Text;
            //string fi = textBoxFi.Text;
            string abs = dotsToCommas(textBoxAbs.Text);
            string fi = dotsToCommas(textBoxFi.Text);
            if (stringIsNumber(abs) && stringIsNumber(fi))
            {
                double absD = Convert.ToDouble(abs);
                double fiD = Convert.ToDouble(fi);
                bList.Add(new CoTrigonometric(absD, fiD));
            }
            else MessageBox.Show(ERR_WRONG_TEXTBOX);
        }
        void saveToFile()
        {
            CoTrSave.save(bList, PATH_SAVED_LIST);
        }
        void loadFrFile()
        {
            bList = CoTrSave.load(PATH_SAVED_LIST);
            dataGridView1.DataSource = bList;
        }
        void process()//button foo
        {
            switch (stateNow)
            {
                case 'c'://create
                case 'e'://edit
                    {
                        addRecord();
                        textBoxAbs.Clear();
                        textBoxFi.Clear();
                    }break;
                case 'l': { labelSearchRes.Text = searchInColl('l').ToString(); }break;
                case 'b': { labelSearchRes.Text = searchInColl('b').ToString(); } break;
            }
            
        }
        void sortCollAsc()
        {
            ProcessSortSearch.SortAsc(bList);
        }
        bool searchInColl(char mode)
        {
            string abs = dotsToCommas(textBoxAbs.Text);
            string fi = dotsToCommas(textBoxFi.Text);
            string eps = dotsToCommas(textBoxEps.Text);
            double absD = 0 , fiD = 0, epsD = 0;
            if (stringIsNumber(abs) && stringIsNumber(fi) && stringIsNumber(eps))//?????????????
            {
                absD = Convert.ToDouble(abs);
                fiD = Convert.ToDouble(fi);
                epsD = Convert.ToDouble(eps);
                
                switch (mode)
                {
                    case 'l':
                    case 'L': { return ProcessSortSearch.SearchLinear(bList, absD, fiD, epsD); }
                    case 'b':
                    case 'B': { return ProcessSortSearch.SearchBinary(bList, absD, fiD, epsD); }
                }
            }
            else MessageBox.Show(ERR_WRONG_TEXTBOX);
            
            return false;
        }
        //--------------------------------------------------------------------------------------states
        void stateCreate()
        {
            DialogResult result = MessageBox.Show(REALLY_CREATE_NEW, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes) {

                stateNow = 'c';

                labelState.Text = MODE_CREATE;
                labelSearchRes.Visible = false;

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
            stateNow = 'v';

            labelState.Text = MODE_VIEW;
            labelSearchRes.Visible = false;

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
            stateNow = 'e';

            labelState.Text = MODE_EDIT;
            labelSearchRes.Visible = false;

            groupBox1.Text = MODE_EDIT;

            dataGridView1.RowHeadersVisible = true;
            dataGridView1.ReadOnly = false;

            textBoxAbs.ReadOnly = false;
            textBoxFi.ReadOnly = false;
            textBoxEps.ReadOnly = true;

            buttonProcess.Enabled = true;
            buttonProcess.Text = "Add";
        }
        void stateSearchLinear()
        {
            stateNow = 'l';

            labelState.Text = MODE_SEARCH_LINEAR;
            labelSearchRes.Visible = true;

            groupBox1.Text = MODE_SEARCH_LINEAR;

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;

            textBoxAbs.ReadOnly = false;
            textBoxFi.ReadOnly = false;
            textBoxEps.ReadOnly = false;

            buttonProcess.Enabled = true;
            buttonProcess.Text = "Search";
        }
        void stateSearchBinary()
        {
            stateSearchLinear();

            stateNow = 'b';

            labelState.Text = MODE_SEARCH_BINARY;

            groupBox1.Text = MODE_SEARCH_BINARY;
        }
        //---------------------------------------------------------------------------------------GUI
        private void CreateToolStripMenuItem_Click(object sender, EventArgs e){ stateCreate(); }
        private void ViewToolStripMenuItem_Click(object sender, EventArgs e){ stateView(); }
        private void EditToolStripMenuItem_Click(object sender, EventArgs e){ stateEdit(); }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e){ saveToFile(); }
        private void LoadToolStripMenuItem_Click(object sender, EventArgs e){ loadFrFile(); }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e){ Application.Exit(); }
        //-----
        private void sortToolStripMenuItem_Click(object sender, EventArgs e){ sortCollAsc(); }
        private void linearToolStripMenuItem_Click(object sender, EventArgs e){ stateSearchLinear(); }
        private void binaryToolStripMenuItem_Click(object sender, EventArgs e){ stateSearchBinary(); }
        //-----
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by TenNM", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //showList();
        }
        //-----
        private void buttonProcess_Click(object sender, EventArgs e){ process(); }       
        //-------------------------------------------------------------------------------------------end
    }
}
