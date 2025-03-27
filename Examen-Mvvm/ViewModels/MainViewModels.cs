using CommunityToolkit.Mvvm.ComponentModel;

namespace Examen_Mvvm.ViewModels;

public partial class MainViewModels:ObservableObject
{
    [ObservableProperty] 
    private double producto1;
    
    [ObservableProperty]
    private double producto2;
    
    [ObservableProperty]
    private double producto3;
    
}