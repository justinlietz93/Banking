namespace JKL.Banking.BL.Models
{
    public class Person
    {
        #region Properties
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string ssn;

        public string SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        private DateTime birthDate;

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }


        public string FullName
        {
            get { return firstName + ' ' + lastName; }
        }


        public int Age
        {
            get
            {
                DateTime today = DateTime.Today;
                int age = today.Year - birthDate.Year;
                if (birthDate > today.AddYears(-age)) age--;
                return age;
            }
        }
        #endregion
    }
}
