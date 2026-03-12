using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentCore
{
    public class HeaderBlock : IBlock
    {
        private string _text;
        public string Render()
        {
            return "=== " + _text + " ===";
        }
        public void SetContent(string content)
        {
            _text = content;
        }
        public string GetName()
        {
            return "Заголовок: " + _text;
        }
    }
}