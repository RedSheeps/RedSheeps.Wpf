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

        public string FileName => DateTime.Today.ToString("yyyyMMdd");

        public Command<string> SaveFileCommand => new Command<string>(OnSaveFile);

        public Command<string> OpenFileCommand => new Command<string>(OnOpenFile);
        public Command<IEnumerable<string>> OpenFilesCommand => new Command<IEnumerable<string>>(OnOpenFiles);

        private void OnInitialize()
        {
            
        }

        private void OnSaveFile(string fileName)
        {

        }

        private void OnOpenFile(string fileName)
        {

        }

        private void OnOpenFiles(IEnumerable<string> fileNames)
        {

        }
    }
}
