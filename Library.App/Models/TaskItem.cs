using SQLite;


namespace Library.App.Models
{


    public class TaskItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id
        { get; set; }

        public string TaskDesc { get; set; }

        public string TaskGroup { get; set; }

    }
}
