namespace HelloWorld
{
    internal class BSCS : Student
    {
        private string name;
        private int age;
        private string address;
        private char gender;
        private string specialization;

        /* A constructor. It is a special method that is called when an object is created. */
        public BSCS()
        {
            this.name = "";
            this.age = 0;
            this.address = "";
            this.gender = ' ';
            this.specialization = "";
        }

        /// This function sets the name of the student
        public void setName(string name)
        {
            this.name = name;
        }

        /// The function checks if the age is between 15 and 30. 
        /// If it is, the age is set to the value of the parameter.
        /// If not, an error message is displayed
        public void setAge(int age)
        {
            if (age >= 15 && age <= 30) this.age = age;
            else Console.WriteLine("Invalid age! Age should be 15 - 30 for BSIT and BSCS");
        }

        /// This function sets the address of the student
        public void setAddress(string address)
        {
            this.address = address;
        }

        /// This function sets the gender of the student
        public void setGender(char gender)
        {
            this.gender = gender;
        }

        /// It sets the specialization of the student.
        public void setSpecialization(string specialization)
        {
            //"Software Engineering" and "Game Development"
            this.specialization = specialization;
        }

        /// This function returns the name of the student
        public string getName()
        {
            return name;
        }

        /// This function returns the age of the student
        public int getAge()
        {
            return age;
        }

        /// This function returns the address of the student
        public string getAddress()
        {
            return address;
        }

        /// This function returns the gender of the student
        public char getGender()
        {
            return gender;
        }

        /// This function returns the specialization of the student
        public string getSpecialization()
        {
            return specialization;
        }

        public static implicit operator BSCS(MSIT v)
        {
            throw new NotImplementedException();
        }
    }
}