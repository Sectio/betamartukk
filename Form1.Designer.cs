namespace Betamartukk
{
    partial class Form1
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tsBread = new System.Windows.Forms.ToolStripButton();
            this.tsListofProducts = new System.Windows.Forms.ToolStripButton();
            this.tsUser = new System.Windows.Forms.ToolStripButton();
            this.tsLogin = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(60, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBread,
            this.tsListofProducts,
            this.tsUser,
            this.tsLogin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(333, 72);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BakeryInventorySystem.Properties.Resources.Frame_1__1_1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 104);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tsBread
            // 
            this.tsBread.Image = global::BakeryInventorySystem.Properties.Resources.download11;
            this.tsBread.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBread.Name = "tsBread";
            this.tsBread.Size = new System.Drawing.Size(64, 69);
            this.tsBread.Text = "Product";
            this.tsBread.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBread.Click += new System.EventHandler(this.addproducts);
            // 
            // tsListofProducts
            // 
            this.tsListofProducts.Image = global::BakeryInventorySystem.Properties.Resources._12169952;
            this.tsListofProducts.Name = "tsListofProducts";
            this.tsListofProducts.Size = new System.Drawing.Size(93, 69);
            this.tsListofProducts.Text = "List of Products";
            this.tsListofProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsListofProducts.Click += new System.EventHandler(this.listProducts);
            // 
            // tsUser
            // 
            this.tsUser.Image = global::BakeryInventorySystem.Properties.Resources._6633281;
            this.tsUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUser.Name = "tsUser";
            this.tsUser.Size = new System.Drawing.Size(85, 69);
            this.tsUser.Text = "Manage Users";
            this.tsUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsUser.Click += new System.EventHandler(this.user);
            // 
            // tsLogin
            // 
            this.tsLogin.Image = global::BakeryInventorySystem.Properties.Resources.images;
            this.tsLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLogin.Name = "tsLogin";
            this.tsLogin.Size = new System.Drawing.Size(64, 69);
            this.tsLogin.Text = "Login";
            this.tsLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsLogin.Click += new System.EventHandler(this.login);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 176);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BetaMart";
            this.Load += new System.EventHandler(this.Switch);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBread;
        private System.Windows.Forms.ToolStripButton tsUser;
        private System.Windows.Forms.ToolStripButton tsLogin;
        private System.Windows.Forms.ToolStripButton tsListofProducts;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}