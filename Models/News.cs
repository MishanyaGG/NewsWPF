using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace NewsWPF.Models
{
    internal class News
    {
        /// <summary>
        /// Идентификатор новости
        /// </summary>
        public static int Id { get; private set; }
        
        /// <summary>
        /// Заголовок новости
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Категория новости
        /// </summary>
        public Category Category { get; private set; }

        /// <summary>
        /// Время публикации новости
        /// </summary>
        public DateTime DateOfPublication { get; private set; }

        /// <summary>
        /// Автор новости
        /// </summary>
        public string Author { get; private set; }

        /// <summary>
        /// Число просмотра новости
        /// </summary>
        public int NumberOfView { get; private set; }

        /// <summary>
        /// Статус новости
        /// </summary>
        public string Status { get; private set; }

        /// <summary>
        /// Текст новости
        /// </summary>
        public string Text { get; private set; }


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="title">Заголовок новости</param>
        /// <param name="category">Категория новости</param>
        /// <param name="author">Автор новости</param>
        /// <param name="status">Статус новости</param>
        /// <param name="text">Текст новости</param>
        public News(string title,
            Category category, 
            string author,
            string status,
            string text)
        {
            Title = title;
            Category = category;
            DateOfPublication = DateTime.Now;
            Author = author;
            NumberOfView = 0;
            Status = status;
            Text = text;
            Id++;
        }
           
        /// <summary>
        /// Изменение заголовка новости
        /// </summary>
        /// <param name="newTitle">Новый заголовок</param>
        /// <returns>Статус выполненной работы функции</returns>
        public bool setTitle(string newTitle)
        {
            try
            {
                Title = newTitle;
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка при изменении описания новости");
                return false;
            }
        }


        /// <summary>
        /// Изменение категории новости
        /// </summary>
        /// <param name="newCategory">Новая категория новости</param>
        /// <returns>Статус выполненной работы функции</returns>
        public bool setCategory(Category newCategory)
        {
            try
            {
                Category = newCategory;
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка при изменении категории новости");
                return false;
            }
        }


        /// <summary>
        /// Изменеине автора новости
        /// </summary>
        /// <param name="newAuthor">Новый автор новости</param>
        /// <returns>Статус выполненной работы функции</returns>
        public bool setAuthor(string newAuthor)
        {
            try
            {
                Author = newAuthor;
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка при изменении автора новости");
                return false;
            }
        }

        /// <summary>
        /// Изменение статуса новости
        /// </summary>
        /// <param name="newStatus">Новый статус новости</param>
        /// <returns>Статус выполненной работы функции</returns>
        public bool setStatus(string newStatus)
        {
            try
            {
                Status = newStatus;
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка при изменении статуса новости");
                return false;
            }
        }

        /// <summary>
        /// Изменение текста новости
        /// </summary>
        /// <param name="newText">Новый текст новости</param>
        /// <returns>Статус выполненной работы функции</returns>
        public bool setText(string newText)
        {
            try
            {
                Text = newText;
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка при изменении текста новости");
                return false;
            }
        }

        /// <summary>
        /// Увеличение просмотров у новости
        /// </summary>
        /// <returns>Статус выполненной работы функции</returns>
        public bool addNumberOfView()
        {
            try
            {
                NumberOfView++;
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка при изменении количества просмотров новости");
                return false;
            }
        }

        /// <summary>
        /// Удаление новости по индексу
        /// </summary>
        /// <param name="news">Список новостей</param>
        /// <param name="index">Индекс новости, которую хотим удалить</param>
        /// <returns>Статус выполненной работы функции</returns>
        public bool deleteNews(List<News> news, int index)
        {
            try
            {
                news.Remove(news[index]);
                Id--;
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка при удалении новости из списка");
                return false;
            }
            
        }
    }
}
