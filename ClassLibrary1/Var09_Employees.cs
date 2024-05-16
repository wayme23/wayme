
namespace ClassLibrary1
{
    public class Var09_Employees
    {
        private string name = "";
        private string surname = "";
        private string patronymic = "";
        private Var10_Post post;

        public Var09_Employees(string name, string surname, string patronymic, Var10_Post post)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Post = post;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }

        public Var10_Post Post
        {
            get { return post; }
            set { post = value; }
        }

        internal static Var09_Employees ToString(string value)
        {
            throw new NotImplementedException();
        }
    }
}
