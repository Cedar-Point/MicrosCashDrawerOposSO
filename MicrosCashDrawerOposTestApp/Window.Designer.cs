namespace MicrosCashDrawerOposTestApp
{
    partial class Window
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
            this.btnOpenDrawer = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenDrawer
            // 
            this.btnOpenDrawer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenDrawer.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenDrawer.Location = new System.Drawing.Point(12, 118);
            this.btnOpenDrawer.Name = "btnOpenDrawer";
            this.btnOpenDrawer.Size = new System.Drawing.Size(277, 40);
            this.btnOpenDrawer.TabIndex = 0;
            this.btnOpenDrawer.Text = "Open Drawer";
            this.btnOpenDrawer.UseVisualStyleBackColor = true;
            this.btnOpenDrawer.Click += new System.EventHandler(this.btnOpenDrawer_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatus.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(301, 103);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Unknown";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 170);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnOpenDrawer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Window";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Micros Cash Drawer Opos Test App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenDrawer;
        private System.Windows.Forms.Label lblStatus;
    }
}

