using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calendar_with_jokes
{
    /// <summary>
    /// Klasa tworząca pojedyńczy dzień
    /// </summary>
    public partial class DayControl : UserControl
    {
        /// <summary>
        /// Konstruktor tworzący pojedyńczy dzień
        /// </summary>
        public DayControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Funkcja kliknięcia przycisku, ktora otwiera okno dnia z wydarzeniami
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show($"{day.ToString()} - {month.ToString()} - {year.ToString()}");
            ViewDay viewday = new ViewDay();

            viewday.Actualday = day;
            viewday.Actualmonth = month;
            viewday.Actualyear = year;

            viewday.Show();
            viewday.ShowEvents(year,month,day);

        }
        /// <summary>
        /// Funkcja dostepu do zmiennej day, czyli zmiennej przechowującej dzien miesiaca
        /// </summary>
        public int day { get; set; }
        /// <summary>
        /// Funkcja dostępu do zmiennej month, czyli zmiennej przechowujacej numer miesiaca
        /// </summary>
        public int month { get; set; }
        /// <summary>
        /// Funkcja dostępu do zmiennej year, czyli zmiennej przechowujacej numer roku
        /// </summary>
        public int year { get; set; }
    }
}
