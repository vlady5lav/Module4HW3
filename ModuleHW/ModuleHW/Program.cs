namespace ModuleHW
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var appContext = new ApplicationContext();
            appContext.SaveChanges();
        }
    }
}
