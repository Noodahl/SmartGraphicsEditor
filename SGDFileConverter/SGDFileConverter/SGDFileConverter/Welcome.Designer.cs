namespace SGDFileConverter
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EditSGD_Btn = new System.Windows.Forms.Button();
            this.FileLocation_TextBox = new System.Windows.Forms.TextBox();
            this.Browse_Btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 551);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "SGD EDITOR";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.EditSGD_Btn);
            this.panel2.Controls.Add(this.FileLocation_TextBox);
            this.panel2.Controls.Add(this.Browse_Btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(217, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 551);
            this.panel2.TabIndex = 1;
            // 
            // EditSGD_Btn
            // 
            this.EditSGD_Btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.EditSGD_Btn.Enabled = false;
            this.EditSGD_Btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.EditSGD_Btn.ForeColor = System.Drawing.Color.White;
            this.EditSGD_Btn.Location = new System.Drawing.Point(25, 263);
            this.EditSGD_Btn.Name = "EditSGD_Btn";
            this.EditSGD_Btn.Size = new System.Drawing.Size(409, 37);
            this.EditSGD_Btn.TabIndex = 3;
            this.EditSGD_Btn.Text = "Edit";
            this.EditSGD_Btn.UseVisualStyleBackColor = false;
            this.EditSGD_Btn.Click += new System.EventHandler(this.EditSGD_Btn_Click);
            // 
            // FileLocation_TextBox
            // 
            this.FileLocation_TextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileLocation_TextBox.ForeColor = System.Drawing.Color.Black;
            this.FileLocation_TextBox.Location = new System.Drawing.Point(25, 207);
            this.FileLocation_TextBox.Name = "FileLocation_TextBox";
            this.FileLocation_TextBox.Size = new System.Drawing.Size(290, 26);
            this.FileLocation_TextBox.TabIndex = 2;
            // 
            // Browse_Btn
            // 
            this.Browse_Btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Browse_Btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.Browse_Btn.ForeColor = System.Drawing.Color.White;
            this.Browse_Btn.Location = new System.Drawing.Point(324, 201);
            this.Browse_Btn.Name = "Browse_Btn";
            this.Browse_Btn.Size = new System.Drawing.Size(110, 37);
            this.Browse_Btn.TabIndex = 1;
            this.Browse_Btn.Text = "Browse";
            this.Browse_Btn.UseVisualStyleBackColor = false;
            this.Browse_Btn.Click += new System.EventHandler(this.Browse_Btn_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 551);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Welcome";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIMPL# Tools";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button EditSGD_Btn;
        private System.Windows.Forms.TextBox FileLocation_TextBox;
        private System.Windows.Forms.Button Browse_Btn;
    }
}

