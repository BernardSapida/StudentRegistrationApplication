namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Creating a new instance of the TestStudent class. */
            TestStudent testStudent = new TestStudent();

            /* An infinite loop that will keep the program running until the user exits the program. */
            while (true) testStudent.loadStudentForm();
        }
    }
}