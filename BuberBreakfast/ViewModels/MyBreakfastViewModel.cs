using BuberBreakfast.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BuberBreakfast.ViewModels;

public partial class MyBreakfastViewModel : ObservableObject
{
    [ObservableProperty]
    public List<Breakfast> breakfasts;
    [ObservableProperty]
    public bool isRefreshing;
    public MyBreakfastViewModel()
    {
        LoadBreakfastsAsync().GetAwaiter();
    }

    [RelayCommand]
    public async Task LoadBreakfastsAsync()
    {
        try
        {
            await Task.Delay(2000);
            Breakfasts = new List<Breakfast>
                {
                    new Breakfast
                    (
                        Name : "Vegan Sunshine",
                        Description : "Vegan Sunsine! Join us for the healty breakfast full of vegan dishesh and cookies.",
                        StartDateTime : DateTime.UtcNow.AddDays(1),
                        EndDateTime : DateTime.UtcNow.AddDays(1).AddHours(2),
                        Image : "img1.jpg",
                        Savory : new List<string>(){"Oatmeal","Avacado Toast","Omelet","Salad"},
                        Sweet: new List<string>(){"Cookie"}
                    ),
                    new Breakfast
                    (
                        Name : "Breakfast @ ABC's",
                        Description : "Hi i am ABC. I'll be your chef on Sunday",
                        StartDateTime : DateTime.UtcNow,
                        EndDateTime : DateTime.UtcNow.AddHours(2),
                        Image : "img2.jpg",
                        Savory : new List<string>(){"Sandwitch","Omelet","Salad"},
                        Sweet: new List<string>(){"Pancake","Waffle"}
                    ),
                    new Breakfast
                    (
                        Name : "Breakfast @ DEF's",
                        Description : "Hi i am DEF. I'll be your chef on Sunday",
                        StartDateTime : DateTime.UtcNow,
                        EndDateTime : DateTime.UtcNow.AddHours(2),
                        Image : "img2.jpg",
                        Savory : new List<string>(){"Sandwitch","Omelet","Salad"},
                        Sweet: new List<string>(){"Pancake","Waffle"}
                    ),
                    new Breakfast
                    (
                        Name : "Breakfast @ XYZ's",
                        Description : "Hi i am XYZ. I'll be your chef on Sunday",
                        StartDateTime : DateTime.UtcNow,
                        EndDateTime : DateTime.UtcNow.AddHours(2),
                        Image : "img2.jpg",
                        Savory : new List<string>(){"Sandwitch","Omelet","Salad"},
                        Sweet: new List<string>(){"Pancake","Waffle"}
                    ),
                    new Breakfast
                    (
                        Name : "Breakfast @ QWERTY's",
                        Description : "Hi i am QWERTY. I'll be your chef on Sunday",
                        StartDateTime : DateTime.UtcNow,
                        EndDateTime : DateTime.UtcNow.AddHours(2),
                        Image : "img2.jpg",
                        Savory : new List<string>(){"Sandwitch","Omelet","Salad"},
                        Sweet: new List<string>(){"Pancake","Waffle"}
                    )
                };
        }
        finally
        {
            IsRefreshing = false;
        }

    }
}
