namespace HelloWorld
{
    internal class StudentForm
    {
        BSIT[] bsitStudents = new BSIT[6];
        BSCS[] bscsStudents = new BSCS[6];
        MSIT[] msitStudents = new MSIT[6];
        MSCS[] mscsStudents = new MSCS[6];
        int bsitStudentNumbers, bscsStudentNumbers, msitStudentNumbers, mscsStudentNumbers = 0;

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

        public void addStudent(string course)
        {
            switch(course)
            {
                case "1":
                    registerBSITStudent();
                    break;
                case "2":
                    registerBSCStudent();
                    break;
                case "3":
                    registerMSITStudent();
                    break;
                case "4":
                    registerMSCStudent();
                    break;
            }
            Console.WriteLine("\n==================================================================\n");
        }

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

        public void registerBSITStudent()
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
            bsitStudentNumbers++;
        }

        public void registerBSCStudent()
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
            bscsStudentNumbers++;
        }

        public void registerMSITStudent()
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
            msitStudentNumbers++;
        }

        public void registerMSCStudent()
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
            mscsStudentNumbers++;
        }
    }
}