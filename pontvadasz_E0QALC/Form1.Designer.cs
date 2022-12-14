namespace pontvadasz_E0QALC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNewOutfitList = new System.Windows.Forms.Button();
            this.buttonNewOutfitName = new System.Windows.Forms.Button();
            this.buttonClothesNumber = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonNewOutfitList
            // 
            this.buttonNewOutfitList.Location = new System.Drawing.Point(12, 49);
            this.buttonNewOutfitList.Name = "buttonNewOutfitList";
            this.buttonNewOutfitList.Size = new System.Drawing.Size(120, 39);
            this.buttonNewOutfitList.TabIndex = 0;
            this.buttonNewOutfitList.Text = "NewOutfitList";
            this.buttonNewOutfitList.UseVisualStyleBackColor = true;
            this.buttonNewOutfitList.Click += new System.EventHandler(this.buttonNewOutfitList_Click);
            // 
            // buttonNewOutfitName
            // 
            this.buttonNewOutfitName.Location = new System.Drawing.Point(12, 167);
            this.buttonNewOutfitName.Name = "buttonNewOutfitName";
            this.buttonNewOutfitName.Size = new System.Drawing.Size(120, 44);
            this.buttonNewOutfitName.TabIndex = 1;
            this.buttonNewOutfitName.Text = "NewOutfitName";
            this.buttonNewOutfitName.UseVisualStyleBackColor = true;
            this.buttonNewOutfitName.Click += new System.EventHandler(this.buttonNewOutfitName_Click);
            // 
            // buttonClothesNumber
            // 
            this.buttonClothesNumber.Location = new System.Drawing.Point(12, 290);
            this.buttonClothesNumber.Name = "buttonClothesNumber";
            this.buttonClothesNumber.Size = new System.Drawing.Size(120, 44);
            this.buttonClothesNumber.TabIndex = 2;
            this.buttonClothesNumber.Text = "ClothesNumber";
            this.buttonClothesNumber.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(138, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 426);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonClothesNumber);
            this.Controls.Add(this.buttonNewOutfitName);
            this.Controls.Add(this.buttonNewOutfitList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonNewOutfitList;
        private Button buttonNewOutfitName;
        private Button buttonClothesNumber;
        private Panel panel1;
    }
}