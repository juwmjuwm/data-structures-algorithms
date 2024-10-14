using System.Text.RegularExpressions;

namespace algorithms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SubmitDataBtn_Click(object sender, EventArgs e)
        {
            int[] ints;
            try
            {
                ints = this.InputToNumArray(this.dataInput.Text);
                this.inputDisplay.Text = NumArrayToString(ints);
                this.inputDisplay.ForeColor = Color.Black;
            }
            catch (InvalidDataException ex)
            {
                this.inputDisplay.Text = "INVALID INPUT";
                this.inputDisplay.ForeColor = Color.Red;
                return;
            }

            ISortingAlgorithm alg = new InsertionSort();
            alg.Sort(ints);
            this.outputDisplay.Text = NumArrayToString(ints);
        }

        private int[] InputToNumArray(string input)
        {
            string[] dataArray = Regex.Split(input, @"\s+");
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
    }
}
