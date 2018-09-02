using System;
using System.Linq;

namespace newLinq
{
    public class DisplayHelper : IDisplayHelper
    {
        public void Display<T>(T entity)
        {
            foreach (var property in typeof(T).GetProperties())
            {
                Console.Write($"{property.GetValue(entity).ToString(), -24}|");
            }
            Console.WriteLine();
        }
    }

    public interface IDisplayHelper
    {
        void Display<T>(T entity);
    }
}
