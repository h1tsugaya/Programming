namespace ProjectProgramming.Model.Classes
{
    /// <summary>
    /// Представляет дисциплину.
    /// </summary>
    class Discipline
    {
        private string _disciplineName;
        private string _instructor;
        private int _grade;
        private int _semester;

        /// <summary>
        /// Получает или задает название дисциплины.
        /// </summary>
        public string DiscpilineName
        {
            get { return _disciplineName; }
            set
            {
                if (value.Length == 0) throw new ArgumentException("The Discipline name cannot be empty!");
                _disciplineName = value;
            }
        }

        /// <summary>
        /// Получает или задает имя преподавателя.
        /// </summary>
        public string Instructor
        {
            get { return _instructor; }
            set
            {
                if (value.Length == 0) throw new ArgumentException("The Instructor cannot be empty!");
                _instructor = value;
            }
        }

        /// <summary>
        /// Получает или задает оценку за дисциплину.
        /// </summary>
        public int Grade
        {
            get { return _grade; }
            set
            {
                Validator.AssertValueInRange(value, 0, 6);
                _grade = value;
            }
        }

        /// <summary>
        /// Получает или задает семестр, в котором проходит дисциплина.
        /// </summary>
        public int Semester
        {
            get { return _semester; }
            set
            {
                Validator.AssertValueInRange(value, 0, 9);
                _semester = value;
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса Discipline со значениями по умолчанию.
        /// </summary>
        public Discipline()
        {
            DiscpilineName = "Programming";
            Grade = 5;
            Semester = 2;
            Instructor = "0_0";
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса Discipline с указанными параметрами.
        /// </summary>
        /// <param name="disciplineName">Название дисциплины.</param>
        /// <param name="instructor">Преподаватель.</param>
        /// <param name="semester">Семестр.</param>
        /// <param name="grade">Оценка.</param>
        public Discipline(string disciplineName, string instructor, int semester, int grade)
        {
            DiscpilineName = disciplineName;
            Grade = grade;
            Semester = semester;
            Instructor = instructor;
        }
    }
}
