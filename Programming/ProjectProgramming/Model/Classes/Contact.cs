namespace ProjectProgramming.Model.Classes
{
    class Contact
    {
        private string _name;
        private string _surname;
        private string _email;

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
        public string PhoneNumber { get; set; }
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
        public string Company { get; set; }
        public Contact(string name, string phoneNumber, string email, string company)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            Company = company;
        }
        public Contact()
        {
            Name = "Gleb";
            PhoneNumber = "8-800-555-35-35";
            Email = "super_gleb@gmail.com";
            Company = "TUSUR";
        }
        private void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            if (!IsEnglishAlphabet(value))
                throw new ArgumentException($"The {propertyName.ToLower()} should contain only English alphabet characters!");
        }
        private bool IsEnglishAlphabet(string input)
        {
            return !string.IsNullOrEmpty(input) && input.All(char.IsLetter) && input.All(char.IsLetterOrDigit);
        }
    }
}
