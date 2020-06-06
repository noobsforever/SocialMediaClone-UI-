namespace SocialMediaClone
{
    partial class Feedback
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
            this.feedbackAdd = new System.Windows.Forms.RichTextBox();
            this.addButton = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.feedbackAdd);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Location = new System.Drawing.Point(32, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 352);
            this.panel1.TabIndex = 0;
            // 
            // feedbackAdd
            // 
            this.feedbackAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackAdd.Location = new System.Drawing.Point(59, 75);
            this.feedbackAdd.Margin = new System.Windows.Forms.Padding(14);
            this.feedbackAdd.Name = "feedbackAdd";
            this.feedbackAdd.Size = new System.Drawing.Size(615, 204);
            this.feedbackAdd.TabIndex = 11;
            this.feedbackAdd.Text = "";
            this.feedbackAdd.TextChanged += new System.EventHandler(this.descriptionText_TextChanged);
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
            this.addButton.Location = new System.Drawing.Point(59, 296);
            this.addButton.Name = "addButton";
            this.addButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.addButton.Rotation = 0D;
            this.addButton.Size = new System.Drawing.Size(107, 43);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Add some feedback or Query";
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(854, 439);
            this.Controls.Add(this.panel1);
            this.Name = "Feedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback";
            this.Load += new System.EventHandler(this.Feedback_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox feedbackAdd;
        private FontAwesome.Sharp.IconButton addButton;
        private System.Windows.Forms.Label label1;
    }
}