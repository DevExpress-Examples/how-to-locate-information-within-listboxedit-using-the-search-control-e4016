using System.Windows.Controls;

namespace ListBoxFilteringUsingSearchPanel {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            listBox.ItemsSource = Stuff.GetStuff();
        }
    }
}
