namespace Lessons
{
    partial class MainForm
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
            this.btnValueTypes = new System.Windows.Forms.Button();
            this.btnRefTypes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnValueTypes
            // 
            this.btnValueTypes.Location = new System.Drawing.Point(93, 66);
            this.btnValueTypes.Name = "btnValueTypes";
            this.btnValueTypes.Size = new System.Drawing.Size(75, 23);
            this.btnValueTypes.TabIndex = 0;
            this.btnValueTypes.Text = "Value types";
            this.btnValueTypes.UseVisualStyleBackColor = true;
            this.btnValueTypes.Click += new System.EventHandler(this.btnValueTypes_Click);
            // 
            // btnRefTypes
            // 
            this.btnRefTypes.Location = new System.Drawing.Point(93, 96);
            this.btnRefTypes.Name = "btnRefTypes";
            this.btnRefTypes.Size = new System.Drawing.Size(75, 23);
            this.btnRefTypes.TabIndex = 1;
            this.btnRefTypes.Text = "Ref types";
            this.btnRefTypes.UseVisualStyleBackColor = true;
            this.btnRefTypes.Click += new System.EventHandler(this.btnRefTypes_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.btnRefTypes);
            this.Controls.Add(this.btnValueTypes);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValueTypes;
        private System.Windows.Forms.Button btnRefTypes;

    }
}

