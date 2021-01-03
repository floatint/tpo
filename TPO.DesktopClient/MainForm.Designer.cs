namespace TPO.DesktopClient
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.taskListLabel = new System.Windows.Forms.Label();
            this.taskListBox = new System.Windows.Forms.ListBox();
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.taskNameTextBox = new System.Windows.Forms.TextBox();
            this.taskDescrLabel = new System.Windows.Forms.Label();
            this.taskDescrTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.detailTaskDescrLabel = new System.Windows.Forms.Label();
            this.detailTaskDescrTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // taskListLabel
            // 
            this.taskListLabel.AutoSize = true;
            this.taskListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskListLabel.Location = new System.Drawing.Point(3, 9);
            this.taskListLabel.Name = "taskListLabel";
            this.taskListLabel.Size = new System.Drawing.Size(137, 25);
            this.taskListLabel.TabIndex = 0;
            this.taskListLabel.Text = "Список задач";
            // 
            // taskListBox
            // 
            this.taskListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskListBox.FormattingEnabled = true;
            this.taskListBox.ItemHeight = 25;
            this.taskListBox.Location = new System.Drawing.Point(8, 37);
            this.taskListBox.Name = "taskListBox";
            this.taskListBox.Size = new System.Drawing.Size(324, 204);
            this.taskListBox.TabIndex = 1;
            this.taskListBox.SelectedIndexChanged += new System.EventHandler(this.taskListBox_SelectedIndexChanged);
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskNameLabel.Location = new System.Drawing.Point(413, 9);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(169, 25);
            this.taskNameLabel.TabIndex = 2;
            this.taskNameLabel.Text = "Название задачи";
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskNameTextBox.Location = new System.Drawing.Point(418, 37);
            this.taskNameTextBox.MaxLength = 16;
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.ShortcutsEnabled = false;
            this.taskNameTextBox.Size = new System.Drawing.Size(346, 30);
            this.taskNameTextBox.TabIndex = 3;
            this.taskNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.taskNameTextBox_KeyPress);
            // 
            // taskDescrLabel
            // 
            this.taskDescrLabel.AutoSize = true;
            this.taskDescrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskDescrLabel.Location = new System.Drawing.Point(413, 81);
            this.taskDescrLabel.Name = "taskDescrLabel";
            this.taskDescrLabel.Size = new System.Drawing.Size(172, 25);
            this.taskDescrLabel.TabIndex = 4;
            this.taskDescrLabel.Text = "Описание задачи";
            // 
            // taskDescrTextBox
            // 
            this.taskDescrTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskDescrTextBox.Location = new System.Drawing.Point(418, 109);
            this.taskDescrTextBox.MaxLength = 48;
            this.taskDescrTextBox.Multiline = true;
            this.taskDescrTextBox.Name = "taskDescrTextBox";
            this.taskDescrTextBox.Size = new System.Drawing.Size(346, 58);
            this.taskDescrTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(418, 173);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(127, 34);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(591, 173);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(126, 34);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // detailTaskDescrLabel
            // 
            this.detailTaskDescrLabel.AutoSize = true;
            this.detailTaskDescrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detailTaskDescrLabel.Location = new System.Drawing.Point(3, 288);
            this.detailTaskDescrLabel.Name = "detailTaskDescrLabel";
            this.detailTaskDescrLabel.Size = new System.Drawing.Size(276, 25);
            this.detailTaskDescrLabel.TabIndex = 8;
            this.detailTaskDescrLabel.Text = "Подробное описание задачи";
            // 
            // detailTaskDescrTextBox
            // 
            this.detailTaskDescrTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detailTaskDescrTextBox.Location = new System.Drawing.Point(8, 316);
            this.detailTaskDescrTextBox.Multiline = true;
            this.detailTaskDescrTextBox.Name = "detailTaskDescrTextBox";
            this.detailTaskDescrTextBox.ReadOnly = true;
            this.detailTaskDescrTextBox.Size = new System.Drawing.Size(324, 122);
            this.detailTaskDescrTextBox.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.detailTaskDescrTextBox);
            this.Controls.Add(this.detailTaskDescrLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.taskDescrTextBox);
            this.Controls.Add(this.taskDescrLabel);
            this.Controls.Add(this.taskNameTextBox);
            this.Controls.Add(this.taskNameLabel);
            this.Controls.Add(this.taskListBox);
            this.Controls.Add(this.taskListLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "TodoList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskListLabel;
        private System.Windows.Forms.ListBox taskListBox;
        private System.Windows.Forms.Label taskNameLabel;
        private System.Windows.Forms.TextBox taskNameTextBox;
        private System.Windows.Forms.Label taskDescrLabel;
        private System.Windows.Forms.TextBox taskDescrTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label detailTaskDescrLabel;
        private System.Windows.Forms.TextBox detailTaskDescrTextBox;
    }
}

