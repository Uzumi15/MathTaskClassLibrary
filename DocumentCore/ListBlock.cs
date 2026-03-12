using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentCore
{
    public class ListBlock : IBlock
    {
        private List<string> _items = new List<string>();
        public void SetContent(string content)
        {
            _items.Clear();
            string[] lines = content.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                _items.Add(line.Trim());
            }
        }
        public string Render()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in _items)
            {
                sb.AppendLine("• " + item);
            }
            return sb.ToString();
        }
        public string GetName()
        {
            return $"Список (элементов: {_items.Count})";
        }
    }
}