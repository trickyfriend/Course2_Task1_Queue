using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//Создать очередь, информационные поля которой содержат строки  из файла (список фамилий учащихся, упорядоченный по алфавиту). 
//Вставить в этот список новую фамилию с сохранением  порядка.

namespace Course2_Task1_Queue
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TheForm());
        }
    }
}
