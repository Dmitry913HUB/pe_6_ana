using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace pe6
{
    public partial class FormMain: Form
    {
        const string WANT_SAVE = "you want to save data";
        const string MODE_CREATE = "Mode: create";
        const string MODE_VIEW = "Mode: view";
        const string MODE_EDIT = "Mode: edit";
        const string MODE_SEARCH_LINEAR = "Mode: linear search";
        const string MODE_SEARCH_BINARY = "Mode: binaty search";
        const string MODE_FILTER_PRICE = "Mode: Price filter";
        const string MODE_FILTER_KOLVO = "Mode: Kolvo filter";
        const string MODE_FILTER_Sum = "Mode: Sum filter";

        const string REALLY_DELETE = "do you really want to delete";
        const string REALLY_SAVE_NEW = "Are you really want create new collection? Save current collection will be removed.";

        const string ERR_WRONG_TEXTBOX = "Input data is not number";
        const string ERR_FILE_IO = "File IO error";

        BindingList<Goods> bList = new BindingList<Goods>();
        internal static BindingList<Goods> bListKal = new BindingList<Goods>();
        char stateNow = 'x';

        public FormMain()
        {
            InitializeComponent();

            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            //base test values
            //DateTime date1 = new DateTime(2020, 12, 3);
            //DateTime date2 = new DateTime(2018, 12, 12);
            //DateTime date3 = new DateTime(2020, 3, 27);

            //Goods ct1 = new Goods("canod d 345", date1, 12300, 20, 14344);
            //Goods ct2 = new Goods("nikon 334", date2, 34560, 12, 45565);
            //Goods ct3 = new Goods("fuji 56", date3, 56433, 18, 23432);
            //Goods ct4 = new Goods();

            //ct1.cost();
            //ct2.cost();
            //ct3.cost();

            //bList.Add(ct1);
            //bList.Add(ct2);
            //bList.Add(ct3);
            //bList.Add(ct4);

            dataGridView1.DataSource = bList;
            LockTable();

            //stateView();
            //stateSearchLinear();
        }
        //---------------------------------------------------------------------------------------service

        bool AskSave() // вопрос о сохранении 
        {
            DialogResult res = MessageBox.Show("Сохранить данные?", "ПИ-ЛАБ-6", MessageBoxButtons.YesNoCancel);
            switch (res)
            {
                case DialogResult.Yes: saveToFile(); return true;
                case DialogResult.No: return true;
                case DialogResult.Cancel: return false;
            }
            return false;
        }
        private void LockTable() // блокировка таблицы
        {
            dataGridView1.AllowUserToDeleteRows = false;
            for (int i = 1; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].ReadOnly = true;
            }
        }
        private void UnlockTable() // разблокировка таблицы
        {
            dataGridView1.AllowUserToDeleteRows = true;
            for (int i = 1; i < dataGridView1.Columns.Count - 1; i++)
            {
                dataGridView1.Columns[i].ReadOnly = false;
            }
        }
        private bool stringIsNumber(string s) //проверка строки на число
        {
            foreach (char c in s)
            {
                if (char.IsDigit(c) || '/' == c ) { continue; }
                else return false;
            }
            return true;
        }

        //----------------------------------------------------------------------------------process
        void showList()
        {
            string s = "";
            foreach (Goods ct in bList)//list
            {
                s += ct.ToString() + "\n";
            }
            MessageBox.Show(s);
        }

        void addRecord() // добавление данных в таблицу
        {
            string name = textBoxName.Text;
            string date = textBoxDate.Text;
            string price = textBoxPrice.Text;
            string kolvo = textBoxKolvo.Text;
            string number = textBoxNumber.Text;

            if (stringIsNumber(price) && stringIsNumber(number) && stringIsNumber(kolvo) && stringIsNumber(date))
            {
                DateTime dateDT = Convert.ToDateTime(date);
                int priceI = Convert.ToInt32(price);
                int kolvoI = Convert.ToInt32(kolvo);
                int numberI = Convert.ToInt32(number);
                Goods goods = new Goods(name, dateDT, priceI, kolvoI, numberI);
                goods.cost();
                bList.Add(goods);
            }
            else MessageBox.Show(ERR_WRONG_TEXTBOX);

        }
        void saveToFile()// Сохранить как 
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|bin files (*.bin)|*.bin|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    FileIOSerializer.save(bList, myStream);
                    myStream.Close();
                }
            }
        }

        void loadFrFile() // загрузить как 
        {
            Stream myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "txt files (*.txt)|*.txt|bin files (*.bin)|*.bin|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    FileIOSerializer.load(ref bList, myStream);
                    dataGridView1.DataSource = bList;
                    dataGridView1.Refresh();
                    myStream.Close();
                }
            }
        }
 
        //--------------------------------------------------------------------------------------states
        void stateCreate()  
        {
            
            DialogResult result = MessageBox.Show(REALLY_SAVE_NEW, "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {

                labelState.Text = MODE_CREATE;

                dataGridView1.Rows.Clear();
                UnlockTable();
     
            }
            else if (result == DialogResult.Yes)
                saveToFile();
        }
        void stateView()
        {

            labelState.Text = MODE_VIEW;
            LockTable();
        }
        void stateEdit()
        {

            labelState.Text = MODE_EDIT;

            UnlockTable();

        }
        void stateSearchLinear()
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.stateNowBuff = 'l';
            f.Text = MODE_SEARCH_LINEAR;
            f.goods_buffer = new BindingList<Goods>(bList);
            f.Show();
        }
        void stateSearchBinary()
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.stateNowBuff = 'b';
            f.Text = MODE_SEARCH_BINARY;
            f.goods_buffer = new BindingList<Goods>(bList);
            f.Show();
        }
        void filterPrice()
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.stateNowBuff = 's';
            f.Text = MODE_FILTER_PRICE;
            f.goods_buffer = new BindingList<Goods>(bList);
            f.Show();            
        }
        void filterKolvo()
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.stateNowBuff = 'p';
            f.Text = MODE_FILTER_KOLVO;
            f.goods_buffer = new BindingList<Goods>(bList);
            f.Show();
        }

        void filterSum()
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.stateNowBuff = 'a';
            f.Text = MODE_FILTER_Sum;
            f.goods_buffer = new BindingList<Goods>(bList);
            f.Show();
        }

        //---------------------------------------------------------------------------------------GUI

        //-----servis
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by PolevinaAA 2020.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonProcess_Click(object sender, EventArgs e) { /*process();*/ }
        private void CreateToolStripMenuItem_Click(object sender, EventArgs e){ stateCreate(); }
        private void ViewToolStripMenuItem_Click(object sender, EventArgs e){ stateView(); }
        private void EditToolStripMenuItem_Click(object sender, EventArgs e){ stateEdit(); }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e){ saveToFile(); }
        private void LoadToolStripMenuItem_Click(object sender, EventArgs e){ loadFrFile(); }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(WANT_SAVE, "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                saveToFile();
                Application.Exit();
            }
            else if (result == DialogResult.No)
                Application.Exit();             
        }
        private void remToolStripMenuItem_Click(object sender, EventArgs e) 
        { 
           DialogResult result = MessageBox.Show(REALLY_DELETE, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); 
           if(result == DialogResult.Yes)
                dataGridView1.Rows.Clear(); 
        }

        //-----sort
        private void dateToolStripMenuItem_Click(object sender, EventArgs e) { ProcessSortSearch.SortDate(bList);}
        private void priceToolStripMenuItem_Click(object sender, EventArgs e) { ProcessSortSearch.SortPrice(bList);}
        private void kolvoToolStripMenuItem_Click(object sender, EventArgs e) { ProcessSortSearch.SortKolvo(bList);}
        private void numberToolStripMenuItem_Click(object sender, EventArgs e) { ProcessSortSearch.SortNumber(bList);}
        private void sumToolStripMenuItem_Click(object sender, EventArgs e) { ProcessSortSearch.SortSum(bList);}

        //-----search
        private void linearToolStripMenuItem_Click(object sender, EventArgs e){ stateSearchLinear();}
        private void binaryToolStripMenuItem_Click(object sender, EventArgs e){ stateSearchBinary(); }

        //-----filter
        private void absToolStripMenuItem_Click(object sender, EventArgs e){ filterPrice();}
        private void coordinateQuarterToolStripMenuItem_Click(object sender, EventArgs e) { filterKolvo(); }
        private void areaToolStripMenuItem_Click(object sender, EventArgs e){ filterSum(); }

        //-------------------------------------------------------------------------------------------table
        private void setRowNumber(DataGridView dgv) //индекс
        {
            for (int i = 0; i < dgv.Rows.Count - 1; ++i)
            {
                dgv.Rows[i].Cells["index_col"].Value = i + 1;
                dgv.Rows[i].Cells["Sum"].Value = (int)dgv.Rows[i].Cells["Price"].Value * (int)dgv.Rows[i].Cells["kolvo"].Value;
            }

        }
        private void table_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) //добавление строки в тадицу
        {
            setRowNumber(dataGridView1);
            saveToolStripMenuItem.Enabled = true;
        }

        private void table_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) // удаление строки в таблице
        {
            setRowNumber(dataGridView1);
        }
        private void table_DataError(object sender, DataGridViewDataErrorEventArgs e) // ошибка данных
        {
            MessageBox.Show("Неправильные данные!", "Ошибка");
        }

        private void table_CellValueChanged(object sender, DataGridViewCellEventArgs e) // значение ячейки таблицы изменено 
        {
            setRowNumber(dataGridView1);
            saveToolStripMenuItem.Enabled = true;
        }

        //-------------------------------------------------------------------------------------------end
    }
}
