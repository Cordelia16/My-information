namespace Caity
{
    partial class formMain
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
            this.btnName = new System.Windows.Forms.Button();
            this.btnSuburb = new System.Windows.Forms.Button();
            this.btnID = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(12, 79);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 23);
            this.btnName.TabIndex = 1;
            this.btnName.Text = "Name";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnSuburb
            // 
            this.btnSuburb.Location = new System.Drawing.Point(130, 79);
            this.btnSuburb.Name = "btnSuburb";
            this.btnSuburb.Size = new System.Drawing.Size(75, 23);
            this.btnSuburb.TabIndex = 2;
            this.btnSuburb.Text = "Suburb";
            this.btnSuburb.UseVisualStyleBackColor = true;
            this.btnSuburb.Click += new System.EventHandler(this.btnSuburb_Click);
            // 
            // btnID
            // 
            this.btnID.Location = new System.Drawing.Point(243, 78);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(75, 23);
            this.btnID.TabIndex = 3;
            this.btnID.Text = "Student ID";
            this.btnID.UseVisualStyleBackColor = true;
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(12, 131);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(306, 23);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lbl1
            // 
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(52, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(231, 34);
            this.lbl1.TabIndex = 0;
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 169);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnID);
            this.Controls.Add(this.btnSuburb);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formMain";
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.lbName_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnSuburb;
        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lbl1;
    }
}

