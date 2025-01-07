namespace Learning
{
    partial class frmCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCust_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCust_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCust_addr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCust_phone = new System.Windows.Forms.TextBox();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            btnAdd = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ຂໍ້ມູນລູກຄ້າ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCust_id
            // 
            this.txtCust_id.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCust_id.Location = new System.Drawing.Point(106, 65);
            this.txtCust_id.Name = "txtCust_id";
            this.txtCust_id.Size = new System.Drawing.Size(164, 26);
            this.txtCust_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "ປ້ອນຂໍ້ມູນ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "ລະຫັດລູກຄ້າ";
            // 
            // txtCust_name
            // 
            this.txtCust_name.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCust_name.Location = new System.Drawing.Point(106, 103);
            this.txtCust_name.Name = "txtCust_name";
            this.txtCust_name.Size = new System.Drawing.Size(225, 26);
            this.txtCust_name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "ຊື່ລູກຄ້າ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "ທີ່ຢູ່";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCust_addr
            // 
            this.txtCust_addr.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCust_addr.Location = new System.Drawing.Point(106, 140);
            this.txtCust_addr.Name = "txtCust_addr";
            this.txtCust_addr.Size = new System.Drawing.Size(538, 26);
            this.txtCust_addr.TabIndex = 6;
            this.txtCust_addr.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(346, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "ເບີໂທລະສັບ";
            // 
            // txtCust_phone
            // 
            this.txtCust_phone.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCust_phone.Location = new System.Drawing.Point(419, 99);
            this.txtCust_phone.Name = "txtCust_phone";
            this.txtCust_phone.Size = new System.Drawing.Size(225, 26);
            this.txtCust_phone.TabIndex = 8;
            // 
            // dgvShow
            // 
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Location = new System.Drawing.Point(26, 218);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.Size = new System.Drawing.Size(618, 220);
            this.dgvShow.TabIndex = 10;
            this.dgvShow.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvShow_CellMouseClick);
            // 
            // btnAdd
            // 
            btnAdd.AutoEllipsis = true;
            btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            btnAdd.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnAdd.Image = global::Learning.Properties.Resources.plus__1_;
            btnAdd.Location = new System.Drawing.Point(106, 172);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(85, 37);
            btnAdd.TabIndex = 13;
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
            btnEdit.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnEdit.Image = global::Learning.Properties.Resources.pen;
            btnEdit.Location = new System.Drawing.Point(197, 172);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(83, 37);
            btnEdit.TabIndex = 12;
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
            btnDelete.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnDelete.Image = global::Learning.Properties.Resources.bin;
            btnDelete.Location = new System.Drawing.Point(419, 172);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(88, 37);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "ລົບຂໍ້ມູນ";
            btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnEdit);
            this.Controls.Add(btnDelete);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCust_phone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCust_addr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCust_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCust_id);
            this.Controls.Add(this.label1);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCust_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCust_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCust_addr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCust_phone;
        private System.Windows.Forms.DataGridView dgvShow;
    }
}