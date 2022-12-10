namespace HelloWorld
{
    internal class MSIT : BSIT
    {
        private string name;
        private int age;
        private string address;
        private char gender;
        private int yearLevel;
        private string thesisType;

        public MSIT()
        {
            this.name = "";
            this.age = 0;
            this.address = "";
            this.gender = ' ';
            this.yearLevel = 0;
            this.thesisType = "";
        }

        /// This function sets the name of the student
        public void setName(string name)
        {
            this.name = name;
        }

        /// The function checks if the age is between 25 and 30. 
        /// If it is, the age is set to the value of the parameter.
        /// If not, an error message is displayed
        public void setAge(int age)
        {
            if (age >= 25 && age <= 30) this.age = age;
            else Console.WriteLine("Invalid age! Age should be 25 - 30 for MSIT and MSCS");
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

        /// This function sets the year level of the student
        public void setYearLevel(int yearLevel)
        {
            this.yearLevel = yearLevel;
        }

        /// This function sets the thesis type of the student
        public void setThesisType(string thesisType)
        {
            this.thesisType = thesisType;
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

        /// This function returns the year level of the student
        public int getYearLevel()
        {
            return yearLevel;
        }

        /// This function returns the thesis type of the student
        public string getThesisType()
        {
            return thesisType;
        }
    }
}