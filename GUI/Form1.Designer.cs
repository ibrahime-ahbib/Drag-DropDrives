namespace GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.File = new System.Windows.Forms.Button();
            this.Folder = new System.Windows.Forms.Button();
            this.Titre = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // File
            // 
            this.File.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.File.Location = new System.Drawing.Point(464, 173);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(181, 110);
            this.File.TabIndex = 0;
            this.File.Text = "File";
            this.File.UseVisualStyleBackColor = true;
            this.File.Click += new System.EventHandler(this.button1_Click);
            // 
            // Folder
            // 
            this.Folder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Folder.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Folder.Location = new System.Drawing.Point(125, 171);
            this.Folder.Name = "Folder";
            this.Folder.Size = new System.Drawing.Size(181, 112);
            this.Folder.TabIndex = 1;
            this.Folder.Text = "Folder";
            this.Folder.UseVisualStyleBackColor = true;
            this.Folder.Click += new System.EventHandler(this.button2_Click);
            // 
            // Titre
            // 
            this.Titre.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Titre.ForeColor = System.Drawing.Color.Blue;
            this.Titre.Location = new System.Drawing.Point(195, 25);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(383, 33);
            this.Titre.TabIndex = 2;
            this.Titre.Text = "Please enter file or a folder to copy";
            this.Titre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Blue;
            this.richTextBox1.Location = new System.Drawing.Point(125, 388);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(520, 50);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "               Developped by Ibrahime";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Titre);
            this.Controls.Add(this.Folder);
            this.Controls.Add(this.File);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RichTextBox richTextBox1;

        private System.Windows.Forms.TextBox Titre;

        private System.Windows.Forms.Button Folder;

        private System.Windows.Forms.Button File;

        #endregion
    }
}