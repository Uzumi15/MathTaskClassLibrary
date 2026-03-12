using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentCore
{
    public class TableBlock : IBlock
    {
        private string[,] _cells;
        private int _rows, _cols;
        public void SetContent(string content)
        {
            // Ожидается формат: строки разделены переносом, ячейки разделены табуляцией
            string[] rows = content.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            _rows = rows.Length;
            _cols = rows[0].Split('\t').Length;
            _cells = new string[_rows, _cols];
            for (int i = 0; i < _rows; i++)
            {
                string[] cols = rows[i].Split('\t');
                for (int j = 0; j < cols.Length; j++)
                {
                    _cells[i, j] = cols[j];
                }
            }
        }
        public string Render()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    sb.Append(_cells[i, j]?.PadRight(15) + " | ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
        public string GetName()
        {
            return $"Таблица {_rows}x{_cols}";
        }
    }
}