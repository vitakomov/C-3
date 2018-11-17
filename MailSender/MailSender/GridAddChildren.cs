
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MailSender
{
    public static class GridAddChildren
    { 
        /// <summary>Пихаем элемент в грид по указанным данным</summary>                
        /// <returns>индекс позиции добавленного элемента</returns>
        public static int SetFromGrid(this Grid grid, FrameworkElement Control, int Row = -1, int Column = -1, int RowSpan = 1, int ColumnSpan = 1)
        { return grid.SetFromGrid((UIElement)Control, Row, Column, RowSpan, ColumnSpan); }

        /// <summary>Пихаем элемент в грид по указанным данным</summary>                
        /// <returns>индекс позиции добавленного элемента</returns>
        public static int SetFromGrid(this Grid grid, UIElement Control, int Row = -1, int Column = -1, int RowSpan = 1, int ColumnSpan = 1)
        {
            if (Control == null || grid == null)
            { return -1; }
            if (RowSpan < 1 || ColumnSpan < 1)
            { throw new Exception("Ты чё ошалел?\n Нельза спанить на значение меньше 0"); }
            if (grid.Children.Contains(Control))
            { throw new Exception("Попытка добавить дубликат элемента!"); }
            if (Row == -1)
            { Row = grid.RowDefinitions.Count > 0 ? grid.RowDefinitions.Count - 1 : 0; }
            if (Column == -1)
            { Column = grid.ColumnDefinitions.Count > 0 ? grid.ColumnDefinitions.Count - 1 : 0; }

            Grid.SetRow(Control, Row);
            Grid.SetRowSpan(Control, RowSpan);
            Grid.SetColumn(Control, Column);
            Grid.SetColumnSpan(Control, ColumnSpan);
            return grid.Children.Add(Control);
        }
    }
}