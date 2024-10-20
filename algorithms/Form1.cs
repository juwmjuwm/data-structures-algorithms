using algorithms.algorithms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace algorithms
{
    public partial class MainForm : Form
    {

        private SortingApp _sortingApp;

        public MainForm()
        {
            InitializeComponent();
            _sortingApp = new SortingApp();
        }

        private void SubmitDataBtn_Click(object sender, EventArgs e)
        {
            int[] ints;
            try
            {
                _sortingApp.Data = this.InputToNumArray(this.dataInput.Text, @"\s+");
                this.inputDisplay.Text = _sortingApp.DisplayData();
                this.inputDisplay.ForeColor = Color.Black;
            }
            catch (InvalidDataException ex)
            {
                this.inputDisplay.Text = "INVALID INPUT";
                this.inputDisplay.ForeColor = Color.Red;
                return;
            }
        }

        private void generatorBtn_Click(object sender, EventArgs e)
        {
            int len = Convert.ToInt32(this.generatorLengthPicker.Value);
            Generator generator = new Generator();
            int[] randArr = generator.RandArray(len, 0, 1000);
            _sortingApp.Data = randArr;
            this.inputDisplay.Text = _sortingApp.DisplayData();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            ISortingAlgorithm alg = IdToAlgorithm(((AlgComboItem)this.algorithmComboBox.SelectedItem).Id);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int[] sortedCopy = new int[_sortingApp.Data.Length];
            Array.Copy(_sortingApp.Data, sortedCopy, sortedCopy.Length);
            alg.Sort(sortedCopy);
            stopwatch.Stop();
            this.outputDisplay.Text = _sortingApp.DisplayData(sortedCopy);
            this.runningTime.Text = $"{stopwatch.ElapsedMilliseconds} ms";
        }

        private int[] InputToNumArray(string input, string sepPattern)
        {
            input = input.Trim();
            string[] dataArray = Regex.Split(input, sepPattern);
            int[] numDataArray = new int[dataArray.Length];
            for (int i = 0; i < dataArray.Length; i++)
            {
                try
                {
                    numDataArray[i] = int.Parse(dataArray[i]);
                }
                catch (Exception ex)
                {
                    throw new InvalidDataException();
                }
            }
            return numDataArray;
        }

        private string NumArrayToString(int[] array)
        {
            return string.Join("; ", array);
        }

        private static ISortingAlgorithm IdToAlgorithm(int id)
        {
            Dictionary<int, ISortingAlgorithm> algDict = new Dictionary<int, ISortingAlgorithm>();
            algDict.Add(1, new BubbleSort());
            algDict.Add(2, new InsertionSort());
            algDict.Add(4, new MergeSort2());
            algDict.Add(5, new QuickSort());
            return algDict[id];
        }
    }
}
