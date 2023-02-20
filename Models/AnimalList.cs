using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiGrouping.Models
{
    // iNotifyPropertyChanged is includede even though we are using community toolkit as
    // a class can only inherit one parent class
    public class AnimalList : List<Animal>, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string species { get; private set; }

        // variables to control open / close groupings
        private bool _isExpanded = true;
        private bool _notExpanded = false;

        public bool IsExpanded
        {
            get => _isExpanded;
            set => SetField(ref _isExpanded, value);
        }

        public bool NotExpanded
        {
            get => _notExpanded;
            set => SetField(ref _notExpanded, value);
        }

        public List<Animal>? animals { get; private set; }

        public AnimalList(string? species, List<Animal>? animals) : base(animals)
        {
            this.species = species;
            this.animals = animals;
        }


        protected void OnPropertyChanged(string propertyName)
           => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
