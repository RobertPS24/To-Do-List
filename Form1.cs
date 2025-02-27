using System.IO;
using System.Windows.Forms;
namespace ToDoListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnAddTask.Click += btnAddTask_Click;
            btnRemoveTask.Click += btnRemoveTask_Click;
            btnCompleteTask.Click += btnCompleteTask_Click;
            btnSave.Click += btnSave_Click;
            btnLoad.Click += btnLoad_Click;

            this.BackColor = Color.LightGray;

            btnAddTask.BackColor = Color.Blue;
            btnAddTask.ForeColor = Color.White;

            btnRemoveTask.BackColor = Color.Red;
            btnRemoveTask.ForeColor = Color.White;

            btnCompleteTask.BackColor = Color.Green;
            btnCompleteTask.ForeColor = Color.White;

            btnSave.BackColor = Color.Orange;
            btnSave.ForeColor = Color.Black;

            btnLoad.BackColor = Color.Purple;
            btnLoad.ForeColor = Color.White;


            lstTasks.BackColor = Color.Beige;
            lstTasks.ForeColor = Color.Black;



            lstTasks.HorizontalScrollbar = false;
            lstTasks.HorizontalExtent = 0;





        }


        //
        private void UpdateHorizontalScroll()
        {
            int maxWidth = 0;
            using (Graphics g = lstTasks.CreateGraphics())
            {
                foreach (var item in lstTasks.Items)
                {
                    int itemWidth = (int)g.MeasureString(item.ToString(), lstTasks.Font).Width;
                    if (itemWidth > maxWidth)
                        maxWidth = itemWidth;
                }
            }


            if (maxWidth > lstTasks.ClientSize.Width)
            {
                lstTasks.HorizontalScrollbar = true;
                lstTasks.HorizontalExtent = maxWidth;
            }
            else
            {
                lstTasks.HorizontalScrollbar = false;
            }
        }

        //

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTask.Text))
            {
                lstTasks.Items.Add(txtTask.Text);
                txtTask.Clear();
                UpdateHorizontalScroll();
            }
            else
            {
                MessageBox.Show("Please enter a task!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null)
            {
                lstTasks.Items.Remove(lstTasks.SelectedItem);
                UpdateHorizontalScroll();
            }
            else
            {
                MessageBox.Show("Please select a task to remove!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null)
            {
                int index = lstTasks.SelectedIndex;
                string task = lstTasks.SelectedItem.ToString();

                if (!task.StartsWith("[✔] "))
                {
                    lstTasks.Items[index] = "[✔] " + task;
                }
            }
            else
            {
                MessageBox.Show("Please select a task to mark as complete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("tasks.txt"))
            {
                foreach (var item in lstTasks.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }
            MessageBox.Show("Tasks saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists("tasks.txt"))
            {
                lstTasks.Items.Clear();
                using (StreamReader reader = new StreamReader("tasks.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lstTasks.Items.Add(line);
                    }
                }
                MessageBox.Show("Tasks loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No saved tasks found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
