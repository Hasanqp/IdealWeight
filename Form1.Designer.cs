namespace IdealWeight
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
            label1 = new Label();
            numericUpDownAge = new NumericUpDown();
            label2 = new Label();
            comboBoxGender = new ComboBox();
            label3 = new Label();
            numericUpDownHeight = new NumericUpDown();
            label4 = new Label();
            numericUpDownWeight = new NumericUpDown();
            label5 = new Label();
            textBoxBMI = new TextBox();
            label6 = new Label();
            comboBoxPhysicalActivity = new ComboBox();
            buttonStart = new Button();
            textBoxResult = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(31, 10);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 0;
            label1.Text = "Age:";
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Font = new Font("Segoe UI", 14.25F);
            numericUpDownAge.Location = new Point(31, 41);
            numericUpDownAge.Margin = new Padding(4);
            numericUpDownAge.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDownAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(315, 33);
            numericUpDownAge.TabIndex = 1;
            numericUpDownAge.Value = new decimal(new int[] { 23, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(31, 80);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 0;
            label2.Text = "Gender:";
            // 
            // comboBoxGender
            // 
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxGender.Location = new Point(31, 111);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(315, 33);
            comboBoxGender.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(31, 150);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 0;
            label3.Text = "Height (cm):";
            // 
            // numericUpDownHeight
            // 
            numericUpDownHeight.Font = new Font("Segoe UI", 14.25F);
            numericUpDownHeight.Location = new Point(31, 181);
            numericUpDownHeight.Margin = new Padding(4);
            numericUpDownHeight.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDownHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownHeight.Name = "numericUpDownHeight";
            numericUpDownHeight.Size = new Size(315, 33);
            numericUpDownHeight.TabIndex = 1;
            numericUpDownHeight.Value = new decimal(new int[] { 175, 0, 0, 0 });
            numericUpDownHeight.ValueChanged += numericUpDownHeight_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(31, 290);
            label4.Name = "label4";
            label4.Size = new Size(45, 25);
            label4.TabIndex = 0;
            label4.Text = "BMI";
            // 
            // numericUpDownWeight
            // 
            numericUpDownWeight.Font = new Font("Segoe UI", 14.25F);
            numericUpDownWeight.Location = new Point(31, 251);
            numericUpDownWeight.Margin = new Padding(4);
            numericUpDownWeight.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDownWeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownWeight.Name = "numericUpDownWeight";
            numericUpDownWeight.Size = new Size(315, 33);
            numericUpDownWeight.TabIndex = 1;
            numericUpDownWeight.Value = new decimal(new int[] { 65, 0, 0, 0 });
            numericUpDownWeight.ValueChanged += numericUpDownWeight_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(31, 220);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 0;
            label5.Text = "Weight (kg):";
            // 
            // textBoxBMI
            // 
            textBoxBMI.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxBMI.Location = new Point(31, 321);
            textBoxBMI.Name = "textBoxBMI";
            textBoxBMI.ReadOnly = true;
            textBoxBMI.Size = new Size(315, 33);
            textBoxBMI.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F);
            label6.Location = new Point(31, 360);
            label6.Name = "label6";
            label6.Size = new Size(223, 25);
            label6.TabIndex = 0;
            label6.Text = "Physical Activity level 1-4";
            // 
            // comboBoxPhysicalActivity
            // 
            comboBoxPhysicalActivity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPhysicalActivity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxPhysicalActivity.FormattingEnabled = true;
            comboBoxPhysicalActivity.Items.AddRange(new object[] { "1", "2", "3", "4" });
            comboBoxPhysicalActivity.Location = new Point(31, 391);
            comboBoxPhysicalActivity.Name = "comboBoxPhysicalActivity";
            comboBoxPhysicalActivity.Size = new Size(315, 33);
            comboBoxPhysicalActivity.TabIndex = 2;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(31, 430);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(315, 35);
            buttonStart.TabIndex = 4;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(31, 471);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(315, 50);
            textBoxResult.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 526);
            Controls.Add(buttonStart);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxBMI);
            Controls.Add(comboBoxPhysicalActivity);
            Controls.Add(label6);
            Controls.Add(comboBoxGender);
            Controls.Add(label2);
            Controls.Add(numericUpDownWeight);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numericUpDownHeight);
            Controls.Add(label3);
            Controls.Add(numericUpDownAge);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ideal Form";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDownAge;
        private Label label2;
        private ComboBox comboBoxGender;
        private Label label3;
        private NumericUpDown numericUpDownHeight;
        private Label label4;
        private NumericUpDown numericUpDownWeight;
        private Label label5;
        private TextBox textBoxBMI;
        private Label label6;
        private ComboBox comboBoxPhysicalActivity;
        private Button buttonStart;
        private TextBox textBoxResult;
    }
}
