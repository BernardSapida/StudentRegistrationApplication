namespace HelloWorld
{
    internal class StudentForm
    {
        BSIT[] bsitStudents = new BSIT[6];
        BSCS[] bscsStudents = new BSCS[6];
        MSIT[] msitStudents = new MSIT[6];
        MSCS[] mscsStudents = new MSCS[6];
        int bsitStudentNumbers, bscsStudentNumbers, msitStudentNumbers, mscsStudentNumbers = 0;

        /// It will ask the user to choose a course and will return the course that the user chose
        public string courseSelection()
        {
            while (true)
            {
                Console.WriteLine("Types of course:");
                Console.WriteLine("[1] BSIT");
                Console.WriteLine("[2] BSCS");
                Console.WriteLine("[3] MSIT");
                Console.WriteLine("[4] MSCS");
                Console.Write("Choose a course: ");
                string course = Console.ReadLine();

                if (course.Equals("1") || course.Equals("2") || course.Equals("3") || course.Equals("4"))
                {
                    Console.WriteLine("\n==================================================================\n");
                    return course;
                }
                else Console.WriteLine("The course is invalid! Please try again.");
            }
        }

        /// This function is used to add a student to the list of students.
        public Student addStudent(string course, Student student)
        {
            if(bsitStudentNumbers + bscsStudentNumbers + msitStudentNumbers + mscsStudentNumbers < 6)
            {
                if(course.Equals("1")) return registerBSITStudent(student);
                else if(course.Equals("2")) return registerBSCStudent(student);
                else if(course.Equals("3")) return registerMSITStudent(student);
                else if(course.Equals("4")) return registerMSCStudent(student);
            } else
            {
                Console.WriteLine("The maximum students you can enroll is 6! Limit reached.");
                Console.WriteLine("\n==================================================================\n");
            }

            return student;
        }

        /// It registers a BSIT student
        public Student registerBSITStudent(Student student)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = Int32.Parse(Console.ReadLine());

            while(true)
            {
                if (age >= 15 && age <= 30) break;
                Console.WriteLine("Age should be greater than or equal to 15 and less than or equal to 30");
                Console.WriteLine("\n==================================================================\n");
                Console.Write("Age: ");
                age = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("Gender: ");
            char gender = Console.ReadLine()[0];

            while (true)
            {
                if (gender.Equals('M') || gender.Equals('F')) break;
                Console.WriteLine("Gender should be M or F! Please try again.");
                Console.WriteLine("\n==================================================================\n");
                Console.Write("Age: ");
                gender = Console.ReadLine()[0];
            }

            Console.Write("Year Level: ");
            int yearLevel = Int32.Parse(Console.ReadLine());

            while (true)
            {
                if (yearLevel >= 1 && yearLevel <= 4) break;
                Console.WriteLine("Year level should be greater than or equal to 1 and less than or equal to 4");
                Console.WriteLine("\n==================================================================\n");
                Console.Write("Year level: ");
                yearLevel = Int32.Parse(Console.ReadLine());
            }

            this.bsitStudents[bsitStudentNumbers] = new BSIT();
            this.bsitStudents[bsitStudentNumbers].setName(name);
            this.bsitStudents[bsitStudentNumbers].setAge(age);
            this.bsitStudents[bsitStudentNumbers].setAddress(address);
            this.bsitStudents[bsitStudentNumbers].setGender(gender);
            this.bsitStudents[bsitStudentNumbers].setYearLevel(yearLevel);

            student.newBSITStudent(this.bsitStudents[bsitStudentNumbers], bsitStudentNumbers);

            bsitStudentNumbers++;

            return student;
        }

        /// It takes the user's input and stores it in the array of BSCS objects
        public Student registerBSCStudent(Student student)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = Int32.Parse(Console.ReadLine());

            while (true)
            {
                if (age >= 15 && age <= 30) break;
                Console.WriteLine("Age should be greater than or equal to 15 and less than or equal to 30");
                Console.WriteLine("\n==================================================================\n");
                Console.Write("Age: ");
                age = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("Gender: ");
            char gender = Console.ReadLine()[0];

            while (true)
            {
                if (gender.Equals('M') || gender.Equals('F')) break;
                Console.WriteLine("Gender should be M or F! Please try again.");
                Console.WriteLine("\n==================================================================\n");
                Console.Write("Age: ");
                gender = Console.ReadLine()[0];
            }

            Console.Write("Specialization: ");
            string specialization = Console.ReadLine();

            while (true)
            {
                if (specialization.Equals("Software Engineering") || specialization.Equals("Game Development")) break;
                Console.WriteLine("Specialization should be Software Engineering or Game Development! Please try again.");
                Console.WriteLine("\n==================================================================\n");
                Console.Write("Specialization: ");
                specialization = Console.ReadLine();
            }

            bscsStudents[bscsStudentNumbers] = new BSCS();
            bscsStudents[bscsStudentNumbers].setName(name);
            bscsStudents[bscsStudentNumbers].setAge(age);
            bscsStudents[bscsStudentNumbers].setAddress(address);
            bscsStudents[bscsStudentNumbers].setGender(gender);
            bscsStudents[bscsStudentNumbers].setSpecialization(specialization);

            student.newBSCSStudent(this.bscsStudents[bscsStudentNumbers], bscsStudentNumbers);

            bscsStudentNumbers++;

            return student;
        }

        /// It registers a student in the MSIT program
        public Student registerMSITStudent(Student student)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = Int32.Parse(Console.ReadLine());

            while (true)
            {
                if (age >= 25 && age <= 30) break;
                Console.WriteLine("Age should be greater than or equal to 25 and less than or equal to 30");
                Console.WriteLine("\n==================================================================\n");
                Console.Write("Age: ");
                age = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("Gender: ");
            char gender = Console.ReadLine()[0];

            while (true)
            {
                if (gender.Equals('M') || gender.Equals('F')) break;
                Console.WriteLine("Gender should be M or F! Please try again.");
                Console.WriteLine("\n==================================================================\n");
                Console.Write("Age: ");
                gender = Console.ReadLine()[0];
            }

            Console.Write("Year Level: ");
            int yearLevel = Int32.Parse(Console.ReadLine());

            while (true)
            {
                if (yearLevel >= 1 && yearLevel <= 2) break;
                Console.WriteLine("Year level should be greater than or equal to 1 and less than or equal to 2");
                Console.WriteLine("\n==================================================================\n");
                Console.Write("Year level: ");
                yearLevel = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Thesis type: ");
            string thesisType = Console.ReadLine();

            while (true)
            {
                if (thesisType.Equals("Database") || thesisType.Equals("Networking") || thesisType.Equals("MIS")) break;
                Console.WriteLine("Thesis type should be Database, Networking, or MIS! Please try again.");
                Console.WriteLine("\n==================================================================\n");
                Console.Write("Thesis Type: ");
                thesisType = Console.ReadLine();
            }

            msitStudents[msitStudentNumbers] = new MSIT();
            msitStudents[msitStudentNumbers].setName(name);
            msitStudents[msitStudentNumbers].setAge(age);
            msitStudents[msitStudentNumbers].setAddress(address);
            msitStudents[msitStudentNumbers].setGender(gender);
            msitStudents[msitStudentNumbers].setYearLevel(yearLevel);
            msitStudents[msitStudentNumbers].setThesisType(thesisType);

            student.newMSITStudent(this.msitStudents[msitStudentNumbers], msitStudentNumbers);

            msitStudentNumbers++;

            return student;
        }

        /// This function is used to register a new MSCS student
        public Student registerMSCStudent(Student student)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = Int32.Parse(Console.ReadLine());

            while (true)
            {
                if (age >= 25 && age <= 30) break;
                Console.WriteLine("Age should be greater than or equal to 25 and less than or equal to 30");
                Console.WriteLine("\n==================================================================\n");
                Console.Write("Age: ");
                age = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("IT0083: ");
            string IT0083 = Console.ReadLine();

            Console.Write("Gender: ");
            char gender = Console.ReadLine()[0];

            while (true)
            {
                if (gender.Equals('M') || gender.Equals('F')) break;
                Console.WriteLine("Gender should be M or F! Please try again.");
                Console.WriteLine("\n==================================================================\n");
                Console.Write("Age: ");
                gender = Console.ReadLine()[0];
            }

            Console.Write("Specialization: ");
            string specialization = Console.ReadLine();

            while (true)
            {
                if (specialization.Equals("Algorithm Design") || specialization.Equals("Game Algorithm")) break;
                Console.WriteLine("Specialization should be Algorithm Design or Game Algorithm! Please try again.");
                Console.WriteLine("\n==================================================================\n");
                Console.Write("Specialization: ");
                specialization = Console.ReadLine();
            }

            Console.Write("Connected Company Type: ");
            string connectedCompanyType = Console.ReadLine();

            while (true)
            {
                if (connectedCompanyType.Equals("Software") || connectedCompanyType.Equals("Call Center") || connectedCompanyType.Equals("Parse")) break;
                Console.WriteLine("Thesis type should be Software, Call Center, or Parse! Please try again.");
                Console.WriteLine("\n==================================================================\n");
                Console.Write("Connected Company Type: ");
                connectedCompanyType = Console.ReadLine();
            }

            mscsStudents[mscsStudentNumbers] = new MSCS();
            mscsStudents[mscsStudentNumbers].setName(name);
            mscsStudents[mscsStudentNumbers].setAge(age);
            mscsStudents[mscsStudentNumbers].setAddress(address);
            mscsStudents[mscsStudentNumbers].setGender(gender);
            mscsStudents[mscsStudentNumbers].setSpecialization(specialization);
            mscsStudents[mscsStudentNumbers].setConnectedCompanyType(connectedCompanyType);

            student.newMSCSStudent(this.mscsStudents[mscsStudentNumbers], mscsStudentNumbers);

            mscsStudentNumbers++;

            return student;
        }
    }
}