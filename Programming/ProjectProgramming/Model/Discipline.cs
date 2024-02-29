namespace ProjectProgramming.Model
{
    class Discipline
    {
        private string _disciplineName;
        private string _instructor;
        private int _grade;
        private int _semester;

        public string DiscpilineName
        {
            get { return _disciplineName; }
            set
            {
                if (value.Length == 0) throw new ArgumentException("The Discipline name cannot be empty!");
                _disciplineName = value;
            }
        }
        public string Instructor
        {
            get { return _instructor; }
            set
            {
                if (value.Length == 0) throw new ArgumentException("The Instructor cannot be empty!");
                _instructor = value;
            }
        }
        public int Grade
        {
            get { return _grade; }
            set
            {
                Validator.AssertValueInRange(value, 0, 6);
                _grade = value;
            }
        }
        public int Semester
        {
            get { return _semester; }
            set
            {
                Validator.AssertValueInRange(value, 0, 9);
                _semester = value;
            }
        }

        public Discipline()
        {
            DiscpilineName = "Programming";
            Grade = 5;
            Semester = 2;
            Instructor = "0_0";
        }

        public Discipline(string disciplineName, string instructor, int semester, int grade)
        {
            DiscpilineName = disciplineName;
            Grade = grade;
            Semester = semester;
            Instructor = instructor;
        }
    }
}
