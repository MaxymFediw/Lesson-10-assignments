namespace Lesson_10_assignments
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
            this.btnSound = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.imgPig = new System.Windows.Forms.PictureBox();
            this.imgDog = new System.Windows.Forms.PictureBox();
            this.imgCat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSound
            // 
            this.btnSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSound.Location = new System.Drawing.Point(509, 22);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(230, 94);
            this.btnSound.TabIndex = 0;
            this.btnSound.Text = "Click For The Sound";
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(50, 386);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(99, 33);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score:";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(12, 47);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(425, 33);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "What Animal Made The Sound?";
            // 
            // imgPig
            // 
            this.imgPig.Image = global::Lesson_10_assignments.Properties.Resources.pig;
            this.imgPig.Location = new System.Drawing.Point(549, 169);
            this.imgPig.Name = "imgPig";
            this.imgPig.Size = new System.Drawing.Size(200, 166);
            this.imgPig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPig.TabIndex = 5;
            this.imgPig.TabStop = false;
            this.imgPig.Click += new System.EventHandler(this.imgPig_Click);
            // 
            // imgDog
            // 
            this.imgDog.Image = global::Lesson_10_assignments.Properties.Resources.dog;
            this.imgDog.Location = new System.Drawing.Point(300, 169);
            this.imgDog.Name = "imgDog";
            this.imgDog.Size = new System.Drawing.Size(200, 166);
            this.imgDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDog.TabIndex = 4;
            this.imgDog.TabStop = false;
            this.imgDog.Click += new System.EventHandler(this.imgDog_Click);
            // 
            // imgCat
            // 
            this.imgCat.Image = global::Lesson_10_assignments.Properties.Resources.cat;
            this.imgCat.Location = new System.Drawing.Point(56, 169);
            this.imgCat.Name = "imgCat";
            this.imgCat.Size = new System.Drawing.Size(200, 166);
            this.imgCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCat.TabIndex = 3;
            this.imgCat.TabStop = false;
            this.imgCat.Click += new System.EventHandler(this.imgCat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgPig);
            this.Controls.Add(this.imgDog);
            this.Controls.Add(this.imgCat);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnSound);
            this.Name = "Form1";
            this.Text = "GUI Part 3 - Sounds and stuff.";
            ((System.ComponentModel.ISupportInitialize)(this.imgPig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.PictureBox imgCat;
        private System.Windows.Forms.PictureBox imgDog;
        private System.Windows.Forms.PictureBox imgPig;
    }
}

