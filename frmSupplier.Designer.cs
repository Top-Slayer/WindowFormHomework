namespace Learning
{
    partial class frmSupplier
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvShowData = new System.Windows.Forms.DataGridView();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addr = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.phoneNum = new System.Windows.Forms.TextBox();
            this.contactName = new System.Windows.Forms.TextBox();
            this.supName = new System.Windows.Forms.TextBox();
            this.supID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(226, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "ຟ້ອມຂໍ້ມູນຜູ້ສະໜອງ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.dgvShowData);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.addr);
            this.panel2.Controls.Add(this.email);
            this.panel2.Controls.Add(this.phoneNum);
            this.panel2.Controls.Add(this.contactName);
            this.panel2.Controls.Add(this.supName);
            this.panel2.Controls.Add(this.supID);
            this.panel2.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(8, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 398);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dgvShowData
            // 
            this.dgvShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowData.Location = new System.Drawing.Point(28, 234);
            this.dgvShowData.Name = "dgvShowData";
            this.dgvShowData.Size = new System.Drawing.Size(527, 150);
            this.dgvShowData.TabIndex = 3;
            this.dgvShowData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowData_CellClick);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Red;
            this.btnDel.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(430, 191);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "ລົບຂໍ້ມູນ";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEdit.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(282, 191);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "ແກ້ໄຂຂໍ້ມູນ";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAdd.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(140, 191);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ເພີ່ມຂໍ້ມູນ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(281, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "ອີເມວ:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "ທີ່ຢູ່:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "ເບີໂທຕິດຕໍ່:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "ຊື່ຜູ້ຕິດຕໍ່:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "ຊື່ບໍລິສັດ:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "ລະຫັດຜູ້ສະໜອງ:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ຮັບຂໍ້ມູນຜູ້ສະໜອງ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addr
            // 
            this.addr.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addr.Location = new System.Drawing.Point(140, 116);
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(374, 26);
            this.addr.TabIndex = 0;
            this.addr.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(323, 142);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(191, 26);
            this.email.TabIndex = 0;
            this.email.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // phoneNum
            // 
            this.phoneNum.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNum.Location = new System.Drawing.Point(140, 142);
            this.phoneNum.Name = "phoneNum";
            this.phoneNum.Size = new System.Drawing.Size(135, 26);
            this.phoneNum.TabIndex = 0;
            this.phoneNum.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // contactName
            // 
            this.contactName.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactName.Location = new System.Drawing.Point(140, 90);
            this.contactName.Name = "contactName";
            this.contactName.Size = new System.Drawing.Size(374, 26);
            this.contactName.TabIndex = 0;
            this.contactName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // supName
            // 
            this.supName.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supName.Location = new System.Drawing.Point(140, 64);
            this.supName.Name = "supName";
            this.supName.Size = new System.Drawing.Size(374, 26);
            this.supName.TabIndex = 0;
            this.supName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // supID
            // 
            this.supID.Font = new System.Drawing.Font("Noto Sans Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supID.Location = new System.Drawing.Point(140, 38);
            this.supID.Name = "supID";
            this.supID.Size = new System.Drawing.Size(374, 26);
            this.supID.TabIndex = 0;
            this.supID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 33);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmSupplier";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.frmSupplier_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addr;
        private System.Windows.Forms.TextBox phoneNum;
        private System.Windows.Forms.TextBox contactName;
        private System.Windows.Forms.TextBox supName;
        private System.Windows.Forms.TextBox supID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.DataGridView dgvShowData;
    }
}