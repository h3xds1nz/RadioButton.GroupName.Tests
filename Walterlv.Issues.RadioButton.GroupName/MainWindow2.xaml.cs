using System.ComponentModel;
using System.Threading;
using System.Windows;

namespace Walterlv.Issues
{
    public partial class MainWindow2 : Window
    {
        public MainWindow2()
        {
            InitializeComponent();
        }
    }

    public class Foo2 : INotifyPropertyChanged
    {
        public static Foo Instance { get; } = new Foo();

        public bool Bar
        {
            get => _bar;
            set
            {
                if (!Equals(_bar, value))
                {
                    _bar = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Bar)));
                }
            }
        }

        public bool Kitty
        {
            get => _kitty;
            set
            {
                if (!Equals(_kitty, value))
                {
                    _kitty = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Kitty)));
                }
            }
        }

        private bool _kitty;
        private bool _bar;
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
