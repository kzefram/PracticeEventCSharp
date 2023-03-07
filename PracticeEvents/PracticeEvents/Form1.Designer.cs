namespace PracticeEvents
{
    partial class lblPracticeEvent
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtNameBox = new System.Windows.Forms.TextBox();
            this.btnShowName = new System.Windows.Forms.Button();
            this.btnDisplayTitle = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(93, 63);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(93, 119);
            this.lblDisplay.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(83, 25);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "Display";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(275, 119);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(336, 25);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Text = "Your output will be displayed here";
            // 
            // txtNameBox
            // 
            this.txtNameBox.Location = new System.Drawing.Point(280, 58);
            this.txtNameBox.Margin = new System.Windows.Forms.Padding(5);
            this.txtNameBox.Name = "txtNameBox";
            this.txtNameBox.Size = new System.Drawing.Size(331, 30);
            this.txtNameBox.TabIndex = 1;
            // 
            // btnShowName
            // 
            this.btnShowName.Location = new System.Drawing.Point(78, 195);
            this.btnShowName.Margin = new System.Windows.Forms.Padding(5);
            this.btnShowName.Name = "btnShowName";
            this.btnShowName.Size = new System.Drawing.Size(152, 58);
            this.btnShowName.TabIndex = 2;
            this.btnShowName.Text = "&Show Name";
            this.btnShowName.UseVisualStyleBackColor = true;
            this.btnShowName.Click += new System.EventHandler(this.btnShowName_Click);
            // 
            // btnDisplayTitle
            // 
            this.btnDisplayTitle.Location = new System.Drawing.Point(280, 195);
            this.btnDisplayTitle.Margin = new System.Windows.Forms.Padding(5);
            this.btnDisplayTitle.Name = "btnDisplayTitle";
            this.btnDisplayTitle.Size = new System.Drawing.Size(152, 58);
            this.btnDisplayTitle.TabIndex = 3;
            this.btnDisplayTitle.Text = "&Display Title";
            this.btnDisplayTitle.UseVisualStyleBackColor = true;
            this.btnDisplayTitle.Click += new System.EventHandler(this.btnDisplayTitle_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(479, 195);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(152, 58);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblPracticeEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 324);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDisplayTitle);
            this.Controls.Add(this.btnShowName);
            this.Controls.Add(this.txtNameBox);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "lblPracticeEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practice Events";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtNameBox;
        private System.Windows.Forms.Button btnShowName;
        private System.Windows.Forms.Button btnDisplayTitle;
        private System.Windows.Forms.Button btnReset;
    }
}

