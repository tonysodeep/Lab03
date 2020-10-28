namespace Lab03
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_diemTB = new System.Windows.Forms.TextBox();
            this.cb_nganh = new System.Windows.Forms.ComboBox();
            this.tb_ho_ten = new System.Windows.Forms.TextBox();
            this.tb_mssv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacultyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentData = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_diemTB);
            this.groupBox1.Controls.Add(this.cb_nganh);
            this.groupBox1.Controls.Add(this.tb_ho_ten);
            this.groupBox1.Controls.Add(this.tb_mssv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 226);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Sinh Viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tb_diemTB
            // 
            this.tb_diemTB.Location = new System.Drawing.Point(105, 157);
            this.tb_diemTB.Name = "tb_diemTB";
            this.tb_diemTB.Size = new System.Drawing.Size(100, 23);
            this.tb_diemTB.TabIndex = 4;
            // 
            // cb_nganh
            // 
            this.cb_nganh.FormattingEnabled = true;
            this.cb_nganh.Location = new System.Drawing.Point(105, 108);
            this.cb_nganh.Name = "cb_nganh";
            this.cb_nganh.Size = new System.Drawing.Size(146, 23);
            this.cb_nganh.TabIndex = 3;
            // 
            // tb_ho_ten
            // 
            this.tb_ho_ten.Location = new System.Drawing.Point(105, 71);
            this.tb_ho_ten.Name = "tb_ho_ten";
            this.tb_ho_ten.Size = new System.Drawing.Size(100, 23);
            this.tb_ho_ten.TabIndex = 2;
            // 
            // tb_mssv
            // 
            this.tb_mssv.Location = new System.Drawing.Point(105, 36);
            this.tb_mssv.Name = "tb_mssv";
            this.tb_mssv.Size = new System.Drawing.Size(100, 23);
            this.tb_mssv.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điểm TB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Số SV";
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(142, 309);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(62, 35);
            this.bt_add.TabIndex = 3;
            this.bt_add.Text = "Thêm";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(235, 309);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(62, 35);
            this.bt_sua.TabIndex = 3;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(325, 309);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(62, 35);
            this.bt_xoa.TabIndex = 3;
            this.bt_xoa.Text = "Xoa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "StudentID";
            this.StudentID.HeaderText = "Ma so Sinh Vien";
            this.StudentID.Name = "StudentID";
            this.StudentID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentID.Width = 150;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Ho Ten";
            this.FullName.Name = "FullName";
            this.FullName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FullName.Width = 150;
            // 
            // FacultyName
            // 
            this.FacultyName.DataPropertyName = "FacultyName";
            this.FacultyName.HeaderText = "Ten Khoa";
            this.FacultyName.Name = "FacultyName";
            this.FacultyName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FacultyName.Width = 200;
            // 
            // AverageScore
            // 
            this.AverageScore.DataPropertyName = "AverageScore";
            this.AverageScore.HeaderText = "Diem TB";
            this.AverageScore.Name = "AverageScore";
            this.AverageScore.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // studentData
            // 
            this.studentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.FullName,
            this.FacultyName,
            this.AverageScore});
            this.studentData.Location = new System.Drawing.Point(422, 60);
            this.studentData.Name = "studentData";
            this.studentData.Size = new System.Drawing.Size(641, 324);
            this.studentData.TabIndex = 1;
            this.studentData.Text = "dataGridView1";
            this.studentData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentData_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 450);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.studentData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView studentData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_diemTB;
        private System.Windows.Forms.ComboBox cb_nganh;
        private System.Windows.Forms.TextBox tb_ho_ten;
        private System.Windows.Forms.TextBox tb_mssv;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacultyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageScore;
    }
}

