namespace _5_с_
{
    partial class ChessForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChessForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ChangeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeMenuSize = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeMenuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.CompleteTaskMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SizeButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TaskButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ClearButton = new System.Windows.Forms.ToolStripButton();
            this.ExitButton = new System.Windows.Forms.ToolStripButton();
            this.ChessView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChessView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeMenu,
            this.CompleteTaskMenu,
            this.MenuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1054, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ChangeMenu
            // 
            this.ChangeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeMenuSize,
            this.ChangeMenuClear});
            this.ChangeMenu.Name = "ChangeMenu";
            this.ChangeMenu.Size = new System.Drawing.Size(137, 24);
            this.ChangeMenu.Text = "Редактирование";
            // 
            // ChangeMenuSize
            // 
            this.ChangeMenuSize.Name = "ChangeMenuSize";
            this.ChangeMenuSize.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.ChangeMenuSize.Size = new System.Drawing.Size(350, 26);
            this.ChangeMenuSize.Text = "Изменить размерность доски";
            this.ChangeMenuSize.Click += new System.EventHandler(this.Change_Size_Click);
            // 
            // ChangeMenuClear
            // 
            this.ChangeMenuClear.Name = "ChangeMenuClear";
            this.ChangeMenuClear.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.ChangeMenuClear.Size = new System.Drawing.Size(350, 26);
            this.ChangeMenuClear.Text = "Очистить";
            this.ChangeMenuClear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // CompleteTaskMenu
            // 
            this.CompleteTaskMenu.Name = "CompleteTaskMenu";
            this.CompleteTaskMenu.Size = new System.Drawing.Size(162, 24);
            this.CompleteTaskMenu.Text = "Выполнить задание";
            this.CompleteTaskMenu.Click += new System.EventHandler(this.CompleteTask);
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.MenuExit.Size = new System.Drawing.Size(67, 24);
            this.MenuExit.Text = "Выход";
            this.MenuExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Output
            // 
            this.Output.Enabled = false;
            this.Output.Location = new System.Drawing.Point(12, 578);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(1030, 37);
            this.Output.TabIndex = 1;
            this.Output.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.InitialDirectory = "D:\\C#\\Лабы стр и алг 4 семестр\\2\\Trie(13)";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.InitialDirectory = "D:\\C#\\Лабы стр и алг 4 семестр\\2\\Trie(13)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SizeButton,
            this.toolStripSeparator1,
            this.TaskButton,
            this.toolStripSeparator2,
            this.ClearButton,
            this.ExitButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1054, 27);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SizeButton
            // 
            this.SizeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SizeButton.Image = ((System.Drawing.Image)(resources.GetObject("SizeButton.Image")));
            this.SizeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SizeButton.Name = "SizeButton";
            this.SizeButton.Size = new System.Drawing.Size(29, 24);
            this.SizeButton.Text = "Задать размерность доски";
            this.SizeButton.Click += new System.EventHandler(this.Change_Size_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // TaskButton
            // 
            this.TaskButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TaskButton.Image = ((System.Drawing.Image)(resources.GetObject("TaskButton.Image")));
            this.TaskButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TaskButton.Name = "TaskButton";
            this.TaskButton.Size = new System.Drawing.Size(29, 24);
            this.TaskButton.Text = "Выполнить задание";
            this.TaskButton.Click += new System.EventHandler(this.CompleteTask);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // ClearButton
            // 
            this.ClearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearButton.Image")));
            this.ClearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(29, 24);
            this.ClearButton.Text = "Очистить таблицу";
            this.ClearButton.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(29, 24);
            this.ExitButton.Text = "Выход";
            this.ExitButton.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ChessView
            // 
            this.ChessView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChessView.Location = new System.Drawing.Point(12, 58);
            this.ChessView.Name = "ChessView";
            this.ChessView.ReadOnly = true;
            this.ChessView.RowHeadersWidth = 50;
            this.ChessView.RowTemplate.Height = 24;
            this.ChessView.Size = new System.Drawing.Size(1030, 514);
            this.ChessView.TabIndex = 13;
            this.ChessView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChessView_CellClick);
            this.ChessView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChessView_CellDoubleClick);
            this.ChessView.SelectionChanged += new System.EventHandler(this.ChessView_SelectionChanged);
            // 
            // ChessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 627);
            this.Controls.Add(this.ChessView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChessForm";
            this.Text = "Шахматы";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChessView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ChangeMenu;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.ToolStripMenuItem ChangeMenuSize;
        private System.Windows.Forms.ToolStripMenuItem ChangeMenuClear;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SizeButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ClearButton;
        private System.Windows.Forms.ToolStripButton ExitButton;
        private System.Windows.Forms.ToolStripMenuItem CompleteTaskMenu;
        private System.Windows.Forms.ToolStripButton TaskButton;
        private System.Windows.Forms.DataGridView ChessView;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
    }
}

