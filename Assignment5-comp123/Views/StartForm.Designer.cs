namespace Assignment5_comp123.Views
{
    partial class StartForm
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
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Newbutton = new System.Windows.Forms.Button();
            this.Chooselabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exitbutton
            // 
            this.Exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.Location = new System.Drawing.Point(121, 459);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(187, 41);
            this.Exitbutton.TabIndex = 9;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            // 
            // Savebutton
            // 
            this.Savebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebutton.Location = new System.Drawing.Point(107, 401);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(219, 43);
            this.Savebutton.TabIndex = 8;
            this.Savebutton.Text = "Open a Saved Order";
            this.Savebutton.UseVisualStyleBackColor = true;
            // 
            // Newbutton
            // 
            this.Newbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Newbutton.Location = new System.Drawing.Point(121, 337);
            this.Newbutton.Name = "Newbutton";
            this.Newbutton.Size = new System.Drawing.Size(187, 43);
            this.Newbutton.TabIndex = 7;
            this.Newbutton.Text = "Start a new Order";
            this.Newbutton.UseVisualStyleBackColor = true;
            // 
            // Chooselabel
            // 
            this.Chooselabel.AutoSize = true;
            this.Chooselabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chooselabel.Location = new System.Drawing.Point(84, 9);
            this.Chooselabel.Name = "Chooselabel";
            this.Chooselabel.Size = new System.Drawing.Size(263, 25);
            this.Chooselabel.TabIndex = 6;
            this.Chooselabel.Text = "Choose your computer today";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 521);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.Newbutton);
            this.Controls.Add(this.Chooselabel);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Newbutton;
        private System.Windows.Forms.Label Chooselabel;
    }
}