using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiLibrary
{
    /// <summary>
    /// Klasa przechowujaca zmienne zartu
    /// </summary>
    public class JokeModel
    {
        /// <summary>
        ///  Funkcja dostepu do zmiennej error, czyli zmiennej majacej wartosc true lub false oznaczajacej czy wystapil blad
        /// </summary>
        public string error { get; set; }
        /// <summary>
        /// Funkcja dostepu do zmiennej type, czyli zmiennej przechowującej typ zartu (mozliwy jest typ "single" oznaczajacy zwykly zart, oraz "double" oznaczajacy zart dwuczesciowy)
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// Funkcja dostepu do zmiennej Joke, czyli zmiennej przechowującej zart (jesli jest pojedynczy)
        /// </summary>
        public string Joke { get; set; }
        /// <summary>
        /// Funkcja dostepu do zmiennej setup, czyli zmiennej przechowującej przygotowanie zartu
        /// </summary>
        public string setup { get; set; }
        /// <summary>
        /// Funkcja dostepu do zmiennej delivery, czyli zmiennej przechowującej druga czesc dwuczesciowego zartu
        /// </summary>
        public string delivery { get; set; }
    }
}
