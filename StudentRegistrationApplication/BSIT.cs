namespace HelloWorld
{
    internal class BSIT : Student
    {
        private string name;
        private int age;
        private string address;
        private char gender;
        private int yearLevel;

        public BSIT()
        {
            this.name = "";
            this.age = 0;
            this.address = "";
            this.gender = ' ';
            this.yearLevel = 0;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setAge(int age)
        {
            this.age = age;
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
    }
}