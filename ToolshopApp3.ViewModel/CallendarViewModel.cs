using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ToolshopApp3.ViewModel
{
    public class CallendarViewModel : BaseViewModel
    {
        private bool unhideButtonVisibility = true;

        public bool UnhideButtonVisibility
        {
            get { return unhideButtonVisibility; }
            set { unhideButtonVisibility = value; OnPropertyChanged(); }
        }

        private bool stackPanelVisibility = false;
        public bool StackPanelVisibility        {
            get { return stackPanelVisibility; }
            set { stackPanelVisibility = value; OnPropertyChanged(); }
        }
        public ICommand ChangeVisibilityCommand { get; private set; }
        public CallendarViewModel()
        {
            ChangeVisibilityCommand = new DelegateCommand(ChangeVisibility);
        }
        private void ChangeVisibility()
        {
            StackPanelVisibility = UnhideButtonVisibility;
            UnhideButtonVisibility = !StackPanelVisibility;
        }
    }
}
