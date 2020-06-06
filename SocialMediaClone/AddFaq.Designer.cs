namespace SocialMediaClone
{
    partial class AddFaq
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.answerAdd = new System.Windows.Forms.RichTextBox();
            this.questionAdd = new System.Windows.Forms.RichTextBox();
            this.addButton = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.answerAdd);
            this.panel1.Controls.Add(this.questionAdd);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Location = new System.Drawing.Point(39, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 379);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 33);
            this.label2.TabIndex = 18;
            this.label2.Text = "Answer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Question:";
            // 
            // answerAdd
            // 
            this.answerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerAdd.Location = new System.Drawing.Point(204, 140);
            this.answerAdd.Margin = new System.Windows.Forms.Padding(14);
            this.answerAdd.Name = "answerAdd";
            this.answerAdd.Size = new System.Drawing.Size(559, 147);
            this.answerAdd.TabIndex = 16;
            this.answerAdd.Text = "";
            // 
            // questionAdd
            // 
            this.questionAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionAdd.Location = new System.Drawing.Point(204, 29);
            this.questionAdd.Margin = new System.Windows.Forms.Padding(14);
            this.questionAdd.Name = "questionAdd";
            this.questionAdd.Size = new System.Drawing.Size(559, 67);
            this.questionAdd.TabIndex = 14;
            this.questionAdd.Text = "";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.addButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addButton.IconColor = System.Drawing.Color.Gainsboro;
            this.addButton.IconSize = 32;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(204, 317);
            this.addButton.Name = "addButton";
            this.addButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.addButton.Rotation = 0D;
            this.addButton.Size = new System.Drawing.Size(107, 43);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Add";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddFaq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(886, 428);
            this.Controls.Add(this.panel1);
            this.Name = "AddFaq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFaq";
            this.Load += new System.EventHandler(this.AddFaq_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox answerAdd;
        private System.Windows.Forms.RichTextBox questionAdd;
        private FontAwesome.Sharp.IconButton addButton;
    }
}