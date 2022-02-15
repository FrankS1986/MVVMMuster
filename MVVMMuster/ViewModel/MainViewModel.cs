using GalaSoft.MvvmLight;

namespace MainViewModel.ViewModel
{

    public class MainViewModel : ViewModelBase
    {

        public MainViewModel()
        {
            if (IsInDesignMode)
            {
                WindowTitle = "MvvSample (Designmode)";
            }
            else
            {
                WindowTitle = "MvvSample";
            }
        }
        public string WindowTitle { get; private set; }
    }
}