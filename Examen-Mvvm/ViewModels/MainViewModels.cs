using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Examen_Mvvm.ViewModels;

public partial class MainViewModels:ObservableObject
{
    [ObservableProperty] 
    private double producto1;
    
    [ObservableProperty]
    private double producto2;
    
    [ObservableProperty]
    private double producto3;
    
    [ObservableProperty]
    private double descuento;
    
    [ObservableProperty]
    private double total;
    
    [ObservableProperty]
    private double suma;

    [RelayCommand]
    private void Calcular()
    {
       Suma= producto1 + producto2 + producto3;

       if (Suma>10000)
       {
           Descuento = Suma * 0.3;
       }
       else if (Suma>5000)
       {
           Descuento = Suma * 0.2;
       }
       else if (Suma>1000)
       {
           Descuento = Suma * 0.1;
       }
       else
       {
           Descuento = 0;
       }

       Total = Suma - Descuento;
    }
    
    [RelayCommand]
    private void Limpiar()
    {
        Producto1 = 0;
        Producto2 = 0;
        Producto3 = 0;
        Suma = 0;
        Descuento = 0;
        Total = 0;
    }
    
    private void Alerta(string Titulo, string Mensaje)
    {
        MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
    }
    
}