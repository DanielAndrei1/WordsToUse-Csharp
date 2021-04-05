namespace WordsToUse
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Add_Words = new System.Windows.Forms.Button();
            this.wordsTOUseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elevatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wordsTOUseDataSet4 = new WordsToUse.WordsTOUseDataSet4();
            this.wordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wordsTableAdapter = new WordsToUse.WordsTOUseDataSet4TableAdapters.WordsTableAdapter();
            this.tableAdapterManager1 = new WordsToUse.WordsTOUseDataSet4TableAdapters.TableAdapterManager();
            this.DataSet = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trkSpeed = new System.Windows.Forms.TrackBar();
            this.trkvolume = new System.Windows.Forms.TrackBar();
            this.Btnread = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FriendConnect = new System.Windows.Forms.Button();
            this.LanguageTranslate = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnDetectSrcLang = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.comboAvailableLangs = new System.Windows.Forms.ComboBox();
            this.txtDestLang = new System.Windows.Forms.TextBox();
            this.lblSrcLang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wordsTOUseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsTOUseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkvolume)).BeginInit();
            this.LanguageTranslate.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add_Words
            // 
            this.Add_Words.Location = new System.Drawing.Point(21, 117);
            this.Add_Words.Name = "Add_Words";
            this.Add_Words.Size = new System.Drawing.Size(75, 23);
            this.Add_Words.TabIndex = 0;
            this.Add_Words.Text = "Add Word";
            this.Add_Words.UseVisualStyleBackColor = true;
            this.Add_Words.Click += new System.EventHandler(this.AddWordClick);
            // 
            // elevatorBindingSource
            // 
            this.elevatorBindingSource.DataMember = "Elevator";
            // 
            // wordsTOUseDataSet4
            // 
            this.wordsTOUseDataSet4.DataSetName = "WordsTOUseDataSet4";
            this.wordsTOUseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wordsBindingSource
            // 
            this.wordsBindingSource.DataMember = "Words";
            this.wordsBindingSource.DataSource = this.wordsTOUseDataSet4;
            // 
            // wordsTableAdapter
            // 
            this.wordsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = WordsToUse.WordsTOUseDataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.WordsTableAdapter = this.wordsTableAdapter;
            // 
            // DataSet
            // 
            this.DataSet.AutoGenerateColumns = false;
            this.DataSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.DataSet.DataSource = this.wordsBindingSource;
            this.DataSet.Location = new System.Drawing.Point(364, 54);
            this.DataSet.Name = "DataSet";
            this.DataSet.Size = new System.Drawing.Size(344, 441);
            this.DataSet.TabIndex = 3;
            this.DataSet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataSet_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Words";
            this.dataGridViewTextBoxColumn2.HeaderText = "Words";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Speak";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(228, 76);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Select ID to be deleted";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Words to use!";
            // 
            // trkSpeed
            // 
            this.trkSpeed.Location = new System.Drawing.Point(12, 254);
            this.trkSpeed.Name = "trkSpeed";
            this.trkSpeed.Size = new System.Drawing.Size(84, 45);
            this.trkSpeed.TabIndex = 12;
            // 
            // trkvolume
            // 
            this.trkvolume.Location = new System.Drawing.Point(104, 254);
            this.trkvolume.Maximum = 100;
            this.trkvolume.Minimum = 50;
            this.trkvolume.Name = "trkvolume";
            this.trkvolume.Size = new System.Drawing.Size(91, 45);
            this.trkvolume.TabIndex = 13;
            this.trkvolume.Value = 50;
            // 
            // Btnread
            // 
            this.Btnread.Location = new System.Drawing.Point(21, 202);
            this.Btnread.Name = "Btnread";
            this.Btnread.Size = new System.Drawing.Size(150, 23);
            this.Btnread.TabIndex = 14;
            this.Btnread.Text = "Select ID or Word to speech";
            this.Btnread.UseVisualStyleBackColor = true;
            this.Btnread.Click += new System.EventHandler(this.Btnread_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(484, 527);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 15;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyUp);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(360, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Search words:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FriendConnect
            // 
            this.FriendConnect.Location = new System.Drawing.Point(21, 319);
            this.FriendConnect.Name = "FriendConnect";
            this.FriendConnect.Size = new System.Drawing.Size(105, 23);
            this.FriendConnect.TabIndex = 17;
            this.FriendConnect.Text = "Talk with a friend";
            this.FriendConnect.UseVisualStyleBackColor = true;
            this.FriendConnect.Click += new System.EventHandler(this.FriendConnect_Click);
            // 
            // LanguageTranslate
            // 
            this.LanguageTranslate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LanguageTranslate.Controls.Add(this.lblSrcLang);
            this.LanguageTranslate.Controls.Add(this.txtDestLang);
            this.LanguageTranslate.Controls.Add(this.comboAvailableLangs);
            this.LanguageTranslate.Controls.Add(this.btnTranslate);
            this.LanguageTranslate.Controls.Add(this.btnAC);
            this.LanguageTranslate.Controls.Add(this.btnDetectSrcLang);
            this.LanguageTranslate.Controls.Add(this.textBox5);
            this.LanguageTranslate.Location = new System.Drawing.Point(21, 363);
            this.LanguageTranslate.Name = "LanguageTranslate";
            this.LanguageTranslate.Size = new System.Drawing.Size(307, 202);
            this.LanguageTranslate.TabIndex = 18;
            this.LanguageTranslate.TabStop = false;
            this.LanguageTranslate.Text = "Language Translate";
            this.LanguageTranslate.Enter += new System.EventHandler(this.LanguageTranslate_Enter);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(7, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(294, 20);
            this.textBox5.TabIndex = 0;
            // 
            // btnDetectSrcLang
            // 
            this.btnDetectSrcLang.Location = new System.Drawing.Point(6, 45);
            this.btnDetectSrcLang.Name = "btnDetectSrcLang";
            this.btnDetectSrcLang.Size = new System.Drawing.Size(294, 25);
            this.btnDetectSrcLang.TabIndex = 1;
            this.btnDetectSrcLang.Text = "Detect Language";
            this.btnDetectSrcLang.UseVisualStyleBackColor = true;
            this.btnDetectSrcLang.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAC
            // 
            this.btnAC.Location = new System.Drawing.Point(7, 76);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(141, 23);
            this.btnAC.TabIndex = 2;
            this.btnAC.Text = "Access Control";
            this.btnAC.UseVisualStyleBackColor = true;
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(154, 76);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(141, 23);
            this.btnTranslate.TabIndex = 3;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            // 
            // comboAvailableLangs
            // 
            this.comboAvailableLangs.FormattingEnabled = true;
            this.comboAvailableLangs.Location = new System.Drawing.Point(6, 105);
            this.comboAvailableLangs.Name = "comboAvailableLangs";
            this.comboAvailableLangs.Size = new System.Drawing.Size(288, 21);
            this.comboAvailableLangs.TabIndex = 4;
            // 
            // txtDestLang
            // 
            this.txtDestLang.Location = new System.Drawing.Point(6, 133);
            this.txtDestLang.Multiline = true;
            this.txtDestLang.Name = "txtDestLang";
            this.txtDestLang.Size = new System.Drawing.Size(289, 36);
            this.txtDestLang.TabIndex = 5;
            // 
            // lblSrcLang
            // 
            this.lblSrcLang.Location = new System.Drawing.Point(9, 176);
            this.lblSrcLang.Name = "lblSrcLang";
            this.lblSrcLang.Size = new System.Drawing.Size(285, 13);
            this.lblSrcLang.TabIndex = 6;
            this.lblSrcLang.Text = "Source Language";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(732, 577);
            this.Controls.Add(this.LanguageTranslate);
            this.Controls.Add(this.FriendConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Btnread);
            this.Controls.Add(this.trkvolume);
            this.Controls.Add(this.trkSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DataSet);
            this.Controls.Add(this.Add_Words);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learn new words";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.wordsTOUseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsTOUseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkvolume)).EndInit();
            this.LanguageTranslate.ResumeLayout(false);
            this.LanguageTranslate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Words;
        private System.Windows.Forms.BindingSource wordsTOUseDataSetBindingSource;
        private System.Windows.Forms.BindingSource elevatorBindingSource;
        private WordsTOUseDataSet4 wordsTOUseDataSet4;
        private System.Windows.Forms.BindingSource wordsBindingSource;
        private WordsTOUseDataSet4TableAdapters.WordsTableAdapter wordsTableAdapter;
        private WordsTOUseDataSet4TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView DataSet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trkSpeed;
        private System.Windows.Forms.TrackBar trkvolume;
        private System.Windows.Forms.Button Btnread;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FriendConnect;
        private System.Windows.Forms.GroupBox LanguageTranslate;
        private System.Windows.Forms.Button btnDetectSrcLang;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtDestLang;
        private System.Windows.Forms.ComboBox comboAvailableLangs;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.Label lblSrcLang;
    }
}

