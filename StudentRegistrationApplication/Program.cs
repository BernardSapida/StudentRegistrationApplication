namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            TestStudent testStudent = new TestStudent();

            while (true) testStudent.loadStudentForm();
        }
    }
}