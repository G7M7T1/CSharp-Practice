namespace SttuctureE
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 以下的new只是为了初始化
            Category category = new Category();
            // struct本身只适用于储存一个
            // 如果要使用到两个或者多个 请使用class

            category.CategoryID = 100;
            category.CategoryName = "John";
            
            System.Console.WriteLine(category.GetCategoryNameLength());
            System.Console.WriteLine(category.CategoryID);
            System.Console.WriteLine(category.CategoryName);
            System.Console.ReadKey();
        }
    }
}