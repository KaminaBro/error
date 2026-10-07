using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MyAvaloniaApp.Models;
using System.Threading.Tasks;

namespace MyAvaloniaApp.ViewModels;

public partial class TovarViewModel : ViewModelBase
{
    [ObservableProperty]
    private ObservableCollection<Tovar> tovarList=new();
    public TovarViewModel()
    {
        Load();
    }
    private void Load()
    {
        using (PostgresContext db=new PostgresContext())
        {
            TovarList.Clear();
            TovarList=new ObservableCollection<Tovar>(getALL());
        }
    }
    private List<Tovar> getALL()
    {
        using(PostgresContext db=new PostgresContext())
        {
            Task<List<Tovar>> task = Task.Run(() => db.Tovars.ToList());
            return task.Result;
        }
    }
}
