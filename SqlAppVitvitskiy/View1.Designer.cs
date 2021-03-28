
namespace SqlAppVitvitskiy
{
    partial class View1
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
            this.freightElevatorsDataGridView = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.freightElevatorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freightElevatorsDataGridView)).BeginInit();
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
            this.tableAdapterManager.МалыйГрузовойЛифтTableAdapter = null;
            this.tableAdapterManager.МодельныйРядПегасTableAdapter = null;
            // 
            // freightElevatorsDataGridView
            // 
            this.freightElevatorsDataGridView.AllowUserToAddRows = false;
            this.freightElevatorsDataGridView.AutoGenerateColumns = false;
            this.freightElevatorsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.freightElevatorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.freightElevatorsDataGridView.DataSource = this.freightElevatorsBindingSource;
            this.freightElevatorsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freightElevatorsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.freightElevatorsDataGridView.Name = "freightElevatorsDataGridView";
            this.freightElevatorsDataGridView.Size = new System.Drawing.Size(1563, 450);
            this.freightElevatorsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ИндексЛифта";
            this.dataGridViewTextBoxColumn1.HeaderText = "ИндексЛифта";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Грузоподъемность";
            this.dataGridViewTextBoxColumn2.HeaderText = "Грузоподъемность";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Скорость";
            this.dataGridViewTextBoxColumn3.HeaderText = "Скорость";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ШиринаКабины";
            this.dataGridViewTextBoxColumn4.HeaderText = "ШиринаКабины";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ГлубинаКабины";
            this.dataGridViewTextBoxColumn5.HeaderText = "ГлубинаКабины";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ВысотаКабины";
            this.dataGridViewTextBoxColumn6.HeaderText = "ВысотаКабины";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ШиринаШахты";
            this.dataGridViewTextBoxColumn7.HeaderText = "ШиринаШахты";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ГлубинаШахты";
            this.dataGridViewTextBoxColumn8.HeaderText = "ГлубинаШахты";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Противовес";
            this.dataGridViewTextBoxColumn9.HeaderText = "Противовес";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ШиринаПроемаДверей";
            this.dataGridViewTextBoxColumn10.HeaderText = "ШиринаПроемаДверей";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "МаксВысотаПодъема";
            this.dataGridViewTextBoxColumn11.HeaderText = "МаксВысотаПодъема";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ОстановокКабины";
            this.dataGridViewTextBoxColumn12.HeaderText = "ОстановокКабины";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // View1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 450);
            this.Controls.Add(this.freightElevatorsDataGridView);
            this.Name = "View1";
            this.Text = "Характеристики разногабаритных грузовых лифтов";
            this.Load += new System.EventHandler(this.View1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.factoryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freightElevatorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freightElevatorsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FactoryDBDataSet factoryDBDataSet;
        private System.Windows.Forms.BindingSource freightElevatorsBindingSource;
        private FactoryDBDataSetTableAdapters.FreightElevatorsTableAdapter freightElevatorsTableAdapter;
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
        public System.Windows.Forms.DataGridView freightElevatorsDataGridView;
    }
}