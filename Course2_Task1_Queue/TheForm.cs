using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace Course2_Task1_Queue
{
    public partial class TheForm : Form
    {
        MyQueue queue = new MyQueue();

        public TheForm()
        {
            InitializeComponent();
            
        }
    
        private void ShowQueue(MyQueue q)
        {
            SurnameListBox.Items.Clear();
            for (int i = 0; i < q.Count; i++)
            {
                string s = q.Dequeue();
                SurnameListBox.Items.Add(s);
                q.Enqueue(s);
            }
        }

        private void FileChooseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    openFileDialog.InitialDirectory = Path.GetDirectoryName(openFileDialog.FileName);
                    string[] input = IOUtils.ReadInputFromFile(openFileDialog.FileName);
                    for (int i = 0; i < input.Length; i++)
                        Logic.QueueAddSort(queue, input[i]);
                    ShowQueue(queue);
                }
                catch (Exception except)
                {
                    FormsUtils.ErrorMessageBox(except);
                }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            Logic.QueueAddSort(queue, InsertTextBox.Text);
            ShowQueue(queue);
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    saveFileDialog.InitialDirectory = Path.GetDirectoryName(saveFileDialog.FileName);
                    File.WriteAllText(saveFileDialog.FileName, queue.ConvertToString());
                }
                catch (Exception except)
                {
                    FormsUtils.ErrorMessageBox(except);
                }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            queue.Clear();
            ShowQueue(queue);
        }
    }
}
