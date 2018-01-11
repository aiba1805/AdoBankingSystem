namespace AdoBankingSystem.ClientUI.Forms
{
    partial class TransactionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionForm));
            this.transferButton = new System.Windows.Forms.Button();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.fromLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // transferButton
            // 
            this.transferButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.transferButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.transferButton.Location = new System.Drawing.Point(245, 358);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(145, 61);
            this.transferButton.TabIndex = 0;
            this.transferButton.Text = "Transfer";
            this.transferButton.UseVisualStyleBackColor = true;
            this.transferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amountNumericUpDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.amountNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.amountNumericUpDown.Location = new System.Drawing.Point(179, 282);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(286, 38);
            this.amountNumericUpDown.TabIndex = 1;
            // 
            // fromTextBox
            // 
            this.fromTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fromTextBox.Location = new System.Drawing.Point(179, 116);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(286, 38);
            this.fromTextBox.TabIndex = 2;
            // 
            // toTextBox
            // 
            this.toTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toTextBox.Location = new System.Drawing.Point(179, 201);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(286, 38);
            this.toTextBox.TabIndex = 3;
            // 
            // fromLabel
            // 
            this.fromLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromLabel.AutoSize = true;
            this.fromLabel.BackColor = System.Drawing.Color.Transparent;
            this.fromLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.fromLabel.Location = new System.Drawing.Point(241, 69);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(153, 32);
            this.fromLabel.TabIndex = 4;
            this.fromLabel.Text = "Your account";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(178, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Who you want to transfer";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(266, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount";
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(651, 512);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.amountNumericUpDown);
            this.Controls.Add(this.transferButton);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}