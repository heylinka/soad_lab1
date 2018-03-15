namespace SoadLab1
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
            this.Number = new System.Windows.Forms.CheckBox();
            this.Strings = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lineagevstavki = new System.Windows.Forms.CheckBox();
            this.binstavki = new System.Windows.Forms.CheckBox();
            this.quicksort = new System.Windows.Forms.CheckBox();
            this.shell = new System.Windows.Forms.CheckBox();
            this.Boxtime = new System.Windows.Forms.TextBox();
            this.BoxPeres = new System.Windows.Forms.TextBox();
            this.Boxsrav = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.Browse = new System.Windows.Forms.Button();
            this.BigText = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textinput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(265, 57);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(71, 21);
            this.Number.TabIndex = 0;
            this.Number.Text = "Числа";
            this.Number.UseVisualStyleBackColor = true;
            // 
            // Strings
            // 
            this.Strings.AutoSize = true;
            this.Strings.Location = new System.Drawing.Point(265, 84);
            this.Strings.Name = "Strings";
            this.Strings.Size = new System.Drawing.Size(70, 21);
            this.Strings.TabIndex = 1;
            this.Strings.Text = "Слова";
            this.Strings.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип данных:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Результаты:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Тип сортировки:";
            // 
            // lineagevstavki
            // 
            this.lineagevstavki.AutoSize = true;
            this.lineagevstavki.Location = new System.Drawing.Point(24, 139);
            this.lineagevstavki.Name = "lineagevstavki";
            this.lineagevstavki.Size = new System.Drawing.Size(117, 21);
            this.lineagevstavki.TabIndex = 6;
            this.lineagevstavki.Text = "Пузырьковая";
            this.lineagevstavki.UseVisualStyleBackColor = true;
            // 
            // binstavki
            // 
            this.binstavki.AutoSize = true;
            this.binstavki.Location = new System.Drawing.Point(24, 166);
            this.binstavki.Name = "binstavki";
            this.binstavki.Size = new System.Drawing.Size(78, 21);
            this.binstavki.TabIndex = 7;
            this.binstavki.Text = "Гномья";
            this.binstavki.UseVisualStyleBackColor = true;
            // 
            // quicksort
            // 
            this.quicksort.AutoSize = true;
            this.quicksort.Location = new System.Drawing.Point(24, 220);
            this.quicksort.Name = "quicksort";
            this.quicksort.Size = new System.Drawing.Size(136, 21);
            this.quicksort.TabIndex = 8;
            this.quicksort.Text = "Пирамидальная";
            this.quicksort.UseVisualStyleBackColor = true;
            // 
            // shell
            // 
            this.shell.AutoSize = true;
            this.shell.Location = new System.Drawing.Point(24, 193);
            this.shell.Name = "shell";
            this.shell.Size = new System.Drawing.Size(73, 21);
            this.shell.TabIndex = 9;
            this.shell.Text = "Шелла";
            this.shell.UseVisualStyleBackColor = true;
            // 
            // Boxtime
            // 
            this.Boxtime.Location = new System.Drawing.Point(131, 282);
            this.Boxtime.Name = "Boxtime";
            this.Boxtime.Size = new System.Drawing.Size(100, 22);
            this.Boxtime.TabIndex = 10;
            // 
            // BoxPeres
            // 
            this.BoxPeres.Location = new System.Drawing.Point(131, 337);
            this.BoxPeres.Name = "BoxPeres";
            this.BoxPeres.Size = new System.Drawing.Size(100, 22);
            this.BoxPeres.TabIndex = 11;
            this.BoxPeres.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Boxsrav
            // 
            this.Boxsrav.Location = new System.Drawing.Point(131, 309);
            this.Boxsrav.Name = "Boxsrav";
            this.Boxsrav.Size = new System.Drawing.Size(100, 22);
            this.Boxsrav.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(500, 74);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 38);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Загрузить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(407, 53);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 14;
            this.Browse.Text = "Обзор...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // BigText
            // 
            this.BigText.Location = new System.Drawing.Point(262, 131);
            this.BigText.Name = "BigText";
            this.BigText.Size = new System.Drawing.Size(327, 192);
            this.BigText.TabIndex = 15;
            this.BigText.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Время:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Перестановки:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Сравневния:";
            // 
            // textinput
            // 
            this.textinput.Location = new System.Drawing.Point(382, 82);
            this.textinput.Name = "textinput";
            this.textinput.Size = new System.Drawing.Size(100, 22);
            this.textinput.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 38);
            this.button1.TabIndex = 21;
            this.button1.Text = "Отсортировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 383);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textinput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BigText);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Boxsrav);
            this.Controls.Add(this.BoxPeres);
            this.Controls.Add(this.Boxtime);
            this.Controls.Add(this.shell);
            this.Controls.Add(this.quicksort);
            this.Controls.Add(this.binstavki);
            this.Controls.Add(this.lineagevstavki);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Strings);
            this.Controls.Add(this.Number);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Number;
        private System.Windows.Forms.CheckBox Strings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox lineagevstavki;
        private System.Windows.Forms.CheckBox binstavki;
        private System.Windows.Forms.CheckBox quicksort;
        private System.Windows.Forms.CheckBox shell;
        private System.Windows.Forms.TextBox Boxtime;
        public System.Windows.Forms.TextBox BoxPeres;
        public System.Windows.Forms.TextBox Boxsrav;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.RichTextBox BigText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textinput;
        private System.Windows.Forms.Button button1;
    }
}

