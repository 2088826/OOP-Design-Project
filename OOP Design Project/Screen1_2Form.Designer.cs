namespace OOP_Design_Project
{
    partial class Screen1_2Form
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
            this.newIDLlabel = new System.Windows.Forms.Label();
            this.iDNumberLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newIDLlabel
            // 
            this.newIDLlabel.AutoSize = true;
            this.newIDLlabel.Location = new System.Drawing.Point(251, 131);
            this.newIDLlabel.Name = "newIDLlabel";
            this.newIDLlabel.Size = new System.Drawing.Size(61, 15);
            this.newIDLlabel.TabIndex = 0;
            this.newIDLlabel.Text = "Your Id is: ";
            // 
            // iDNumberLabel
            // 
            this.iDNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iDNumberLabel.Location = new System.Drawing.Point(330, 121);
            this.iDNumberLabel.Name = "iDNumberLabel";
            this.iDNumberLabel.Size = new System.Drawing.Size(136, 39);
            this.iDNumberLabel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Log In ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(424, 285);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(144, 60);
            this.goBackButton.TabIndex = 3;
            this.goBackButton.Text = "Go back to main menu";
            this.goBackButton.UseVisualStyleBackColor = true;
            // 
            // Screen1_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iDNumberLabel);
            this.Controls.Add(this.newIDLlabel);
            this.Name = "Screen1_2";
            this.Text = "Log in information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label newIDLlabel;
        private Label iDNumberLabel;
        private Button button1;
        private Button goBackButton;
    }
}