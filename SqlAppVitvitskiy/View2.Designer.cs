
namespace SqlAppVitvitskiy
{
    partial class View2
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
            this.modelPegasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelPegasTableAdapter = new SqlAppVitvitskiy.FactoryDBDataSetTableAdapters.ModelPegasTableAdapter();
            this.tableAdapterManager = new SqlAppVitvitskiy.FactoryDBDataSetTableAdapters.TableAdapterManager();
            this.modelPegasDataGridView = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.factoryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelPegasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelPegasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // factoryDBDataSet
            // 
            this.factoryDBDataSet.DataSetName = "FactoryDBDataSet";
            this.factoryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modelPegasBindingSource
            // 
            this.modelPegasBindingSource.DataMember = "ModelPegas";
            this.modelPegasBindingSource.DataSource = this.factoryDBDataSet;
            // 
            // modelPegasTableAdapter
            // 
            this.modelPegasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = SqlAppVitvitskiy.FactoryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГрузовойЛифтTableAdapter = null;
            this.tableAdapterManager.МалыйГрузовойЛифтTableAdapter = null;
            this.tableAdapterManager.МодельныйРядПегасTableAdapter = null;
            // 
            // modelPegasDataGridView
            // 
            this.modelPegasDataGridView.AllowUserToAddRows = false;
            this.modelPegasDataGridView.AutoGenerateColumns = false;
            this.modelPegasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.modelPegasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modelPegasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewTextBoxColumn12});
            this.modelPegasDataGridView.DataSource = this.modelPegasBindingSource;
            this.modelPegasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelPegasDataGridView.Location = new System.Drawing.Point(0, 0);
            this.modelPegasDataGridView.Name = "modelPegasDataGridView";
            this.modelPegasDataGridView.Size = new System.Drawing.Size(1576, 450);
            this.modelPegasDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Pegas_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Pegas_id";
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
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ШтихмасКабины(мм)";
            this.dataGridViewTextBoxColumn8.HeaderText = "ШтихмасКабины(мм)";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ШиринаШахты";
            this.dataGridViewTextBoxColumn9.HeaderText = "ШиринаШахты";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ГлубинаШахты";
            this.dataGridViewTextBoxColumn10.HeaderText = "ГлубинаШахты";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Противовес";
            this.dataGridViewTextBoxColumn11.HeaderText = "Противовес";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ШиринаПроемаДверей";
            this.dataGridViewTextBoxColumn12.HeaderText = "ШиринаПроемаДверей";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // View2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 450);
            this.Controls.Add(this.modelPegasDataGridView);
            this.Name = "View2";
            this.Text = "Характеристики модельного ряда Пегас";
            this.Load += new System.EventHandler(this.View2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.factoryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelPegasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelPegasDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FactoryDBDataSet factoryDBDataSet;
        private System.Windows.Forms.BindingSource modelPegasBindingSource;
        private FactoryDBDataSetTableAdapters.ModelPegasTableAdapter modelPegasTableAdapter;
        private FactoryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        public System.Windows.Forms.DataGridView modelPegasDataGridView;
    }
}