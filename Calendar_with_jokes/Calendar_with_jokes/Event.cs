//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Calendar_with_jokes
{
    using System;
    using System.Collections.Generic;
    /// <summary>
    /// Klasa przechowujaca parametry wydarzenia
    /// </summary>
    public partial class Event
    {
        /// <summary>
        /// Funkcja dostepu do zmiennej EventID, czyli zmiennej przechowującej indeks
        /// </summary>
        public int EventID { get; set; }
        /// <summary>
        /// Funkcja dostepu do zmiennej Kind, czyli zmiennej przechowującej rodzaj
        /// </summary>
        public string Kind { get; set; }
        /// <summary>
        /// Funkcja dostepu do zmiennej Name, czyli zmiennej przechowującej nazwe
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Funkcja dostepu do zmiennej Description, czyli zmiennej przechowującej opis
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Funkcja dostepu do zmiennej Year, czyli zmiennej przechowującej rok
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// Funkcja dostepu do zmiennej Month, czyli zmiennej przechowującej miesiac
        /// </summary>
        public int Month { get; set; }
        /// <summary>
        /// Funkcja dostepu do zmiennej Day, czyli zmiennej przechowującej dzien
        /// </summary>
        public int Day { get; set; }
        /// <summary>
        /// Konstruktor bezparametryczny
        /// </summary>
        public Event() { }
        /// <summary>
        /// Konstruktor parametryczny
        /// </summary>
        /// <param name="eventID">Indeks wydarzenia</param>
        /// <param name="name">Nazwa wydarzenia</param>
        /// <param name="kind">Rodzaj wydarzenia</param>
        /// <param name="description">Opis wydarzenia</param>
        /// <param name="year">Rok w ktorym odbywa sie wydarzenie</param>
        /// <param name="month">Miesiac w ktorym odbywa sie wydarzenie</param>
        /// <param name="day">Dzien w ktorym odbywa sie wydarzenie</param>
        public Event(int eventID, string name, string kind, string description, int year, int month, int day)
        {
            this.EventID = eventID;
            this.Name = name;
            this.Kind = kind;
            this.Description = description;
            this.Year = year;
            this.Month = month;
            this.Day = day;
        }
    }
}
