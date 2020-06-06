namespace SocialMediaClone
{
    partial class faqItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(faqItem));
            this.label1 = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Q)";
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.questionLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(8, 42);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.ReadOnly = true;
            this.questionLabel.Size = new System.Drawing.Size(718, 43);
            this.questionLabel.TabIndex = 5;
            this.questionLabel.Text = resources.GetString("questionLabel.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "A)";
            // 
            // answerLabel
            // 
            this.answerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.answerLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.answerLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.ForeColor = System.Drawing.Color.White;
            this.answerLabel.Location = new System.Drawing.Point(0, 174);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.ReadOnly = true;
            this.answerLabel.Size = new System.Drawing.Size(687, 82);
            this.answerLabel.TabIndex = 7;
            this.answerLabel.Text = resources.GetString("answerLabel.Text");
            // 
            // faqItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.label1);
            this.Name = "faqItem";
            this.Size = new System.Drawing.Size(687, 278);
            this.Load += new System.EventHandler(this.faqItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox questionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox answerLabel;
    }
}
