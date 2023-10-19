namespace Tomagotchi_SlobodanPetkovic
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
            this.components = new System.ComponentModel.Container();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblWelzijn = new System.Windows.Forms.Label();
            this.lblDrinken = new System.Windows.Forms.Label();
            this.lblEten = new System.Windows.Forms.Label();
            this.barWelzijn = new System.Windows.Forms.ProgressBar();
            this.barDrinken = new System.Windows.Forms.ProgressBar();
            this.barEten = new System.Windows.Forms.ProgressBar();
            this.btnDrinken = new System.Windows.Forms.Button();
            this.btnEten = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbAfbeelding = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbAfbeelding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(26, 119);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 19;
            this.lblScore.Text = "Score";
           
            // 
            // lblWelzijn
            // 
            this.lblWelzijn.AutoSize = true;
            this.lblWelzijn.Location = new System.Drawing.Point(190, 82);
            this.lblWelzijn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelzijn.Name = "lblWelzijn";
            this.lblWelzijn.Size = new System.Drawing.Size(41, 13);
            this.lblWelzijn.TabIndex = 18;
            this.lblWelzijn.Text = "Welzijn";
         
            // 
            // lblDrinken
            // 
            this.lblDrinken.AutoSize = true;
            this.lblDrinken.Location = new System.Drawing.Point(313, 9);
            this.lblDrinken.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDrinken.Name = "lblDrinken";
            this.lblDrinken.Size = new System.Drawing.Size(47, 13);
            this.lblDrinken.TabIndex = 17;
            this.lblDrinken.Text = "Drinken:";
            
            // 
            // lblEten
            // 
            this.lblEten.AutoSize = true;
            this.lblEten.Location = new System.Drawing.Point(26, 9);
            this.lblEten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEten.Name = "lblEten";
            this.lblEten.Size = new System.Drawing.Size(32, 13);
            this.lblEten.TabIndex = 16;
            this.lblEten.Text = "Eten:";
           
            // 
            // barWelzijn
            // 
            this.barWelzijn.Location = new System.Drawing.Point(193, 97);
            this.barWelzijn.Margin = new System.Windows.Forms.Padding(2);
            this.barWelzijn.Name = "barWelzijn";
            this.barWelzijn.Size = new System.Drawing.Size(233, 35);
            this.barWelzijn.TabIndex = 14;
            this.barWelzijn.Value = 100;
          
            // 
            // barDrinken
            // 
            this.barDrinken.Location = new System.Drawing.Point(316, 29);
            this.barDrinken.Margin = new System.Windows.Forms.Padding(2);
            this.barDrinken.Name = "barDrinken";
            this.barDrinken.Size = new System.Drawing.Size(233, 35);
            this.barDrinken.TabIndex = 13;
            this.barDrinken.Value = 100;
           
            // 
            // barEten
            // 
            this.barEten.Location = new System.Drawing.Point(29, 29);
            this.barEten.Margin = new System.Windows.Forms.Padding(2);
            this.barEten.Name = "barEten";
            this.barEten.Size = new System.Drawing.Size(233, 35);
            this.barEten.TabIndex = 12;
            this.barEten.Value = 100;
          
            // 
            // btnDrinken
            // 
            this.btnDrinken.Location = new System.Drawing.Point(490, 387);
            this.btnDrinken.Margin = new System.Windows.Forms.Padding(2);
            this.btnDrinken.Name = "btnDrinken";
            this.btnDrinken.Size = new System.Drawing.Size(88, 38);
            this.btnDrinken.TabIndex = 11;
            this.btnDrinken.Text = "drinken";
            this.btnDrinken.UseVisualStyleBackColor = true;
            this.btnDrinken.Click += new System.EventHandler(this.btnDrinken_Click);
            // 
            // btnEten
            // 
            this.btnEten.Location = new System.Drawing.Point(11, 387);
            this.btnEten.Margin = new System.Windows.Forms.Padding(2);
            this.btnEten.Name = "btnEten";
            this.btnEten.Size = new System.Drawing.Size(88, 38);
            this.btnEten.TabIndex = 10;
            this.btnEten.Text = "eten";
            this.btnEten.UseVisualStyleBackColor = true;
            this.btnEten.Click += new System.EventHandler(this.btnEten_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbAfbeelding
            // 
            this.pbAfbeelding.Image = global::Tomagotchi_SlobodanPetkovic.Properties.Resources.max;
            this.pbAfbeelding.Location = new System.Drawing.Point(131, 149);
            this.pbAfbeelding.Name = "pbAfbeelding";
            this.pbAfbeelding.Size = new System.Drawing.Size(354, 275);
            this.pbAfbeelding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAfbeelding.TabIndex = 20;
            this.pbAfbeelding.TabStop = false;
            // 
            // bindingSource1
            // 
          
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(608, 436);
            this.Controls.Add(this.pbAfbeelding);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblWelzijn);
            this.Controls.Add(this.lblDrinken);
            this.Controls.Add(this.lblEten);
            this.Controls.Add(this.barWelzijn);
            this.Controls.Add(this.barDrinken);
            this.Controls.Add(this.barEten);
            this.Controls.Add(this.btnDrinken);
            this.Controls.Add(this.btnEten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAfbeelding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblWelzijn;
        private System.Windows.Forms.Label lblDrinken;
        private System.Windows.Forms.Label lblEten;
        private System.Windows.Forms.ProgressBar barWelzijn;
        private System.Windows.Forms.ProgressBar barDrinken;
        private System.Windows.Forms.ProgressBar barEten;
        private System.Windows.Forms.Button btnDrinken;
        private System.Windows.Forms.Button btnEten;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox pbAfbeelding;
    }
}

