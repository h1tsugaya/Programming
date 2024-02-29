namespace ProjectProgramming.Model
{
    public class Contact
    {
        private string _name;
        private string _email;

        public string Name
        {
            get { return _name; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Имя не может быть пустым или содержать только пробелы.");
                _name = value; 
            }
        }
        public string PhoneNumber { get; set; }
        public string Email
        {
            get { return _email; }
            set 
            {   if (!string.IsNullOrWhiteSpace(_email) && _email.Contains("@"))
                    throw new ArgumentException("Неккоректный формат электронной почты.");
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
            Name = "None";
            PhoneNumber = "None";
            Email = "None";
            Company = "None";
        }
    }
}
