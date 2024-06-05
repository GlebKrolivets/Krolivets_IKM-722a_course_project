using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krolivets_IKM_722a_course_project
{
    internal class MajorWork
    {
        //Поля
        private System.DateTime TimeBegin; // час початку роботи програми
        private string Data; //вхідні дані
        private string Result; //поле результату
        //Методи
        public void SetTime() // метод запису часу початку роботи програми
        {
            this.TimeBegin = System.DateTime.Now;
        }
        public System.DateTime GetTime() // Метод отримання часу завершення програми
        {
            return this.TimeBegin;
        }
        public void Write(string D)
        {
            this.Data = D;
        }
        public string Read()
        {
            return this.Result;// метод відображення результату
        }
        public void Task() // метод реалізації програмного завдання
        {
            if (this.Data.Length> 5)
            {
                this.Result = Convert.ToString(true);

            }
            else
            {
                this.Result = Convert.ToString(false);
            }
        }
    }
}
