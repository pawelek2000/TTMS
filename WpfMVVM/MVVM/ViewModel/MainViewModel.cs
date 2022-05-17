using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMVVM.Core;
using Zadanie6.MVVM.Model;

namespace WpfMVVM.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand DodajOsobaCommand { get; set; }
        public RelayCommand UsunCommand { get; set; }
        public ObservableCollection<Departament> ListaRegionow { get; set; }
        public MainViewModel()
        {
            ListaOsob = new ObservableCollection<Osoba>();
            ListaRegionow = new ObservableCollection<Departament> {new Departament { Id = 0, Nazwa = "Sprzedaż"}, new Departament { Id = 1, Nazwa = "Produkcja" },
                                                               new Departament { Id = 2, Nazwa = "Marketing"}, new Departament { Id = 3, Nazwa = "Projektownie"}};
            
            ListaOsob.Add(new Osoba
            {
                IsAButton = true,
            });

            DodajOsobaCommand = new RelayCommand(o =>
            {
                SelectedOsoba = (o as Osoba);

                
                if (SelectedOsoba.IsAButton) 
                {
                    SelectedOsoba.IsAButton = false;
                    var index = (ListaOsob.Max(f => f.Id)) + 1;
                    SelectedOsoba.Id = index;
                    ListaOsob.Add(new Osoba
                    {
                        IsAButton = true,
                    });

                }

                AktualizacajWidocznisci();
            });
            UsunCommand = new RelayCommand(o =>
            {
                if(SelectedOsoba.IsAButton == false)
                ListaOsob.Remove(SelectedOsoba);
                AktualizacajWidocznisci();
            });


        }
        public ObservableCollection<Osoba> ListaOsob
        {
            get { return _ListaOsob; }
            set
            {   
                _ListaOsob = value;
                OnPropertyChanged();
                
            }
        }
        private ObservableCollection<Osoba> _ListaOsob;

        public Osoba SelectedOsoba
        {
            get 
            {   
                return _SelectedOsoba; 
            }
            set
            {
                _SelectedOsoba = value;
                OnPropertyChanged();
            }
        }
        private Osoba _SelectedOsoba;

        public bool CzyJestJakasOsoba
        {
            get { return _CzyJestJakasOsoba; }
            set
            {
                _CzyJestJakasOsoba = value;
                OnPropertyChanged();

            }
        }
        private bool _CzyJestJakasOsoba;

        private void AktualizacajWidocznisci() 
        {
            if (ListaOsob == null || ListaOsob.Count == 1)
                CzyJestJakasOsoba = false;
            else
                CzyJestJakasOsoba = true;
        }
    }
}
