using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using ApiLibrary;

namespace Calendar_with_jokes
{
    /// <summary>
    /// Klasa przechowujaca dane i metody dnia i wydarzen danego dnia
    /// </summary>
    public partial class ViewDay : Window
    {
        /// <summary>
        /// Funkcja dostepu do zmiennej Actualday, czyli zmiennej przechowującej dzien
        /// </summary>
        public int Actualday { get; set; }
        /// <summary>
        /// Funkcja dostepu do zmiennej Actualmonth, czyli zmiennej przechowującej miesiac
        /// </summary>
        public int Actualmonth { get; set; }
        /// <summary>
        /// Funkcja dostepu do zmiennej Actualyear, czyli zmiennej przechowującej rok
        /// </summary>
        public int Actualyear { get; set; }
        /// <summary>
        /// Widok przechowujacacy wydarzenia do wyswietlenia
        /// </summary>
        public ICollectionView EventsList { get; private set; }
        /// <summary>
        /// Konstruktor tworzacy okno dnia z wydarzeniami
        /// </summary>
        public ViewDay()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
            showJoke();
        }
        /// <summary>
        /// Wydarzenie do aktualizacji okna po dokonaniu zmiany
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Funkcja aktualizujaca widok po dokonaniu zmiany
        /// </summary>
        /// <param name="propertyName"></param>
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// Funkcja sprawdzajaca czy dany tekst nie jest pusty
        /// </summary>
        /// <param name="text">Tekst do sprawdzenia</param>
        /// <returns>Zwraca prawde jesli tekst nie jest pusty</returns>
        public bool IsNotNull(string text)
        {
            if (!String.IsNullOrWhiteSpace(text) & !String.IsNullOrEmpty(text))
                return true;
            return false;
        }
        /// <summary>
        /// Funkcja sprawdzajaca czy tekst jest odpowiedniej dlugosci
        /// </summary>
        /// <param name="text">Tekst do sprawdzenia</param>
        /// <returns>Zwraca prawde jesli dlugosc tekstu jest odpowiednia</returns>
        public bool IsProperLength(string text, int length)
        {
            if (text.Length < length)
                return true;
            return false;
        }
        /// <summary>
        /// Funkcja sprawdzajaca czy zart jest jednoczesciowy
        /// </summary>
        /// <param name="JokeInfo">Zart do sprawdzenia</param>
        /// <returns>Zwraca prawde jesli zart jest jednoczesciowy</returns>
        public bool IsSingle(JokeModel JokeInfo)
        {
            if (JokeInfo.type == "single")
                return true;
            return false;
        }
        /// <summary>
        /// Sprawdza czy zart nie ma bledu
        /// </summary>
        /// <param name="JokeInfo">Zart do sprawdzenia</param>
        /// <returns>Zwraca prawde jesli zart ma blad</returns>
        public bool IsError(JokeModel JokeInfo)
        {
            if (JokeInfo.error == "true")
                return true;
            return false;
        }

        /// <summary>
        /// Funkcja wyswietlajaca wydarzenia dla danego dnia
        /// </summary>
        /// <param name="year">Zmienna okreslajaca dla jakiego roku wydarzenia wyswietlic</param>
        /// <param name="month">Zmienna okreslajaca dla jakiego miesiaca wydarzenia wyswietlic</param>
        /// <param name="day">Zmienna okreslajaca dla jakiego dnia wydarzenia wyswietlic</param>     
        public void ShowEvents(int year, int month, int day)
        {
            Actualday = day;
            Actualyear = year;
            Actualmonth = month;
            CalendarEntities2 db = new CalendarEntities2();
            var events = from v in db.Events
                         where v.Year == year && v.Month == month && v.Day == day
                         select v;
            EventsList = CollectionViewSource.GetDefaultView(events.ToList());
            DataContext = this;
            NotifyPropertyChanged();
        }
        /// <summary>
        /// Funkcja pozwalajaca dodac nowe wydarzenie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            CalendarEntities2 db = new CalendarEntities2();

            if (IsProperLength(txtKind.Text, 25) & IsProperLength(txtName.Text, 25) & IsProperLength(txtDescription.Text, 100))
            {
                if (IsNotNull(txtName.Text))
                {
                    Event eventObject = new Event()
                    {
                        Year = Actualyear,
                        Month = Actualmonth,
                        Day = Actualday,
                        Kind = txtKind.Text,
                        Name = txtName.Text,
                        Description = txtDescription.Text
                    };
                    db.Events.Add(eventObject);
                    db.SaveChanges();
                    ShowEvents(Actualyear, Actualmonth, Actualday);
                }
                else
                {
                    MessageBox.Show("Event has to have name", "Event Adding Error");
                }
            }
            else MessageBox.Show("Name and Kind should have maximum 25 characters", "Event Adding Error");
        }
        /// <summary>
        /// Zmienna przechowujaca indeks dnia ktory nalezy zaktualizowac
        /// </summary>
        private int updatingEventID = 0;
        /// <summary>
        /// Funkcja odpowiedzialna za zapamietanie indeksu wydarzenia ktore zostalo zaznaczone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridEvents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.gridEvents.SelectedIndex >= 0)
            {
                if (this.gridEvents.SelectedItems.Count >= 0)
                {
                    if (this.gridEvents.SelectedItems[0].GetType() == typeof(Event))
                    {
                        Event x = (Event)this.gridEvents.SelectedItems[0];

                            this.txtKindUpd.Text = x.Kind;
                            this.txtNameUpd.Text = x.Name;
                            this.txtDescriptionUpd.Text = x.Description;
                            this.updatingEventID = x.EventID;
                        
                    }
                }
            }
        }
        /// <summary>
        /// Funkcja pozwalajaca na zaktualizowanie parametrow dotyczacych zaznaczonego wydarzenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            CalendarEntities2 db = new CalendarEntities2();

            var r = from v in db.Events
                    where v.EventID == this.updatingEventID
                    select v;

            Event obj = r.SingleOrDefault();

            if (obj != null)
            {
                if (IsProperLength(txtNameUpd.Text, 25) & IsProperLength(txtKindUpd.Text, 25) & IsProperLength(txtDescriptionUpd.Text, 100))
                {
                    if (IsNotNull(txtNameUpd.Text))
                    {
                        obj.Name = this.txtNameUpd.Text;
                        obj.Kind = this.txtKindUpd.Text;
                        obj.Description = this.txtDescriptionUpd.Text;
                        db.SaveChanges();
                        ShowEvents(Actualyear, Actualmonth, Actualday);
                    }
                    else
                    {
                        obj.Kind = this.txtKindUpd.Text;
                        obj.Description = this.txtDescriptionUpd.Text;
                        db.SaveChanges();
                        ShowEvents(Actualyear, Actualmonth, Actualday);
                    }
                }
                else MessageBox.Show("Name and Kind should have maximum 25 characters", "Event Adding Error");
            }
        }
        /// <summary>
        /// Funkcja pozwalajaca usunac wydarzenie ktore zostalo zaznaczone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult deleteResult = MessageBox.Show("Are you sure you want to delete?", 
                "Delete Event", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);
            if (deleteResult == MessageBoxResult.Yes)
            {
                CalendarEntities2 db = new CalendarEntities2();

                var r = from v in db.Events
                        where v.EventID == this.updatingEventID
                        select v;

                Event obj = r.SingleOrDefault();

                if (obj != null)
                {
                    db.Events.Remove(obj);
                    db.SaveChanges();
                    ShowEvents(Actualyear,Actualmonth,Actualday);
                }
            }
        }
        /// <summary>
        /// Funkcja odpowiedzialna za pokazanie zartu z uzyciem JokeAPI
        /// </summary>
        private async void showJoke()
        {
            var jokeInfo = await JokeProcessor.LoadJoke();
            if (!IsError(jokeInfo))
            {

                if (IsSingle(jokeInfo))
                {
                    txtJoke.Text = $"{jokeInfo.Joke}";
                }
                else
                {
                    txtJoke.Text = $"{jokeInfo.setup}\n\n{jokeInfo.delivery}";
                }
            }
        }
    }
}
