
namespace SqlAppVitvitskiy
{
    partial class History
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
            this.грузовойЛифтИсторияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.грузовойЛифтИсторияTableAdapter = new SqlAppVitvitskiy.FactoryDBDataSetTableAdapters.ГрузовойЛифтИсторияTableAdapter();
            this.tableAdapterManager = new SqlAppVitvitskiy.FactoryDBDataSetTableAdapters.TableAdapterManager();
            this.грузовойЛифтИсторияDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.factoryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.грузовойЛифтИсторияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.грузовойЛифтИсторияDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // factoryDBDataSet
            // 
            this.factoryDBDataSet.DataSetName = "FactoryDBDataSet";
            this.factoryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // грузовойЛифтИсторияBindingSource
            // 
            this.грузовойЛифтИсторияBindingSource.DataMember = "ГрузовойЛифтИстория";
            this.грузовойЛифтИсторияBindingSource.DataSource = this.factoryDBDataSet;
            // 
            // грузовойЛифтИсторияTableAdapter
            // 
            this.грузовойЛифтИсторияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = SqlAppVitvitskiy.FactoryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГрузовойЛифтTableAdapter = null;
            this.tableAdapterManager.ГрузовойЛифтИсторияTableAdapter = this.грузовойЛифтИсторияTableAdapter;
            this.tableAdapterManager.ГрузовойЛифтТестTableAdapter = null;
            this.tableAdapterManager.МалыйГрузовойЛифтTableAdapter = null;
            this.tableAdapterManager.МалыйГрузовойЛифтИмпортTableAdapter = null;
            this.tableAdapterManager.МодельныйРядПегасTableAdapter = null;
            this.tableAdapterManager.МодельныйРядПегасИмпортTableAdapter = null;
            // 
            // грузовойЛифтИсторияDataGridView
            // 
            this.грузовойЛифтИсторияDataGridView.AutoGenerateColumns = false;
            this.грузовойЛифтИсторияDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.грузовойЛифтИсторияDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.грузовойЛифтИсторияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.грузовойЛифтИсторияDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.грузовойЛифтИсторияDataGridView.DataSource = this.грузовойЛифтИсторияBindingSource;
            this.грузовойЛифтИсторияDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.грузовойЛифтИсторияDataGridView.Location = new System.Drawing.Point(0, 0);
            this.грузовойЛифтИсторияDataGridView.Name = "грузовойЛифтИсторияDataGridView";
            this.грузовойЛифтИсторияDataGridView.Size = new System.Drawing.Size(1055, 450);
            this.грузовойЛифтИсторияDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ElevatorIndex";
            this.dataGridViewTextBoxColumn2.HeaderText = "ElevatorIndex";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Operation";
            this.dataGridViewTextBoxColumn3.HeaderText = "Operation";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CreateAt";
            this.dataGridViewTextBoxColumn4.HeaderText = "CreateAt";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 450);
            this.Controls.Add(this.грузовойЛифтИсторияDataGridView);
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.factoryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.грузовойЛифтИсторияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.грузовойЛифтИсторияDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FactoryDBDataSet factoryDBDataSet;
        private System.Windows.Forms.BindingSource грузовойЛифтИсторияBindingSource;
        private FactoryDBDataSetTableAdapters.ГрузовойЛифтИсторияTableAdapter грузовойЛифтИсторияTableAdapter;
        private FactoryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView грузовойЛифтИсторияDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}