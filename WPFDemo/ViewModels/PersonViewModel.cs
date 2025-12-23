using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFDemo.Models;

namespace WPFDemo.ViewModels
{
    public partial class PersonViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Person> people;

        [ObservableProperty]
        private string vorname;

        [ObservableProperty]
        private string nachname;

        [ObservableProperty]
        private int alter;

        public PersonViewModel()
        {
            People = new ObservableCollection<Person>();
        }

        [RelayCommand]
        private void CreatePerson()
        {
            People.Add(new Person(Vorname, Nachname, Alter));
            MessageBox.Show("jbg");
        }
    }
}
