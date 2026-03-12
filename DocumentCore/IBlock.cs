using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentCore
{
    public interface IBlock
    {
        string Render();
        void SetContent(string content);
        string GetName();
    }
}