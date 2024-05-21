using System;
using System.Windows.Forms;

namespace term_paper_1
{
    public partial class QuickSortOptionForm : Form
    {
        public QuickSortingVariant SelectedOption { get; private set; }
        public QuickSortOptionForm() => InitializeComponent();

        private void buttonQuicksortWindowOK_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                SelectedOption = QuickSortingVariant.OnePivot;
            }
            else if (radioButton2.Checked)
            {
                SelectedOption = QuickSortingVariant.OneMedianPivot;
            }
            
            DialogResult = DialogResult.OK;
            Close();
        }
        
    }

    public enum QuickSortingVariant
    {
        OnePivot,
        OneMedianPivot,
    }
}