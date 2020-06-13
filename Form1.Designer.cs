namespace pe6
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.collectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolvoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.absToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coordinateQuarterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.index_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelState = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxKolvo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSearchRes = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelEps = new System.Windows.Forms.Label();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelFi = new System.Windows.Forms.Label();
            this.labelAbs = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.collectionToolStripMenuItem,
            this.processToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(579, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // collectionToolStripMenuItem
            // 
            this.collectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.remToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.collectionToolStripMenuItem.Name = "collectionToolStripMenuItem";
            this.collectionToolStripMenuItem.Size = new System.Drawing.Size(73, 22);
            this.collectionToolStripMenuItem.Text = "Collection";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.ViewToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // remToolStripMenuItem
            // 
            this.remToolStripMenuItem.Name = "remToolStripMenuItem";
            this.remToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.remToolStripMenuItem.Text = "Remove";
            this.remToolStripMenuItem.Click += new System.EventHandler(this.remToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem,
            this.seaToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateToolStripMenuItem,
            this.priceToolStripMenuItem,
            this.kolvoToolStripMenuItem,
            this.numberToolStripMenuItem,
            this.sumToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.dateToolStripMenuItem.Text = "Date";
            this.dateToolStripMenuItem.Click += new System.EventHandler(this.dateToolStripMenuItem_Click);
            // 
            // priceToolStripMenuItem
            // 
            this.priceToolStripMenuItem.Name = "priceToolStripMenuItem";
            this.priceToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.priceToolStripMenuItem.Text = "Price";
            this.priceToolStripMenuItem.Click += new System.EventHandler(this.priceToolStripMenuItem_Click);
            // 
            // kolvoToolStripMenuItem
            // 
            this.kolvoToolStripMenuItem.Name = "kolvoToolStripMenuItem";
            this.kolvoToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.kolvoToolStripMenuItem.Text = "Kolvo";
            this.kolvoToolStripMenuItem.Click += new System.EventHandler(this.kolvoToolStripMenuItem_Click);
            // 
            // numberToolStripMenuItem
            // 
            this.numberToolStripMenuItem.Name = "numberToolStripMenuItem";
            this.numberToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.numberToolStripMenuItem.Text = "Number";
            this.numberToolStripMenuItem.Click += new System.EventHandler(this.numberToolStripMenuItem_Click);
            // 
            // sumToolStripMenuItem
            // 
            this.sumToolStripMenuItem.Name = "sumToolStripMenuItem";
            this.sumToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.sumToolStripMenuItem.Text = "Sum";
            this.sumToolStripMenuItem.Click += new System.EventHandler(this.sumToolStripMenuItem_Click);
            // 
            // seaToolStripMenuItem
            // 
            this.seaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linearToolStripMenuItem,
            this.binaryToolStripMenuItem});
            this.seaToolStripMenuItem.Name = "seaToolStripMenuItem";
            this.seaToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.seaToolStripMenuItem.Text = "Search";
            // 
            // linearToolStripMenuItem
            // 
            this.linearToolStripMenuItem.Name = "linearToolStripMenuItem";
            this.linearToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.linearToolStripMenuItem.Text = "Linear";
            this.linearToolStripMenuItem.Click += new System.EventHandler(this.linearToolStripMenuItem_Click);
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            this.binaryToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.binaryToolStripMenuItem.Text = "Binary";
            this.binaryToolStripMenuItem.Click += new System.EventHandler(this.binaryToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.absToolStripMenuItem,
            this.coordinateQuarterToolStripMenuItem,
            this.areaToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.filterToolStripMenuItem.Text = "filter";
            // 
            // absToolStripMenuItem
            // 
            this.absToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.absToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.absToolStripMenuItem.Name = "absToolStripMenuItem";
            this.absToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.absToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.absToolStripMenuItem.Text = "Price";
            this.absToolStripMenuItem.Click += new System.EventHandler(this.absToolStripMenuItem_Click);
            // 
            // coordinateQuarterToolStripMenuItem
            // 
            this.coordinateQuarterToolStripMenuItem.Name = "coordinateQuarterToolStripMenuItem";
            this.coordinateQuarterToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.coordinateQuarterToolStripMenuItem.Text = "Kolvo";
            this.coordinateQuarterToolStripMenuItem.Click += new System.EventHandler(this.coordinateQuarterToolStripMenuItem_Click);
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.areaToolStripMenuItem.Text = "Sum";
            this.areaToolStripMenuItem.Click += new System.EventHandler(this.areaToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index_col});
            this.dataGridView1.Location = new System.Drawing.Point(7, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(559, 252);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellValueChanged);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.table_DataError);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.table_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.table_RowsRemoved);
            // 
            // index_col
            // 
            this.index_col.HeaderText = "index";
            this.index_col.Name = "index_col";
            this.index_col.ReadOnly = true;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(191, 6);
            this.labelState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(54, 13);
            this.labelState.TabIndex = 2;
            this.labelState.Text = "labelState";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPrice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxNumber);
            this.groupBox1.Controls.Add(this.textBoxKolvo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelSearchRes);
            this.groupBox1.Controls.Add(this.textBox);
            this.groupBox1.Controls.Add(this.labelEps);
            this.groupBox1.Controls.Add(this.buttonProcess);
            this.groupBox1.Controls.Add(this.textBoxDate);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.labelFi);
            this.groupBox1.Controls.Add(this.labelAbs);
            this.groupBox1.Location = new System.Drawing.Point(490, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(295, 203);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(188, 39);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(68, 20);
            this.textBoxPrice.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Price";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(114, 90);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(68, 20);
            this.textBoxNumber.TabIndex = 11;
            // 
            // textBoxKolvo
            // 
            this.textBoxKolvo.Location = new System.Drawing.Point(41, 90);
            this.textBoxKolvo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKolvo.Name = "textBoxKolvo";
            this.textBoxKolvo.Size = new System.Drawing.Size(68, 20);
            this.textBoxKolvo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kolvo";
            // 
            // labelSearchRes
            // 
            this.labelSearchRes.AutoSize = true;
            this.labelSearchRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearchRes.Location = new System.Drawing.Point(12, 163);
            this.labelSearchRes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSearchRes.Name = "labelSearchRes";
            this.labelSearchRes.Size = new System.Drawing.Size(122, 20);
            this.labelSearchRes.TabIndex = 7;
            this.labelSearchRes.Text = "Search res here";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(187, 90);
            this.textBox.Margin = new System.Windows.Forms.Padding(2);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(68, 20);
            this.textBox.TabIndex = 6;
            // 
            // labelEps
            // 
            this.labelEps.AutoSize = true;
            this.labelEps.Location = new System.Drawing.Point(185, 70);
            this.labelEps.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEps.Name = "labelEps";
            this.labelEps.Size = new System.Drawing.Size(0, 13);
            this.labelEps.TabIndex = 5;
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(102, 129);
            this.buttonProcess.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(95, 27);
            this.buttonProcess.TabIndex = 4;
            this.buttonProcess.Text = "Process";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(114, 39);
            this.textBoxDate.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(68, 20);
            this.textBoxDate.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(41, 39);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(68, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // labelFi
            // 
            this.labelFi.AutoSize = true;
            this.labelFi.Location = new System.Drawing.Point(114, 19);
            this.labelFi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFi.Name = "labelFi";
            this.labelFi.Size = new System.Drawing.Size(30, 13);
            this.labelFi.TabIndex = 1;
            this.labelFi.Text = "Date";
            // 
            // labelAbs
            // 
            this.labelAbs.AutoSize = true;
            this.labelAbs.Location = new System.Drawing.Point(41, 19);
            this.labelAbs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAbs.Name = "labelAbs";
            this.labelAbs.Size = new System.Drawing.Size(35, 13);
            this.labelAbs.TabIndex = 0;
            this.labelAbs.Text = "Name";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 322);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Form Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem collectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        internal System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelFi;
        private System.Windows.Forms.Label labelAbs;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label labelEps;
        private System.Windows.Forms.Label labelSearchRes;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem absToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coordinateQuarterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxKolvo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem remToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolvoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn index_col;
    }
}

