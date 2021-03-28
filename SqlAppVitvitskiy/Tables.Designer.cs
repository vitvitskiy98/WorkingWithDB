
namespace SqlAppVitvitskiy
{
    partial class Tables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tables));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.грузовойЛифтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factoryDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factoryDBDataSet = new SqlAppVitvitskiy.FactoryDBDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.грузовойЛифтTableAdapter = new SqlAppVitvitskiy.FactoryDBDataSetTableAdapters.ГрузовойЛифтTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.грузовойЛифтBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(-3, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 176);
            this.label1.TabIndex = 10;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(574, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Грузовые лифты",
            "Малые Грузовые лифты",
            "Модельный ряд Пегас",
            "Грузовые лифты Импорт",
            "Малые Грузовые лифты Импорт",
            "Модельный ряд Пегас Импорт"});
            this.comboBox1.Location = new System.Drawing.Point(37, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // грузовойЛифтBindingSource
            // 
            this.грузовойЛифтBindingSource.DataMember = "ГрузовойЛифт";
            this.грузовойЛифтBindingSource.DataSource = this.factoryDBDataSetBindingSource;
            // 
            // factoryDBDataSetBindingSource
            // 
            this.factoryDBDataSetBindingSource.DataSource = this.factoryDBDataSet;
            this.factoryDBDataSetBindingSource.Position = 0;
            // 
            // factoryDBDataSet
            // 
            this.factoryDBDataSet.DataSetName = "FactoryDBDataSet";
            this.factoryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(34, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Выберите таблицу:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 37);
            this.button2.TabIndex = 15;
            this.button2.Text = "Перейти к таблице";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // грузовойЛифтTableAdapter
            // 
            this.грузовойЛифтTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SqlAppVitvitskiy.Properties.Resources.m_logo_kmz2;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(152, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(609, 280);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tables";
            this.Load += new System.EventHandler(this.Tables_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tables_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tables_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.грузовойЛифтBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FactoryDBDataSet factoryDBDataSet;
        private System.Windows.Forms.BindingSource factoryDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource грузовойЛифтBindingSource;
        private FactoryDBDataSetTableAdapters.ГрузовойЛифтTableAdapter грузовойЛифтTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}