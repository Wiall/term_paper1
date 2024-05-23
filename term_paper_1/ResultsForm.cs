using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Brushes = System.Drawing.Brushes;

namespace term_paper_1
{
    public partial class ResultsForm : Form
    {
        private const int RectangleWidth = 9;
        private const int Spacing = 2;
        private Timer _animationTimer;
        private PictureBox _pictureBox;
        private int[] _tempArray;
        private int _currentStateIndex;
        private readonly bool _visualCheck;
        private readonly Color _rectangleColor1 = ColorTranslator.FromHtml("#7D94C4");
        private readonly Color _rectangleColor2 = ColorTranslator.FromHtml("#ebcf89");
        public ResultsForm(bool st)
        {
            InitializeComponent();
            _visualCheck = st;
            if (!st)
                UpdateButtonsVisibility();
            InitializePictureBox();
            InitializeTimer();
            
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(buttonStartAnimation, "Почати/продовжити анімацію");
            toolTip.SetToolTip(buttonStopAnimation, "Зупинити анімацію");
        }
        
        private void InitializePictureBox()
        {
            _pictureBox = new PictureBox();
            _pictureBox.Dock = DockStyle.Fill;
            _pictureBox.Paint += PictureBox_Paint;
            Controls.Add(_pictureBox);
            
        }
        private void InitializeTimer()
        {
            _animationTimer = new Timer();
            _animationTimer.Interval = 150;
            _animationTimer.Tick += AnimationTimer_Tick;
        }
        
        

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (_currentStateIndex < Sorting.ArrayStates.Count)
            {
                _tempArray = Sorting.ArrayStates[_currentStateIndex];
                UpdatePictureBox();
                UpdateCountLabel();
                _currentStateIndex++;
            }
            else
            {
                _animationTimer.Stop();
            }
        }
        
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (_tempArray == null) return;
            int pictureBoxWidth = _pictureBox.ClientSize.Width;
            int pictureBoxHeight = _pictureBox.ClientSize.Height;
    
            int arrayLength = Sorting.Array.Length;
    
            int totalRectanglesWidth = arrayLength * RectangleWidth + (arrayLength - 1) * Spacing;
            int totalRectanglesHeight = _tempArray.Max() * 3;
    
            int startX = (pictureBoxWidth - totalRectanglesWidth) / 2;
            int startY = (pictureBoxHeight - totalRectanglesHeight) / 2;
            
            Font font = new Font("Arial", 5);

            for (int i = 0; i < arrayLength; i++)
            {
                int value = _tempArray[i];

                Brush brush = (value < 0) ? new SolidBrush(_rectangleColor2) : new SolidBrush(_rectangleColor1);

                int rectangleHeight = Math.Abs(value) * 2;

                int rectangleWidth = RectangleWidth;
                int rectangleX = startX + i * (rectangleWidth + Spacing);
                int rectangleY = startY + (totalRectanglesHeight - rectangleHeight);

                e.Graphics.FillRectangle(brush, rectangleX, rectangleY, rectangleWidth, rectangleHeight);
                
                string text = value.ToString();
                SizeF textSize = e.Graphics.MeasureString(text, font);
                float textX = rectangleX + (rectangleWidth - textSize.Width) / 2;
                float textY = rectangleY + (rectangleHeight - textSize.Height) / 2;
                e.Graphics.DrawString(text, font, Brushes.Black, textX, textY);
            }
        }


        private void StartAnimation()
        {
            _animationTimer.Start();
            if(_currentStateIndex == Sorting.ArrayStates.Count)
                _currentStateIndex = 0;
        } 
        
        private void UpdateButtonsVisibility()
        {
            if (!_visualCheck || Sorting.Array.Length != 100)
            {
                buttonStartAnimation.Visible = false;
                buttonStopAnimation.Visible = false;
                radioButton05speed.Visible = false;
                radioButton10speed.Visible = false;
                radioButton15speed.Visible = false;
                label2.Visible = false;
            }
        }
        
        private void UpdatePictureBox() => _pictureBox.Invalidate();
        public void UpdateCountLabel()
        {
            if (Sorting.ChosenSortingMethod == Sorting.SortingMethod.HeapSort ||Sorting.ChosenSortingMethod == Sorting.SortingMethod.SmoothSort)
            {
                label1.Text = "Практична складність алгоритму: " + Sorting.SwapsCount;
            }
            else
            {
                label1.Text = "Практична складність алгоритму: " + Sorting.MaxRecursionDepth * Sorting.Array.Length;
            }
            
        }
        private void buttonReturnToMenu_Click(object sender, EventArgs e) => Hide();
        private void buttonStartAnimation_Click(object sender, EventArgs e) => StartAnimation();
        private void buttonStopAnimation_Click(object sender, EventArgs e) => StopAnimation();
        private void StopAnimation() => _animationTimer.Stop();
        private void radioButton05speed_CheckedChanged(object sender, EventArgs e) => _animationTimer.Interval = 300;
        private void radioButton10speed_CheckedChanged(object sender, EventArgs e) => _animationTimer.Interval = 200;
        private void radioButton15speed_CheckedChanged(object sender, EventArgs e) => _animationTimer.Interval = 100;
    }
}
