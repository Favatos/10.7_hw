namespace _10._7_hm
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
            components = new System.ComponentModel.Container();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            toolTip1 = new ToolTip(components);
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CalendarMonthBackground = SystemColors.HighlightText;
            dateTimePickerStart.Location = new Point(262, 99);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(250, 27);
            dateTimePickerStart.TabIndex = 0;
            toolTip1.SetToolTip(dateTimePickerStart, "Completion date can't be later than the start date");
            dateTimePickerStart.ValueChanged += dateTimePickerStart_ValueChanged;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(262, 151);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(250, 27);
            dateTimePickerEnd.TabIndex = 1;
            dateTimePickerEnd.ValueChanged += dateTimePickerEnd_ValueChanged;
            dateTimePickerEnd.Leave += dateTimePickerEnd_Leave;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(262, 205);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 2;
            toolTip1.SetToolTip(textBox1, "Enter cost of one day");
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 104);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 3;
            label1.Text = "Start date of the work";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 156);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 4;
            label2.Text = "Completion date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 208);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 5;
            label3.Text = "Cost of one day";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(594, 169);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 6;
            label4.Text = "Cost of work: ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Name = "Form1";
            Text = "v";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ToolTip toolTip1;
        private ErrorProvider errorProvider1;
    }
}
