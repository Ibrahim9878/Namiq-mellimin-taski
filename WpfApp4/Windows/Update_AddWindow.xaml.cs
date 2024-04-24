using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using WpfApp4.Models;

namespace WpfApp4.Windows;

public partial class Update_AddWindow : Window, INotifyPropertyChanged
{
    private Car? car;
    private string? text;

    public event PropertyChangedEventHandler? PropertyChanged;
    public string? Text { get => text; set { text = value;  OnPropertyChanged(); } }
    public Car? Car { get => car; set { car = value; OnPropertyChanged(); } }
    public Update_AddWindow()
    {
        InitializeComponent();
        DataContext = this;
    }

    protected void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    private void AddUpdateButton_Click(object sender, RoutedEventArgs e)
    {
        if(AddUpdateButton.Content.ToString() == "Update")
        {
            DialogResult = false;
            return;
        }   
        else
        {
            car = new();
            car.Model = ModelBox.Text;
            car.Year = YearBox.Text;
            car.Vendor = VendorBox.Text;
            DialogResult = false;
            return;
        }

    }

    private void CancelButton_Click(object sender, RoutedEventArgs e)
    {
        DialogResult = false;
        if (AddUpdateButton.Content.ToString() == "Update")
        {
            DialogResult = false;
            return;
        }
        else
        {
            car = new();
            car.Model = ModelBox.Text;
            car.Year = YearBox.Text;
            car.Vendor = VendorBox.Text;
            DialogResult = false;
            return;
        }
    }
}
