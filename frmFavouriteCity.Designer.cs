namespace WeatherApp
{
    partial class frmFavouriteCity
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
            this.cklCity = new System.Windows.Forms.CheckedListBox();
            this.btnFavSelection = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cklCity
            // 
            this.cklCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(71)))), ((int)(((byte)(150)))));
            this.cklCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cklCity.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cklCity.ForeColor = System.Drawing.Color.White;
            this.cklCity.FormattingEnabled = true;
            this.cklCity.Location = new System.Drawing.Point(59, 64);
            this.cklCity.Name = "cklCity";
            this.cklCity.Size = new System.Drawing.Size(210, 234);
            this.cklCity.TabIndex = 9;
            // 
            // btnFavSelection
            // 
            this.btnFavSelection.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFavSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavSelection.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavSelection.ForeColor = System.Drawing.Color.White;
            this.btnFavSelection.Location = new System.Drawing.Point(59, 394);
            this.btnFavSelection.Name = "btnFavSelection";
            this.btnFavSelection.Size = new System.Drawing.Size(210, 37);
            this.btnFavSelection.TabIndex = 46;
            this.btnFavSelection.Text = "Save Current Selection";
            this.btnFavSelection.UseVisualStyleBackColor = false;
            this.btnFavSelection.Click += new System.EventHandler(this.btnFavSelection_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(59, 454);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(210, 37);
            this.btnBack.TabIndex = 47;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmFavouriteCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(71)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(319, 537);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFavSelection);
            this.Controls.Add(this.cklCity);
            this.Name = "frmFavouriteCity";
            this.Text = "frmFavouriteCity";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFavouriteCity_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cklCity;
        private System.Windows.Forms.Button btnFavSelection;
        private System.Windows.Forms.Button btnBack;
    }
}