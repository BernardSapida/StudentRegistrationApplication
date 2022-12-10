namespace HelloWorld
{
    internal class TestStudent
    {
        /* Creating a new instance of the StudentForm class. */
        Student student = new Student();
        StudentForm studentForm = new StudentForm();

        /// This function is used to load the student form
        public void loadStudentForm()
        {
            string course = studentForm.courseSelection();
            string action = queryAction();

            if(action.Equals("1")) {
                student = studentForm.addStudent(course, student);
                Console.WriteLine("\n==================================================================\n");
            } else student.studentInformation(course);
        }

        /// It asks the user to choose an action, and if the user inputs a valid action, it returns the
        /// action
        public String queryAction()
        {
            while (true)
            {
                Console.WriteLine("Actions: ");
                Console.WriteLine("[1] Add new student");
                Console.WriteLine("[2] Display students information");
                Console.Write("Choose an action: ");
                string action = Console.ReadLine();

                if (action.Equals("1") || action.Equals("2"))
                {
                    Console.WriteLine("\n==================================================================\n");
                    return action;
                }
                else Console.WriteLine("Invalid input! Please try again.");
            }
        }
    }
}