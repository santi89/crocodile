namespace WindowsFormsApp1
{
    partial class Crocodile
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
            this.simpleOpenGlControl1 = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.btstart = new System.Windows.Forms.Button();
            this.btnout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // simpleOpenGlControl1
            // 
            this.simpleOpenGlControl1.AccumBits = ((byte)(0));
            this.simpleOpenGlControl1.AutoCheckErrors = false;
            this.simpleOpenGlControl1.AutoFinish = false;
            this.simpleOpenGlControl1.AutoMakeCurrent = true;
            this.simpleOpenGlControl1.AutoSwapBuffers = true;
            this.simpleOpenGlControl1.BackColor = System.Drawing.Color.Black;
            this.simpleOpenGlControl1.ColorBits = ((byte)(32));
            this.simpleOpenGlControl1.DepthBits = ((byte)(16));
            this.simpleOpenGlControl1.Location = new System.Drawing.Point(0, 0);
            this.simpleOpenGlControl1.Name = "simpleOpenGlControl1";
            this.simpleOpenGlControl1.Size = new System.Drawing.Size(1478, 698);
            this.simpleOpenGlControl1.StencilBits = ((byte)(0));
            this.simpleOpenGlControl1.TabIndex = 0;
            this.simpleOpenGlControl1.Load += new System.EventHandler(this.simpleOpenGlControl1_Load);
            this.simpleOpenGlControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.simpleOpenGlControl1_Paint);
            this.simpleOpenGlControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.simpleOpenGlControl1_KeyPress);
            // 
            // btstart
            // 
            this.btstart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btstart.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btstart.Font = new System.Drawing.Font("Saysettha OT", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btstart.Location = new System.Drawing.Point(473, 497);
            this.btstart.Name = "btstart";
            this.btstart.Size = new System.Drawing.Size(216, 72);
            this.btstart.TabIndex = 1;
            this.btstart.Text = "ເລີ່ມໃໝ່";
            this.btstart.UseVisualStyleBackColor = false;
            this.btstart.Visible = false;
            this.btstart.Click += new System.EventHandler(this.btstart_Click);
            this.btstart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btstart_KeyPress);
            // 
            // btnout
            // 
            this.btnout.BackColor = System.Drawing.Color.Red;
            this.btnout.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnout.Location = new System.Drawing.Point(767, 491);
            this.btnout.Name = "btnout";
            this.btnout.Size = new System.Drawing.Size(211, 78);
            this.btnout.TabIndex = 2;
            this.btnout.Text = "End";
            this.btnout.UseVisualStyleBackColor = false;
            this.btnout.Visible = false;
            this.btnout.Click += new System.EventHandler(this.btnout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(623, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Game Over";
            this.label1.Visible = false;
            // 
            // Crocodile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 696);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnout);
            this.Controls.Add(this.btstart);
            this.Controls.Add(this.simpleOpenGlControl1);
            this.Name = "Crocodile";
            this.Text = "Crocodile";
            this.Load += new System.EventHandler(this.Crocodile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl simpleOpenGlControl1;
        private System.Windows.Forms.Button btstart;
        private System.Windows.Forms.Button btnout;
        private System.Windows.Forms.Label label1;
    }
}