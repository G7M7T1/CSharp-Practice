namespace ImplictlyTypedVariable
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            namespace1.namespace2.namespace3.Person p1;
            p1 = new namespace1.namespace2.namespace3.Person() { PersonName = "Yun" };

            var p2 = new namespace1.namespace2.namespace3.Person() { PersonName = "Lis" };
        }
    }
}