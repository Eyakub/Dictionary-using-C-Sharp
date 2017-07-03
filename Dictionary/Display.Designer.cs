namespace Dictionary
{
    partial class Display
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
            this.btnDelete = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialFlatButton();
            this.mydicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydicDataGridView = new System.Windows.Forms.DataGridView();
            this.mydicBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new Dictionary.AppData();
            this.mydicTableAdapter1 = new Dictionary.AppDataTableAdapters.mydicTableAdapter();
            this.tableAdapterManager1 = new Dictionary.AppDataTableAdapters.TableAdapterManager();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mydicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydicDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydicBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Depth = 0;
            this.btnDelete.Location = new System.Drawing.Point(293, 379);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Primary = false;
            this.btnDelete.Size = new System.Drawing.Size(60, 36);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Location = new System.Drawing.Point(379, 379);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = false;
            this.btnUpdate.Size = new System.Drawing.Size(64, 36);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // mydicBindingSource
            // 
            this.mydicBindingSource.DataMember = "mydic";
            // 
            // dicBindingSource
            // 
            this.dicBindingSource.DataMember = "dic";
            // 
            // mydicDataGridView
            // 
            this.mydicDataGridView.AutoGenerateColumns = false;
            this.mydicDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mydicDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.mydicDataGridView.DataSource = this.mydicBindingSource1;
            this.mydicDataGridView.Location = new System.Drawing.Point(0, 64);
            this.mydicDataGridView.Name = "mydicDataGridView";
            this.mydicDataGridView.Size = new System.Drawing.Size(693, 288);
            this.mydicDataGridView.TabIndex = 2;
            // 
            // mydicBindingSource1
            // 
            this.mydicBindingSource1.DataMember = "mydic";
            this.mydicBindingSource1.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mydicTableAdapter1
            // 
            this.mydicTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.mydicTableAdapter = this.mydicTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Dictionary.AppDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "word";
            this.dataGridViewTextBoxColumn2.HeaderText = "word";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "mean";
            this.dataGridViewTextBoxColumn3.HeaderText = "mean";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 435);
            this.Controls.Add(this.mydicDataGridView);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Name = "Display";
            this.Text = "Display";
            this.Load += new System.EventHandler(this.Display_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mydicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydicDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydicBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private DictionaryDBDataSet dictionaryDBDataSet;
        private System.Windows.Forms.BindingSource dicBindingSource;
        //private DictionaryDBDataSetTableAdapters.dicTableAdapter dicTableAdapter;
        private MaterialSkin.Controls.MaterialFlatButton btnDelete;
        private MaterialSkin.Controls.MaterialFlatButton btnUpdate;
        //private dictionaryDataSet dictionaryDataSet;
        private System.Windows.Forms.BindingSource mydicBindingSource;
        //private dictionaryDataSetTableAdapters.mydicTableAdapter mydicTableAdapter;
        //private dictionaryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AppData appData;
        private System.Windows.Forms.BindingSource mydicBindingSource1;
        private AppDataTableAdapters.mydicTableAdapter mydicTableAdapter1;
        private AppDataTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView mydicDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}