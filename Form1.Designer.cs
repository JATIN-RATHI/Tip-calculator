namespace Tip_Calculator
{
    partial class tip_calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tip_calculator));
            this.bill_label = new System.Windows.Forms.Label();
            this.tip_percentage = new System.Windows.Forms.Label();
            this.number_of_people = new System.Windows.Forms.Label();
            this.bill_amount_input = new System.Windows.Forms.TextBox();
            this.tip_input = new System.Windows.Forms.NumericUpDown();
            this.total_people_input = new System.Windows.Forms.NumericUpDown();
            this.tip_per = new System.Windows.Forms.Label();
            this.per_person = new System.Windows.Forms.Label();
            this.total_per = new System.Windows.Forms.Label();
            this.total_per_person = new System.Windows.Forms.Label();
            this.tip_amt_per_person = new System.Windows.Forms.Label();
            this.total_amt_per_person = new System.Windows.Forms.Label();
            this.alert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tip_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total_people_input)).BeginInit();
            this.SuspendLayout();
            // 
            // bill_label
            // 
            this.bill_label.AutoSize = true;
            this.bill_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bill_label.Location = new System.Drawing.Point(51, 104);
            this.bill_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bill_label.Name = "bill_label";
            this.bill_label.Size = new System.Drawing.Size(38, 28);
            this.bill_label.TabIndex = 0;
            this.bill_label.Text = "Bill";
            this.bill_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // tip_percentage
            // 
            this.tip_percentage.AutoSize = true;
            this.tip_percentage.Location = new System.Drawing.Point(51, 219);
            this.tip_percentage.Name = "tip_percentage";
            this.tip_percentage.Size = new System.Drawing.Size(60, 28);
            this.tip_percentage.TabIndex = 1;
            this.tip_percentage.Text = "Tip %";
            // 
            // number_of_people
            // 
            this.number_of_people.AutoSize = true;
            this.number_of_people.Location = new System.Drawing.Point(51, 329);
            this.number_of_people.Name = "number_of_people";
            this.number_of_people.Size = new System.Drawing.Size(173, 28);
            this.number_of_people.TabIndex = 2;
            this.number_of_people.Text = "Number of people";
            this.number_of_people.Click += new System.EventHandler(this.label3_Click);
            // 
            // bill_amount_input
            // 
            this.bill_amount_input.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bill_amount_input.Location = new System.Drawing.Point(51, 153);
            this.bill_amount_input.Name = "bill_amount_input";
            this.bill_amount_input.Size = new System.Drawing.Size(332, 43);
            this.bill_amount_input.TabIndex = 3;
            this.bill_amount_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bill_amount_input.TextChanged += new System.EventHandler(this.bill_amount_input_TextChanged);
            // 
            // tip_input
            // 
            this.tip_input.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tip_input.Location = new System.Drawing.Point(51, 259);
            this.tip_input.Name = "tip_input";
            this.tip_input.Size = new System.Drawing.Size(332, 43);
            this.tip_input.TabIndex = 4;
            this.tip_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tip_input.ValueChanged += new System.EventHandler(this.tip_input_ValueChanged);
            // 
            // total_people_input
            // 
            this.total_people_input.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.total_people_input.Location = new System.Drawing.Point(51, 369);
            this.total_people_input.Name = "total_people_input";
            this.total_people_input.Size = new System.Drawing.Size(329, 43);
            this.total_people_input.TabIndex = 4;
            this.total_people_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.total_people_input.ValueChanged += new System.EventHandler(this.total_people_input_ValueChanged);
            // 
            // tip_per
            // 
            this.tip_per.AutoSize = true;
            this.tip_per.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tip_per.Location = new System.Drawing.Point(517, 193);
            this.tip_per.Name = "tip_per";
            this.tip_per.Size = new System.Drawing.Size(66, 38);
            this.tip_per.TabIndex = 5;
            this.tip_per.Text = "Tip ";
            // 
            // per_person
            // 
            this.per_person.AutoSize = true;
            this.per_person.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.per_person.Location = new System.Drawing.Point(517, 231);
            this.per_person.Name = "per_person";
            this.per_person.Size = new System.Drawing.Size(106, 28);
            this.per_person.TabIndex = 6;
            this.per_person.Text = "per person";
            // 
            // total_per
            // 
            this.total_per.AutoSize = true;
            this.total_per.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.total_per.Location = new System.Drawing.Point(517, 311);
            this.total_per.Name = "total_per";
            this.total_per.Size = new System.Drawing.Size(81, 38);
            this.total_per.TabIndex = 7;
            this.total_per.Text = "Total";
            // 
            // total_per_person
            // 
            this.total_per_person.AutoSize = true;
            this.total_per_person.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.total_per_person.Location = new System.Drawing.Point(518, 349);
            this.total_per_person.Name = "total_per_person";
            this.total_per_person.Size = new System.Drawing.Size(106, 28);
            this.total_per_person.TabIndex = 8;
            this.total_per_person.Text = "per person";
            // 
            // tip_amt_per_person
            // 
            this.tip_amt_per_person.AutoSize = true;
            this.tip_amt_per_person.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tip_amt_per_person.Location = new System.Drawing.Point(688, 178);
            this.tip_amt_per_person.Name = "tip_amt_per_person";
            this.tip_amt_per_person.Size = new System.Drawing.Size(210, 81);
            this.tip_amt_per_person.TabIndex = 9;
            this.tip_amt_per_person.Text = "_______";
            this.tip_amt_per_person.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tip_amt_per_person.Click += new System.EventHandler(this.tip_amt_per_person_Click);
            // 
            // total_amt_per_person
            // 
            this.total_amt_per_person.AutoSize = true;
            this.total_amt_per_person.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.total_amt_per_person.Location = new System.Drawing.Point(647, 271);
            this.total_amt_per_person.Name = "total_amt_per_person";
            this.total_amt_per_person.Size = new System.Drawing.Size(276, 106);
            this.total_amt_per_person.TabIndex = 10;
            this.total_amt_per_person.Text = "_______";
            this.total_amt_per_person.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.total_amt_per_person.Click += new System.EventHandler(this.total_amt_per_person_Click);
            // 
            // alert
            // 
            this.alert.AutoSize = true;
            this.alert.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alert.ForeColor = System.Drawing.Color.Red;
            this.alert.Location = new System.Drawing.Point(51, 199);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(0, 17);
            this.alert.TabIndex = 11;
            // 
            // tip_calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.alert);
            this.Controls.Add(this.total_amt_per_person);
            this.Controls.Add(this.tip_amt_per_person);
            this.Controls.Add(this.total_per_person);
            this.Controls.Add(this.total_per);
            this.Controls.Add(this.per_person);
            this.Controls.Add(this.tip_per);
            this.Controls.Add(this.total_people_input);
            this.Controls.Add(this.tip_input);
            this.Controls.Add(this.bill_amount_input);
            this.Controls.Add(this.number_of_people);
            this.Controls.Add(this.tip_percentage);
            this.Controls.Add(this.bill_label);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "tip_calculator";
            this.Text = "Tip Calculator";
            this.Load += new System.EventHandler(this.tip_calculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tip_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total_people_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bill_label;
        private System.Windows.Forms.Label tip_percentage;
        private System.Windows.Forms.Label number_of_people;
        private System.Windows.Forms.TextBox bill_amount_input;
        private System.Windows.Forms.NumericUpDown tip_input;
        private System.Windows.Forms.NumericUpDown total_people_input;
        private System.Windows.Forms.Label tip_per;
        private System.Windows.Forms.Label per_person;
        private System.Windows.Forms.Label total_per;
        private System.Windows.Forms.Label total_per_person;
        private System.Windows.Forms.Label tip_amt_per_person;
        private System.Windows.Forms.Label total_amt_per_person;
        private System.Windows.Forms.Label alert;
    }
}

