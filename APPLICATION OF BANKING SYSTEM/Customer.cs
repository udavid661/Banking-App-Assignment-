namespace Banking_App_Assignment
{
    public class Customer
    {
        private string _firstName;
        private string _lastName;
        private string _gender;

        public void SetFirstName(string firstName)
        {
            this._firstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            this._lastName = lastName;
        }

        public void SetGender(string gender)
        {
            this._gender = gender;
        }

        public string GetFirstName()
        {
            return _firstName;
        }
        
        public string GetLastName()
        {
            return _lastName;
        }

        public string GetGender()
        {
            return _gender;
        }
    }
}