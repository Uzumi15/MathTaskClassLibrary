using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentCore
{
    public class DocumentBuilder
    {
        private List<IBlock> _blocks = new List<IBlock>();
        public void AddBlock(IBlock block)
        {
            _blocks.Add(block);
        }
        public void RemoveBlock(int index)
        {
            if (index >= 0 && index < _blocks.Count)
                _blocks.RemoveAt(index);
        }
        public IBlock GetBlock(int index)
        {
            if (index >= 0 && index < _blocks.Count)
                return _blocks[index];
            return null;
        }
        public int BlockCount => _blocks.Count;
        public string Build()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var block in _blocks)
            {
                sb.AppendLine(block.Render());
            }
            return sb.ToString();
        }
    }
}