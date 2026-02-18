using JavaLearning.Model;
using System.Data.Entity;
using System.Windows.Controls;

namespace JavaLearning.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для TeacherReadOnlyQuestionUserPage.xaml
    /// </summary>
    public partial class TeacherReadOnlyQuestionUserPage : Page
    {
        private ValeryEntities _context;

        public TeacherReadOnlyQuestionUserPage()
        {
            InitializeComponent();
            _context = App.GetContext();
            LoadData();
        }

        private void LoadData()
        {
            _context.Users.Load();
            _context.Questions.Load();
            _context.QuestionUsers.Load();

            QuestionUserGrid.ItemsSource = _context.QuestionUsers.Local.ToBindingList();
        }
    }
}