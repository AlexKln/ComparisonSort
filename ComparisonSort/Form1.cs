using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComparisonSort
{
    public partial class ComparisonSort : Form
    {
        public ComparisonSort()
        {
            InitializeComponent();
        }

        private void btnHeapSort_Click(object sender, EventArgs e)
        {
            string arrInput = txtInput.Text;
            string[] tokens = arrInput.Split(',');
            List<int> numList = new List<int>();
            int singleNum;
            foreach (string s in tokens)
            {
                if (Int32.TryParse(s, out singleNum))
                    numList.Add(singleNum);
            }
            int[] numArray = numList.ToArray();
            if (numArray.Length < 1)
            {
                MessageBox.Show("Wrong input");
                btnClear_Click(sender, e);
            } else
            {
                HeapSort.sort(numArray);
                foreach (int x in numArray)
                {
                    txtOutput.Text = txtOutput.Text + x.ToString() + ",";
                }
                txtOutput.Text = txtOutput.Text.Remove(txtOutput.Text.ToString().LastIndexOf(","), 1);
                txtComparisons.Text = HeapSort.comparisonCounter.ToString();
                HeapSort.comparisonCounter = 0;
                btnHeapSort.Enabled = false;
                btnMergeSort.Enabled = false;
                btnInsertionSort.Enabled = false;
                btnQuickSort.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtOutput.Text = "";
            txtComparisons.Text = "";
            btnHeapSort.Enabled = true;
            btnMergeSort.Enabled = true;
            btnInsertionSort.Enabled = true;
            btnQuickSort.Enabled = true;
        }

        private void btnMergeSort_Click(object sender, EventArgs e)
        {
            string arrInput = txtInput.Text;
            string[] tokens = arrInput.Split(',');
            List<int> numList = new List<int>();
            int singleNum;
            foreach (string s in tokens)
            {
                if (Int32.TryParse(s, out singleNum))
                    numList.Add(singleNum);
            }
            int[] numArray = numList.ToArray();
            if (numArray.Length < 1)
            {
                MessageBox.Show("Wrong input");
                btnClear_Click(sender, e);
            }
            else
            {
                MergeSort.SortMerge(numArray, 0, numArray.Length - 1);
                foreach (int x in numArray)
                {
                    txtOutput.Text = txtOutput.Text + x.ToString() + ",";
                }
                txtOutput.Text = txtOutput.Text.Remove(txtOutput.Text.ToString().LastIndexOf(","), 1);
                txtComparisons.Text = MergeSort.comparisonCounter.ToString();
                MergeSort.comparisonCounter = 0;
                btnHeapSort.Enabled = false;
                btnMergeSort.Enabled = false;
                btnInsertionSort.Enabled = false;
                btnQuickSort.Enabled = false;
            }
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            string arrInput = txtInput.Text;
            string[] tokens = arrInput.Split(',');
            List<int> numList = new List<int>();
            int singleNum;
            foreach (string s in tokens)
            {
                if (Int32.TryParse(s, out singleNum))
                    numList.Add(singleNum);
            }
            int[] numArray = numList.ToArray();
            if (numArray.Length < 1)
            {
                MessageBox.Show("Wrong input");
                btnClear_Click(sender, e);
            }
            else
            {
                QuickSort.quickSort(numArray, 0, numArray.Length - 1);
                foreach (int x in numArray)
                {
                    txtOutput.Text = txtOutput.Text + x.ToString() + ",";
                }
                txtOutput.Text = txtOutput.Text.Remove(txtOutput.Text.ToString().LastIndexOf(","), 1);
                txtComparisons.Text = QuickSort.comparisonCounter.ToString();
                QuickSort.comparisonCounter = 0;
                btnHeapSort.Enabled = false;
                btnMergeSort.Enabled = false;
                btnInsertionSort.Enabled = false;
                btnQuickSort.Enabled = false;
            }
        }

        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            string arrInput = txtInput.Text;
            string[] tokens = arrInput.Split(',');
            List<int> numList = new List<int>();
            int singleNum;
            foreach (string s in tokens)
            {
                if (Int32.TryParse(s, out singleNum))
                    numList.Add(singleNum);
            }
            int[] numArray = numList.ToArray();
            if (numArray.Length < 1)
            {
                MessageBox.Show("Wrong input");
                btnClear_Click(sender, e);
            }
            else
            {
                InsertionSort.sort(numArray);
                foreach (int x in numArray)
                {
                    txtOutput.Text = txtOutput.Text + x.ToString() + ",";
                }
                txtOutput.Text = txtOutput.Text.Remove(txtOutput.Text.ToString().LastIndexOf(","), 1);
                txtComparisons.Text = InsertionSort.comparisonCounter.ToString();
                InsertionSort.comparisonCounter = 0;
                btnHeapSort.Enabled = false;
                btnMergeSort.Enabled = false;
                btnInsertionSort.Enabled = false;
                btnQuickSort.Enabled = false;
            }
        }
    }
}
