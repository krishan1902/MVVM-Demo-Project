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
        public ObservableCollection<Person> People { get; }

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(CreatePersonCommand))]
        private string vorname;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(CreatePersonCommand))]
        private string nachname;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(CreatePersonCommand))]
        private int alter;

        [ObservableProperty]
        private Person selectedPerson;


        private bool CanSave()
        {
            return !string.IsNullOrWhiteSpace(Vorname) &&
                   !string.IsNullOrWhiteSpace(Nachname) &&
                   Alter > 0 && !string.IsNullOrWhiteSpace(Convert.ToString(Alter));
        }
        
        [RelayCommand(CanExecute = nameof(CanSave))]
        private void CreatePerson()
        {
            People.Add(new Person(Vorname, Nachname, Alter));
            Vorname = "";
            Nachname = "";
            Alter = 0;
        }

        [RelayCommand]
        private void DeletePerson()
        {
            if (selectedPerson == null) return; 
            
            MessageBox.Show($"Person mit Nachname {selectedPerson.Nachname} wird gelöscht", "tmm");
            People.Remove(selectedPerson);
        }

        public PersonViewModel()
        {
            People = new ObservableCollection<Person>();
        }
    }
}
