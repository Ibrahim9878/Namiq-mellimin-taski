using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp4.Models;

public class Car : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
	private string? vendor;
    private string? model;
    private string? year;

    public string? Vendor
	{
		get { return vendor; }
		set { vendor = value; OnPropertyChanged(); }

	}
    public string? Model { get => model; set { model = value; OnPropertyChanged(); } }
    public string? Year { get => year; set { year = value; OnPropertyChanged(); } }
    protected void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
    public Car()
    {
        vendor = null;
        model = null;
        year = null;
    }

    public Car(string? vendor, string? model, string? year)
    {
        Vendor = vendor;
        Model = model;
        Year = year;
    }
}
