using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK_01_02_Exam
{
    public static class FuncTabulation
    {
        private static readonly double numberOfTicket = 15;

        /// <summary>
        /// Данный метод хранит себе функцию, а также возвращает результат ее выполнения. Это функция является основной в задачи. 
        /// </summary>
        /// <param name="argX"></param>
        /// <returns></returns>
        public static double MainFunction(double argX)
        {
            double result;
            result = Math.Sin(2 * argX - 3) / (Math.Cos(2 * Math.PI + 1.2 * argX) + 256);
            return result;
        }

        /// <summary>
        /// Данный метод тубулирует функцию из метода MainFunction. Метод возрващает таблицу пар значений Y и X в виде словаря Dictionary<double, double> 
        /// </summary>
        /// <returns></returns>
        public static Dictionary<double, double> TabulateFunc()
        {
            Dictionary<double, double> result = [];

            double step = 0;

            while (step <= numberOfTicket)
            {
                double resultY = MainFunction(step);
                resultY = Math.Round(resultY, 5);
                result.Add(resultY, step);

                step += 0.1 * numberOfTicket;
            }

            return result;
        }
    }
}
