namespace pontvadasz_E0QALC
{
    partial class UserControlNewOutfitName
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddNewName = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.outfitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outfitIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outfitNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outfitListsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outfitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.outfitIdDataGridViewTextBoxColumn,
            this.outfitNameDataGridViewTextBoxColumn,
            this.outfitListsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.outfitBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(473, 315);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonAddNewName
            // 
            this.buttonAddNewName.Location = new System.Drawing.Point(510, 146);
            this.buttonAddNewName.Name = "buttonAddNewName";
            this.buttonAddNewName.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNewName.TabIndex = 1;
            this.buttonAddNewName.Text = "NewName";
            this.buttonAddNewName.UseVisualStyleBackColor = true;
            this.buttonAddNewName.Click += new System.EventHandler(this.buttonAddNewName_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(510, 201);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // outfitBindingSource
            // 
            this.outfitBindingSource.DataSource = typeof(pontvadasz_E0QALC.Models.Outfit);
            // 
            // outfitIdDataGridViewTextBoxColumn
            // 
            this.outfitIdDataGridViewTextBoxColumn.DataPropertyName = "OutfitId";
            this.outfitIdDataGridViewTextBoxColumn.HeaderText = "OutfitId";
            this.outfitIdDataGridViewTextBoxColumn.Name = "outfitIdDataGridViewTextBoxColumn";
            // 
            // outfitNameDataGridViewTextBoxColumn
            // 
            this.outfitNameDataGridViewTextBoxColumn.DataPropertyName = "OutfitName";
            this.outfitNameDataGridViewTextBoxColumn.HeaderText = "OutfitName";
            this.outfitNameDataGridViewTextBoxColumn.Name = "outfitNameDataGridViewTextBoxColumn";
            // 
            // outfitListsDataGridViewTextBoxColumn
            // 
            this.outfitListsDataGridViewTextBoxColumn.DataPropertyName = "OutfitLists";
            this.outfitListsDataGridViewTextBoxColumn.HeaderText = "OutfitLists";
            this.outfitListsDataGridViewTextBoxColumn.Name = "outfitListsDataGridViewTextBoxColumn";
            this.outfitListsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UserControlNewOutfitName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAddNewName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControlNewOutfitName";
            this.Size = new System.Drawing.Size(627, 364);
            this.Load += new System.EventHandler(this.UserControlNewOutfitName_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outfitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonAddNewName;
        private Button buttonSave;
        private DataGridViewTextBoxColumn outfitIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn outfitNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn outfitListsDataGridViewTextBoxColumn;
        private BindingSource outfitBindingSource;
    }
}
