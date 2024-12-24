using System;

namespace MDK_01_02_Exam
{
    public static class Programm
    {
        private static Dictionary<double, double> resultTable = FuncTabulation.TabulateFunc();

        public static void Main()
        {
            foreach (KeyValuePair<double, double> kvp in resultTable)
            {
                Console.WriteLine($"Значение Y: {kvp.Key}; при значение X: {kvp.Value}");
            }

            Console.WriteLine();
            FindValues(resultTable);
        }

        /// <summary>
        /// Данный метод ищет значение удовлетворяющие условию "1 < y < 3.1". Если таких данных нет, выводится соответсвующие сообщиение, иначе, произведение таких значений
        /// </summary>
        /// <param name="tableKVP"></param>
        private static void FindValues(Dictionary<double, double> tableKVP)
        {
            List<double> values = [];
            double result = 1;

            foreach(KeyValuePair<double, double > kvp in tableKVP)
            {
                if (kvp.Key > 1 && kvp.Key < 3.1)
                {
                    values.Add(kvp.Value);
                }
                else
                {
                    continue;
                }
            }

            if (values.Count == 0)
            {
                Console.WriteLine(@"Данных, удовлетворяющие условию ""1 < y < 3.1"" нет");
                return;
            }

            foreach(double item in values)
            {
                result *= item;
            }

            Console.WriteLine(@"Произведение, элементов удовлетворяющих условие ""1 < y < 3.1"" равно: {0}", result);
        }
    }
}