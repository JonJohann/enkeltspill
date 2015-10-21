namespace enkeltSpill
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
            this.Ball = new System.Windows.Forms.PictureBox();
            this.gameEngine = new System.Windows.Forms.Timer(this.components);
            this.LeftBar = new System.Windows.Forms.PictureBox();
            this.RightBar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valgPanel = new System.Windows.Forms.Panel();
            this.btAvslutt = new System.Windows.Forms.Button();
            this.btNyttSpill = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBar)).BeginInit();
            this.valgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ball
            // 
            this.Ball.Image = global::enkeltSpill.Properties.Resources.ball;
            this.Ball.Location = new System.Drawing.Point(238, 132);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(30, 30);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ball.TabIndex = 0;
            this.Ball.TabStop = false;
            // 
            // gameEngine
            // 
            this.gameEngine.Interval = 64;
            this.gameEngine.Tick += new System.EventHandler(this.gameEngine_Tick);
            // 
            // LeftBar
            // 
            this.LeftBar.BackColor = System.Drawing.SystemColors.Desktop;
            this.LeftBar.Location = new System.Drawing.Point(12, 90);
            this.LeftBar.Name = "LeftBar";
            this.LeftBar.Size = new System.Drawing.Size(20, 100);
            this.LeftBar.TabIndex = 1;
            this.LeftBar.TabStop = false;
            // 
            // RightBar
            // 
            this.RightBar.BackColor = System.Drawing.SystemColors.Desktop;
            this.RightBar.Location = new System.Drawing.Point(498, 90);
            this.RightBar.Name = "RightBar";
            this.RightBar.Size = new System.Drawing.Size(20, 100);
            this.RightBar.TabIndex = 2;
            this.RightBar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "0";
            // 
            // valgPanel
            // 
            this.valgPanel.Controls.Add(this.btAvslutt);
            this.valgPanel.Controls.Add(this.btNyttSpill);
            this.valgPanel.Controls.Add(this.label3);
            this.valgPanel.Location = new System.Drawing.Point(12, 233);
            this.valgPanel.Name = "valgPanel";
            this.valgPanel.Size = new System.Drawing.Size(59, 54);
            this.valgPanel.TabIndex = 5;
            // 
            // btAvslutt
            // 
            this.btAvslutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAvslutt.Location = new System.Drawing.Point(246, 119);
            this.btAvslutt.Name = "btAvslutt";
            this.btAvslutt.Size = new System.Drawing.Size(122, 32);
            this.btAvslutt.TabIndex = 2;
            this.btAvslutt.Text = "Avslutt";
            this.btAvslutt.UseVisualStyleBackColor = true;
            this.btAvslutt.Click += new System.EventHandler(this.btAvslutt_Click);
            // 
            // btNyttSpill
            // 
            this.btNyttSpill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNyttSpill.Location = new System.Drawing.Point(118, 119);
            this.btNyttSpill.Name = "btNyttSpill";
            this.btNyttSpill.Size = new System.Drawing.Size(122, 32);
            this.btNyttSpill.TabIndex = 1;
            this.btNyttSpill.Text = "Nytt spill";
            this.btNyttSpill.UseVisualStyleBackColor = true;
            this.btNyttSpill.Click += new System.EventHandler(this.btNyttSpill_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "GAME OVER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 299);
            this.Controls.Add(this.valgPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RightBar);
            this.Controls.Add(this.LeftBar);
            this.Controls.Add(this.Ball);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBar)).EndInit();
            this.valgPanel.ResumeLayout(false);
            this.valgPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer gameEngine;
        private System.Windows.Forms.PictureBox LeftBar;
        private System.Windows.Forms.PictureBox RightBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel valgPanel;
        private System.Windows.Forms.Button btAvslutt;
        private System.Windows.Forms.Button btNyttSpill;
        private System.Windows.Forms.Label label3;
    }
}

