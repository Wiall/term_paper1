using System.ComponentModel;

namespace term_paper_1
{
    partial class ResultsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReturnToMenu = new System.Windows.Forms.Button();
            this.buttonStartAnimation = new System.Windows.Forms.Button();
            this.buttonStopAnimation = new System.Windows.Forms.Button();
            this.radioButton05speed = new System.Windows.Forms.RadioButton();
            this.radioButton10speed = new System.Windows.Forms.RadioButton();
            this.radioButton15speed = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(562, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кількість порівнянь при сортуванні: ";
            // 
            // buttonReturnToMenu
            // 
            this.buttonReturnToMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReturnToMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonReturnToMenu.FlatAppearance.BorderSize = 0;
            this.buttonReturnToMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonReturnToMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonReturnToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturnToMenu.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReturnToMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonReturnToMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonReturnToMenu.Image")));
            this.buttonReturnToMenu.Location = new System.Drawing.Point(539, 54);
            this.buttonReturnToMenu.Name = "buttonReturnToMenu";
            this.buttonReturnToMenu.Size = new System.Drawing.Size(418, 85);
            this.buttonReturnToMenu.TabIndex = 1;
            this.buttonReturnToMenu.Text = "Повернутися до меню";
            this.buttonReturnToMenu.UseVisualStyleBackColor = false;
            this.buttonReturnToMenu.Click += new System.EventHandler(this.buttonReturnToMenu_Click);
            // 
            // buttonStartAnimation
            // 
            this.buttonStartAnimation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStartAnimation.BackColor = System.Drawing.Color.Transparent;
            this.buttonStartAnimation.FlatAppearance.BorderSize = 0;
            this.buttonStartAnimation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonStartAnimation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStartAnimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartAnimation.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartAnimation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStartAnimation.Image = ((System.Drawing.Image)(resources.GetObject("buttonStartAnimation.Image")));
            this.buttonStartAnimation.Location = new System.Drawing.Point(678, 140);
            this.buttonStartAnimation.Name = "buttonStartAnimation";
            this.buttonStartAnimation.Size = new System.Drawing.Size(69, 61);
            this.buttonStartAnimation.TabIndex = 2;
            this.buttonStartAnimation.UseVisualStyleBackColor = false;
            this.buttonStartAnimation.Click += new System.EventHandler(this.buttonStartAnimation_Click);
            // 
            // buttonStopAnimation
            // 
            this.buttonStopAnimation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStopAnimation.BackColor = System.Drawing.Color.Transparent;
            this.buttonStopAnimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopAnimation.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStopAnimation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStopAnimation.Image = ((System.Drawing.Image)(resources.GetObject("buttonStopAnimation.Image")));
            this.buttonStopAnimation.Location = new System.Drawing.Point(753, 140);
            this.buttonStopAnimation.Name = "buttonStopAnimation";
            this.buttonStopAnimation.Size = new System.Drawing.Size(72, 60);
            this.buttonStopAnimation.TabIndex = 3;
            this.buttonStopAnimation.UseVisualStyleBackColor = false;
            this.buttonStopAnimation.Click += new System.EventHandler(this.buttonStopAnimation_Click);
            // 
            // radioButton05speed
            // 
            this.radioButton05speed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton05speed.BackColor = System.Drawing.Color.Transparent;
            this.radioButton05speed.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton05speed.Location = new System.Drawing.Point(1015, 43);
            this.radioButton05speed.Name = "radioButton05speed";
            this.radioButton05speed.Size = new System.Drawing.Size(130, 35);
            this.radioButton05speed.TabIndex = 4;
            this.radioButton05speed.TabStop = true;
            this.radioButton05speed.Text = "0.5x";
            this.radioButton05speed.UseVisualStyleBackColor = false;
            this.radioButton05speed.CheckedChanged += new System.EventHandler(this.radioButton05speed_CheckedChanged);
            // 
            // radioButton10speed
            // 
            this.radioButton10speed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton10speed.BackColor = System.Drawing.Color.Transparent;
            this.radioButton10speed.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton10speed.Location = new System.Drawing.Point(1015, 84);
            this.radioButton10speed.Name = "radioButton10speed";
            this.radioButton10speed.Size = new System.Drawing.Size(114, 31);
            this.radioButton10speed.TabIndex = 5;
            this.radioButton10speed.TabStop = true;
            this.radioButton10speed.Text = "1.0x";
            this.radioButton10speed.UseVisualStyleBackColor = false;
            this.radioButton10speed.CheckedChanged += new System.EventHandler(this.radioButton10speed_CheckedChanged);
            // 
            // radioButton15speed
            // 
            this.radioButton15speed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton15speed.BackColor = System.Drawing.Color.Transparent;
            this.radioButton15speed.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton15speed.Location = new System.Drawing.Point(1015, 121);
            this.radioButton15speed.Name = "radioButton15speed";
            this.radioButton15speed.Size = new System.Drawing.Size(114, 29);
            this.radioButton15speed.TabIndex = 5;
            this.radioButton15speed.TabStop = true;
            this.radioButton15speed.Text = "1.5x";
            this.radioButton15speed.UseVisualStyleBackColor = false;
            this.radioButton15speed.CheckedChanged += new System.EventHandler(this.radioButton15speed_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1011, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Швидкість";
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton15speed);
            this.Controls.Add(this.radioButton10speed);
            this.Controls.Add(this.radioButton05speed);
            this.Controls.Add(this.buttonStopAnimation);
            this.Controls.Add(this.buttonStartAnimation);
            this.Controls.Add(this.buttonReturnToMenu);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 100);
            this.MaximumSize = new System.Drawing.Size(2200, 1000);
            this.MinimumSize = new System.Drawing.Size(1918, 600);
            this.Name = "ResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorting";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.RadioButton radioButton05speed;
        private System.Windows.Forms.RadioButton radioButton10speed;
        private System.Windows.Forms.RadioButton radioButton15speed;

        private System.Windows.Forms.Button buttonStopAnimation;

        private System.Windows.Forms.Button buttonStartAnimation;

        private System.Windows.Forms.Button buttonReturnToMenu;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}