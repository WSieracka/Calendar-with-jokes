using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;

namespace Calendar_with_jokes
{
    /// <summary>
    /// Główna klasa tworząca kalendarz
    /// </summary>
    public partial class MainWindow : Window
    {
        DateTime now = DateTime.Now;
        int pos = 0;
        int year = 2021;
        int days;
        string[] month = new string[] { "Styczeń", "Luty", "Marzec", "Kwiecień", "Maj", "Czerwiec", "Lipiec", "Sierpień", "Wrzesień", "Październik", "Listopad", "Grudzień" };
        WeekControl weekRow = new WeekControl();
        GridLength rowHeight;
        /// <summary>
        /// Konstruktor kalendarza
        /// </summary>
        public MainWindow()

        {
            InitializeComponent();
            this.Title = "Calendar with jokes";
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            var bg = new BrushConverter();
            b_first.Background = (Brush)bg.ConvertFrom("#FFD9113C");
            b_second.Background = (Brush)bg.ConvertFrom("#FFD9113C");
            this.Background = (Brush)bg.ConvertFrom("#C1C3CA");
            year = now.Year;
            c.Content = year;
            pos = now.Month - 1;
            msc.Text = month[pos];
            makecalenadr(pos, year);
        }
        /// <summary>
        /// Funkcja kliknięcia prawego przycisku zmieniająca miesiące w przód, po 12 kliknięciach również rok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void b_first_Click(object sender, RoutedEventArgs e)
        {
            if (pos == 11)
            {
                pos = -1;
            }
            pos++;
            msc.Text = month[pos];
            if (pos == 0)
            {
                year++;
                c.Content = year;
            }
            makecalenadr(pos, year);
        }
        /// <summary>
        /// Funkcja kliknięcia lewego przycisku zmieniająca miesiące w tył, po 12 kliknięciach również rok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_second_Click(object sender, RoutedEventArgs e)
        {
            if (pos == 0)
            {
                pos = 12;
            }
            pos = pos - 1;
            msc.Text = month[pos];
            if (pos == 11)
            {
                year--;
                c.Content = year;
            }
            makecalenadr(pos, year);
        }
        /// <summary>
        /// Funkcja tworząca tworząca dni w kalendarzu
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="year"></param>
        void makecalenadr(int pos, int year)
        {
            int WeekCount = 0;
            MonthViewGrid.Children.Clear();
            MonthViewGrid.RowDefinitions.Clear();
            weekRow.WeekRowGrid.Children.Clear();
            DateTime dateValue = new DateTime(year, pos + 1, 1);
            days = (int)dateValue.DayOfWeek;
            if (days == 0)
            {
                days = 7;
            }
            int DaysInMonth = System.DateTime.DaysInMonth(year, pos + 1);
            rowHeight = new System.Windows.GridLength(60, System.Windows.GridUnitType.Star);
            for (int i = 0; i < 6; i++)
            {
                RowDefinition rowDef = new RowDefinition();
                rowDef.Height = rowHeight;
                MonthViewGrid.RowDefinitions.Add(rowDef);
            }
            for (int i = 0; i < DaysInMonth; i++)
            {
                if (i != 0 && (System.Math.IEEERemainder((i + days - 1), 7) == 0))
                {
                    //dodaje tydzien
                    Grid.SetRow(weekRow, WeekCount);
                    MonthViewGrid.Children.Add(weekRow);
                    //tworzy nowy
                    weekRow = new WeekControl();
                    WeekCount += 1;

                }
                DayControl aday = new DayControl();
                aday.DayNumberLabel.Content = i + 1;
                aday.day = i + 1;
                aday.month = pos + 1;
                aday.year = year;

                CalendarEntities2 db = new CalendarEntities2();

                var events = (from v in db.Events where v.Year == aday.year && v.Month == aday.month && v.Day == aday.day select v);
                if (events.Count()>0)
                {
                    foreach (Event actual_event in events)
                    {
                        EventControl apt = new EventControl();
                        apt.txtEvent.Text = actual_event.Name;
                        aday.DayAppointmentsStack.Children.Add(apt);
                    }
                }

                Grid.SetColumn(aday, (i - (WeekCount * 7)) + days - 1);
                weekRow.WeekRowGrid.Children.Add(aday);

            }
            Grid.SetRow(weekRow, WeekCount);
            MonthViewGrid.Children.Add(weekRow);
        }
    }
}
