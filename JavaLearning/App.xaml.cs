using JavaLearning.Model;
using System.Windows;

namespace JavaLearning
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static User CurrentUser { get; set; }
        private static ValeryEntities _context;
        public static ValeryEntities GetContext()
        {
            if (_context == null)
            {
                _context = new ValeryEntities();
            }
            return _context;
        }
    }
}
