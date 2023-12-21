namespace WinFormsApp1.Forms
{
    partial class TovarsForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            SortGroupBox = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            FilterGroupBox = new GroupBox();
            button1 = new Button();
            SkidkaComboBox = new ComboBox();
            textBox1 = new TextBox();
            ExitButton = new Button();
            UpdateButton = new Button();
            SortCostGroup = new GroupBox();
            CostUpRadio = new RadioButton();
            CostDownRadio = new RadioButton();
            SortNameGroup = new GroupBox();
            NameUpRadio = new RadioButton();
            NameDownRadio = new RadioButton();
            SortGroupBox.SuspendLayout();
            FilterGroupBox.SuspendLayout();
            SortCostGroup.SuspendLayout();
            SortNameGroup.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 41);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(604, 397);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // SortGroupBox
            // 
            SortGroupBox.Controls.Add(button3);
            SortGroupBox.Controls.Add(button2);
            SortGroupBox.Location = new Point(622, 41);
            SortGroupBox.Name = "SortGroupBox";
            SortGroupBox.Size = new Size(202, 80);
            SortGroupBox.TabIndex = 1;
            SortGroupBox.TabStop = false;
            SortGroupBox.Text = "Сортировка";
            // 
            // button3
            // 
            button3.Location = new Point(6, 51);
            button3.Name = "button3";
            button3.Size = new Size(190, 23);
            button3.TabIndex = 1;
            button3.Text = "По цене";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(6, 22);
            button2.Name = "button2";
            button2.Size = new Size(190, 23);
            button2.TabIndex = 0;
            button2.Text = "По наименованию";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FilterGroupBox
            // 
            FilterGroupBox.Controls.Add(button1);
            FilterGroupBox.Controls.Add(SkidkaComboBox);
            FilterGroupBox.Location = new Point(622, 127);
            FilterGroupBox.Name = "FilterGroupBox";
            FilterGroupBox.Size = new Size(202, 81);
            FilterGroupBox.TabIndex = 2;
            FilterGroupBox.TabStop = false;
            FilterGroupBox.Text = "Фильтрация";
            // 
            // button1
            // 
            button1.Location = new Point(6, 51);
            button1.Name = "button1";
            button1.Size = new Size(190, 23);
            button1.TabIndex = 1;
            button1.Text = "Фильтровать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SkidkaComboBox
            // 
            SkidkaComboBox.FormattingEnabled = true;
            SkidkaComboBox.Items.AddRange(new object[] { "Все товары", "0.01% - 4.99%", "5% - 9.99%", "10% - 14.99%" });
            SkidkaComboBox.Location = new Point(6, 22);
            SkidkaComboBox.Name = "SkidkaComboBox";
            SkidkaComboBox.Size = new Size(190, 23);
            SkidkaComboBox.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(604, 23);
            textBox1.TabIndex = 3;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(622, 12);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(202, 23);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(622, 415);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(202, 23);
            UpdateButton.TabIndex = 6;
            UpdateButton.Text = "Обновить";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // SortCostGroup
            // 
            SortCostGroup.Controls.Add(CostUpRadio);
            SortCostGroup.Controls.Add(CostDownRadio);
            SortCostGroup.Location = new Point(622, 228);
            SortCostGroup.Name = "SortCostGroup";
            SortCostGroup.Size = new Size(202, 82);
            SortCostGroup.TabIndex = 7;
            SortCostGroup.TabStop = false;
            SortCostGroup.Text = "Сортировка по цене";
            // 
            // CostUpRadio
            // 
            CostUpRadio.AutoSize = true;
            CostUpRadio.Location = new Point(6, 47);
            CostUpRadio.Name = "CostUpRadio";
            CostUpRadio.Size = new Size(116, 19);
            CostUpRadio.TabIndex = 1;
            CostUpRadio.TabStop = true;
            CostUpRadio.Text = "По возрастанию";
            CostUpRadio.UseVisualStyleBackColor = true;
            CostUpRadio.CheckedChanged += CostUpRadio_CheckedChanged;
            // 
            // CostDownRadio
            // 
            CostDownRadio.AutoSize = true;
            CostDownRadio.Location = new Point(6, 22);
            CostDownRadio.Name = "CostDownRadio";
            CostDownRadio.Size = new Size(102, 19);
            CostDownRadio.TabIndex = 0;
            CostDownRadio.TabStop = true;
            CostDownRadio.Text = "По убыванию";
            CostDownRadio.UseVisualStyleBackColor = true;
            CostDownRadio.CheckedChanged += CostDownRadio_CheckedChanged;
            // 
            // SortNameGroup
            // 
            SortNameGroup.Controls.Add(NameUpRadio);
            SortNameGroup.Controls.Add(NameDownRadio);
            SortNameGroup.Location = new Point(622, 316);
            SortNameGroup.Name = "SortNameGroup";
            SortNameGroup.Size = new Size(202, 93);
            SortNameGroup.TabIndex = 8;
            SortNameGroup.TabStop = false;
            SortNameGroup.Text = "Сортировка наименованию";
            // 
            // NameUpRadio
            // 
            NameUpRadio.AutoSize = true;
            NameUpRadio.Location = new Point(6, 47);
            NameUpRadio.Name = "NameUpRadio";
            NameUpRadio.Size = new Size(116, 19);
            NameUpRadio.TabIndex = 1;
            NameUpRadio.TabStop = true;
            NameUpRadio.Text = "По возрастанию";
            NameUpRadio.UseVisualStyleBackColor = true;
            NameUpRadio.CheckedChanged += NameUpRadio_CheckedChanged;
            // 
            // NameDownRadio
            // 
            NameDownRadio.AutoSize = true;
            NameDownRadio.Location = new Point(6, 22);
            NameDownRadio.Name = "NameDownRadio";
            NameDownRadio.Size = new Size(102, 19);
            NameDownRadio.TabIndex = 0;
            NameDownRadio.TabStop = true;
            NameDownRadio.Text = "По убыванию";
            NameDownRadio.UseVisualStyleBackColor = true;
            NameDownRadio.CheckedChanged += NameDownRadio_CheckedChanged;
            // 
            // TovarsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 450);
            Controls.Add(SortNameGroup);
            Controls.Add(SortCostGroup);
            Controls.Add(UpdateButton);
            Controls.Add(ExitButton);
            Controls.Add(textBox1);
            Controls.Add(FilterGroupBox);
            Controls.Add(SortGroupBox);
            Controls.Add(flowLayoutPanel1);
            Name = "TovarsForm";
            Text = "Товары";
            Load += TovarsForm_Load;
            SortGroupBox.ResumeLayout(false);
            FilterGroupBox.ResumeLayout(false);
            SortCostGroup.ResumeLayout(false);
            SortCostGroup.PerformLayout();
            SortNameGroup.ResumeLayout(false);
            SortNameGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox SortGroupBox;
        private GroupBox FilterGroupBox;
        private TextBox textBox1;
        private Button ExitButton;
        private Button UpdateButton;
        private ComboBox SkidkaComboBox;
        private Button button1;
        private Button button3;
        private Button button2;
        private GroupBox SortCostGroup;
        private GroupBox SortNameGroup;
        private RadioButton CostUpRadio;
        private RadioButton CostDownRadio;
        private RadioButton NameUpRadio;
        private RadioButton NameDownRadio;
    }
}