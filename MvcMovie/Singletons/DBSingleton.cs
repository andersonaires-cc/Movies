namespace MvcMovie.Singletons
{
    public sealed class DBSingleton
    {
        private static DBSingleton _instance;

        public string dbConnection = "Data Source = localhost;Initial Catalog = MvcMovie;User Id=sa; Password=123456";

        public static DBSingleton GetInstance()
        {
            if(_instance == null)
                _instance = new DBSingleton();

            return _instance;
        }

    }
}
