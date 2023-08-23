
namespace Simple_Salary_System
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
            this.btnCalculateSalary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWorkHour = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEducationDegree = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSalaryPerHour = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculateSalary
            // 
            this.btnCalculateSalary.Location = new System.Drawing.Point(187, 190);
            this.btnCalculateSalary.Name = "btnCalculateSalary";
            this.btnCalculateSalary.Size = new System.Drawing.Size(113, 23);
            this.btnCalculateSalary.TabIndex = 0;
            this.btnCalculateSalary.Text = "Calculate";
            this.btnCalculateSalary.UseVisualStyleBackColor = true;
            this.btnCalculateSalary.Click += new System.EventHandler(this.btnCalculateSalary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Education Degree";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Work Hour";
            // 
            // txtWorkHour
            // 
            this.txtWorkHour.Location = new System.Drawing.Point(187, 139);
            this.txtWorkHour.Name = "txtWorkHour";
            this.txtWorkHour.Size = new System.Drawing.Size(113, 20);
            this.txtWorkHour.TabIndex = 4;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(187, 246);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(113, 20);
            this.txtSalary.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salary";
            // 
            // cmbEducationDegree
            // 
            this.cmbEducationDegree.FormattingEnabled = true;
            this.cmbEducationDegree.Items.AddRange(new object[] {
            "Associate",
            "Bachelor",
            "Master",
            "Doctoral"});
            this.cmbEducationDegree.Location = new System.Drawing.Point(187, 73);
            this.cmbEducationDegree.Name = "cmbEducationDegree";
            this.cmbEducationDegree.Size = new System.Drawing.Size(113, 21);
            this.cmbEducationDegree.TabIndex = 7;
            this.cmbEducationDegree.SelectedIndexChanged += new System.EventHandler(this.cmbEducationDegree_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Salary per Hour (Base On Educational Degree) :";
            // 
            // lblSalaryPerHour
            // 
            this.lblSalaryPerHour.AutoSize = true;
            this.lblSalaryPerHour.Location = new System.Drawing.Point(293, 110);
            this.lblSalaryPerHour.Name = "lblSalaryPerHour";
            this.lblSalaryPerHour.Size = new System.Drawing.Size(0, 13);
            this.lblSalaryPerHour.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 414);
            this.Controls.Add(this.lblSalaryPerHour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEducationDegree);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtWorkHour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculateSalary);
            this.Name = "Form1";
            this.Text = "Salary Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWorkHour;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEducationDegree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSalaryPerHour;
    }
}

