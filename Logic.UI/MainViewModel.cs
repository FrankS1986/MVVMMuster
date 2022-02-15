using GalaSoft.MvvmLight;

namespace Logic.UI
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