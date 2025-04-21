namespace ChooseYourDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Blue = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Violet;
            this.Blue.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Blue.ForeColor = System.Drawing.Color.Snow;
            this.Blue.Location = new System.Drawing.Point(50, 50);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(200, 200);
            this.Blue.TabIndex = 0;
            this.Blue.Text = "Lazy Then Regret";
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Tomato;
            this.Red.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Red.ForeColor = System.Drawing.Color.Snow;
            this.Red.Location = new System.Drawing.Point(473, 64);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(200, 200);
            this.Red.TabIndex = 1;
            this.Red.Text = "Tired Then Happy";
            this.Red.UseVisualStyleBackColor = false;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Blue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Red;
    }
}

