using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _5_с_
{
    class Utilities : Desk
    {
        private DataGridView grid;
        private RichTextBox output;

        public Utilities(int field_size, DataGridView grid, RichTextBox output) : base(field_size)
        {
            this.grid = grid;
            this.output = output;
        }

        public void MakeDesk(int field_size)
        {
            GridToMatrix();
        }

        public void CompleteTask()
        {
            GridToMatrix();
            MatrixClear();
            output.Text = "Наименьшее колличество коней - " + FindSol();
            MatrixToGrid();
        }

        public void Clear()
        {
            MatrixClear();
            output.Text = "";
            MakeGrid();
        }

        public void GridToMatrix()
        {
            DataGridViewCell dataCell;

            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    dataCell = grid.Rows[i].Cells[j];

                    switch (dataCell.Style.BackColor.Name)
                    {
                        case ("Red"):
                            field[i, j] = CellStatus.enemy;
                            enemyCnt++;
                            Console.WriteLine(field[i, j].ToString());
                            break;
                        case ("Blue"):
                            field[i, j] = CellStatus.friend;
                            break;
                        default:
                            field[i, j] = CellStatus.empty;
                            break;
                    }
                }
            }
        }
        public void MatrixToGrid()
        {
            DataGridViewCell dataCell;

            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    dataCell = grid.Rows[i].Cells[j];

                    switch(battleField[i,j])
                    {
                        case (CellStatus.horse):
                            dataCell.Style.BackColor = Color.Purple;
                            dataCell.Value = "horse";
                            break;
                        case (CellStatus.underAttack):
                            dataCell.Style.BackColor = Color.DarkOrange;
                            break;
                        case (CellStatus.friend):
                            dataCell.Style.BackColor = Color.Blue;
                            break;
                        default:
                            if (((i % 2 == 0) && (j % 2 != 0)) || ((i % 2 != 0) && (j % 2 == 0)))
                            {
                                grid.Rows[i].Cells[j].Style.BackColor = Color.DimGray;
                            }
                            break;
                    }
                }
            }
        }

        public void MatrixClear()
        {
            DataGridViewCell dataCell;

            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    dataCell = grid.Rows[i].Cells[j];
                    dataCell.Value = "";
                    dataCell.Style.BackColor = Color.White;
                }
            }
        }

        public void MakeGrid()
        {
            grid.ColumnCount = base.fieldSize;
            grid.RowCount = base.fieldSize;

            for (int i = 0; i < base.fieldSize; i++)
            {
                grid.Columns[i].Width = 70;

                for (int j = 0; j < base.fieldSize; j++)
                {

                   if (((i % 2 == 0) && (j % 2 !=0)) || ((i % 2 != 0) && (j % 2 == 0)))
                   {
                        grid.Rows[i].Cells[j].Style.BackColor = Color.DimGray;
                   }
                }
            }
        }

    }
}

//public void Clear()
//{
//    treeViewer.Nodes.Clear();
//}

//public override bool Delete(string word)
//{
//    base.Delete(word);
//    MakeTree();
//    IsChanged = true;
//    output.Text = "Слово было удалено";
//    return true;
//}

//public override bool DeleteSub(string word)
//{
//    base.DeleteSub(word);
//    MakeTree();
//    IsChanged = true;
//    output.Text = "Все записи содержащие заданную подстроку были удалены";
//    return true;
//}

//public override bool Find(string word)
//{
//    if (base.Find(word))
//    {
//        output.Text = "Введенное слово есть в дереве";
//        return true;
//    }
//    output.Text = "Введенного слова нет в дереве";
//    return false;
//}

//public void Open()
//{
//    serializer = new FileSerializer(this);
//    if (fileName.LastIndexOf(".txt") == fileName.Length - 4)
//    {
//        serializer.DeserializeText(fileName);
//        MakeTree();
//        output.Text = "Файл был успешно открыт";
//    }
//    else
//    {
//        output.Text = "Файл не был открыт";
//    }
//}

//public void SaveAs()
//{
//    if (fileName.LastIndexOf(".txt") == fileName.Length - 4)
//    {
//        serializer.SerializeText(fileName);
//        IsChanged = false;
//    }
//    else
//    {
//        output.Text = "Файл не был сохранен";
//    }
//}

//public bool Save()
//{
//    Console.WriteLine("fileName = " + fileName);
//    if (IsChanged)
//    {
//        serializer = new FileSerializer(this);
//        DialogResult result = MessageBox.Show("Сохранить изменения?", "Сохранение", MessageBoxButtons.YesNoCancel);

//        if (result == DialogResult.Cancel)
//        {
//            return false;
//        }
//        else if (result == DialogResult.Yes)
//        {
//            SaveAs();
//        }
//    }
//    return true;
//}

//public void CloseFile()
//{
//    Save();
//    fileName = "";
//    Clear();
//}

//public void SetFileName(string fileName)
//{
//    this.fileName = fileName;
//}
