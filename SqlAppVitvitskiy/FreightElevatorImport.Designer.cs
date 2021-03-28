
namespace SqlAppVitvitskiy
{
    partial class FreightElevatorImport
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
            this.factoryDBDataSet = new SqlAppVitvitskiy.FactoryDBDataSet();
            this.freightElevatorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.freightElevatorsTableAdapter = new SqlAppVitvitskiy.FactoryDBDataSetTableAdapters.FreightElevatorsTableAdapter();
            this.tableAdapterManager = new SqlAppVitvitskiy.FactoryDBDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.грузовойЛифтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.грузовойЛифтTableAdapter = new SqlAppVitvitskiy.FactoryDBDataSetTableAdapters.ГрузовойЛифтTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.грузовойЛифтТестBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.грузовойЛифтТестTableAdapter = new SqlAppVitvitskiy.FactoryDBDataSetTableAdapters.ГрузовойЛифтТестTableAdapter();
            this.грузовойЛифтТестDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.factoryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freightElevatorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.грузовойЛифтBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.грузовойЛифтТестBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.грузовойЛифтТестDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // factoryDBDataSet
            // 
            this.factoryDBDataSet.DataSetName = "FactoryDBDataSet";
            this.factoryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // freightElevatorsBindingSource
            // 
            this.freightElevatorsBindingSource.DataMember = "FreightElevators";
            this.freightElevatorsBindingSource.DataSource = this.factoryDBDataSet;
            // 
            // freightElevatorsTableAdapter
            // 
            this.freightElevatorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = SqlAppVitvitskiy.FactoryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГрузовойЛифтTableAdapter = null;
            this.tableAdapterManager.ГрузовойЛифтТестTableAdapter = null;
            this.tableAdapterManager.МалыйГрузовойЛифтTableAdapter = null;
            this.tableAdapterManager.МодельныйРядПегасTableAdapter = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(120, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Путь файла:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 417);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1157, 26);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1413, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Выбрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(993, 478);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 33);
            this.button3.TabIndex = 6;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // грузовойЛифтBindingSource
            // 
            this.грузовойЛифтBindingSource.DataMember = "ГрузовойЛифт";
            this.грузовойЛифтBindingSource.DataSource = this.factoryDBDataSet;
            // 
            // грузовойЛифтTableAdapter
            // 
            this.грузовойЛифтTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(532, 485);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(362, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(392, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Выберите лист:";
            // 
            // грузовойЛифтТестBindingSource
            // 
            this.грузовойЛифтТестBindingSource.DataMember = "ГрузовойЛифтТест";
            this.грузовойЛифтТестBindingSource.DataSource = this.factoryDBDataSet;
            // 
            // грузовойЛифтТестTableAdapter
            // 
            this.грузовойЛифтТестTableAdapter.ClearBeforeFill = true;
            // 
            // грузовойЛифтТестDataGridView
            // 
            this.грузовойЛифтТестDataGridView.AutoGenerateColumns = false;
            this.грузовойЛифтТестDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.грузовойЛифтТестDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.грузовойЛифтТестDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.грузовойЛифтТестDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.грузовойЛифтТестDataGridView.DataSource = this.грузовойЛифтТестBindingSource;
            this.грузовойЛифтТестDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.грузовойЛифтТестDataGridView.Location = new System.Drawing.Point(0, 0);
            this.грузовойЛифтТестDataGridView.Name = "грузовойЛифтТестDataGridView";
            this.грузовойЛифтТестDataGridView.Size = new System.Drawing.Size(1554, 383);
            this.грузовойЛифтТестDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "freightElevatorID";
            this.dataGridViewTextBoxColumn1.HeaderText = "freightElevatorID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ИндексЛифта";
            this.dataGridViewTextBoxColumn2.HeaderText = "ИндексЛифта";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Грузоподъемность";
            this.dataGridViewTextBoxColumn3.HeaderText = "Грузоподъемность";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Скорость";
            this.dataGridViewTextBoxColumn4.HeaderText = "Скорость";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ШиринаКабины";
            this.dataGridViewTextBoxColumn5.HeaderText = "ШиринаКабины";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ГлубинаКабины";
            this.dataGridViewTextBoxColumn6.HeaderText = "ГлубинаКабины";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ВысотаКабины";
            this.dataGridViewTextBoxColumn7.HeaderText = "ВысотаКабины";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ШиринаШахты";
            this.dataGridViewTextBoxColumn8.HeaderText = "ШиринаШахты";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ГлубинаШахты";
            this.dataGridViewTextBoxColumn9.HeaderText = "ГлубинаШахты";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Противовес";
            this.dataGridViewTextBoxColumn10.HeaderText = "Противовес";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ШиринаПроемаДверей";
            this.dataGridViewTextBoxColumn11.HeaderText = "ШиринаПроемаДверей";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "МаксВысотаПодъема";
            this.dataGridViewTextBoxColumn12.HeaderText = "МаксВысотаПодъема";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ОстановокКабины";
            this.dataGridViewTextBoxColumn13.HeaderText = "ОстановокКабины";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // FreightElevatorImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1554, 566);
            this.Controls.Add(this.грузовойЛифтТестDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FreightElevatorImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FreightElevatorImport";
            this.Load += new System.EventHandler(this.FreightElevatorImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.factoryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freightElevatorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.грузовойЛифтBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.грузовойЛифтТестBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.грузовойЛифтТестDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FactoryDBDataSet factoryDBDataSet;
        private System.Windows.Forms.BindingSource freightElevatorsBindingSource;
        private FactoryDBDataSetTableAdapters.FreightElevatorsTableAdapter freightElevatorsTableAdapter;
        private FactoryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource грузовойЛифтBindingSource;
        private FactoryDBDataSetTableAdapters.ГрузовойЛифтTableAdapter грузовойЛифтTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource грузовойЛифтТестBindingSource;
        private FactoryDBDataSetTableAdapters.ГрузовойЛифтТестTableAdapter грузовойЛифтТестTableAdapter;
        private System.Windows.Forms.DataGridView грузовойЛифтТестDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}