namespace TaxCalculator
{
    partial class TaxCalculatorForm
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
            this.txtBox_Salary = new System.Windows.Forms.TextBox();
            this.btn_Cal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_CalculatedSalary = new System.Windows.Forms.Label();
            this.lbl_Tax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_Salary
            // 
            this.txtBox_Salary.Location = new System.Drawing.Point(36, 82);
            this.txtBox_Salary.Name = "txtBox_Salary";
            this.txtBox_Salary.Size = new System.Drawing.Size(153, 23);
            this.txtBox_Salary.TabIndex = 0;
            // 
            // btn_Cal
            // 
            this.btn_Cal.Location = new System.Drawing.Point(122, 222);
            this.btn_Cal.Name = "btn_Cal";
            this.btn_Cal.Size = new System.Drawing.Size(118, 56);
            this.btn_Cal.TabIndex = 2;
            this.btn_Cal.Text = "Calculate";
            this.btn_Cal.UseVisualStyleBackColor = true;
            this.btn_Cal.Click += new System.EventHandler(this.btn_Cal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(254, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tax %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(36, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Your salaray after tax";
            // 
            // lbl_CalculatedSalary
            // 
            this.lbl_CalculatedSalary.AutoSize = true;
            this.lbl_CalculatedSalary.Location = new System.Drawing.Point(36, 168);
            this.lbl_CalculatedSalary.Name = "lbl_CalculatedSalary";
            this.lbl_CalculatedSalary.Size = new System.Drawing.Size(0, 15);
            this.lbl_CalculatedSalary.TabIndex = 6;
            // 
            // lbl_Tax
            // 
            this.lbl_Tax.AutoSize = true;
            this.lbl_Tax.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Tax.Location = new System.Drawing.Point(270, 82);
            this.lbl_Tax.Name = "lbl_Tax";
            this.lbl_Tax.Size = new System.Drawing.Size(0, 30);
            this.lbl_Tax.TabIndex = 7;
            // 
            // TaxCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 299);
            this.Controls.Add(this.lbl_Tax);
            this.Controls.Add(this.lbl_CalculatedSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cal);
            this.Controls.Add(this.txtBox_Salary);
            this.Name = "TaxCalculatorForm";
            this.Text = "TaxCalculatorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBox_Salary;
        private Button btn_Cal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbl_CalculatedSalary;
        private Label lbl_Tax;
    }
}