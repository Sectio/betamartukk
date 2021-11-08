namespace Betamartukk
{
    partial class frmEditProduct
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
            this.Label1 = new System.Windows.Forms.Label();
            this.txtPROCODE = new System.Windows.Forms.TextBox();
            this.TXTDESC = new System.Windows.Forms.RichTextBox();
            this.TXTPRICE = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TXTPRONAME = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.BTNSAVE = new System.Windows.Forms.Button();
            this.cboCateg = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(54, 65);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 15);
            this.Label1.TabIndex = 68;
            this.Label1.Text = "Code :";
            // 
            // txtPROCODE
            // 
            this.txtPROCODE.Enabled = false;
            this.txtPROCODE.Location = new System.Drawing.Point(145, 65);
            this.txtPROCODE.Name = "txtPROCODE";
            this.txtPROCODE.Size = new System.Drawing.Size(339, 20);
            this.txtPROCODE.TabIndex = 67;
            // 
            // TXTDESC
            // 
            this.TXTDESC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTDESC.Location = new System.Drawing.Point(145, 132);
            this.TXTDESC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTDESC.Name = "TXTDESC";
            this.TXTDESC.Size = new System.Drawing.Size(339, 60);
            this.TXTDESC.TabIndex = 60;
            this.TXTDESC.Text = "";
            // 
            // TXTPRICE
            // 
            this.TXTPRICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTPRICE.Location = new System.Drawing.Point(145, 235);
            this.TXTPRICE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTPRICE.Name = "TXTPRICE";
            this.TXTPRICE.Size = new System.Drawing.Size(99, 30);
            this.TXTPRICE.TabIndex = 61;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(49, 102);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(53, 15);
            this.Label2.TabIndex = 62;
            this.Label2.Text = "Name :";
            // 
            // TXTPRONAME
            // 
            this.TXTPRONAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTPRONAME.Location = new System.Drawing.Point(145, 99);
            this.TXTPRONAME.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTPRONAME.Name = "TXTPRONAME";
            this.TXTPRONAME.Size = new System.Drawing.Size(339, 23);
            this.TXTPRONAME.TabIndex = 59;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(49, 135);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(47, 15);
            this.Label3.TabIndex = 63;
            this.Label3.Text = "Desc :";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(49, 235);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(48, 15);
            this.Label6.TabIndex = 64;
            this.Label6.Text = "Price :";
            // 
            // BTNSAVE
            // 
            this.BTNSAVE.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTNSAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSAVE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNSAVE.Location = new System.Drawing.Point(387, 320);
            this.BTNSAVE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNSAVE.Name = "BTNSAVE";
            this.BTNSAVE.Size = new System.Drawing.Size(97, 32);
            this.BTNSAVE.TabIndex = 56;
            this.BTNSAVE.Text = "Save";
            this.BTNSAVE.UseVisualStyleBackColor = false;
            this.BTNSAVE.Click += new System.EventHandler(this.saveclick);
            // 
            // cboCateg
            // 
            this.cboCateg.AutoCompleteCustomSource.AddRange(new string[] {
            "Makanan ",
            "Minuman"});
            this.cboCateg.FormattingEnabled = true;
            this.cboCateg.Items.AddRange(new object[] {
            "Makanan",
            "Minuman",
            "Pemanis"});
            this.cboCateg.Location = new System.Drawing.Point(145, 199);
            this.cboCateg.Name = "cboCateg";
            this.cboCateg.Size = new System.Drawing.Size(339, 21);
            this.cboCateg.TabIndex = 69;
            this.cboCateg.Text = "Select";
            this.cboCateg.SelectedIndexChanged += new System.EventHandler(this.cboCateg_SelectedIndexChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(49, 200);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(75, 15);
            this.Label7.TabIndex = 65;
            this.Label7.Text = "Category : ";
            // 
            // frmEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 400);
            this.Controls.Add(this.cboCateg);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtPROCODE);
            this.Controls.Add(this.TXTDESC);
            this.Controls.Add(this.TXTPRICE);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TXTPRONAME);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.BTNSAVE);
            this.Name = "frmEditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Product";
            this.Load += new System.EventHandler(this.editproduct);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtPROCODE;
        internal System.Windows.Forms.RichTextBox TXTDESC;
        internal System.Windows.Forms.TextBox TXTPRICE;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TXTPRONAME;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button BTNSAVE;
        internal System.Windows.Forms.ComboBox cboCateg;
        internal System.Windows.Forms.Label Label7;
    }
}