namespace ProjectProgramming.Model.Classes
{
    /// <summary>
    /// Представляет контакт.
    /// </summary>
    class Contact
    {
        private string _name;
        private string _surname;
        private string _email;

        /// <summary>
        /// Получает или задает имя контакта.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("The name cannot be empty or contain only spaces!");
                AssertStringContainsOnlyLetters(value, "Name");

                _name = value;
            }
        }

        /// <summary>
        /// Получает или задает фамилию контакта.
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("The surname cannot be empty or contain only spaces!");
                AssertStringContainsOnlyLetters(value, "Surname");
                _surname = value;
            }
        }

        /// <summary>
        /// Получает или задает номер телефона контакта.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Получает или задает электронную почту контакта.
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                if (!string.IsNullOrWhiteSpace(_email) && _email.Contains("@"))
                    throw new ArgumentException("Invalid email format!");
                _email = value;
            }
        }

        /// <summary>
        /// Получает или задает компанию контакта.
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса Contact с указанными параметрами.
        /// </summary>
        /// <param name="name">Имя контакта.</param>
        /// <param name="phoneNumber">Номер телефона контакта.</param>
        /// <param name="email">Электронная почта контакта.</param>
        /// <param name="company">Компания контакта.</param>
        public Contact(string name, string phoneNumber, string email, string company)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            Company = company;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса Contact с значениями по умолчанию.
        /// </summary>
        public Contact()
        {
            Name = "Gleb";
            PhoneNumber = "8-800-555-35-35";
            Email = "super_gleb@gmail.com";
            Company = "TUSUR";
        }

        /// <summary>
        /// Проверяет, содержит ли строка только буквы английского алфавита.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="propertyName">Имя свойства.</param>
        private void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            if (!IsEnglishAlphabet(value))
                throw new ArgumentException($"The {propertyName.ToLower()} should contain only English alphabet characters!");
        }

        /// <summary>
        /// Проверяет, состоит ли строка из букв английского алфавита.
        /// </summary>
        /// <param name="input">Проверяемая строка.</param>
        /// <returns>True, если строка содержит только буквы английского алфавита, иначе - false.</returns>
        private bool IsEnglishAlphabet(string input)
        {
            return !string.IsNullOrEmpty(input) && input.All(char.IsLetter) && input.All(char.IsLetterOrDigit);
        }
    }
}
