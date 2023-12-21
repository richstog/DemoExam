namespace WinFormsApp1.UserControls
{
    partial class TovarControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            NameLabel = new Label();
            BaseCostLabel = new Label();
            NewCostLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 94);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(119, 3);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(117, 21);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Наименование";
            // 
            // BaseCostLabel
            // 
            BaseCostLabel.AutoSize = true;
            BaseCostLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BaseCostLabel.Location = new Point(119, 36);
            BaseCostLabel.Name = "BaseCostLabel";
            BaseCostLabel.Size = new Size(67, 21);
            BaseCostLabel.TabIndex = 2;
            BaseCostLabel.Text = "1000.00";
            // 
            // NewCostLabel
            // 
            NewCostLabel.AutoSize = true;
            NewCostLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            NewCostLabel.Location = new Point(119, 64);
            NewCostLabel.Name = "NewCostLabel";
            NewCostLabel.Size = new Size(66, 25);
            NewCostLabel.TabIndex = 3;
            NewCostLabel.Text = "998.99";
            // 
            // TovarControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(NewCostLabel);
            Controls.Add(BaseCostLabel);
            Controls.Add(NameLabel);
            Controls.Add(pictureBox1);
            Name = "TovarControl";
            Size = new Size(560, 100);
            Load += TovarControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label NameLabel;
        private Label BaseCostLabel;
        private Label NewCostLabel;
    }
}
