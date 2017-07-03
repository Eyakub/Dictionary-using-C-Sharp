namespace Dictionary
{
    partial class AddDictionary
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAdd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mydicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new Dictionary.AppData();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.mydicTableAdapter = new Dictionary.AppDataTableAdapters.mydicTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mydicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(183, 295);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 63);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(110, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "MDES Dictionary";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 334);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 55);
            this.panel2.TabIndex = 11;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(16, 128);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(74, 19);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Add Word";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(15, 213);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(96, 19);
            this.materialLabel2.TabIndex = 14;
            this.materialLabel2.Text = "Add Meaning";
            // 
            // txtAdd
            // 
            this.txtAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mydicBindingSource, "word", true));
            this.txtAdd.Depth = 0;
            this.txtAdd.Hint = "";
            this.txtAdd.Location = new System.Drawing.Point(136, 128);
            this.txtAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(174, 23);
            this.txtAdd.TabIndex = 15;
            // 
            // mydicBindingSource
            // 
            this.mydicBindingSource.DataMember = "mydic";
            this.mydicBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMeaning
            // 
            this.txtMeaning.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mydicBindingSource, "mean", true));
            this.txtMeaning.Location = new System.Drawing.Point(136, 198);
            this.txtMeaning.Multiline = true;
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(174, 70);
            this.txtMeaning.TabIndex = 4;
            // 
            // mydicTableAdapter
            // 
            this.mydicTableAdapter.ClearBeforeFill = true;
            // 
            // AddDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 389);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMeaning);
            this.Controls.Add(this.btnInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "AddDictionary";
            this.Text = "AddDictionary";
            this.Load += new System.EventHandler(this.AddDictionary_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mydicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAdd;
        private System.Windows.Forms.TextBox txtMeaning;
        private AppData appData;
        private System.Windows.Forms.BindingSource mydicBindingSource;
        private AppDataTableAdapters.mydicTableAdapter mydicTableAdapter;
    }
}