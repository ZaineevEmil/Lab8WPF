using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab8WPF
{
    class MyCommands
    {
        public static RoutedCommand Color { get; set; }

        static MyCommands()
        {
            Color = new RoutedCommand("Color", typeof(MyCommands));
        }

    }
}
