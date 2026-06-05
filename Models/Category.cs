using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace NewsWPF.Models
{
    internal class Category
    {
        /// <summary>
        /// Идентификатор категории
        /// </summary>
        public static int Id { get; private set; }
        
        /// <summary>
        /// Имя категории
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Описание категории
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Количество созданных новостей с данной категорией
        /// </summary>
        public int CountNews { get; private set; }


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Имя категории</param>
        /// <param name="description">Описание категории</param>
        Category(string name, string description)
        {
            Name = name;
            Description = description;
            CountNews = 0;
            Id++;
        }


        /// <summary>
        /// Установка нового имени
        /// </summary>
        /// <param name="newName">Новое имя</param>
        /// <returns>Статус успешности выполнения функции</returns>
        public bool setName(string newName)
        {
            try
            {
                Name = newName;
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка при сохранении имени");
                return false;
            }
        }

        /// <summary>
        /// Установка нового описания для категории
        /// </summary>
        /// <param name="newDescription">Новое описание</param>
        /// <returns>Статус успешности выполнения функции</returns>
        public bool setDescription(string newDescription)
        {
            try
            {
                Description = newDescription;
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка при сохранении описания");
                return false;
            }
        }


        /// <summary>
        /// Увеличение числа новостей определенной категории
        /// </summary>
        /// <param name="categories">Список категорий</param>
        /// <param name="category">Категория, у которой увеличилось число новостей</param>
        /// <returns>Статус успешности выполнения функции</returns>
        public bool setCountNews(List<Category> categories, Category category)
        {
            try
            {
                if (categories.Contains(category))
                {
                    categories[categories.IndexOf(category)].CountNews++;
                    return true;
                }
                else
                {
                    MessageBox.Show("Отсутствует категория в списках категорий");
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка при увеличении числа новостей определенной категории");
                return false;
            }
        }
    }
}
