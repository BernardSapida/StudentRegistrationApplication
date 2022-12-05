namespace HelloWorld
{
    internal class BSCS : Student
    {
        private string name;
        private int age;
        private string address;
        private char gender;
        private string specialization;

        public BSCS()
        {
            this.name = "";
            this.age = 0;
            this.address = "";
            this.gender = ' ';
            this.specialization = "";
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setAge(int age)
        {
            if (age >= 15 && age <= 30) this.age = age;
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
            //"Software Engineering" and "Game Development"
            this.specialization = specialization;
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

        public static implicit operator BSCS(MSIT v)
        {
            throw new NotImplementedException();
        }
    }
}