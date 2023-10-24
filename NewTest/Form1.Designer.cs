namespace NewTest
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
            this.southLightPictureBox = new System.Windows.Forms.PictureBox();
            this.westLightPictureBox = new System.Windows.Forms.PictureBox();
            this.southLabel = new System.Windows.Forms.Label();
            this.westLabel = new System.Windows.Forms.Label();
            this.eastLightPictureBox = new System.Windows.Forms.PictureBox();
            this.northLightPictureBox = new System.Windows.Forms.PictureBox();
            this.eastLabel = new System.Windows.Forms.Label();
            this.northLabel = new System.Windows.Forms.Label();
            this.rightTurnPictureBox = new System.Windows.Forms.PictureBox();
            this.rightTurnLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.southLightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.westLightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eastLightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northLightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightTurnPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // southLightPictureBox
            // 
            this.southLightPictureBox.Location = new System.Drawing.Point(550, 366);
            this.southLightPictureBox.Name = "southLightPictureBox";
            this.southLightPictureBox.Size = new System.Drawing.Size(103, 97);
            this.southLightPictureBox.TabIndex = 0;
            this.southLightPictureBox.TabStop = false;
            // 
            // westLightPictureBox
            // 
            this.westLightPictureBox.Location = new System.Drawing.Point(277, 239);
            this.westLightPictureBox.Name = "westLightPictureBox";
            this.westLightPictureBox.Size = new System.Drawing.Size(103, 97);
            this.westLightPictureBox.TabIndex = 1;
            this.westLightPictureBox.TabStop = false;
            // 
            // southLabel
            // 
            this.southLabel.AutoSize = true;
            this.southLabel.Location = new System.Drawing.Point(564, 504);
            this.southLabel.Name = "southLabel";
            this.southLabel.Size = new System.Drawing.Size(52, 20);
            this.southLabel.TabIndex = 2;
            this.southLabel.Text = "South";
            this.southLabel.Click += new System.EventHandler(this.southLabel_Click);
            // 
            // westLabel
            // 
            this.westLabel.AutoSize = true;
            this.westLabel.Location = new System.Drawing.Point(168, 275);
            this.westLabel.Name = "westLabel";
            this.westLabel.Size = new System.Drawing.Size(46, 20);
            this.westLabel.TabIndex = 3;
            this.westLabel.Text = "West";
            this.westLabel.Click += new System.EventHandler(this.westLabel_Click);
            // 
            // eastLightPictureBox
            // 
            this.eastLightPictureBox.Location = new System.Drawing.Point(796, 239);
            this.eastLightPictureBox.Name = "eastLightPictureBox";
            this.eastLightPictureBox.Size = new System.Drawing.Size(103, 97);
            this.eastLightPictureBox.TabIndex = 4;
            this.eastLightPictureBox.TabStop = false;
            // 
            // northLightPictureBox
            // 
            this.northLightPictureBox.Location = new System.Drawing.Point(550, 59);
            this.northLightPictureBox.Name = "northLightPictureBox";
            this.northLightPictureBox.Size = new System.Drawing.Size(103, 97);
            this.northLightPictureBox.TabIndex = 5;
            this.northLightPictureBox.TabStop = false;
            // 
            // eastLabel
            // 
            this.eastLabel.AutoSize = true;
            this.eastLabel.Location = new System.Drawing.Point(932, 275);
            this.eastLabel.Name = "eastLabel";
            this.eastLabel.Size = new System.Drawing.Size(42, 20);
            this.eastLabel.TabIndex = 6;
            this.eastLabel.Text = "East";
            this.eastLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // northLabel
            // 
            this.northLabel.AutoSize = true;
            this.northLabel.Location = new System.Drawing.Point(568, 24);
            this.northLabel.Name = "northLabel";
            this.northLabel.Size = new System.Drawing.Size(48, 20);
            this.northLabel.TabIndex = 7;
            this.northLabel.Text = "North";
            // 
            // rightTurnPictureBox
            // 
            this.rightTurnPictureBox.Location = new System.Drawing.Point(458, 384);
            this.rightTurnPictureBox.Name = "rightTurnPictureBox";
            this.rightTurnPictureBox.Size = new System.Drawing.Size(62, 50);
            this.rightTurnPictureBox.TabIndex = 8;
            this.rightTurnPictureBox.TabStop = false;
            // 
            // rightTurnLabel
            // 
            this.rightTurnLabel.AutoSize = true;
            this.rightTurnLabel.Location = new System.Drawing.Point(454, 471);
            this.rightTurnLabel.Name = "rightTurnLabel";
            this.rightTurnLabel.Size = new System.Drawing.Size(83, 20);
            this.rightTurnLabel.TabIndex = 9;
            this.rightTurnLabel.Text = "Right Turn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 684);
            this.Controls.Add(this.rightTurnLabel);
            this.Controls.Add(this.rightTurnPictureBox);
            this.Controls.Add(this.northLabel);
            this.Controls.Add(this.eastLabel);
            this.Controls.Add(this.northLightPictureBox);
            this.Controls.Add(this.eastLightPictureBox);
            this.Controls.Add(this.westLabel);
            this.Controls.Add(this.southLabel);
            this.Controls.Add(this.westLightPictureBox);
            this.Controls.Add(this.southLightPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.southLightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.westLightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eastLightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northLightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightTurnPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox southLightPictureBox;
        private System.Windows.Forms.PictureBox westLightPictureBox;
        private System.Windows.Forms.Label southLabel;
        private System.Windows.Forms.Label westLabel;
        private System.Windows.Forms.PictureBox eastLightPictureBox;
        private System.Windows.Forms.PictureBox northLightPictureBox;
        private System.Windows.Forms.Label eastLabel;
        private System.Windows.Forms.Label northLabel;
        private System.Windows.Forms.PictureBox rightTurnPictureBox;
        private System.Windows.Forms.Label rightTurnLabel;
    }
}

