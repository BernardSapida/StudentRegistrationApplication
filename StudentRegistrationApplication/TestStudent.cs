namespace HelloWorld
{
    internal class TestStudent
    {
        StudentForm studentForm = new StudentForm();

        public void loadStudentForm()
        {
            string course = studentForm.courseSelection();
            string action = queryAction();

            if(action.Equals("1")) studentForm.addStudent(course);
            else studentForm.studentInformation(course);
        }

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