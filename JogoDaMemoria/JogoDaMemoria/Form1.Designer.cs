
namespace JogoDaMemoria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.iniciargame = new System.Windows.Forms.Button();
            this.iniciargame2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // iniciargame
            // 
            this.iniciargame.Location = new System.Drawing.Point(612, 32);
            this.iniciargame.Name = "iniciargame";
            this.iniciargame.Size = new System.Drawing.Size(160, 90);
            this.iniciargame.TabIndex = 0;
            this.iniciargame.Text = "INICIAR COM 16 PEDRAS (Por enquanto só esse funciona)";
            this.iniciargame.UseVisualStyleBackColor = true;
            this.iniciargame.Click += new System.EventHandler(this.iniciargame_Click);
            // 
            // iniciargame2
            // 
            this.iniciargame2.Location = new System.Drawing.Point(612, 194);
            this.iniciargame2.Name = "iniciargame2";
            this.iniciargame2.Size = new System.Drawing.Size(160, 90);
            this.iniciargame2.TabIndex = 1;
            this.iniciargame2.Text = "INICIAR COM 8 PEDRAS (Fase de testes)";
            this.iniciargame2.UseVisualStyleBackColor = true;
            this.iniciargame2.Click += new System.EventHandler(this.iniciargame2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iniciargame2);
            this.Controls.Add(this.iniciargame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button iniciargame;
        private System.Windows.Forms.Button iniciargame2;
    }
}

