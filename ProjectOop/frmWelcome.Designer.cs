namespace ProjectOop
{
    partial class frmWelcome
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuick = new System.Windows.Forms.Button();
            this.btnVideo = new System.Windows.Forms.Button();
            this.lblusername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(304, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // btnQuick
            // 
            this.btnQuick.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuick.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuick.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuick.Location = new System.Drawing.Point(441, 238);
            this.btnQuick.Name = "btnQuick";
            this.btnQuick.Size = new System.Drawing.Size(165, 57);
            this.btnQuick.TabIndex = 1;
            this.btnQuick.Text = "Quick";
            this.btnQuick.UseVisualStyleBackColor = false;
            this.btnQuick.Click += new System.EventHandler(this.btnQuick_Click);
            // 
            // btnVideo
            // 
            this.btnVideo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideo.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVideo.Location = new System.Drawing.Point(162, 238);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(165, 57);
            this.btnVideo.TabIndex = 1;
            this.btnVideo.Text = "Video";
            this.btnVideo.UseVisualStyleBackColor = false;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(320, 134);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(151, 24);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "show username";
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.btnVideo);
            this.Controls.Add(this.btnQuick);
            this.Controls.Add(this.label1);
            this.Name = "frmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmWelcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuick;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Label lblusername;
    }
}