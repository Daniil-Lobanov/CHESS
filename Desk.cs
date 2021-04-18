using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Backtracking(18конь)*/
/*18. Для шахматного поля размера NxN на котором расставлены черные и белые фигуры,
 найти наименьшее кол-во коней и их расстановку, при которой все поля доски,
 занятые фигурами противоположного цвета, находятся под ударом*/
namespace _5_с_
{
    public enum CellStatus
    {
        empty, friend, enemy, horse, underAttack
    }

    class Desk
    {
        public const int maxFigureNum = 16; //-2 коня = 14 в каждой команде
        public static CellStatus[,] field;
        public static CellStatus[,] battleField;
        public int fieldSize;
        public int enemyCnt;
        /// //////////////////////////////////////////////////////////////
        class Horse
        {
            public int x, y; //сделать свойствами
            public int figuresUnderAttack = 0;

            int[] moveX = {1, -1, -2, 2};
            int[] moveY = { 2, -2, -1, 1};

            bool moveIsPossible(int x, int y, int fieldSize)
            {
                if (((this.x + x) <= fieldSize - 1) && ((this.y + y) <= fieldSize - 1) &&
                    ((this.x + x) >= 0) && ((this.y + y) >= 0))
                {
                    return true;
                }
                return false;
            }

            public bool isThreatingSomeone(/*ref CellStatus[,] currentBattleField,*/ int fieldSize)
            {
                CellStatus[,] currentBattleField = new CellStatus[fieldSize, fieldSize];
                bool isThreatingSomeone = false;
                for (int i = 0; i < moveX.Length; i++)
                {
                    int temp = i/2 == 0 ? 0 : 2;
                    for (int j = temp; j< temp+2; j++)
                    {
                        if (moveIsPossible(moveX[i], moveY[j], fieldSize))
                        {
                            //если противник в клетке хода есть, и если эта клетак не находится под атакой
                            if (field[x + moveX[i], y + moveY[j]] == CellStatus.enemy && 
                                currentBattleField[x + moveX[i], y + moveY[j]] != CellStatus.underAttack)
                            {
                                Console.WriteLine("field[" + x + " + " +  moveX[i] + ", " + y + " + " + moveY[j] + "] == " + (field[x + moveX[i], y + moveY[j]].ToString()));
                                currentBattleField[x + moveX[i], y + moveY[j]] = CellStatus.underAttack;
                                figuresUnderAttack++;
                                isThreatingSomeone = true;
                            }
                        }
                    }
                }
                return isThreatingSomeone;
            }


            public Horse(int x_init, int y_init)
            {
                x = x_init;
                y = y_init;
            }
        }



        public Desk(int fieldSize)
        {
            this.fieldSize = fieldSize;
            field = new CellStatus[fieldSize, fieldSize];
            battleField = new CellStatus[fieldSize, fieldSize];

            for (int i = 0; i<fieldSize; i++)
            {
                for (int j = 0; j< this.fieldSize; j++)
                {
                    battleField[i, j] = CellStatus.empty;
                }
            }
            enemyCnt = 0;
        }

        bool moveToTheNextCell(ref int x, ref int y)
        {
            if (x < fieldSize - 1)
            {
                x++;
                return true;
            }
            else
            {
                if (y < fieldSize - 1)
                {
                    x = 0;
                    y++;
                    return true;
                }
            }
            return false;
        }


        //public int FindBestSol()
        //{
        //    Horse horse = new Horse(0, 0);
        //    if (horse.isThreatingSomeone()) //если с первой клетки
        //    {
        //        return 1;
        //    }

        //    for (int bestResult = 1; bestResult < fieldSize*fieldSize; bestResult++)
        //    {
        //        if (FindBestSol(1,bestResult, 0, 0))
        //        {
        //            return enemyFigureCnt;
        //        }
        //    }
        //    return 0;
        //}


        public int FindSol()
        {
            int bestResult = enemyCnt;
            bool solutionFound = false;

            for (int y = 0; y < fieldSize; y++)
            {
                for (int x = 0; x < fieldSize; x++)
                {
                    Console.WriteLine("(ВНЕШНИЙ УРОВЕНЬ)\nВыбираем новую ячейку");
                    if (FindSol(0, ref bestResult, enemyCnt, x, y))//if (FindSol(0, ref bestResult, battleField, enemyCnt, x, y))
                    {
                        solutionFound = true;
                    }
                }
            }
            if (solutionFound)
            {
                return bestResult;
            }
            return 0;
        }

        //bool TryAddHorse(int x, int y, ref int currentResult, ref CellStatus[,] currentBattleField, ref int figuresUnderAttack)
        //{
        //    Horse horse = new Horse(x, y);
        //    if (horse.isThreatingSomeone(ref currentBattleField, fieldSize))
        //    {
        //        currentBattleField[x, y] = CellStatus.horse;
        //        figuresUnderAttack = horse.figuresUnderAttack;
        //        currentResult++;
        //        return true;
        //    }
        //    return false;
        //}

        //bool FindSol(int currentResult, ref int bestResult, CellStatus[,] currentField, int enemyCnt, int x, int y)
        //{
        //    int i = y;
        //    int j = x;
        //    CellStatus[,] currentBattleField = currentField;

        //    while (moveToTheNextCell(ref j, ref i))
        //    {
        //        Console.WriteLine("(ВНУТРЕННИЙ УРОВЕНЬ)\ny = " + i + "; x = " + j);
        //        if (field[i, j] == CellStatus.empty)
        //        {
        //            int figuresUnderAttack = 0;

        //            if (TryAddHorse(j, i, ref currentResult, ref currentBattleField, ref figuresUnderAttack))
        //            {
        //                if (enemyCnt - figuresUnderAttack > 0) //если решение неполное
        //                {
        //                    Console.WriteLine("(ВНУТРЕННИЙ УРОВЕНЬ)\nНашли неполное решение");
        //                    Console.WriteLine("enemy2go = " + (enemyCnt - figuresUnderAttack));
        //                    Console.WriteLine("переходим на шаг ниже с y=" + i + "; x=" + j);

        //                    //если это неполное решение вообще является решением
        //                    if (FindSol(currentResult, ref bestResult, currentBattleField, enemyCnt - figuresUnderAttack, j, i)) 
        //                    {
        //                        return true;
        //                    }
        //                }
        //                else
        //                {
        //                    Console.WriteLine("(ВНУТРЕННИЙ УРОВЕНЬ)\nНашли полное решение = " + currentResult + "!!!");
        //                    if (currentResult < bestResult)
        //                    {
        //                        bestResult = currentResult;
        //                        battleField = currentBattleField;
        //                    }
        //                    return true;
        //                }
        //                //убираем фигуру с поля

        //                currentBattleField = currentField;
        //                currentResult--;
        //            }
        //        }
        //    }
        //    return false;
        //}



        bool FindSol(int currentResult, ref int bestResult, int enemyCnt, int x, int y)
        {
            int i = y;
            int j = x;
            while (moveToTheNextCell(ref j, ref i))
            {
                //Console.WriteLine("(ВНУТРЕННИЙ УРОВЕНЬ)\ny = " + i + "; x = " + j);
                if (field[i, j] == CellStatus.empty)
                {
                    Console.WriteLine("(ВНУТРЕННИЙ УРОВЕНЬ)\ny = " + i + "; x = " + j);
                    Horse horse = new Horse(j, i);

                    if (horse.isThreatingSomeone(fieldSize))
                    {
                        //помещаем лошадь
                        battleField[x, y] = CellStatus.horse;
                        currentResult++;

                        if (enemyCnt - horse.figuresUnderAttack > 0) //ПРЕДУСМОТРЕТЬ СИТУАЦИЮ ЕСЛИ НИКАК НЕ ПОБИТЬ ФИГУРУ!!!
                        {
                            Console.WriteLine("(ВНУТРЕННИЙ УРОВЕНЬ)\nНашли неполное решение");
                            Console.WriteLine("enemy2go = " + (enemyCnt - horse.figuresUnderAttack));

                            Console.WriteLine("переходим на шаг ниже с y=" + i + "; x=" + j);
                            if (FindSol(currentResult, ref bestResult, enemyCnt - horse.figuresUnderAttack, j, i))
                            {
                                return true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("(ВНУТРЕННИЙ УРОВЕНЬ)\nНашли полное решение = " + currentResult + "!!!");
                            if (currentResult < bestResult)
                            {
                                bestResult = currentResult;
                            }
                            return true;
                        }
                        //убираем фигуру с поля
                        battleField[x, y] = CellStatus.empty;
                        currentResult--;
                    }
                }
            }
            return false;
        }








        //bool FindSol(int currentResult, ref int bestResult, int enemyCnt, int x, int y)
        //{
        //    int i = y;
        //    int j = x;
        //    while (moveToTheNextCell(ref j, ref i))
        //    {
        //        //if (x == fieldSize)
        //            //x = 0;
        //        Console.WriteLine("(ВНУТРЕННИЙ УРОВЕНЬ)\ny = " + i + "; x = " + j);
        //        if (field[i, j] == CellStatus.empty)
        //        {
        //            Horse horse = new Horse(i, j);
        //            battleField[i, j] = CellStatus.horse;
        //            UpdateBattleField();

        //            if (horse.isThreatingSomeone(fieldSize))
        //            {
        //                currentResult++;

        //                if (enemyCnt - horse.figuresUnderAttack > 0) //ПРЕДУСМОТРЕТЬ СИТУАЦИЮ ЕСЛИ НИКАК НЕ ПОБИТЬ ФИГУРУ!!!
        //                {
        //                    //помещаем лошадь
        //                    //обновляем массив побитых

        //                    Console.WriteLine("(ВНУТРЕННИЙ УРОВЕНЬ)\nНашли неполное решение");
        //                    Console.WriteLine("enemy2go = " + (enemyCnt - horse.figuresUnderAttack));

        //                    Console.WriteLine("переходим на шаг ниже с y=" + i + "; x=" + j);
        //                    if (FindSol(currentResult, ref bestResult, enemyCnt - horse.figuresUnderAttack, j, i))
        //                    {
        //                        return true;
        //                    }
        //                }
        //                else
        //                {
        //                    Console.WriteLine("(ВНУТРЕННИЙ УРОВЕНЬ)\nНашли полное решение = " + currentResult + "!!!");
        //                    if (currentResult < bestResult)
        //                    {
        //                        bestResult = currentResult;
        //                    }
        //                    return true;
        //                }
        //                currentResult--;
        //                //убираем фигуру с поля
        //            }
        //        }
        //    }
        //    return false;
        //}























        //bool FindSol(int currentResult, ref int bestResult, int enemyCnt, int x, int y)
        //{
        //    for (int i = y; i < fieldSize; i++)
        //    {
        //        for (int j = x; j < fieldSize; j++)
        //        {
        //            if (x == fieldSize)
        //                x = 0;
        //            Console.WriteLine("(ВНУТРЕННИЙ УРОВЕНЬ)\ny = " + i + "; x = " + j);
        //            if (field[i, j] == CellStatus.empty)
        //            {
        //                Horse horse = new Horse(i, j);

        //                if (horse.isThreatingSomeone(fieldSize))
        //                {
        //                    currentResult++;

        //                    if (enemyCnt - horse.figuresUnderAttack > 0) //ПРЕДУСМОТРЕТЬ СИТУАЦИЮ ЕСЛИ НИКАК НЕ ПОБИТЬ ФИГУРУ!!!
        //                    {
        //                        //помещаем лошадь
        //                        //обновляем массив побитых
        //                        //enemyCnt -= horse.figuresUnderAttack;

        //                        Console.WriteLine("(ВНУТРЕННИЙ УРОВЕНЬ)\nНашли неполное решение");
        //                        Console.WriteLine("enemy2go = " + (enemyCnt - horse.figuresUnderAttack));

        //                        int temp_x = j;
        //                        int temp_y = i;

        //                        moveToTheNextCell(ref temp_x, ref temp_y);

        //                        Console.WriteLine("переходим на шаг ниже с x=" + temp_x + "; y=" + temp_y);
        //                        if (FindSol(currentResult, ref bestResult, enemyCnt - horse.figuresUnderAttack, temp_x, temp_y))
        //                        {
        //                            return true;
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("(ВНУТРЕННИЙ УРОВЕНЬ)\nНашли полное решение = " + currentResult + "!!!");
        //                        if (currentResult < bestResult)
        //                        {
        //                            bestResult = currentResult;
        //                        }
        //                        return true;
        //                    }
        //                    currentResult--;
        //                    //enemyCnt += horse.figuresUnderAttack;
        //                    //убираем фигуру с поля
        //                }
        //            }
        //        }
        //    }
        //    return false;
        //}

        //void FindBestSol(int currentResult, ref int bestResult, int x, int y)
        //{
        //    if (field[x, y] == CellStatus.empty)
        //    {
        //        Horse horse = new Horse(x, y);
        //        if (horse.isThreatingSomeone())
        //        {
        //            //запомаем координаты ЛОШАДИ

        //            currentResult++;
        //            enemyFigureCnt -= horse.figuresUnderAttack; //ввести отдельную переменную

        //            if (enemyFigureCnt != 0) //
        //            {
        //                moveToTheNextCell(ref x, ref y);
        //                FindBestSol(currentResult, ref bestResult, x, y);
        //            }
        //            else
        //            {
        //                //проверка на оптимальность!

        //                if (currentResult < bestResult)
        //                {
        //                    bestResult = currentResult;
        //                }
        //            }

        //            currentResult--;
        //            enemyFigureCnt += horse.figuresUnderAttack;
        //        }
        //    }
        //    moveToTheNextCell(ref x, ref y);
        //    FindBestSol(currentResult, ref bestResult, x, y);
        //}

        //public int FindBestSol()
        //{
        //    int bestResult = enemyFigureCnt;
        //    FindBestSol(0, ref bestResult, 0, 0);
        //    return bestResult;
        //}
    }
}
//void FindBestSol(int currentResult, ref int bestResult, int x, int y)
//{
//    if (field[x, y] == CellStatus.empty)
//    {
//        if (TryPlace(x, y))
//        {
//            //field[x, y] = CellStatus.horse;//запомаем координаты ЛОШАДИ

//            currentResult++;
//            enemyFigureCnt-=Horse.figuresUnderAttack; //ввести отдельную переменную

//            if (enemyFigureCnt != 0) //
//            {
//                if (x < fieldSize - 1)
//                {
//                    x++;
//                }
//                else
//                {
//                    if (y >= fieldSize - 1)
//                    {
//                        return;
//                    }
//                    y++;
//                    x = 0;
//                }
//                FindBestSol(currentResult, ref bestResult, x, y);
//            }
//            else
//            {
//                //проверка на оптимальность!


//                if (currentResult < bestResult)
//                {
//                    bestResult = currentResult;
//                }
//            }

//            //field[x, y] = CellStatus.empty;
//            currentResult--;
//            enemyFigureCnt+=Horse.figuresUnderAttack;
//            FindBestSol(currentResult, ref bestResult, x, y);
//        }
//    }
//    if (x < fieldSize-1)
//    {
//        x++;
//    }
//    else
//    {
//        if (y >= fieldSize-1)
//        {
//            return;
//        }
//        y++;
//        x = 0;
//    }
//    FindBestSol(currentResult, ref bestResult, x, y);
//}
/*public Desk(int field_size)
{
    field = new Figure[n];

    for (int i = 0; i<n; i++)
    {
        field[i] = new Figure[n];
        //field[i] = null;
    }

    Figure[] figures = Randomizer.GetFigures();

    for (int i = 0; i<Randomizer.figuresN; i++)
    {
        Coordinate coord = figures[i].coord;
        field[coord.x][coord.y] = figures[i];
    }
    процедура рандомного заполнения поля фигурами
}*/
/*(public void Try(int i, int j)
        {
            if (field[i,j] == CellStatus.empty)
            {
                //если убивает одним шагом
                //{
                //  добавляем
                //  если решение не полное (enemy_figure_cnt != 0)
                //  {
                //      переходим на следующий шаг
                //  }
                //  иначе
                //  {
                //      проверка оптимальности
                //      {
                //          исключение объекта
                //      }
                //      если приемлимо невключение, то проверяем можем ли не брать объект в решение
                //      если решение неполное (enemy_figure_cnt != 0)
                //          переходим на след шаг
                //      иначе - проверка оптимальности
                //  }
            }
        }*/
//класс для рандомизации и заполнения поля фигурами
//class Randomizer
//{
//    static public int figuresN;
//    //public Figure[] whiteFigures;
//    //public Figure[] blackFigures;
//    static public Figure[] figures;
//    static Random rnd;

//    static Randomizer()
//    {
//        rnd = new Random();
//        int whiteN = rnd.Next(0, Desk.maxFigureNum);
//        int blackN = rnd.Next(0, Desk.maxFigureNum);

//        //whiteFigures = new Figure[whiteN];
//        //blackFigures = new Figure[blackN];
//        figuresN = whiteN + blackN;

//        figures = new Figure[figuresN];

//        for (int i = 0; i< whiteN; i++)
//        {
//            //whiteFigures[i] = new Figure(true, GetRandomCoord());
//            figures[i] = new Figure(true, GetRandomCoord());
//        }

//        for (int i = whiteN; i < figuresN; i++)
//        {
//            //blackFigures[i] = new Figure(false, GetRandomCoord());
//            figures[i] = new Figure(false, GetRandomCoord());
//        }
//    }

//    static public Coordinate GetRandomCoord()
//    {
//        int x = rnd.Next(0, Desk.n);
//        int y = rnd.Next(0, Desk.n);
//        return new Coordinate(x,y);
//    }


//    static public Figure[] GetFigures()
//    {
//        return figures;
//    }

//    //public Figure[] GetWhiteFigures()
//    //{
//    //    return whiteFigures;
//    //}

//    //public Figure[] GetBlackFigures()
//    //{
//    //    return blackFigures;
//    //}
//}


//class Coordinate
//{
//    public int x;
//    public int y;
//    public Coordinate(int x, int y)
//    {
//        this.x = x;
//        this.y = y;
//    }
//}

//класс фигуры - цвет фигуры и возможно тип фигуры
//class Figure
//{
//    //public bool color; //white==true black==false
//    public Coordinate coord;

//    public Figure(bool color, Coordinate coord)
//    {
//        this.color = color;
//        this.coord = coord;
//    }
//}

//class HorseMoves
//{
//    int x, y;


//    public HorseMoves(int x_init, int y_init)
//    {
//        x = x_init;
//        y = y_init;
//    }
//    public int get_x()
//    {
//        return x;
//    }

//    public int get_y()
//    {
//        return y;
//    }

//    public void move_down_right()
//    {
//        x++;
//        y -= 2;
//    }

//    public void move_down_left()
//    {
//        x--;
//        y -= 2;
//    }

//    public void move_up_right()
//    {
//        x++;
//        y += 2;
//    }

//    public void move_up_left()
//    {
//        x--;
//        y += 2;
//    }

//    public void move_left_down()
//    {
//        x-=2;
//        y--;
//    }

//    public void move_right_down()
//    {
//        x += 2;
//        y--;
//    }

//    public void move_left_up()
//    {
//        x -= 2;
//        y++;
//    }

//    public void move_right_up()
//    {
//        x += 2;
//        y++;
//    }

//    /*конь атак(x,y) - (столбец_конь(x)+2 == столбец_фигура(x)) && ( (ряд_конь(y)+1 == ряд_фигура(y)) || (ряд_конь(y)-1 == ряд_фигура(y))) ||   
//                       (столбец_конь(x)-2 == столбец_фигура(x)) && ( (ряд_конь(y)+1 == ряд_фигура(y)) || (ряд_конь(y)-1 == ряд_фигура(y))) ||
//                       (ряд_конь(y)+2 == ряд_фигура(y)) && ( (столбец_конь(x)+1 == столбец_фигура(y)) || (столбец_конь(x)-1 == столбец_фигура(y))) ||
//                       (ряд_конь(y)-2 == ряд_фигура(y)) && ( (столбец_конь(x)+1 == столбец_фигура(y)) || (столбец_конь(x)-1 == столбец_фигура(y))) ||
//     +проверка на то что находится по углам поля или на краю поля

//     Решением является доска, которая удовлетворяет следующим условиям:
//     ---
//     */

//}
//bool TryPlace(int x, int y)
//{
//    Horse horse = new Horse(x, y);
//    return horse ? true : false;
//}

//class Cell
//{
//    public int x, y;
//    public bool isEmpty;

//    public Cell()
//    {
//        isEmpty = false;
//    }
//}
//void bestSol(int& horseCnt/*string& s, string& bests, int& bestCount, int i*/)
//{
//    for (char x = 'A'; x <= 'C'; x++)
//    {
//        if (kills(x,y)/*rightText(s + x)*/) // включение приемлемо
//        {
//            horseCnt++;//s = s + x; //включение буквы x;
//            if (i < n)
//            {
//                bestSol(s, bests, bestCount, i + 1);
//            }
//            else
//            {
//                int count = sumOrd(s); //код строки
//                if (bestCount > count) //проверка оптимальности // если строка больше лушчего кода
//                {
//                    bests = s; //лучший текущий результат присваивается текущему результату
//                    bestCount = count; //а код лучшей строки присваивается текущему коду строки
//                }

//            }
//            s.erase(s.length() - 1, 1); //исключение буквы x //исключаем из решения последнюю добавленную букву?
//        }
//    }
//}
//текст с минимальной суммой кодов букв
//void bestSolution(string& bests)
//{
//    string s = "";
//    bests = "";
//    int bestCount = 'C' * n + 1;
//    bestSol(s, bests, bestCount, 1);
//}
//static public bool threat_down_right()
//{
//    try
//    {
//        if (field[x + 1, y + 2] != CellStatus.enemy)
//        {
//            return false;
//        }
//        //field[x + 1, y + 2] = CellStatus.underAttack;
//        figuresUnderAttack++;
//        return true;
//    }
//    catch (IndexOutOfRangeException)
//    {
//        return false;
//    }
//}

//static public bool threat_down_left()
//{
//    try
//    {
//        if (field[x - 1, y + 2] != CellStatus.enemy)
//        {
//            return false;
//        }
//        //field[x + 1, y + 2] = CellStatus.underAttack;
//        figuresUnderAttack++;
//        return true;
//    }
//    catch (IndexOutOfRangeException)
//    {
//        return false;
//    }
//}

//static public bool threat_up_right()
//{
//    try
//    {
//        if (field[x + 1, y + 2] != CellStatus.enemy)
//        {
//            return false;
//        }
//        //field[x + 1, y - 2] = CellStatus.underAttack;
//        figuresUnderAttack++;
//        return true;
//    }
//    catch (IndexOutOfRangeException)
//    {
//        return false;
//    }
//}

//static public bool threat_up_left()
//{
//    try
//    {
//        if (field[x - 1, y + 2] != CellStatus.enemy)
//        {
//            return false;
//        }
//        //field[x - 1, y + 2] = CellStatus.underAttack;
//        figuresUnderAttack++;
//        return true;
//    }
//    catch (IndexOutOfRangeException)
//    {
//        return false;
//    }
//}

//static public bool threat_left_down()
//{
//    try
//    {
//        if (field[x - 2, y - 1] != CellStatus.enemy)
//        {
//            return false;
//        }
//        //field[x - 2, y + 1] = CellStatus.underAttack;
//        figuresUnderAttack++;
//        return true;
//    }
//    catch (IndexOutOfRangeException)
//    {
//        return false;
//    }
//}

//static public bool threat_right_down()
//{
//    try
//    {
//        if (field[x + 2, y + 1] != CellStatus.enemy)
//        {
//            return false;
//        }
//        //field[x + 2, y + 1] = CellStatus.underAttack;
//        figuresUnderAttack++;
//        return true;
//    }
//    catch (IndexOutOfRangeException)
//    {
//        return false;
//    }
//}

//static public bool threat_left_up()
//{
//    try
//    {
//        if (field[x - 2, y - 1] != CellStatus.enemy)
//        {
//            return false;
//        }
//        //field[x - 2, y - 1] = CellStatus.underAttack;
//        figuresUnderAttack++;
//        return true;
//    }
//    catch (IndexOutOfRangeException)
//    {
//        return false;
//    }
//}

//static public bool threat_right_up()
//{
//    try
//    {
//        if (field[x + 2, y - 1] != CellStatus.enemy)
//        {
//            return false;
//        }
//        //field[x + 2, y - 1] = CellStatus.underAttack;
//        figuresUnderAttack++;
//        return true;
//    }
//    catch (IndexOutOfRangeException)
//    {
//        return false;
//    }
//}

//public static bool operator true(Horse op)
//{
//    return threat_down_right() | threat_down_left() | threat_up_right() | threat_up_left() |
//           threat_right_down() | threat_left_down() | threat_right_up() | threat_left_up();
//}
//public static bool operator false(Horse op)
//{
//    return !threat_down_right() & !threat_down_left() & !threat_up_right() & !threat_up_left() &
//           !threat_right_down() & !threat_left_down() & !threat_right_up() & !threat_left_up();
//}