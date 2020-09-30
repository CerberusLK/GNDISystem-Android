namespace ok
{
    partial class Form3
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
            this.nicLabel = new System.Windows.Forms.Label();
            this.NicTbox = new System.Windows.Forms.TextBox();
            this.GenderCbox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTbox = new System.Windows.Forms.TextBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.regBtn = new System.Windows.Forms.Button();
            this.passLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passTbox = new System.Windows.Forms.TextBox();
            this.UsernameTbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nicLabel
            // 
            this.nicLabel.AutoSize = true;
            this.nicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicLabel.ForeColor = System.Drawing.Color.White;
            this.nicLabel.Location = new System.Drawing.Point(104, 360);
            this.nicLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nicLabel.Name = "nicLabel";
            this.nicLabel.Size = new System.Drawing.Size(167, 31);
            this.nicLabel.TabIndex = 27;
            this.nicLabel.Text = "Nic Number";
            // 
            // NicTbox
            // 
            this.NicTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NicTbox.Location = new System.Drawing.Point(57, 395);
            this.NicTbox.Margin = new System.Windows.Forms.Padding(4);
            this.NicTbox.Name = "NicTbox";
            this.NicTbox.Size = new System.Drawing.Size(249, 34);
            this.NicTbox.TabIndex = 26;
            // 
            // GenderCbox
            // 
            this.GenderCbox.FormattingEnabled = true;
            this.GenderCbox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.GenderCbox.Location = new System.Drawing.Point(57, 292);
            this.GenderCbox.Margin = new System.Windows.Forms.Padding(4);
            this.GenderCbox.Name = "GenderCbox";
            this.GenderCbox.Size = new System.Drawing.Size(249, 24);
            this.GenderCbox.TabIndex = 25;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(119, 67);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(133, 31);
            this.nameLabel.TabIndex = 24;
            this.nameLabel.Text = "Fullname";
            // 
            // nameTbox
            // 
            this.nameTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTbox.Location = new System.Drawing.Point(57, 110);
            this.nameTbox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTbox.Name = "nameTbox";
            this.nameTbox.Size = new System.Drawing.Size(249, 34);
            this.nameTbox.TabIndex = 23;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.ForeColor = System.Drawing.Color.White;
            this.GenderLabel.Location = new System.Drawing.Point(119, 257);
            this.GenderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(110, 31);
            this.GenderLabel.TabIndex = 22;
            this.GenderLabel.Text = "Gender";
            // 
            // regBtn
            // 
            this.regBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.regBtn.FlatAppearance.BorderSize = 0;
            this.regBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBtn.ForeColor = System.Drawing.Color.Transparent;
            this.regBtn.Location = new System.Drawing.Point(57, 575);
            this.regBtn.Margin = new System.Windows.Forms.Padding(4);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(249, 50);
            this.regBtn.TabIndex = 21;
            this.regBtn.Text = "SignUp";
            this.regBtn.UseVisualStyleBackColor = false;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.ForeColor = System.Drawing.Color.White;
            this.passLabel.Location = new System.Drawing.Point(110, 462);
            this.passLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(142, 31);
            this.passLabel.TabIndex = 20;
            this.passLabel.Text = "Password";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.Color.White;
            this.userLabel.Location = new System.Drawing.Point(105, 170);
            this.userLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(147, 31);
            this.userLabel.TabIndex = 19;
            this.userLabel.Text = "Username";
            // 
            // passTbox
            // 
            this.passTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTbox.Location = new System.Drawing.Point(57, 497);
            this.passTbox.Margin = new System.Windows.Forms.Padding(4);
            this.passTbox.Name = "passTbox";
            this.passTbox.PasswordChar = '*';
            this.passTbox.Size = new System.Drawing.Size(249, 34);
            this.passTbox.TabIndex = 18;
            // 
            // UsernameTbox
            // 
            this.UsernameTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTbox.Location = new System.Drawing.Point(57, 205);
            this.UsernameTbox.Margin = new System.Windows.Forms.Padding(4);
            this.UsernameTbox.Name = "UsernameTbox";
            this.UsernameTbox.Size = new System.Drawing.Size(249, 34);
            this.UsernameTbox.TabIndex = 17;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(363, 682);
            this.Controls.Add(this.nicLabel);
            this.Controls.Add(this.NicTbox);
            this.Controls.Add(this.GenderCbox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTbox);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.passTbox);
            this.Controls.Add(this.UsernameTbox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nicLabel;
        private System.Windows.Forms.TextBox NicTbox;
        private System.Windows.Forms.ComboBox GenderCbox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTbox;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox passTbox;
        private System.Windows.Forms.TextBox UsernameTbox;
    }
}