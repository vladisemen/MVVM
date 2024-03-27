using Librarian_CLient.models;
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows;
using System.Runtime.CompilerServices;

namespace Librarian_CLient.ViewModels
{
    // Реализация ViewModel в котором обрабатывается нажатие на кнопку через команду
    public class BookViewModel : INotifyPropertyChanged
    {

        private Book book = new Book();

        private string genre;
        private string author;
        private string year;

        public AsyncRelayCommand HttpSenderCommand { get; }

        // Отслеживание полей ввода в реальном времени
        public string Genre
        {
            get { return genre; }
            set
            {
                if (genre != value)
                {
                    genre = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Author
        {
            get { return author; }
            set
            {
                if (author != value)
                {
                    author = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Year
        {
            get { return year; }
            set
            {
                if (year != value)
                {
                    year = value;
                    OnPropertyChanged();
                }
            }
        }

        public BookViewModel()
        {
            HttpSenderCommand = new AsyncRelayCommand(HttpSender);
        }

        // Обращение к серверу
        private async Task HttpSender()
        {
            string url = $"http://127.0.0.1:8000/books?";

            if (string.IsNullOrEmpty(genre) == false)
            {
                url = url + $"genre={genre}&";
            }
            if (string.IsNullOrEmpty(author) == false)
            {
                url = url + $"author={author}&";
            }
            if (string.IsNullOrEmpty(year) == false)
            {
                url = url + $"year={year}&";
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();

                        book = JsonConvert.DeserializeObject<Book>(responseData);


                        MessageBox.Show(book.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Ошибка: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
