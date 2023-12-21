namespace WinFormsApp1.Forms
{
    partial class LoginForm
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
            LoginButton = new Button();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.Location = new Point(140, 183);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(320, 49);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Вход в систему";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 345);
            Controls.Add(LoginButton);
            Name = "LoginForm";
            Text = "Добро пожаловать";
            ResumeLayout(false);
        }

        #endregion

        private Button LoginButton;
    }
}