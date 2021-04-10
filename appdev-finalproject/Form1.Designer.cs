
namespace appdev_finalproject
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.userLabel = new System.Windows.Forms.Label();
            this.pwLabel = new System.Windows.Forms.Label();
            this.unameTextBox = new System.Windows.Forms.TextBox();
            this.pwTextBox = new System.Windows.Forms.TextBox();
            this.debugButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.schoolSystemLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(13, 213);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(58, 13);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Username:";
            // 
            // pwLabel
            // 
            this.pwLabel.AutoSize = true;
            this.pwLabel.Location = new System.Drawing.Point(13, 241);
            this.pwLabel.Name = "pwLabel";
            this.pwLabel.Size = new System.Drawing.Size(56, 13);
            this.pwLabel.TabIndex = 2;
            this.pwLabel.Text = "Password:";
            // 
            // unameTextBox
            // 
            this.unameTextBox.Location = new System.Drawing.Point(75, 210);
            this.unameTextBox.Name = "unameTextBox";
            this.unameTextBox.Size = new System.Drawing.Size(176, 20);
            this.unameTextBox.TabIndex = 3;
            // 
            // pwTextBox
            // 
            this.pwTextBox.Location = new System.Drawing.Point(75, 237);
            this.pwTextBox.Name = "pwTextBox";
            this.pwTextBox.Size = new System.Drawing.Size(176, 20);
            this.pwTextBox.TabIndex = 4;
            this.pwTextBox.UseSystemPasswordChar = true;
            // 
            // debugButton
            // 
            this.debugButton.Location = new System.Drawing.Point(384, 279);
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(75, 23);
            this.debugButton.TabIndex = 5;
            this.debugButton.Text = "Debug";
            this.debugButton.UseVisualStyleBackColor = true;
            this.debugButton.Click += new System.EventHandler(this.debugButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(257, 222);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // schoolSystemLabel
            // 
            this.schoolSystemLabel.AutoSize = true;
            this.schoolSystemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolSystemLabel.Location = new System.Drawing.Point(109, 59);
            this.schoolSystemLabel.Name = "schoolSystemLabel";
            this.schoolSystemLabel.Size = new System.Drawing.Size(359, 39);
            this.schoolSystemLabel.TabIndex = 7;
            this.schoolSystemLabel.Text = "Vanier School System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::appdev_finalproject.Properties.Resources.login_icon_nobg;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 149);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 314);
            this.Controls.Add(this.schoolSystemLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.debugButton);
            this.Controls.Add(this.pwTextBox);
            this.Controls.Add(this.unameTextBox);
            this.Controls.Add(this.pwLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loginForm";
            this.Text = "Vanier School System - Login";
            this.Load += new System.EventHandler(this.loginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label pwLabel;
        private System.Windows.Forms.TextBox unameTextBox;
        private System.Windows.Forms.TextBox pwTextBox;
        private System.Windows.Forms.Button debugButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label schoolSystemLabel;
    }
}

