using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var scale = new EqualityScale<int>(4, 4);
            Console.WriteLine(scale.AreEqual());
        }
    }

    public class EqualityScale<T>
    {
        public T Right;
        public T Left;
        public EqualityScale(T right, T left)
        {
            this.Right = right;
            this.Left = left;
        }

        public bool AreEqual()
        {
            return Right.Equals(Left);
        }
    }
}
