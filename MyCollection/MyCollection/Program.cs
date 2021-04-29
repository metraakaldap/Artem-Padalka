using System;

namespace MyCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class RefList : IRefList
    {
        public object this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public void Add(object value)
        {
            throw new NotImplementedException();
        }

        public void AddToEnd(object value)
        {
            throw new NotImplementedException();
        }

        public void DeleteByIndex(int index)
        {
            throw new NotImplementedException();
        }

        public void DeleteByValue(object value)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public object[] ToArray()
        {
            throw new NotImplementedException();
        }
    }
    public interface IRefList
    {
        void Add(object value);
        void AddToEnd(object value);
        void DeleteByValue(object value); // Удаляет все вхождения
        void DeleteByIndex(int index);
        int IndexOf(object value);
        object this[int index] { get; set; }
        object[] ToArray();
        int Count { get; }
    }
}
