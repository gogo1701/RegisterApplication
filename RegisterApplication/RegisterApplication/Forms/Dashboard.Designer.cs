namespace RegisterApplication
{
    partial class Dashboard
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
            welcomeMessageLabel = new Label();
            button1 = new Button();
            managerButton = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // welcomeMessageLabel
            // 
            welcomeMessageLabel.AutoSize = true;
            welcomeMessageLabel.Font = new Font("Segoe UI", 20F);
            welcomeMessageLabel.Location = new Point(12, 9);
            welcomeMessageLabel.Name = "welcomeMessageLabel";
            welcomeMessageLabel.Size = new Size(172, 37);
            welcomeMessageLabel.TabIndex = 0;
            welcomeMessageLabel.Text = "Hello, {USER}";
            welcomeMessageLabel.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 50F);
            button1.Location = new Point(12, 53);
            button1.Name = "button1";
            button1.Size = new Size(558, 976);
            button1.TabIndex = 1;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // managerButton
            // 
            managerButton.Enabled = false;
            managerButton.Font = new Font("Segoe UI", 50F);
            managerButton.Location = new Point(576, 53);
            managerButton.Name = "managerButton";
            managerButton.Size = new Size(558, 976);
            managerButton.TabIndex = 2;
            managerButton.Text = "Manager Menu";
            managerButton.UseVisualStyleBackColor = true;
            managerButton.Click += managerButton_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 50F);
            button3.Location = new Point(1140, 53);
            button3.Name = "button3";
            button3.Size = new Size(558, 976);
            button3.TabIndex = 3;
            button3.Text = "Settings";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 50F);
            button4.Location = new Point(1704, 53);
            button4.Name = "button4";
            button4.Size = new Size(188, 976);
            button4.TabIndex = 4;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(managerButton);
            Controls.Add(button1);
            Controls.Add(welcomeMessageLabel);
            Name = "Dashboard";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeMessageLabel;
        private Button button1;
        private Button managerButton;
        private Button button3;
        private Button button4;
    }
}