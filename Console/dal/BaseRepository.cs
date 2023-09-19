namespace dal
{
    public class BaseRepository
    {
        protected string ConnectionString { get; }

        public BaseRepository()
        {
            ConnectionString = DatabaseConection.ConnectionString("tasks");
        }
    }
}