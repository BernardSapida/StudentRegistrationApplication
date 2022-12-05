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

        public void setName(string name)
        {
            this.name = name;
        }

        public void setAge(int age)
        {
            if (age >= 25 && age <= 30) this.age = age;
            else Console.WriteLine("Invalid age! Age should be 15 - 30 for BSIT and BSCS");
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public void setGender(char gender)
        {
            this.gender = gender;
        }

        public void setSpecialization(string specialization)
        {
            //"Algorithm Design" and "Game Algorithm"
            this.specialization = specialization;
        }

        public void setConnectedCompanyType(string connectedCompanyType)
        {
            this.connectedCompanyType = connectedCompanyType;
            //"Software", "Call Center", and "Parse"
        }

        public string getName()
        {
            return name;
        }

        public int getAge()
        {
            return age;
        }

        public string getAddress()
        {
            return address;
        }

        public char getGender()
        {
            return gender;
        }

        public string getSpecialization()
        {
            return specialization;
        }

        public string getConnectedCompanyType()
        {
            return connectedCompanyType;
        }
    }
}