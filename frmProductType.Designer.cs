namespace Learning
{
    partial class frmProductType
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
            System.Windows.Forms.Button btnAdd;
            System.Windows.Forms.Button btnEdit;
            System.Windows.Forms.Button btnDelete;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.txtPtTypeName = new System.Windows.Forms.TextBox();
            this.txtPtTypeID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.AutoEllipsis = true;
            btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            btnAdd.Font = new System.Drawing.Font("Noto Sans Lao", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnAdd.Image = global::Learning.Properties.Resources.plus__1_;
            btnAdd.Location = new System.Drawing.Point(49, 321);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(85, 37);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "ເພີ່ມຂໍ້ມູນ";
            btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            btnEdit.AutoEllipsis = true;
            btnEdit.BackColor = System.Drawing.Color.Teal;
            btnEdit.Font = new System.Drawing.Font("Noto Sans Lao", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnEdit.Image = global::Learning.Properties.Resources.pen;
            btnEdit.Location = new System.Drawing.Point(140, 321);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(83, 37);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "ແກ້ໄຂຂໍ້ມູນ";
            btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            btnDelete.AutoEllipsis = true;
            btnDelete.BackColor = System.Drawing.Color.Firebrick;
            btnDelete.Font = new System.Drawing.Font("Noto Sans Lao", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnDelete.Image = global::Learning.Properties.Resources.bin;
            btnDelete.Location = new System.Drawing.Point(229, 321);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(88, 37);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "ລົບຂໍ້ມູນ";
            btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Noto Sans Lao", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(24, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 33);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Lao", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ຟ້ອມຂໍ້ມູນປະເພດສິນຄ້າ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.dgvShow);
            this.panel2.Controls.Add(btnAdd);
            this.panel2.Controls.Add(btnEdit);
            this.panel2.Controls.Add(btnDelete);
            this.panel2.Controls.Add(this.txtPtTypeName);
            this.panel2.Controls.Add(this.txtPtTypeID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Noto Sans Lao", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(24, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 377);
            this.panel2.TabIndex = 0;
            // 
            // dgvShow
            // 
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Location = new System.Drawing.Point(335, 17);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.Size = new System.Drawing.Size(288, 341);
            this.dgvShow.TabIndex = 10;
            this.dgvShow.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvShow_CellMouseClick);
            // 
            // txtPtTypeName
            // 
            this.txtPtTypeName.Font = new System.Drawing.Font("Noto Sans Lao", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPtTypeName.Location = new System.Drawing.Point(122, 83);
            this.txtPtTypeName.Multiline = true;
            this.txtPtTypeName.Name = "txtPtTypeName";
            this.txtPtTypeName.Size = new System.Drawing.Size(195, 225);
            this.txtPtTypeName.TabIndex = 4;
            // 
            // txtPtTypeID
            // 
            this.txtPtTypeID.Font = new System.Drawing.Font("Noto Sans Lao", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPtTypeID.Location = new System.Drawing.Point(122, 47);
            this.txtPtTypeID.Name = "txtPtTypeID";
            this.txtPtTypeID.Size = new System.Drawing.Size(195, 27);
            this.txtPtTypeID.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans Lao", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "ຊື່ປະເພດສິນຄ້າ: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans Lao", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "ລະຫັດປະເພດ: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans Lao", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ຮັບຂໍ້ມູນສິນຄ້າ";
            // 
            // frmProductType
            // 
            this.AccessibleDescription = "           ";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmProductType";
            this.Text = "frmProductType";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPtTypeName;
        private System.Windows.Forms.TextBox txtPtTypeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvShow;
    }
}