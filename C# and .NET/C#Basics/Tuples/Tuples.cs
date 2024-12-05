namespace Tuples
{
    internal class Tuples
    {

        public (int, int, int) SomeFunction(int a, int b, int c)
        {
            return (a, b, c);
        }
        public void Print()
        {
            //-------------------------------- Tuples --------------------------------

            Tuple<int, int> tp1 = new Tuple<int, int>(1, 2);
            var tp2 = Tuple.Create(1, 2, 3, 34, 4);

            Console.WriteLine(tp2);
            var nestedTuples = Tuple.Create(1, 2, 3, Tuple.Create(1, "umang"), (1, 2, 3), new Tuple<int, int>(3, 4), new ValueTuple<int, int, int>(1, 2, 3));
            var value = nestedTuples.ToValueTuple();
            value.Item1 = 5;
            Console.WriteLine(value);

            //-------------------------------ValueTuples----------------------------

            var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 8);
            dynamic str = "Aayush";
            var vt1 = (1, 2, 3, 4, 5, 6);
            ValueTuple<int, int> vt5 = new ValueTuple<int, int>(1, 2);
            var vt2 = ValueTuple.Create(1, 2, 3, 4, 4, 5);
            (string name, int age, bool flag) vtp1 = ValueTuple.Create("umang", 1, true);
            var tp = (23, "Umang", 123456789);
            ValueTuple<int, string, bool> vtt1 = (30, "umang", true);
            (int, int, int) vtp = SomeFunction(1, 2, 3);
            (int a, int b, int c) myTup = (1, 2, 3);
            myTup.c = 9;
            Console.WriteLine(myTup);
        }
    }
}
