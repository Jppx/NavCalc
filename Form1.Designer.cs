namespace TestNav
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCurLat = new TextBox();
            txtCurLng = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            txtDesLat = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtDesLng = new TextBox();
            lblRange = new Label();
            lblBearing = new Label();
            panel3 = new Panel();
            lblError = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 261);
            button1.Name = "button1";
            button1.Size = new Size(161, 23);
            button1.TabIndex = 0;
            button1.Text = "Calc Range and Bearing";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(283, 21);
            label1.TabIndex = 1;
            label1.Text = "Enter Lat/Lon start and end position";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(14, 49);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 2;
            label2.Text = "Lat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(235, 49);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 3;
            label3.Text = "Lon";
            // 
            // txtCurLat
            // 
            txtCurLat.ForeColor = Color.Black;
            txtCurLat.Location = new Point(44, 46);
            txtCurLat.Name = "txtCurLat";
            txtCurLat.Size = new Size(161, 23);
            txtCurLat.TabIndex = 5;
            // 
            // txtCurLng
            // 
            txtCurLng.ForeColor = Color.Black;
            txtCurLng.Location = new Point(268, 46);
            txtCurLng.Name = "txtCurLng";
            txtCurLng.Size = new Size(171, 23);
            txtCurLng.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtCurLat);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtCurLng);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(12, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 90);
            panel1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(6, 13);
            label6.Name = "label6";
            label6.Size = new Size(200, 17);
            label6.TabIndex = 7;
            label6.Text = "Start Location (degrees digital)";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtDesLat);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtDesLng);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(12, 151);
            panel2.Name = "panel2";
            panel2.Size = new Size(463, 90);
            panel2.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(6, 13);
            label7.Name = "label7";
            label7.Size = new Size(243, 17);
            label7.TabIndex = 7;
            label7.Text = "Destination Location (degrees digital)";
            // 
            // txtDesLat
            // 
            txtDesLat.ForeColor = Color.Black;
            txtDesLat.Location = new Point(44, 46);
            txtDesLat.Name = "txtDesLat";
            txtDesLat.Size = new Size(161, 23);
            txtDesLat.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(14, 49);
            label8.Name = "label8";
            label8.Size = new Size(24, 15);
            label8.TabIndex = 2;
            label8.Text = "Lat";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(235, 49);
            label9.Name = "label9";
            label9.Size = new Size(27, 15);
            label9.TabIndex = 3;
            label9.Text = "Lon";
            // 
            // txtDesLng
            // 
            txtDesLng.ForeColor = Color.Black;
            txtDesLng.Location = new Point(268, 46);
            txtDesLng.Name = "txtDesLng";
            txtDesLng.Size = new Size(171, 23);
            txtDesLng.TabIndex = 6;
            // 
            // lblRange
            // 
            lblRange.AutoSize = true;
            lblRange.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRange.ForeColor = Color.DodgerBlue;
            lblRange.Location = new Point(12, 16);
            lblRange.Name = "lblRange";
            lblRange.Size = new Size(61, 21);
            lblRange.TabIndex = 12;
            lblRange.Text = "Range: ";
            // 
            // lblBearing
            // 
            lblBearing.AutoSize = true;
            lblBearing.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBearing.ForeColor = Color.DodgerBlue;
            lblBearing.Location = new Point(12, 58);
            lblBearing.Name = "lblBearing";
            lblBearing.Size = new Size(70, 21);
            lblBearing.TabIndex = 13;
            lblBearing.Text = "Bearing: ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(lblBearing);
            panel3.Controls.Add(lblRange);
            panel3.Location = new Point(12, 309);
            panel3.Name = "panel3";
            panel3.Size = new Size(463, 100);
            panel3.TabIndex = 14;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblError.ForeColor = Color.Firebrick;
            lblError.Location = new Point(190, 263);
            lblError.Name = "lblError";
            lblError.Size = new Size(38, 17);
            lblError.TabIndex = 15;
            lblError.Text = "Error";
            lblError.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 425);
            Controls.Add(lblError);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Test NavCalc Class";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCurLat;
        private TextBox txtCurLng;
        private Panel panel1;
        private Label label6;
        private Panel panel2;
        private Label label7;
        private TextBox txtDesLat;
        private Label label8;
        private Label label9;
        private TextBox txtDesLng;
        private Label lblRange;
        private Label lblBearing;
        private Panel panel3;
        private Label lblError;
    }
}