namespace HelloWorld
{
    internal class MSCS : BSCS
    {
        private string name;
        private int age;
        private string address;
        private string IT0083;
        private char gender;
        private string specialization;
        private string connectedCompanyType;

        public MSCS()
        {
            this.name = "";
            this.age = 0;
            this.address = "";
            this.gender = ' ';
            this.specialization = "";
            this.connectedCompanyType = "";
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

        /// It sets the specialization of the student.
        public void setSpecialization(string specialization)
        {
            //"Algorithm Design" and "Game Algorithm"
            this.specialization = specialization;
        }

        /// It sets the connected company type of the student.
        public void setConnectedCompanyType(string connectedCompanyType)
        {
            this.connectedCompanyType = connectedCompanyType;
            //"Software", "Call Center", and "Parse"
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

        /// This function returns the connected company type of the student
        public string getConnectedCompanyType()
        {
            return connectedCompanyType;
        }
    }
}