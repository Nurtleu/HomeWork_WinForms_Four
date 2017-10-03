namespace WinFormsHW4
{
    partial class GuessTheDate
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
            this.Data_panel = new System.Windows.Forms.Panel();
            this.Time_textBox = new System.Windows.Forms.TextBox();
            this.Time_label = new System.Windows.Forms.Label();
            this.Second_textBox = new System.Windows.Forms.TextBox();
            this.Second_radioButton = new System.Windows.Forms.RadioButton();
            this.Save_button = new System.Windows.Forms.Button();
            this.Data_label = new System.Windows.Forms.Label();
            this.Minute_textBox = new System.Windows.Forms.TextBox();
            this.Minute_radioButton = new System.Windows.Forms.RadioButton();
            this.Day_radioButton = new System.Windows.Forms.RadioButton();
            this.Day_textBox = new System.Windows.Forms.TextBox();
            this.Month_textBox = new System.Windows.Forms.TextBox();
            this.Month_radioButton = new System.Windows.Forms.RadioButton();
            this.Year_textBox = new System.Windows.Forms.TextBox();
            this.Year_radioButton = new System.Windows.Forms.RadioButton();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Date_textBox = new System.Windows.Forms.TextBox();
            this.Data_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Data_panel
            // 
            this.Data_panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Data_panel.Controls.Add(this.Time_textBox);
            this.Data_panel.Controls.Add(this.Time_label);
            this.Data_panel.Controls.Add(this.Second_textBox);
            this.Data_panel.Controls.Add(this.Second_radioButton);
            this.Data_panel.Controls.Add(this.Save_button);
            this.Data_panel.Controls.Add(this.Data_label);
            this.Data_panel.Controls.Add(this.Minute_textBox);
            this.Data_panel.Controls.Add(this.Minute_radioButton);
            this.Data_panel.Controls.Add(this.Day_radioButton);
            this.Data_panel.Controls.Add(this.Day_textBox);
            this.Data_panel.Controls.Add(this.Month_textBox);
            this.Data_panel.Controls.Add(this.Month_radioButton);
            this.Data_panel.Controls.Add(this.Year_textBox);
            this.Data_panel.Controls.Add(this.Year_radioButton);
            this.Data_panel.Controls.Add(this.Clear_button);
            this.Data_panel.Controls.Add(this.Date_textBox);
            this.Data_panel.Location = new System.Drawing.Point(0, 0);
            this.Data_panel.Name = "Data_panel";
            this.Data_panel.Size = new System.Drawing.Size(654, 301);
            this.Data_panel.TabIndex = 0;
            // 
            // Time_textBox
            // 
            this.Time_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time_textBox.Location = new System.Drawing.Point(508, 8);
            this.Time_textBox.MaxLength = 10;
            this.Time_textBox.Multiline = true;
            this.Time_textBox.Name = "Time_textBox";
            this.Time_textBox.Size = new System.Drawing.Size(139, 32);
            this.Time_textBox.TabIndex = 22;
            // 
            // Time_label
            // 
            this.Time_label.AutoSize = true;
            this.Time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time_label.Location = new System.Drawing.Point(357, 11);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(149, 24);
            this.Time_label.TabIndex = 21;
            this.Time_label.Text = "Введите время";
            // 
            // Second_textBox
            // 
            this.Second_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Second_textBox.Location = new System.Drawing.Point(175, 197);
            this.Second_textBox.MaxLength = 10;
            this.Second_textBox.Multiline = true;
            this.Second_textBox.Name = "Second_textBox";
            this.Second_textBox.Size = new System.Drawing.Size(130, 32);
            this.Second_textBox.TabIndex = 20;
            this.Second_textBox.TextChanged += new System.EventHandler(this.Second_textBox_TextChanged);
            // 
            // Second_radioButton
            // 
            this.Second_radioButton.AutoSize = true;
            this.Second_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Second_radioButton.Location = new System.Drawing.Point(12, 201);
            this.Second_radioButton.Name = "Second_radioButton";
            this.Second_radioButton.Size = new System.Drawing.Size(93, 28);
            this.Second_radioButton.TabIndex = 19;
            this.Second_radioButton.TabStop = true;
            this.Second_radioButton.Text = "Секунд";
            this.Second_radioButton.UseVisualStyleBackColor = true;
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.White;
            this.Save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_button.Location = new System.Drawing.Point(63, 253);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(162, 42);
            this.Save_button.TabIndex = 18;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Data_label
            // 
            this.Data_label.AutoSize = true;
            this.Data_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Data_label.Location = new System.Drawing.Point(12, 11);
            this.Data_label.Name = "Data_label";
            this.Data_label.Size = new System.Drawing.Size(134, 24);
            this.Data_label.TabIndex = 17;
            this.Data_label.Text = "Введите дату";
            // 
            // Minute_textBox
            // 
            this.Minute_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minute_textBox.Location = new System.Drawing.Point(175, 159);
            this.Minute_textBox.MaxLength = 10;
            this.Minute_textBox.Multiline = true;
            this.Minute_textBox.Name = "Minute_textBox";
            this.Minute_textBox.Size = new System.Drawing.Size(130, 32);
            this.Minute_textBox.TabIndex = 14;
            // 
            // Minute_radioButton
            // 
            this.Minute_radioButton.AutoSize = true;
            this.Minute_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minute_radioButton.Location = new System.Drawing.Point(12, 163);
            this.Minute_radioButton.Name = "Minute_radioButton";
            this.Minute_radioButton.Size = new System.Drawing.Size(85, 28);
            this.Minute_radioButton.TabIndex = 13;
            this.Minute_radioButton.TabStop = true;
            this.Minute_radioButton.Text = "Минут";
            this.Minute_radioButton.UseVisualStyleBackColor = true;
            this.Minute_radioButton.CheckedChanged += new System.EventHandler(this.Minutes_radioButton_CheckedChanged);
            // 
            // Day_radioButton
            // 
            this.Day_radioButton.AutoSize = true;
            this.Day_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Day_radioButton.Location = new System.Drawing.Point(12, 125);
            this.Day_radioButton.Name = "Day_radioButton";
            this.Day_radioButton.Size = new System.Drawing.Size(75, 28);
            this.Day_radioButton.TabIndex = 12;
            this.Day_radioButton.TabStop = true;
            this.Day_radioButton.Text = "День";
            this.Day_radioButton.UseVisualStyleBackColor = true;
            this.Day_radioButton.CheckedChanged += new System.EventHandler(this.Day_radioButton_CheckedChanged);
            // 
            // Day_textBox
            // 
            this.Day_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Day_textBox.Location = new System.Drawing.Point(175, 121);
            this.Day_textBox.MaxLength = 10;
            this.Day_textBox.Multiline = true;
            this.Day_textBox.Name = "Day_textBox";
            this.Day_textBox.Size = new System.Drawing.Size(130, 32);
            this.Day_textBox.TabIndex = 11;
            // 
            // Month_textBox
            // 
            this.Month_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Month_textBox.Location = new System.Drawing.Point(175, 83);
            this.Month_textBox.MaxLength = 10;
            this.Month_textBox.Multiline = true;
            this.Month_textBox.Name = "Month_textBox";
            this.Month_textBox.Size = new System.Drawing.Size(130, 32);
            this.Month_textBox.TabIndex = 10;
            // 
            // Month_radioButton
            // 
            this.Month_radioButton.AutoSize = true;
            this.Month_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Month_radioButton.Location = new System.Drawing.Point(12, 88);
            this.Month_radioButton.Name = "Month_radioButton";
            this.Month_radioButton.Size = new System.Drawing.Size(86, 28);
            this.Month_radioButton.TabIndex = 9;
            this.Month_radioButton.TabStop = true;
            this.Month_radioButton.Text = "Месяц";
            this.Month_radioButton.UseVisualStyleBackColor = true;
            this.Month_radioButton.CheckedChanged += new System.EventHandler(this.Month_radioButton_CheckedChanged);
            // 
            // Year_textBox
            // 
            this.Year_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Year_textBox.Location = new System.Drawing.Point(175, 45);
            this.Year_textBox.MaxLength = 10;
            this.Year_textBox.Multiline = true;
            this.Year_textBox.Name = "Year_textBox";
            this.Year_textBox.Size = new System.Drawing.Size(130, 32);
            this.Year_textBox.TabIndex = 8;
            // 
            // Year_radioButton
            // 
            this.Year_radioButton.AutoSize = true;
            this.Year_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Year_radioButton.Location = new System.Drawing.Point(12, 49);
            this.Year_radioButton.Name = "Year_radioButton";
            this.Year_radioButton.Size = new System.Drawing.Size(62, 28);
            this.Year_radioButton.TabIndex = 7;
            this.Year_radioButton.TabStop = true;
            this.Year_radioButton.Text = "Год";
            this.Year_radioButton.UseVisualStyleBackColor = true;
            this.Year_radioButton.CheckedChanged += new System.EventHandler(this.Year_radioButton_CheckedChanged);
            // 
            // Clear_button
            // 
            this.Clear_button.BackColor = System.Drawing.Color.White;
            this.Clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_button.Location = new System.Drawing.Point(278, 253);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(162, 42);
            this.Clear_button.TabIndex = 5;
            this.Clear_button.Text = "Очистить";
            this.Clear_button.UseVisualStyleBackColor = false;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Date_textBox
            // 
            this.Date_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date_textBox.Location = new System.Drawing.Point(175, 8);
            this.Date_textBox.MaxLength = 10;
            this.Date_textBox.Multiline = true;
            this.Date_textBox.Name = "Date_textBox";
            this.Date_textBox.Size = new System.Drawing.Size(176, 32);
            this.Date_textBox.TabIndex = 3;
            // 
            // GuessTheDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 299);
            this.Controls.Add(this.Data_panel);
            this.Name = "GuessTheDate";
            this.Data_panel.ResumeLayout(false);
            this.Data_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Data_panel;
        private System.Windows.Forms.TextBox Date_textBox;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.TextBox Minute_textBox;
        private System.Windows.Forms.RadioButton Minute_radioButton;
        private System.Windows.Forms.RadioButton Day_radioButton;
        private System.Windows.Forms.TextBox Day_textBox;
        private System.Windows.Forms.TextBox Month_textBox;
        private System.Windows.Forms.RadioButton Month_radioButton;
        private System.Windows.Forms.TextBox Year_textBox;
        private System.Windows.Forms.RadioButton Year_radioButton;
        private System.Windows.Forms.Label Data_label;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Label Time_label;
        private System.Windows.Forms.TextBox Second_textBox;
        private System.Windows.Forms.RadioButton Second_radioButton;
        private System.Windows.Forms.TextBox Time_textBox;
    }
}

