namespace SocialMediaClone
{
    partial class comment
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
            this.timelineButton = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.descriptionText = new System.Windows.Forms.RichTextBox();
            this.addButton = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.timelineButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 61);
            this.panel1.TabIndex = 0;
            // 
            // timelineButton
            // 
            this.timelineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.timelineButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.timelineButton.FlatAppearance.BorderSize = 0;
            this.timelineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timelineButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.timelineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelineButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.timelineButton.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.timelineButton.IconColor = System.Drawing.Color.Gainsboro;
            this.timelineButton.IconSize = 32;
            this.timelineButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timelineButton.Location = new System.Drawing.Point(0, 0);
            this.timelineButton.Name = "timelineButton";
            this.timelineButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.timelineButton.Rotation = 0D;
            this.timelineButton.Size = new System.Drawing.Size(172, 61);
            this.timelineButton.TabIndex = 3;
            this.timelineButton.Text = "Back";
            this.timelineButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timelineButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.timelineButton.UseVisualStyleBackColor = false;
            this.timelineButton.Click += new System.EventHandler(this.timelineButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 279);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(922, 346);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // descriptionText
            // 
            this.descriptionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionText.Location = new System.Drawing.Point(23, 68);
            this.descriptionText.Margin = new System.Windows.Forms.Padding(14);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(559, 128);
            this.descriptionText.TabIndex = 9;
            this.descriptionText.Text = "";
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
            this.addButton.Location = new System.Drawing.Point(23, 203);
            this.addButton.Name = "addButton";
            this.addButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.addButton.Rotation = 0D;
            this.addButton.Size = new System.Drawing.Size(107, 43);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(922, 625);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "comment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "comment";
            this.Load += new System.EventHandler(this.comment_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton timelineButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RichTextBox descriptionText;
        private FontAwesome.Sharp.IconButton addButton;
    }
}