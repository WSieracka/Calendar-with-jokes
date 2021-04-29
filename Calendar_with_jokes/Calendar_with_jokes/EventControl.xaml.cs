using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calendar_with_jokes
{
    /// <summary>
    /// Klasa tworzaca pojedyncze wydarzenie wyswietlane w kalendarzu
    /// </summary>
    public partial class EventControl : UserControl
    {
        /// <summary>
        /// Kontruktor tworzacy pojedyncze wydarzenie wyswietlane w kalendarzu
        /// </summary>
        public EventControl()
        {
            InitializeComponent();
        }
    }
}
