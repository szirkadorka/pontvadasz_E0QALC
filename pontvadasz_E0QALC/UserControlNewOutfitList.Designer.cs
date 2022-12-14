namespace pontvadasz_E0QALC
{
    partial class UserControlNewOutfitList
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
            this.textBoxOutfit = new System.Windows.Forms.TextBox();
            this.textBoxClothes = new System.Windows.Forms.TextBox();
            this.listBoxOutfit = new System.Windows.Forms.ListBox();
            this.listBoxClothes = new System.Windows.Forms.ListBox();
            this.listBoxOutfitList = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxOutfit
            // 
            this.textBoxOutfit.Location = new System.Drawing.Point(31, 38);
            this.textBoxOutfit.Name = "textBoxOutfit";
            this.textBoxOutfit.Size = new System.Drawing.Size(174, 23);
            this.textBoxOutfit.TabIndex = 0;
            this.textBoxOutfit.TextChanged += new System.EventHandler(this.textBoxOutfit_TextChanged);
            // 
            // textBoxClothes
            // 
            this.textBoxClothes.Location = new System.Drawing.Point(469, 38);
            this.textBoxClothes.Name = "textBoxClothes";
            this.textBoxClothes.Size = new System.Drawing.Size(173, 23);
            this.textBoxClothes.TabIndex = 1;
            this.textBoxClothes.TextChanged += new System.EventHandler(this.textBoxClothes_TextChanged);
            // 
            // listBoxOutfit
            // 
            this.listBoxOutfit.FormattingEnabled = true;
            this.listBoxOutfit.ItemHeight = 15;
            this.listBoxOutfit.Location = new System.Drawing.Point(33, 88);
            this.listBoxOutfit.Name = "listBoxOutfit";
            this.listBoxOutfit.Size = new System.Drawing.Size(172, 274);
            this.listBoxOutfit.TabIndex = 2;
            this.listBoxOutfit.SelectedIndexChanged += new System.EventHandler(this.listBoxOutfit_SelectedIndexChanged);
            // 
            // listBoxClothes
            // 
            this.listBoxClothes.FormattingEnabled = true;
            this.listBoxClothes.ItemHeight = 15;
            this.listBoxClothes.Location = new System.Drawing.Point(469, 88);
            this.listBoxClothes.Name = "listBoxClothes";
            this.listBoxClothes.Size = new System.Drawing.Size(173, 274);
            this.listBoxClothes.TabIndex = 3;
            // 
            // listBoxOutfitList
            // 
            this.listBoxOutfitList.FormattingEnabled = true;
            this.listBoxOutfitList.ItemHeight = 15;
            this.listBoxOutfitList.Location = new System.Drawing.Point(234, 87);
            this.listBoxOutfitList.Name = "listBoxOutfitList";
            this.listBoxOutfitList.Size = new System.Drawing.Size(195, 274);
            this.listBoxOutfitList.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(241, 43);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(333, 43);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.Text = "-";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // UserControlNewOutfitList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxOutfitList);
            this.Controls.Add(this.listBoxClothes);
            this.Controls.Add(this.listBoxOutfit);
            this.Controls.Add(this.textBoxClothes);
            this.Controls.Add(this.textBoxOutfit);
            this.Name = "UserControlNewOutfitList";
            this.Size = new System.Drawing.Size(689, 424);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxOutfit;
        private TextBox textBoxClothes;
        private ListBox listBoxOutfit;
        private ListBox listBoxClothes;
        private ListBox listBoxOutfitList;
        private Button buttonAdd;
        private Button buttonRemove;
    }
}
