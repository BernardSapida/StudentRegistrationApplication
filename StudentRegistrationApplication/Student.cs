namespace HelloWorld
{
    internal class Student
    {
        BSIT[] bsitStudents = new BSIT[6];
        BSCS[] bscsStudents = new BSCS[6];
        MSIT[] msitStudents = new MSIT[6];
        MSCS[] mscsStudents = new MSCS[6];
        int bsitStudentNumbers, bscsStudentNumbers, msitStudentNumbers, mscsStudentNumbers = 0;

        /// This function is used to display the students information
        public void studentInformation(string course)
        {
            Console.WriteLine("Students Information");
            Console.WriteLine("\n==================================================================\n");
            switch (course)
            {
                case "1":
                    displayBSITStudent();
                    break;
                case "2":
                    displayBSCStudent();
                    break;
                case "3":
                    displayMSITStudent();
                    break;
                case "4":
                    displayMSCStudent();
                    break;
            }
        }

        /// It displays the students enrolled in BSIT
        public void displayBSITStudent()
        {
            if(bsitStudentNumbers == 0)
            {
                Console.WriteLine("No students enrolled yet in BSIT!");
                Console.WriteLine("\n==================================================================\n");
            } else
            {
                for (int i = 0; i < bsitStudentNumbers; i++)
                {
                    Console.WriteLine("Student Name: " + bsitStudents[i].getName());
                    Console.WriteLine("Student Age: " + bsitStudents[i].getAge());
                    Console.WriteLine("Student Address: " + bsitStudents[i].getAddress());
                    Console.WriteLine("Student Gender: " + bsitStudents[i].getGender());
                    Console.WriteLine("Student Year Level: " + bsitStudents[i].getYearLevel());
                    Console.WriteLine("\n==================================================================\n");
                }
            }
        }

        /// It displays the students enrolled in BSCS
        public void displayBSCStudent()
        {
            if (bsitStudentNumbers == 0)
            {
                Console.WriteLine("No students enrolled yet in BSCS!");
                Console.WriteLine("\n==================================================================\n");
            } else
            {
                for (int i = 0; i < bscsStudentNumbers; i++)
                {
                    Console.WriteLine("Student Name: " + bscsStudents[i].getName());
                    Console.WriteLine("Student Age: " + bscsStudents[i].getAge());
                    Console.WriteLine("Student Address: " + bscsStudents[i].getAddress());
                    Console.WriteLine("Student Gender: " + bscsStudents[i].getGender());
                    Console.WriteLine("Student Specialization: " + bscsStudents[i].getSpecialization());
                    Console.WriteLine("\n==================================================================\n");
                }
            }
        }

        /// It displays the information of the students enrolled in MSIT
        public void displayMSITStudent()
        {
            if (bsitStudentNumbers == 0)
            {
                Console.WriteLine("No students enrolled yet in MSIT!");
                Console.WriteLine("\n==================================================================\n");
            } else
            {
                for (int i = 0; i < msitStudentNumbers; i++)
                {
                    Console.WriteLine("Student Name: " + msitStudents[i].getName());
                    Console.WriteLine("Student Age: " + msitStudents[i].getAge());
                    Console.WriteLine("Student Address: " + msitStudents[i].getAddress());
                    Console.WriteLine("Student Gender: " + msitStudents[i].getGender());
                    Console.WriteLine("Student Year Level: " + msitStudents[i].getYearLevel());
                    Console.WriteLine("Student Thesis Type: " + msitStudents[i].getThesisType());
                    Console.WriteLine("\n==================================================================\n");
                }
            }
        }

        /// It displays the information of all the students enrolled in the MSCS program
        public void displayMSCStudent()
        {
            if (bsitStudentNumbers == 0)
            {
                Console.WriteLine("No students enrolled yet in MSCS!");
                Console.WriteLine("\n==================================================================\n");
            } else
            {
                for (int i = 0; i < mscsStudentNumbers; i++)
                {
                    Console.WriteLine("Student Name: " + mscsStudents[i].getName());
                    Console.WriteLine("Student Age: " + mscsStudents[i].getAge());
                    Console.WriteLine("Student Address: " + mscsStudents[i].getAddress());
                    Console.WriteLine("Student Gender: " + mscsStudents[i].getGender());
                    Console.WriteLine("Student Specialization: " + mscsStudents[i].getSpecialization());
                    Console.WriteLine("Student Connected Company Type: " + mscsStudents[i].getConnectedCompanyType());
                    Console.WriteLine("\n==================================================================\n");
                }
            }
        }

        /// It adds a new BSIT student to the array of BSIT students.
        public void newBSITStudent(BSIT bsitStudent, int index) {
            this.bsitStudentNumbers++;
            this.bsitStudents[index] = bsitStudent;
        }

        /// It adds a new BSCS student to the array of BSCS students.
        public void newBSCSStudent(BSCS bscsStudent, int index) {
            this.bscsStudentNumbers++;
            this.bscsStudents[index] = bscsStudent;
        }

        /// This function takes in a MSIT student object and an index and sets the MSIT student object
        /// at the index in the array to the MSIT student object
        public void newMSITStudent(MSIT msitStudent, int index) {
            this.msitStudentNumbers++;
            this.msitStudents[index] = msitStudent;
        }

        /// It adds a new MSCS student to the array of MSCS students.
        public void newMSCSStudent(MSCS mscsStudent, int index) {
            this.mscsStudentNumbers++;
            this.mscsStudents[index] = mscsStudent;
        }
    }
}