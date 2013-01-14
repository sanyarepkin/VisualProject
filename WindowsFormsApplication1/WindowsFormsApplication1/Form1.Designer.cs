namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.rb_Cross = new System.Windows.Forms.RadioButton();
            this.rb_line = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rb_Cross
            // 
            this.rb_Cross.AutoSize = true;
            this.rb_Cross.Location = new System.Drawing.Point(12, 295);
            this.rb_Cross.Name = "rb_Cross";
            this.rb_Cross.Size = new System.Drawing.Size(51, 17);
            this.rb_Cross.TabIndex = 0;
            this.rb_Cross.TabStop = true;
            this.rb_Cross.Text = "Cross";
            this.rb_Cross.UseVisualStyleBackColor = true;
            this.rb_Cross.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_line
            // 
            this.rb_line.AutoSize = true;
            this.rb_line.Location = new System.Drawing.Point(12, 272);
            this.rb_line.Name = "rb_line";
            this.rb_line.Size = new System.Drawing.Size(45, 17);
            this.rb_line.TabIndex = 1;
            this.rb_line.TabStop = true;
            this.rb_line.Text = "Line";
            this.rb_line.UseVisualStyleBackColor = true;
            this.rb_line.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 324);
            this.Controls.Add(this.rb_line);
            this.Controls.Add(this.rb_Cross);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_Cross;
        private System.Windows.Forms.RadioButton rb_line;
    }
}

