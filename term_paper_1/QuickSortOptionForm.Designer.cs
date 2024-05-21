using System.ComponentModel;

namespace term_paper_1
{
    partial class QuickSortOptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickSortOptionForm));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.buttonQuicksortWindowOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(28, 48);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(255, 33);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Один опорний елемент";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(28, 87);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(292, 30);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Медіанний опорний елемент";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // buttonQuicksortWindowOK
            // 
            this.buttonQuicksortWindowOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonQuicksortWindowOK.BackColor = System.Drawing.Color.White;
            this.buttonQuicksortWindowOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuicksortWindowOK.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonQuicksortWindowOK.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonQuicksortWindowOK.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuicksortWindowOK.Image")));
            this.buttonQuicksortWindowOK.Location = new System.Drawing.Point(71, 136);
            this.buttonQuicksortWindowOK.Name = "buttonQuicksortWindowOK";
            this.buttonQuicksortWindowOK.Size = new System.Drawing.Size(195, 45);
            this.buttonQuicksortWindowOK.TabIndex = 3;
            this.buttonQuicksortWindowOK.Text = "Ок";
            this.buttonQuicksortWindowOK.UseVisualStyleBackColor = false;
            this.buttonQuicksortWindowOK.Click += new System.EventHandler(this.buttonQuicksortWindowOK_Click);
            // 
            // QuickSortOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(332, 209);
            this.Controls.Add(this.buttonQuicksortWindowOK);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuickSortOptionForm";
            this.Text = "QuickSortOptions";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonQuicksortWindowOK;

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;

        #endregion
    }
}