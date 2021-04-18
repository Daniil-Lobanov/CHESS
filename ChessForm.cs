using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*Backtracking(18конь)*/
/*18. Для шахматного поля размера NxN на котором расставлены черные и белые фигуры,
 найти наименьшее кол-во коней и их расстановку, при которой все поля доски,
 занятые фигурами противоположного цвета, находятся под ударом*/


namespace _5_с_
{
    public partial class ChessForm : Form
    {
        private Utilities desk;
        public ChessForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            Application.Idle += Application_Idle;
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            ChessView.Visible = desk != null && desk.fieldSize != 0;
            CompleteTaskMenu.Visible = desk != null && desk.fieldSize != 0;
            TaskButton.Visible = desk != null && desk.fieldSize != 0;
        }

        private void Change_Size_Click(object sender, EventArgs e)
        {
            ParamsForm newForm = new ParamsForm();
            newForm.ShowDialog();

            if (newForm.DialogResult == DialogResult.Yes)
            {
                if (desk!=null)
                {
                    desk.MatrixClear();
                }
                desk = new Utilities(newForm.GetSize(), ChessView, Output);
                desk.MakeGrid();
                newForm.Dispose();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            desk.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CompleteTask(object sender, EventArgs e)
        {
            desk = new Utilities(desk.fieldSize, ChessView, Output);
            desk.CompleteTask();
        }

        private void ChessView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ChessView.CurrentCell.Style.BackColor = Color.Red;
        }

        private void ChessView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ChessView.CurrentCell.Style.BackColor = Color.Blue;
        }

        private void ChessView_SelectionChanged(object sender, EventArgs e)
        {
            ChessView.ClearSelection();
        }
    }
}





/*        private void New_Click(object sender, EventArgs e)
        {
            //if (tree != null)
            //{
            //    tree.CloseFile();
            //}
            //if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog.FileName.Length > 0)
            //{
            //    tree = new Utilities(saveFileDialog.FileName, treeViewer, Output);
            //    tree.SaveAs();
            //}
        }

    private void TaskForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (tree != null && tree.IsChanged)
            //{
            //    if (!tree.Save())
            //    {
            //        e.Cancel = true;
            //    }
            //}
        }

        private void Open_Click(object sender, EventArgs e)
        {
            //if (tree != null)
            //{
            //    tree.CloseFile();
            //}
            //if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog.FileName.Length > 0) //сначала открывается
            //{
            //    this.tree = new Utilities(openFileDialog.FileName, treeViewer, Output);
            //    tree.Open();
            //}
        }
        private void SaveAs_Click(object sender, EventArgs e)
        {
            //if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog.FileName.Length > 0)
            //{
            //    tree.SetFileName(saveFileDialog.FileName);
            //    tree.SaveAs();
            //}
        }

        private void Save_Click(object sender, EventArgs e)
        {
            //tree.Save();
        }

        private void CloseFile_Click(object sender, EventArgs e)
        {
            //tree.CloseFile();
        }
         private void Find_Click(object sender, EventArgs e)
        {
            //ParamsForm newForm = new ParamsForm();
            //newForm.ShowDialog();

            //if (newForm.DialogResult == DialogResult.Yes)
            //{
            //    tree.Find(newForm.GetWord());
            //    newForm.Dispose();
            //}
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //ParamsForm newForm = new ParamsForm();
            //newForm.ShowDialog();

            //if (newForm.DialogResult == DialogResult.Yes)
            //{
            //    tree.Delete(newForm.GetWord());
            //    newForm.Dispose();
            //}
        }
*/
