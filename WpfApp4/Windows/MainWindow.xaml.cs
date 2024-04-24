using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using WpfApp4.Models;

namespace WpfApp4.Windows;

public partial class MainWindow : Window
{
    public ObservableCollection<Car>? Cars { get; set; }
    public MainWindow()
    {
        Cars = new ObservableCollection<Car>();
        Cars.Add(new Car() { Model = "Nissan", Vendor = "KIa", Year = "1222" });
        Cars.Add(new Car() { Model = "Hunday", Vendor = "KIa", Year = "1222" });
        Cars.Add(new Car() { Model = "BMW", Vendor = "KIa", Year = "1222" });
        InitializeComponent();
        DataContext = this;
    }

    private void ListView_PreviewMouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        Update_AddWindow update_AddWindow = new Update_AddWindow();
        update_AddWindow.Car = (sender as ListView).SelectedItem as Car;
        update_AddWindow.Text = "Update";
        update_AddWindow.ShowDialog();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        Update_AddWindow update_AddWindow = new Update_AddWindow();
        update_AddWindow.Text = "Add";
        update_AddWindow.ShowDialog();
        Cars.Add(update_AddWindow.Car);
    }
}
