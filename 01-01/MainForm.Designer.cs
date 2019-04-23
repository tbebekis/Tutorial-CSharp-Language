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
            this.btnDeclare = new System.Windows.Forms.Button();
            this.btnBlockAndScope = new System.Windows.Forms.Button();
            this.btnIncAndDec = new System.Windows.Forms.Button();
            this.btnCompoundOps = new System.Windows.Forms.Button();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeclare
            // 
            this.btnDeclare.Location = new System.Drawing.Point(79, 12);
            this.btnDeclare.Name = "btnDeclare";
            this.btnDeclare.Size = new System.Drawing.Size(125, 23);
            this.btnDeclare.TabIndex = 0;
            this.btnDeclare.Text = "btnDeclare";
            this.btnDeclare.UseVisualStyleBackColor = true;
            this.btnDeclare.Click += new System.EventHandler(this.btnDeclare_Click);
            // 
            // btnBlockAndScope
            // 
            this.btnBlockAndScope.Location = new System.Drawing.Point(78, 88);
            this.btnBlockAndScope.Name = "btnBlockAndScope";
            this.btnBlockAndScope.Size = new System.Drawing.Size(126, 23);
            this.btnBlockAndScope.TabIndex = 1;
            this.btnBlockAndScope.Text = "btnBlockAndScope";
            this.btnBlockAndScope.UseVisualStyleBackColor = true;
            this.btnBlockAndScope.Click += new System.EventHandler(this.btnBlockAndScope_Click);
            // 
            // btnIncAndDec
            // 
            this.btnIncAndDec.Location = new System.Drawing.Point(79, 124);
            this.btnIncAndDec.Name = "btnIncAndDec";
            this.btnIncAndDec.Size = new System.Drawing.Size(125, 23);
            this.btnIncAndDec.TabIndex = 2;
            this.btnIncAndDec.Text = "btnIncAndDec";
            this.btnIncAndDec.UseVisualStyleBackColor = true;
            this.btnIncAndDec.Click += new System.EventHandler(this.btnIncAndDec_Click);
            // 
            // btnCompoundOps
            // 
            this.btnCompoundOps.Location = new System.Drawing.Point(80, 169);
            this.btnCompoundOps.Name = "btnCompoundOps";
            this.btnCompoundOps.Size = new System.Drawing.Size(124, 23);
            this.btnCompoundOps.TabIndex = 3;
            this.btnCompoundOps.Text = "btnCompoundOps";
            this.btnCompoundOps.UseVisualStyleBackColor = true;
            this.btnCompoundOps.Click += new System.EventHandler(this.btnCompoundOps_Click);
            // 
            // btnInitialize
            // 
            this.btnInitialize.Location = new System.Drawing.Point(84, 49);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(120, 23);
            this.btnInitialize.TabIndex = 4;
            this.btnInitialize.Text = "btnInitialize";
            this.btnInitialize.UseVisualStyleBackColor = true;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.btnInitialize);
            this.Controls.Add(this.btnCompoundOps);
            this.Controls.Add(this.btnIncAndDec);
            this.Controls.Add(this.btnBlockAndScope);
            this.Controls.Add(this.btnDeclare);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeclare;
        private System.Windows.Forms.Button btnBlockAndScope;
        private System.Windows.Forms.Button btnIncAndDec;
        private System.Windows.Forms.Button btnCompoundOps;
        private System.Windows.Forms.Button btnInitialize;
    }
}

