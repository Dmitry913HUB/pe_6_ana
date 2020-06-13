using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pe6
{
    public partial class Form2 : Form
    {
        const string REALLY_RETURN = "to return the original data?";
        const string MODE_SEARCH_LINEAR = "Mode: linear search";
        const string MODE_SEARCH_BINARY = "Mode: binaty search";
        const string MODE_FILTER_PRICE = "Mode: Price filter";
        const string MODE_FILTER_KOLVO = "Mode: Kolvo filter";
        const string MODE_FILTER_Sum = "Mode: Sum filter";

        const string ERR_WRONG_TEXTBOX = "Input data is not number";
        const string ERR_FILE_IO = "File IO error";

        internal BindingList<Goods> goods_buffer = new BindingList<Goods>();
        //BindingList<Goods> bListKal = new BindingList<Goods>();
        internal char stateNowBuff = 'x';
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            switch (stateNowBuff)
            {

                case 'l': { stateSearchLinear(); } break;
                case 'b': { stateSearchBinary(); } break;
                case 's': { filterPrice(); } break;
                case 'p': { filterKolvo(); } break;
                case 'a': { filterSum(); } break;
            }
        }
        //---------------------------------------------------------------------------------------service

        private bool stringIsNumber(string s) //проверка строки на число
        {
            foreach (char c in s)
            {
                if (char.IsDigit(c) || '/' == c) { continue; }
                else return false;
            }
            return true;
        }

        private void fillingInTheTable() 
        {
            FormMain.bListKal.Clear();
            string price = textBoxPrice.Text;
            foreach (Goods c in goods_buffer)
            {
                if (c.Price == Convert.ToInt32(price)) { FormMain.bListKal.Add(c); }
            }
            (this.Owner as FormMain).dataGridView1.DataSource = FormMain.bListKal;
            (this.Owner as FormMain).dataGridView1.Refresh();
        }

        //----------------------------------------------------------------------------------process
        void process()//button foo
        {
            switch (stateNowBuff)
            {
               
                case 'l': 
                    {
                        fillingInTheTable();
                        labelSearchRes.Text = searchInColl('l').ToString();
                    } break;
                case 'b': 
                    {
                        fillingInTheTable();
                        labelSearchRes.Text = searchInColl('b').ToString();
                    } break;
                case 's': { filterPriceF();} break;
                case 'p': { filterKolvoF();} break;
                case 'a': { filterSumF();} break;
            }

        }
        bool searchInColl(char mode) // выбор между бинарным или линейным поиском 
        {
            string price = textBoxPrice.Text;
            int priceI;
            if (stringIsNumber(price))
            {
                priceI = Convert.ToInt32(price);

                switch (mode)
                {
                    case 'l':
                    case 'L': { return ProcessSortSearch.SearchLinear(goods_buffer, priceI); }
                    case 'b':
                    //case 'B': { return ProcessSortSearch.SearchBinary(goods_buffer, priceI); }
                    case 'B': { return ProcessSortSearch.SearchLinear(goods_buffer, priceI); }
                }
            }
            else MessageBox.Show(ERR_WRONG_TEXTBOX);

            return false;
        }
        void filterPriceF() // фильтр по цене, если меньше цены тогда отображаем все которые меньше 
        {
            FormMain.bListKal.Clear();

            string price = textBoxPrice.Text;
            //FormMain f = new FormMain();

            if (stringIsNumber(price))
            {
                foreach (Goods c in goods_buffer)
                {
                    if (c.Price <= Convert.ToInt32(price)) { FormMain.bListKal.Add(c); }
                }
            }
            if (FormMain.bListKal.Count == 0) { labelSearchRes.Text = "product less than the specified price"; }
            else { labelSearchRes.Text = "is product less than the specified price"; }
            (this.Owner as FormMain).dataGridView1.DataSource = FormMain.bListKal;
            (this.Owner as FormMain).dataGridView1.Refresh();
        }
        void filterKolvoF() // фильтр по количиству продукции, если меньше количиства продукции тогда отображаем все которые меньше
        {
            FormMain.bListKal.Clear();
            string kolvo = textBoxKolvo.Text;

            if (stringIsNumber(kolvo))
            {
                foreach (Goods c in goods_buffer)
                {
                    if (c.kolvo <= Convert.ToInt32(kolvo)) { FormMain.bListKal.Add(c); }
                }
            }
            if (FormMain.bListKal.Count == 0) { labelSearchRes.Text = "product less than the specified kolvo"; }
            else { labelSearchRes.Text = "is product less than the specified kolvo"; }
            (this.Owner as FormMain).dataGridView1.DataSource = FormMain.bListKal;
            (this.Owner as FormMain).dataGridView1.Refresh();
        }

        void filterSumF() // фильтр по сумме, если меньше суммы тогда отображаем все которые меньше
        {
            FormMain.bListKal.Clear();
            string sum = textBox.Text;

            if (stringIsNumber(sum))
            {
                foreach (Goods c in goods_buffer)
                {
                    if (c.Sum <= Convert.ToInt32(sum)) { FormMain.bListKal.Add(c); }
                }
            }
            if (FormMain.bListKal.Count == 0) { labelSearchRes.Text = "no product less than the specified Sum"; }
            else { labelSearchRes.Text = "is product less than the specified Sum"; }
            (this.Owner as FormMain).dataGridView1.DataSource = FormMain.bListKal;
            (this.Owner as FormMain).dataGridView1.Refresh();
        }

        //--------------------------------------------------------------------------------------states
        void stateSearchLinear()
        {
            stateNowBuff = 'l';

            groupBox1.Text = MODE_SEARCH_LINEAR;
            groupBox1.Visible = true;

            textBoxName.Enabled = false;
            textBoxDate.Enabled = false;
            textBoxKolvo.Enabled = false;
            textBoxPrice.Enabled = true;
            textBoxNumber.Enabled = false;
            textBox.Enabled = false;

            buttonProcess.Enabled = true;
            buttonProcess.Text = "Search";
        }
        void stateSearchBinary()
        {
            stateSearchLinear();

            stateNowBuff = 'b';

            groupBox1.Text = MODE_SEARCH_BINARY;
            groupBox1.Visible = true;
        }

        void filterPrice()
        {
            stateNowBuff = 's';

            labelSearchRes.Visible = true;

            groupBox1.Text = MODE_FILTER_PRICE;
            groupBox1.Visible = true;

            textBoxName.Enabled = false;
            textBoxDate.Enabled = false;
            textBoxKolvo.Enabled = false;
            textBoxPrice.Enabled = true;
            textBoxNumber.Enabled = false;
            textBox.Enabled = false;

            buttonProcess.Enabled = true;
            buttonProcess.Text = "Filter";
        }
        void filterKolvo()
        {
            stateNowBuff = 'p';

            labelSearchRes.Visible = true;

            groupBox1.Text = MODE_FILTER_KOLVO;
            groupBox1.Visible = true;

            textBoxName.Enabled = false;
            textBoxDate.Enabled = false;
            textBoxKolvo.Enabled = true;
            textBoxPrice.Enabled = false;
            textBoxNumber.Enabled = false;
            textBox.Enabled = false;

            buttonProcess.Enabled = true;
            buttonProcess.Text = "Filter";
        }

        void filterSum()
        {
            stateNowBuff = 'a';

            labelSearchRes.Visible = true;

            groupBox1.Text = MODE_FILTER_Sum;
            groupBox1.Visible = true;

            textBoxName.Enabled = false;
            textBoxDate.Enabled = false;
            textBoxKolvo.Enabled = false;
            textBoxPrice.Enabled = false;
            textBoxNumber.Enabled = false;
            textBox.Enabled = true;

            buttonProcess.Enabled = true;
            buttonProcess.Text = "Filter";

            labelEps.Text = "Sum";
        }

        //---------------------------------------------------------------------------------------GUI
        private void buttonProcess_Click(object sender, EventArgs e){ process();}

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result = MessageBox.Show(REALLY_RETURN, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                (this.Owner as FormMain).dataGridView1.DataSource = goods_buffer;
                (this.Owner as FormMain).dataGridView1.Refresh();
            }
        }
    }
}
