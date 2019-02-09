using RedSheeps.Wpf.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Sample
{
    public class MainWindowViewModel
    {
        public ICommand InitializeCommand => new Command(OnInitialize);

        private void OnInitialize()
        {
            
        }
    }
}
