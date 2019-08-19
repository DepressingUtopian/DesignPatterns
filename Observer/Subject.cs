using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{

    /// <summary>
    /// Интерфейс для субъектов
    /// </summary>
    public interface Subject
    {

        /// <summary>
        /// Регистрация наблюдателя
        /// </summary>
        /// <param name="observer">Ссылка на наблюдателя</param>
        void registerObserver(Observer observer);

        /// <summary>
        /// Удаление наблюдателя
        /// </summary>
        /// <param name="observer">Ссылка на наблюдателя</param>
        void removeObserver(Observer observer);

        /// <summary>
        /// Оповещение наблюдателя
        /// </summary>
        void notifyObservers();
    }
}
