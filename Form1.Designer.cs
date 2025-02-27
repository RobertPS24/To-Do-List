namespace ToDoListApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTask = new TextBox();
            btnAddTask = new Button();
            btnRemoveTask = new Button();
            btnCompleteTask = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            lstTasks = new ListBox();
            SuspendLayout();
            // 
            // txtTask
            // 
            txtTask.Location = new Point(276, 31);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(125, 27);
            txtTask.TabIndex = 0;
            txtTask.TextChanged += textBox1_TextChanged;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(295, 86);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(94, 29);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTask
            // 
            btnRemoveTask.Location = new Point(172, 254);
            btnRemoveTask.Name = "btnRemoveTask";
            btnRemoveTask.Size = new Size(165, 29);
            btnRemoveTask.TabIndex = 2;
            btnRemoveTask.Text = "Remove Task";
            btnRemoveTask.UseVisualStyleBackColor = true;
            // 
            // btnCompleteTask
            // 
            btnCompleteTask.Location = new Point(335, 254);
            btnCompleteTask.Name = "btnCompleteTask";
            btnCompleteTask.Size = new Size(164, 29);
            btnCompleteTask.TabIndex = 3;
            btnCompleteTask.Text = "Complete Task";
            btnCompleteTask.UseVisualStyleBackColor = true;
            btnCompleteTask.Click += button3_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(243, 371);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(345, 371);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // lstTasks
            // 
            lstTasks.FormattingEnabled = true;
            lstTasks.Location = new Point(172, 130);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(327, 104);
            lstTasks.TabIndex = 6;
            lstTasks.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(700, 450);
            Controls.Add(lstTasks);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnCompleteTask);
            Controls.Add(btnRemoveTask);
            Controls.Add(btnAddTask);
            Controls.Add(txtTask);
            Name = "Form1";
            Text = "ToDoList";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTask;
        private Button btnAddTask;
        private Button btnRemoveTask;
        private Button btnCompleteTask;
        private Button btnSave;
        private Button btnLoad;
        private ListBox lstTasks;

    }
}
