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

        public void setYearLevel(int yearLevel)
        {
            this.yearLevel = yearLevel;
        }

        public void setThesisType(string thesisType)
        {
            this.thesisType = thesisType;
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

        public int getYearLevel()
        {
            return yearLevel;
        }

        public string getThesisType()
        {
            return thesisType;
        }
    }
}