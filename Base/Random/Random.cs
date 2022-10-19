namespace Randoms{
    class Progran {
        static void Main(string[] args) {
            Randoms rdm = new Randoms();
            int num;

            for(int i = 0; i < 10; i++) {
                num = rdm.Next(1, 7);
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}