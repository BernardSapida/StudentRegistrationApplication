namespace HelloWorld
{
    internal class BSIT : Student
    {
        private string name;
        private int age;
        private string address;
        private char gender;
        private int yearLevel;

        /* A constructor. */
        public BSIT()
        {
            this.name = "";
            this.age = 0;
            this.address = "";
            this.gender = ' ';
            this.yearLevel = 0;
        }

        /// This function sets the name of the person
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

        /// This function sets the address of the person
        public void setAddress(string address)
        {
            this.address = address;
        }

        /// This function sets the gender of the person
        public void setGender(char gender)
        {
            this.gender = gender;
        }

        /// This function sets the year level of the student
        public void setYearLevel(int yearLevel) 
        {
            this.yearLevel = yearLevel;
        }

        /// This function returns the name of the person
        public string getName()
        {
            return name;
        }

        /// This function returns the age of the person
        public int getAge()
        {
            return age;
        }

        /// This function returns the address of the person
        public string getAddress()
        {
            return address;
        }

        /// This function returns the gender of the person
        public char getGender()
        {
            return gender;
        }

        /// This function sets the year level of the student
        public int getYearLevel()
        {
            return yearLevel;
        }
    }
}