namespace Betamartukk
{
    partial class frmListofProducts
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
            this.DTGLIST = new System.Windows.Forms.DataGridView();
            this.Label2 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGLIST)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTGLIST
            // 
            this.DTGLIST.AllowUserToAddRows = false;
            this.DTGLIST.AllowUserToDeleteRows = false;
            this.DTGLIST.AllowUserToResizeColumns = false;
            this.DTGLIST.AllowUserToResizeRows = false;
            this.DTGLIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DTGLIST.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DTGLIST.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DTGLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGLIST.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DTGLIST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTGLIST.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DTGLIST.Location = new System.Drawing.Point(0, 39);
            this.DTGLIST.Margin = new System.Windows.Forms.Padding(2);
            this.DTGLIST.Name = "DTGLIST";
            this.DTGLIST.RowHeadersVisible = false;
            this.DTGLIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGLIST.Size = new System.Drawing.Size(861, 338);
            this.DTGLIST.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Gray;
            this.Label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label2.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(0, 0);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(861, 39);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "List Products";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.DTGLIST);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Location = new System.Drawing.Point(13, 12);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(863, 379);
            this.Panel1.TabIndex = 21;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Location = new System.Drawing.Point(455, 414);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 35);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.refreshclick);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNew.Location = new System.Drawing.Point(349, 414);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(86, 35);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.newclick);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(349, 466);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 35);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.editclick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(455, 466);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 35);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.delleteclick);
            // 
            // frmListofProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(888, 524);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Name = "frmListofProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of Products";
            this.Load += new System.EventHandler(this.frmListProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGLIST)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView DTGLIST;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Button btnDelete;
    }
}