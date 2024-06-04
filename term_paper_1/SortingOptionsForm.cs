using System;
using System.Threading;
using System.Windows.Forms;

namespace term_paper_1
{
    public partial class SortingOptionsForm : Form
    {
        private Sorting _sortMethod;
        
        public SortingOptionsForm()
        {
            InitializeComponent();
        }

        private void ShowQuickSortOptions()
        {
            QuickSortOptionForm quickSortOptionForm = new QuickSortOptionForm();
            if (quickSortOptionForm.ShowDialog() != DialogResult.OK) return;
            QuickSortingVariant selectedOption = quickSortOptionForm.SelectedOption;

            switch (selectedOption)
            {
                case QuickSortingVariant.OnePivot:
                {
                    QuickSortingOnePivot quickSortingOnePivot = new QuickSortingOnePivot();
                    Thread sortingThread = new Thread(() =>
                    {
                        quickSortingOnePivot.QuickSort(0, Sorting.Array.Length - 1);
                    }, 1024 * 1024 * 64);

                    sortingThread.Start();
                    sortingThread.Join();
                    
                    _sortMethod = quickSortingOnePivot;
                    Sorting.ChosenSortingMethod = Sorting.SortingMethod.QuickSortOnePivot;
                    quickSortingOnePivot.SetSortingMethod(Sorting.SortingMethod.QuickSortOnePivot);
                    break;
                }
                case QuickSortingVariant.OneMedianPivot:
                {
                    QuickSortingMedianPivot quickSortingMedianPivot = new QuickSortingMedianPivot();
                    quickSortingMedianPivot.QuickSort(0, Sorting.Array.Length - 1);
                    _sortMethod = quickSortingMedianPivot;
                    Sorting.ChosenSortingMethod = Sorting.SortingMethod.QuickSortMedianPivot;
                    quickSortingMedianPivot.SetSortingMethod(Sorting.SortingMethod.QuickSortMedianPivot);
                    break;
                }
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void buttonSortingOptionOk_Click_1(object sender, EventArgs e)
        {
            switch (radioButtonQuickSort.Checked)
            {
                case true:
                    ShowQuickSortOptions();
                    break;
                default:
                {
                    if (radioButtonHeapSort.Checked)
                    {
                        HeapSorting heapSort = new HeapSorting();
                        heapSort.HeapSort();
                        _sortMethod = heapSort;
                        Sorting.ChosenSortingMethod = Sorting.SortingMethod.HeapSort;
                        heapSort.SetSortingMethod(Sorting.SortingMethod.HeapSort);
                    }
                    else if (radioButtonSmoothSort.Checked)
                    {
                        SmoothSorting smoothSort = new SmoothSorting();
                        smoothSort.SmoothSort();
                        _sortMethod = smoothSort;
                        Sorting.ChosenSortingMethod = Sorting.SortingMethod.SmoothSort;
                        smoothSort.SetSortingMethod(Sorting.SortingMethod.SmoothSort);
                    }else
                    {
                        MessageBox.Show("Не обрано жодного методу сортування");
                        return;
                    }

                    break;
                }
            }
            
            
            
            if (Sorting.Array.Length > 100 && checkBoxVisualize.Checked )
            {
                MessageBox.Show("Візуалізація доступна лише на масивах\nз розміром 100");
                return;
                
            }if (checkBoxVisualize.Checked && !CheckArrayElements())
            {
                MessageBox.Show("Візуалізація не доступна на масивах з елементами більше 150 за модулем");
                return;
            }
            if (checkBoxVisualize.Checked && Sorting.Array.Length == 100)
            {
                
                Sorting.ArrayStates = Sorting.FilterConsecutiveStates(Sorting.ArrayStates);
                Sorting.SaveArrayState();
            }
            if (checkBoxSaving.Checked && _sortMethod != null)
            {
                _sortMethod.SaveResults();
            }
            Hide();
            ResultsForm resultsForm = new ResultsForm(checkBoxVisualize.Checked);
            resultsForm.UpdateCountLabel();
            resultsForm.ShowDialog();
        }
        private bool CheckArrayElements()
        {
            foreach (int element in Sorting.Array)
            {
                if (element > 150 || element < -150)
                    return false;
            }
            return true;
        }
    }
}