using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Terminal
{
    public enum LibraryAppState
    {
        DisplayList = 1,
        SearchAuthor = 2,
        SearchTitle = 3,
        SelectBook = 4,
        ReturnBook = 5,
        QuitApp = 6
    }
}
