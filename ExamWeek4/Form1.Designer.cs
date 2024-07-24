namespace ExamWeek4
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            yearComboBox = new ComboBox();
            monthComboBox = new ComboBox();
            dayMonthComboBox = new ComboBox();
            dayComboBox = new ComboBox();
            showResultBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(1010, 227);
            label1.Name = "label1";
            label1.Size = new Size(149, 37);
            label1.TabIndex = 0;
            label1.Text = "היום בשבוע";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(741, 227);
            label2.Name = "label2";
            label2.Size = new Size(149, 37);
            label2.TabIndex = 1;
            label2.Text = "היום בחודש";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(515, 227);
            label3.Name = "label3";
            label3.Size = new Size(76, 37);
            label3.TabIndex = 2;
            label3.Text = "חודש";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(294, 227);
            label4.Name = "label4";
            label4.Size = new Size(67, 37);
            label4.TabIndex = 3;
            label4.Text = "שנה";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(573, 81);
            label5.Name = "label5";
            label5.Size = new Size(221, 45);
            label5.TabIndex = 4;
            label5.Text = "כתיבת תאריך";
            // 
            // yearComboBox
            // 
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Items.AddRange(new object[] { "תשפ\"ד", "תשפ\"ה", "תשפ\"ו", "תשפ\"ז", "תשפ\"ח", "תשפ\"ט", "תש\"צ", "תשצ\"א", "תשצ\"ב", "תשצ\"ג", "תשצ\"ד" });
            yearComboBox.Location = new Point(255, 327);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(140, 40);
            yearComboBox.TabIndex = 5;
            // 
            // monthComboBox
            // 
            monthComboBox.FormattingEnabled = true;
            monthComboBox.Items.AddRange(new object[] { "תשרי", "מרחשוון", "כסלו", "טבת", "שבט", "אדר", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיוון", "תמוז", "מנחם אב", "אלול" });
            monthComboBox.Location = new Point(487, 327);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(140, 40);
            monthComboBox.TabIndex = 6;
            // 
            // dayMonthComboBox
            // 
            dayMonthComboBox.FormattingEnabled = true;
            dayMonthComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            dayMonthComboBox.Location = new Point(750, 327);
            dayMonthComboBox.Name = "dayMonthComboBox";
            dayMonthComboBox.Size = new Size(140, 40);
            dayMonthComboBox.TabIndex = 7;
            // 
            // dayComboBox
            // 
            dayComboBox.FormattingEnabled = true;
            dayComboBox.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "ששי" });
            dayComboBox.Location = new Point(1019, 327);
            dayComboBox.Name = "dayComboBox";
            dayComboBox.Size = new Size(140, 40);
            dayComboBox.TabIndex = 8;
            // 
            // showResultBtn
            // 
            showResultBtn.Location = new Point(606, 520);
            showResultBtn.Name = "showResultBtn";
            showResultBtn.Size = new Size(156, 122);
            showResultBtn.TabIndex = 9;
            showResultBtn.Text = "הצג תוצאה";
            showResultBtn.UseVisualStyleBackColor = true;
            showResultBtn.Click += onShowResBtn;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1418, 945);
            Controls.Add(showResultBtn);
            Controls.Add(dayComboBox);
            Controls.Add(dayMonthComboBox);
            Controls.Add(monthComboBox);
            Controls.Add(yearComboBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox yearComboBox;
        private ComboBox monthComboBox;
        private ComboBox dayMonthComboBox;
        private ComboBox dayComboBox;
        private Button showResultBtn;
    }
}
