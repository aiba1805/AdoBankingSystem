using AdoBankingSystem.ClientUI.Base;
using System.Windows.Forms;

namespace AdoBankingSystem.ClientUI.Forms
{
    partial class RegistrationWindow : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationWindow));
            this.signUpButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passConTextBox = new System.Windows.Forms.TextBox();
            this.fristNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.pasLabel = new System.Windows.Forms.Label();
            this.pasConLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signUpButton
            // 
            this.signUpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUpButton.BackColor = System.Drawing.Color.Transparent;
            this.signUpButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpButton.ForeColor = System.Drawing.Color.Purple;
            this.signUpButton.Location = new System.Drawing.Point(226, 449);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(487, 76);
            this.signUpButton.TabIndex = 0;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.Purple;
            this.textBox1.Location = new System.Drawing.Point(201, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(408, 31);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.Purple;
            this.textBox2.Location = new System.Drawing.Point(201, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(408, 31);
            this.textBox2.TabIndex = 2;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.ForeColor = System.Drawing.Color.Purple;
            this.emailTextBox.Location = new System.Drawing.Point(201, 204);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(408, 31);
            this.emailTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Purple;
            this.passwordTextBox.Location = new System.Drawing.Point(201, 284);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(408, 31);
            this.passwordTextBox.TabIndex = 4;
            // 
            // passConTextBox
            // 
            this.passConTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passConTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passConTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passConTextBox.ForeColor = System.Drawing.Color.Purple;
            this.passConTextBox.Location = new System.Drawing.Point(201, 359);
            this.passConTextBox.Name = "passConTextBox";
            this.passConTextBox.Size = new System.Drawing.Size(408, 31);
            this.passConTextBox.TabIndex = 5;
            this.passConTextBox.Text = " ";            // 
            // fristNameLabel
            // 
            this.fristNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fristNameLabel.AutoSize = true;
            this.fristNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.fristNameLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fristNameLabel.ForeColor = System.Drawing.Color.Purple;
            this.fristNameLabel.Location = new System.Drawing.Point(658, 57);
            this.fristNameLabel.Name = "fristNameLabel";
            this.fristNameLabel.Size = new System.Drawing.Size(123, 32);
            this.fristNameLabel.TabIndex = 8;
            this.fristNameLabel.Text = "FirstName";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.Purple;
            this.lastNameLabel.Location = new System.Drawing.Point(662, 133);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(120, 32);
            this.lastNameLabel.TabIndex = 9;
            this.lastNameLabel.Text = "LastName";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.ForeColor = System.Drawing.Color.Purple;
            this.emailLabel.Location = new System.Drawing.Point(662, 212);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(72, 32);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "Email";
            // 
            // pasLabel
            // 
            this.pasLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pasLabel.AutoSize = true;
            this.pasLabel.BackColor = System.Drawing.Color.Transparent;
            this.pasLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pasLabel.ForeColor = System.Drawing.Color.Purple;
            this.pasLabel.Location = new System.Drawing.Point(662, 288);
            this.pasLabel.Name = "pasLabel";
            this.pasLabel.Size = new System.Drawing.Size(112, 32);
            this.pasLabel.TabIndex = 11;
            this.pasLabel.Text = "Password";
            // 
            // pasConLabel
            // 
            this.pasConLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pasConLabel.AutoSize = true;
            this.pasConLabel.BackColor = System.Drawing.Color.Transparent;
            this.pasConLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pasConLabel.ForeColor = System.Drawing.Color.Purple;
            this.pasConLabel.Location = new System.Drawing.Point(662, 363);
            this.pasConLabel.Name = "pasConLabel";
            this.pasConLabel.Size = new System.Drawing.Size(259, 32);
            this.pasConLabel.TabIndex = 12;
            this.pasConLabel.Text = "Password Confirmation";
            // 
            // RegistrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(979, 560);
            this.Controls.Add(this.pasConLabel);
            this.Controls.Add(this.pasLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.fristNameLabel);
            this.Controls.Add(this.passConTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.signUpButton);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "RegistrationWindow";
            this.Text = "RegistrationWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox passConTextBox;
        private System.Windows.Forms.Label fristNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label pasLabel;
        private System.Windows.Forms.Label pasConLabel;
    }
}