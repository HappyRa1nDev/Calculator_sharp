namespace Сalculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EnterT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.ResMonth = new System.Windows.Forms.Button();
            this.ResDays = new System.Windows.Forms.Button();
            this.ResDate = new System.Windows.Forms.Button();
            this.ResMinutes = new System.Windows.Forms.Button();
            this.ResWeeks = new System.Windows.Forms.Button();
            this.ResSeconds = new System.Windows.Forms.Button();
            this.ResHours = new System.Windows.Forms.Button();
            this.EnterDays = new System.Windows.Forms.Button();
            this.EnterMonth = new System.Windows.Forms.Button();
            this.EnterData = new System.Windows.Forms.Button();
            this.FormatData = new System.Windows.Forms.ComboBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EnterT
            // 
            this.EnterT.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterT.Location = new System.Drawing.Point(28, 29);
            this.EnterT.Margin = new System.Windows.Forms.Padding(1);
            this.EnterT.Name = "EnterT";
            this.EnterT.ReadOnly = true;
            this.EnterT.Size = new System.Drawing.Size(204, 29);
            this.EnterT.TabIndex = 0;
            this.EnterT.TextChanged += new System.EventHandler(this.EnterT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Результат:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // minus
            // 
            this.minus.Enabled = false;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus.Location = new System.Drawing.Point(137, 71);
            this.minus.Margin = new System.Windows.Forms.Padding(1);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(69, 68);
            this.minus.TabIndex = 5;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            this.plus.Enabled = false;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus.Location = new System.Drawing.Point(137, 166);
            this.plus.Margin = new System.Windows.Forms.Padding(1);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(69, 68);
            this.plus.TabIndex = 6;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // ResMonth
            // 
            this.ResMonth.Enabled = false;
            this.ResMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResMonth.Location = new System.Drawing.Point(247, 166);
            this.ResMonth.Margin = new System.Windows.Forms.Padding(1);
            this.ResMonth.Name = "ResMonth";
            this.ResMonth.Size = new System.Drawing.Size(69, 68);
            this.ResMonth.TabIndex = 8;
            this.ResMonth.Text = "=Месяцы";
            this.ResMonth.UseVisualStyleBackColor = true;
            this.ResMonth.Click += new System.EventHandler(this.ResMonth_Click);
            // 
            // ResDays
            // 
            this.ResDays.Enabled = false;
            this.ResDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResDays.Location = new System.Drawing.Point(137, 258);
            this.ResDays.Margin = new System.Windows.Forms.Padding(1);
            this.ResDays.Name = "ResDays";
            this.ResDays.Size = new System.Drawing.Size(69, 68);
            this.ResDays.TabIndex = 11;
            this.ResDays.Text = "=Дни";
            this.ResDays.UseVisualStyleBackColor = true;
            this.ResDays.Click += new System.EventHandler(this.ResDays_Click);
            // 
            // ResDate
            // 
            this.ResDate.Enabled = false;
            this.ResDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResDate.Location = new System.Drawing.Point(247, 71);
            this.ResDate.Margin = new System.Windows.Forms.Padding(1);
            this.ResDate.Name = "ResDate";
            this.ResDate.Size = new System.Drawing.Size(69, 68);
            this.ResDate.TabIndex = 12;
            this.ResDate.Text = "=Дата";
            this.ResDate.UseVisualStyleBackColor = true;
            this.ResDate.Click += new System.EventHandler(this.ResDate_Click);
            // 
            // ResMinutes
            // 
            this.ResMinutes.Enabled = false;
            this.ResMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResMinutes.Location = new System.Drawing.Point(345, 166);
            this.ResMinutes.Margin = new System.Windows.Forms.Padding(1);
            this.ResMinutes.Name = "ResMinutes";
            this.ResMinutes.Size = new System.Drawing.Size(69, 68);
            this.ResMinutes.TabIndex = 13;
            this.ResMinutes.Text = "=Минуты";
            this.ResMinutes.UseVisualStyleBackColor = true;
            this.ResMinutes.Click += new System.EventHandler(this.ResMinutes_Click);
            // 
            // ResWeeks
            // 
            this.ResWeeks.Enabled = false;
            this.ResWeeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResWeeks.Location = new System.Drawing.Point(247, 258);
            this.ResWeeks.Margin = new System.Windows.Forms.Padding(1);
            this.ResWeeks.Name = "ResWeeks";
            this.ResWeeks.Size = new System.Drawing.Size(69, 68);
            this.ResWeeks.TabIndex = 14;
            this.ResWeeks.Text = "=Недели";
            this.ResWeeks.UseVisualStyleBackColor = true;
            this.ResWeeks.Click += new System.EventHandler(this.ResWeeks_Click);
            // 
            // ResSeconds
            // 
            this.ResSeconds.Enabled = false;
            this.ResSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResSeconds.Location = new System.Drawing.Point(345, 71);
            this.ResSeconds.Margin = new System.Windows.Forms.Padding(1);
            this.ResSeconds.Name = "ResSeconds";
            this.ResSeconds.Size = new System.Drawing.Size(69, 68);
            this.ResSeconds.TabIndex = 15;
            this.ResSeconds.Text = "=Секунды";
            this.ResSeconds.UseVisualStyleBackColor = true;
            this.ResSeconds.Click += new System.EventHandler(this.ResSeconds_Click);
            // 
            // ResHours
            // 
            this.ResHours.Enabled = false;
            this.ResHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResHours.Location = new System.Drawing.Point(345, 258);
            this.ResHours.Margin = new System.Windows.Forms.Padding(1);
            this.ResHours.Name = "ResHours";
            this.ResHours.Size = new System.Drawing.Size(69, 68);
            this.ResHours.TabIndex = 16;
            this.ResHours.Text = "=Часы";
            this.ResHours.UseVisualStyleBackColor = true;
            this.ResHours.Click += new System.EventHandler(this.ResHours_Click);
            // 
            // EnterDays
            // 
            this.EnterDays.Enabled = false;
            this.EnterDays.Location = new System.Drawing.Point(28, 258);
            this.EnterDays.Margin = new System.Windows.Forms.Padding(1);
            this.EnterDays.Name = "EnterDays";
            this.EnterDays.Size = new System.Drawing.Size(77, 68);
            this.EnterDays.TabIndex = 10;
            this.EnterDays.Text = "Ввести к-во дней";
            this.EnterDays.UseVisualStyleBackColor = true;
            this.EnterDays.Click += new System.EventHandler(this.EnterDays_Click);
            // 
            // EnterMonth
            // 
            this.EnterMonth.Enabled = false;
            this.EnterMonth.Location = new System.Drawing.Point(28, 166);
            this.EnterMonth.Margin = new System.Windows.Forms.Padding(1);
            this.EnterMonth.Name = "EnterMonth";
            this.EnterMonth.Size = new System.Drawing.Size(77, 68);
            this.EnterMonth.TabIndex = 9;
            this.EnterMonth.Text = "Ввести к-во месяцев";
            this.EnterMonth.UseVisualStyleBackColor = true;
            this.EnterMonth.Click += new System.EventHandler(this.EnterMonth_Click);
            // 
            // EnterData
            // 
            this.EnterData.Location = new System.Drawing.Point(28, 71);
            this.EnterData.Margin = new System.Windows.Forms.Padding(1);
            this.EnterData.Name = "EnterData";
            this.EnterData.Size = new System.Drawing.Size(77, 68);
            this.EnterData.TabIndex = 4;
            this.EnterData.Text = "Ввести дату";
            this.EnterData.UseVisualStyleBackColor = true;
            this.EnterData.Click += new System.EventHandler(this.EnterData_Click);
            // 
            // FormatData
            // 
            this.FormatData.FormattingEnabled = true;
            this.FormatData.Items.AddRange(new object[] {
            "Российский формат даты",
            "Американский Формат даты"});
            this.FormatData.Location = new System.Drawing.Point(28, 5);
            this.FormatData.Margin = new System.Windows.Forms.Padding(1);
            this.FormatData.Name = "FormatData";
            this.FormatData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FormatData.Size = new System.Drawing.Size(175, 21);
            this.FormatData.TabIndex = 17;
            this.FormatData.Text = "Российский формат даты";
            this.FormatData.SelectedIndexChanged += new System.EventHandler(this.FormatData_SelectedIndexChanged);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(231, 29);
            this.Delete.Margin = new System.Windows.Forms.Padding(1);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(28, 26);
            this.Delete.TabIndex = 18;
            this.Delete.Text = "<<";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.Location = new System.Drawing.Point(296, 29);
            this.Result.Margin = new System.Windows.Forms.Padding(1);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(121, 29);
            this.Result.TabIndex = 1;
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 369);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.FormatData);
            this.Controls.Add(this.ResHours);
            this.Controls.Add(this.ResSeconds);
            this.Controls.Add(this.ResWeeks);
            this.Controls.Add(this.ResMinutes);
            this.Controls.Add(this.ResDate);
            this.Controls.Add(this.ResDays);
            this.Controls.Add(this.EnterDays);
            this.Controls.Add(this.EnterMonth);
            this.Controls.Add(this.ResMonth);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.EnterData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.EnterT);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnterT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button ResMonth;
        private System.Windows.Forms.Button ResDays;
        private System.Windows.Forms.Button ResDate;
        private System.Windows.Forms.Button ResMinutes;
        private System.Windows.Forms.Button ResWeeks;
        private System.Windows.Forms.Button ResSeconds;
        private System.Windows.Forms.Button ResHours;
        private System.Windows.Forms.Button EnterDays;
        private System.Windows.Forms.Button EnterMonth;
        private System.Windows.Forms.Button EnterData;
        private System.Windows.Forms.ComboBox FormatData;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox Result;
    }
}

