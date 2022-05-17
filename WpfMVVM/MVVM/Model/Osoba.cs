using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfMVVM.Core;

namespace Zadanie6.MVVM.Model
{
    internal class Osoba : ObservableObject
    {
        public int Id { get; set; }
        public string Imie
        {
            get { return _Imie; }
            set
            {
                
                _Imie = value;
                OnPropertyChanged();
                AktualazacjaHeder();
            }
        }
        private string _Imie;

        public string Nazwisko
        {
            get { return _Nazwisko; }
            set
            {
                _Nazwisko = value;
                OnPropertyChanged();
                AktualazacjaHeder();
            }
        }
        private string _Nazwisko;

        public string Email
        {
            get { return _Email; }
            set
            {
                _Email = value;
                OnPropertyChanged();
                AktualazacjaHeder();
            }
        }
        private string _Email;

        public double Wyplata
        {
            get { return _Wyplata; }
            set
            {
                _Wyplata = value;
                OnPropertyChanged();
            }
        }
        private double _Wyplata;
        public Departament IdRegionu
        {
            get { return _IdRegionu; }
            set
            {
                _IdRegionu = value;
                OnPropertyChanged();
            }
        }
        private Departament _IdRegionu;

        public Osoba Kierownik
        {
            get { return _Kierownik; }
            set
            {
                _Kierownik = value;
                OnPropertyChanged();
            }
        }
        private Osoba _Kierownik;

        public int PoziomDostepu
        {
            get { return _PoziomDostepu; }
            set
            {
                _PoziomDostepu = value;
                OnPropertyChanged();
            }
        }
        private int _PoziomDostepu;

        public bool DaneOsobowe
        {
            get { return _DaneOsobowe; }
            set
            {
                _DaneOsobowe = value;
                OnPropertyChanged();
              
            }
        }
        private bool _DaneOsobowe;
        public string Header 
        {
            get { return _Header; }
            set
            {
                _Header = value;
                OnPropertyChanged();
            }
        }
        private string _Header;

        public bool IsAButton
        {
            get { return _IsAButton; }
            set
            {
                _IsAButton = value;
                OnPropertyChanged();
                AktualazacjaHeder();
            }
        }
        private bool _IsAButton;
        private void AktualazacjaHeder() 
        {
            if (IsAButton)
                Header = "dodaj nową osobę...";
            else
                Header = string.Format("{0} {1} ({2})", Imie, Nazwisko, Email);
        }
    }
    
}
