namespace EF3Last
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
            this.cmboxDep = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDeapartment = new System.Windows.Forms.TextBox();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.txtEmpFnm = new System.Windows.Forms.TextBox();
            this.txtEmpLnm = new System.Windows.Forms.TextBox();
            this.txtEmpSal = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.listBoxEmps = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmboxDep
            // 
            this.cmboxDep.FormattingEnabled = true;
            this.cmboxDep.Location = new System.Drawing.Point(135, 28);
            this.cmboxDep.Name = "cmboxDep";
            this.cmboxDep.Size = new System.Drawing.Size(198, 21);
            this.cmboxDep.TabIndex = 0;
            this.cmboxDep.SelectedIndexChanged += new System.EventHandler(this.cmboxDep_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDeapartment
            // 
            this.txtDeapartment.Location = new System.Drawing.Point(135, 72);
            this.txtDeapartment.Name = "txtDeapartment";
            this.txtDeapartment.Size = new System.Drawing.Size(198, 20);
            this.txtDeapartment.TabIndex = 2;
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(485, 146);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(100, 20);
            this.txtEmpId.TabIndex = 3;
            // 
            // txtEmpFnm
            // 
            this.txtEmpFnm.Location = new System.Drawing.Point(485, 183);
            this.txtEmpFnm.Name = "txtEmpFnm";
            this.txtEmpFnm.Size = new System.Drawing.Size(100, 20);
            this.txtEmpFnm.TabIndex = 4;
            // 
            // txtEmpLnm
            // 
            this.txtEmpLnm.Location = new System.Drawing.Point(485, 225);
            this.txtEmpLnm.Name = "txtEmpLnm";
            this.txtEmpLnm.Size = new System.Drawing.Size(100, 20);
            this.txtEmpLnm.TabIndex = 5;
            // 
            // txtEmpSal
            // 
            this.txtEmpSal.Location = new System.Drawing.Point(485, 265);
            this.txtEmpSal.Name = "txtEmpSal";
            this.txtEmpSal.Size = new System.Drawing.Size(100, 20);
            this.txtEmpSal.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "New";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(258, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(449, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Department Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Department Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Employee Id";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Employee Fname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Employee Lname";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Employee Salary";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(510, 31);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "Update";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(449, 79);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 20;
            this.button7.Text = "delete";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // listBoxEmps
            // 
            this.listBoxEmps.FormattingEnabled = true;
            this.listBoxEmps.Location = new System.Drawing.Point(135, 146);
            this.listBoxEmps.Name = "listBoxEmps";
            this.listBoxEmps.Size = new System.Drawing.Size(198, 134);
            this.listBoxEmps.TabIndex = 21;
            this.listBoxEmps.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Employees";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 385);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxEmps);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtEmpSal);
            this.Controls.Add(this.txtEmpLnm);
            this.Controls.Add(this.txtEmpFnm);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.txtDeapartment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmboxDep);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboxDep;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDeapartment;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.TextBox txtEmpFnm;
        private System.Windows.Forms.TextBox txtEmpLnm;
        private System.Windows.Forms.TextBox txtEmpSal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListBox listBoxEmps;
        private System.Windows.Forms.Label label7;
    }
}

