using System.ComponentModel;
using System.Windows.Forms;

namespace term_paper_1
{
    partial class SortingOptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortingOptionsForm));
            this.radioButtonQuickSort = new System.Windows.Forms.RadioButton();
            this.radioButtonHeapSort = new System.Windows.Forms.RadioButton();
            this.radioButtonSmoothSort = new System.Windows.Forms.RadioButton();
            this.checkBoxSaving = new System.Windows.Forms.CheckBox();
            this.checkBoxVisualize = new System.Windows.Forms.CheckBox();
            this.buttonSortingOptionOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonQuickSort
            // 
            this.radioButtonQuickSort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonQuickSort.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonQuickSort.Font = new System.Drawing.Font("Sitka Small", 7.8F);
            this.radioButtonQuickSort.Location = new System.Drawing.Point(95, 95);
            this.radioButtonQuickSort.Name = "radioButtonQuickSort";
            this.radioButtonQuickSort.Size = new System.Drawing.Size(196, 38);
            this.radioButtonQuickSort.TabIndex = 1;
            this.radioButtonQuickSort.TabStop = true;
            this.radioButtonQuickSort.Text = "Швидке сортування";
            this.radioButtonQuickSort.UseVisualStyleBackColor = false;
            // 
            // radioButtonHeapSort
            // 
            this.radioButtonHeapSort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonHeapSort.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonHeapSort.Font = new System.Drawing.Font("Sitka Small", 7.8F);
            this.radioButtonHeapSort.Location = new System.Drawing.Point(318, 99);
            this.radioButtonHeapSort.Name = "radioButtonHeapSort";
            this.radioButtonHeapSort.Size = new System.Drawing.Size(251, 30);
            this.radioButtonHeapSort.TabIndex = 2;
            this.radioButtonHeapSort.TabStop = true;
            this.radioButtonHeapSort.Text = "Пірамідальне сортування";
            this.radioButtonHeapSort.UseVisualStyleBackColor = false;
            // 
            // radioButtonSmoothSort
            // 
            this.radioButtonSmoothSort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonSmoothSort.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonSmoothSort.Font = new System.Drawing.Font("Sitka Small", 7.8F);
            this.radioButtonSmoothSort.Location = new System.Drawing.Point(585, 102);
            this.radioButtonSmoothSort.Name = "radioButtonSmoothSort";
            this.radioButtonSmoothSort.Size = new System.Drawing.Size(188, 24);
            this.radioButtonSmoothSort.TabIndex = 3;
            this.radioButtonSmoothSort.TabStop = true;
            this.radioButtonSmoothSort.Text = "Плавне сортування";
            this.radioButtonSmoothSort.UseVisualStyleBackColor = false;
            // 
            // checkBoxSaving
            // 
            this.checkBoxSaving.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxSaving.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxSaving.Font = new System.Drawing.Font("Sitka Small", 7.8F);
            this.checkBoxSaving.Location = new System.Drawing.Point(318, 246);
            this.checkBoxSaving.Name = "checkBoxSaving";
            this.checkBoxSaving.Size = new System.Drawing.Size(211, 30);
            this.checkBoxSaving.TabIndex = 4;
            this.checkBoxSaving.Text = "Зберегти результати";
            this.checkBoxSaving.UseVisualStyleBackColor = false;
            // 
            // checkBoxVisualize
            // 
            this.checkBoxVisualize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxVisualize.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxVisualize.Font = new System.Drawing.Font("Sitka Small", 7.8F);
            this.checkBoxVisualize.Location = new System.Drawing.Point(318, 211);
            this.checkBoxVisualize.Name = "checkBoxVisualize";
            this.checkBoxVisualize.Size = new System.Drawing.Size(226, 29);
            this.checkBoxVisualize.TabIndex = 5;
            this.checkBoxVisualize.Text = "Показати візуалізацію";
            this.checkBoxVisualize.UseVisualStyleBackColor = false;
            // 
            // buttonSortingOptionOk
            // 
            this.buttonSortingOptionOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSortingOptionOk.BackColor = System.Drawing.Color.Transparent;
            this.buttonSortingOptionOk.FlatAppearance.BorderSize = 0;
            this.buttonSortingOptionOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSortingOptionOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSortingOptionOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortingOptionOk.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.buttonSortingOptionOk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSortingOptionOk.Image = ((System.Drawing.Image)(resources.GetObject("buttonSortingOptionOk.Image")));
            this.buttonSortingOptionOk.Location = new System.Drawing.Point(294, 282);
            this.buttonSortingOptionOk.MinimumSize = new System.Drawing.Size(220, 40);
            this.buttonSortingOptionOk.Name = "buttonSortingOptionOk";
            this.buttonSortingOptionOk.Size = new System.Drawing.Size(235, 54);
            this.buttonSortingOptionOk.TabIndex = 7;
            this.buttonSortingOptionOk.Text = "Почати";
            this.buttonSortingOptionOk.UseVisualStyleBackColor = false;
            this.buttonSortingOptionOk.Click += new System.EventHandler(this.buttonSortingOptionOk_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 10F);
            this.label1.Location = new System.Drawing.Point(294, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Оберіть метод сортування:";
            // 
            // SortingOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(855, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSortingOptionOk);
            this.Controls.Add(this.checkBoxVisualize);
            this.Controls.Add(this.checkBoxSaving);
            this.Controls.Add(this.radioButtonSmoothSort);
            this.Controls.Add(this.radioButtonHeapSort);
            this.Controls.Add(this.radioButtonQuickSort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.MinimumSize = new System.Drawing.Size(740, 400);
            this.Name = "SortingOptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorting";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button buttonSortingOptionOk;

        private System.Windows.Forms.CheckBox checkBoxVisualize;

        private System.Windows.Forms.CheckBox checkBoxSaving;

        private System.Windows.Forms.RadioButton radioButtonSmoothSort;

        public System.Windows.Forms.RadioButton radioButtonHeapSort;

        public System.Windows.Forms.RadioButton radioButtonQuickSort;

        #endregion
    }
}