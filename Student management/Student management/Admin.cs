using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management
{
    class Admin
    {
        public string name = "Amr";
        public string password = "123";
        public string id = "000";
        public static Admin adminobject = new Admin();
        public Student objectstudent = new Student();//object mn class Admin.
        public Courses objectcourse = new Courses(); //object from course class.
        public void ADDstudent(string name,string ID,string pass,string ac_year,List<string> finished,List<string>in_progress)
        {
            using (StreamWriter x = File.AppendText("student.txt"))// b zawed text 3la elfile.
            {
                //put the values in file.
                x.WriteLine("Name:" + name);// b5aly eluser hwa elly yd5alo.
                x.WriteLine("ID:" + ID);
                x.WriteLine("Password:" +pass);
                x.WriteLine("Ac.year:" + ac_year);
                for (int i = 0; i < finished.Count; i++)
                {
                    if (i == 0)
                        x.Write("Finished:" + finished[i]);
                    else
                        x.Write("," + finished[i]);
                }
                x.WriteLine();//endl
                for (int i = 0; i < in_progress.Count; i++)
                {
                    if (i == 0)
                        x.Write("progress:" + in_progress[i]);
                    else
                        x.Write("," + in_progress[i]);
                }
                x.WriteLine();
                x.WriteLine("------------------------");
            }







            //   //Console.WriteLine("Ente the name of student-ID-Password-ac.year-Finished courses-progress courses");
            //   //cin value.
            ////   objectstudent.name = Console.ReadLine();//badkhl name student.
            //  // objectstudent.ID = Console.ReadLine();
            //   //objectstudent.pass = Console.ReadLine();
            //   //objectstudent.academic_year = Console.ReadLine();
            //   do
            //   {
            //       string random;
            //       random = Console.ReadLine();
            //       if (random == "0")
            //           break;
            //       else
            //           objectstudent.finished_courses.Add(random);
            //   } while (true);

            //   do
            //   {
            //       String random;
            //       random = Console.ReadLine();
            //       if (random == "0")
            //           break;
            //       else
            //           objectstudent.courses_progress.Add(random);
            //   } while (true);

            //   using (StreamWriter x = File.AppendText("student.txt"))// b zawed text 3la elfile.
            //   {
            //       //put the values in file.
            //       x.WriteLine("Name:" + objectstudent.name);// b5aly eluser hwa elly yd5alo.
            //       x.WriteLine("ID:" + objectstudent.ID);
            //       x.WriteLine("Password:" + objectstudent.pass);
            //       x.WriteLine("Ac.year:" + objectstudent.academic_year);
            //       for (int i = 0; i < objectstudent.finished_courses.Count; i++)
            //       {
            //           if (i == 0)
            //               x.Write("Finished:" + objectstudent.finished_courses[i]);
            //           else
            //               x.Write("," + objectstudent.finished_courses[i]);
            //       }
            //       x.WriteLine();//endl
            //       for (int i = 0; i < objectstudent.courses_progress.Count; i++)
            //       {
            //           if (i == 0)
            //               x.Write("progress:" + objectstudent.courses_progress[i]);
            //           else
            //               x.Write("," + objectstudent.courses_progress[i]);
            //       }
            //       x.WriteLine();
            //       x.WriteLine("------------------------");
            //   }
        }
        public void ADDcourse(string name,string code,int max,string pre_req,string hours,int numstudents)
        {
            //Console.WriteLine("Enter the name of course , code , maximum num of students , prerequisite courses , hours ");
            ////cin
            //objectcourse.name = Console.ReadLine();
            //objectcourse.code = Console.ReadLine();
            //objectcourse.max_st = Convert.ToInt32(Console.ReadLine());
            //objectcourse.pre_req = Console.ReadLine();
            //objectcourse.hours = Console.ReadLine();

            using (StreamWriter x = File.AppendText("Courses data.txt"))
            {
                x.WriteLine("Name:" + name);
                x.WriteLine("Code:" + code);
                x.WriteLine("Max:" + max);
                x.WriteLine("Students:" + numstudents);
                x.WriteLine("Pre:" + pre_req);
                x.WriteLine("Hours:" + hours);
                x.WriteLine("---------------------------");
            }

        }
        public List<string> studentincourse(string coursecode)
        {
            List<string> nameofstudents = new List<string>();  
            objectstudent.readdata();
            for (int i = 0; i < objectstudent.student_list.Count; i++)
            {
                for (int j = 0; j < objectstudent.student_list[i].courses_progress.Count; j++)
                {

                    if (coursecode == objectstudent.student_list[i].courses_progress[j])
                    {
                        nameofstudents.Add(objectstudent.student_list[i].name);
                        break;
                    }
                }
            }
            return nameofstudents;
        }
        public List<string> progress(string nameofstudent)
        {
            objectstudent.readdata();
            List<string> crs_progress = new List<string>();

            for (int i = 0; i < objectstudent.student_list.Count; i++)
            {
                if (nameofstudent == objectstudent.student_list[i].name)
                {

                    for (int j = 0; j < objectstudent.student_list[i].courses_progress.Count; j++)
                    { 
                        crs_progress.Add(objectstudent.student_list[i].courses_progress[j]);

                    }
                    break;
                }
            }
            return crs_progress;
        }
        public List<string> finish(string nameofstudent)
        {
            objectstudent.readdata();
            List<string> crs_finish = new List<string>();
            for (int i = 0; i < objectstudent.student_list.Count; i++)
            {
                if (nameofstudent == objectstudent.student_list[i].name)
                {
                    for (int j = 0; j < objectstudent.student_list[i].finished_courses.Count; j++)
                    {

                        crs_finish.Add(objectstudent.student_list[i].finished_courses[j]);

                    }
                    break;
                }
            }
            return crs_finish;
        }

        public void editcoursedata(string oldname, string name, string code, int max, int students, string prereq, string hours)
        {

            //// string choice;
            //// string change;

            ////  {
            ////    Console.WriteLine("if you want to change course name press 1");
            ////    Console.WriteLine("if you want to change course code press 2");
            ////    Console.WriteLine("if you want to change course max no press 3");
            ////    Console.WriteLine("if you want to change course of pre-required press 4");
            ////    Console.WriteLine("if you want to change course hours press 5");
            ////    Console.WriteLine("if you want to escape press 0");
            //
            //// choice = Console.ReadLine();

            //{
            //    //  Console.WriteLine("Enter The name of the course you want to change");
            //    //  linecourse:
            //    objectcourse.name = Console.ReadLine();
            //    // Console.WriteLine("Enter The new name of the course ");
            //    //  change = Console.ReadLine();
            //    for (int i = 0; i < objectcourse.course_list.Count; i++)
            //    {
            //        if (objectcourse.name == objectcourse.course_list[i].name)
            //        {
            //            string text = File.ReadAllText("Courses data.txt");
            //            text = text.Replace(objectcourse.course_list[i].name, name);
            //            File.WriteAllText("Courses data.txt", text);
            //            // break;
            //        }
            //        //else if (objectcourse.name != objectcourse.course_list[i].name)
            //        //{
            //        //    Console.WriteLine("The name is not clear enter again");
            //        //    goto linecourse;
            //        //}
            //    }

            //    {
            //        //  Console.WriteLine("Enter The name of the course you want to change");
            //        objectcourse.name = Console.ReadLine();
            //        //    Console.WriteLine("Enter The new code of the course");
            //        //   change = Console.ReadLine();
            //        for (int i = 0; i < objectcourse.course_list.Count; i++)
            //        {
            //            if (objectcourse.name == objectcourse.course_list[i].name)
            //            {
            //                string text = File.ReadAllText("Courses data.txt");
            //                text = text.Replace(objectcourse.course_list[i].code, code);
            //                File.WriteAllText("Courses data.txt", text);
            //            }
            //        }
            //    }

            //    {
            //        //    Console.WriteLine("Enter The name of the course you want to change");
            //        //    objectcourse.name = Console.ReadLine();
            //        //  Console.WriteLine("Enter The new number  of  student in the course");
            //        //   change = Console.ReadLine();
            //        for (int i = 0; i < objectcourse.course_list.Count; i++)
            //        {
            //            if (objectcourse.name == objectcourse.course_list[i].name)
            //            {
            //                //string text = File.ReadAllText("Courses data.txt");
            //                //text = text.Replace(Convert.ToChar(objectcourse.course_list[i].max_st),Convert.ToChar(change));
            //                //File.WriteAllText("Courses data.txt", text);
            //                objectcourse.course_list[i].max_st = Convert.ToInt32(max);
            //                objectcourse.writedata();
            //            }
            //        }
            //    }

            //    {
            //        //   Console.WriteLine("Enter The name of the course you want to change");
            //        //   objectcourse.name = Console.ReadLine();
            //        //   Console.WriteLine("Enter The pre requsite of the course");
            //        //   change = Console.ReadLine();
            //        for (int i = 0; i < objectcourse.course_list.Count; i++)
            //        {
            //            if (objectcourse.name == objectcourse.course_list[i].name)
            //            {
            //                //string text = File.ReadAllText("Courses data.txt");
            //                //text = text.Replace(objectcourse.course_list[i].pre_req, change);
            //                //File.WriteAllText("Courses data.txt", text);
            //                objectcourse.course_list[i].pre_req = prereq;
            //                objectcourse.writedata();
            //            }
            //        }
            //    }

            //    {
            //        //   Console.WriteLine("Enter The name of the course you want to change");
            //        // objectcourse.name = Console.ReadLine();
            //        //  Console.WriteLine("Enter The new number  of  hours  of the course");
            //        //  change = Console.ReadLine();
            //        for (int i = 0; i < objectcourse.course_list.Count; i++)
            //        {
            //            if (objectcourse.name == objectcourse.course_list[i].name)
            //            {
            //                //string text = File.ReadAllText("Courses data.txt");
            //                //text = text.Replace(objectcourse.course_list[i].hours, change);
            //                //File.WriteAllText("Courses data.txt", text);
            //                objectcourse.course_list[i].hours = hours;
            //               
            //            }
            //        }
            //    }
            //}
            objectcourse.read();
            for (int i = 0; i < objectcourse.course_list.Count; i++)
            {
                if (oldname == objectcourse.course_list[i].name)
                {
                    objectcourse.course_list[i].name = name;
                    objectcourse.course_list[i].code = code;
                    objectcourse.course_list[i].max_st = max;
                    objectcourse.course_list[i].no_of_students = students;
                    objectcourse.course_list[i].pre_req = prereq;
                    objectcourse.course_list[i].hours = hours;
                }
            }
            objectcourse.writedata();
        }



        public void coursepre()
        {
            objectcourse.read();
            Console.WriteLine("Enter the name of course");
            objectcourse.name = Console.ReadLine();
            string change;

            for (int i = 0; i < objectcourse.course_list.Count; i++)
            {


                if (objectcourse.name == objectcourse.course_list[i].name)
                {

                    if (objectcourse.course_list[i].pre_req == "_")
                    {
                        Console.WriteLine("Enter the prerequsite course");
                        change = Console.ReadLine();
                        objectcourse.course_list[i].pre_req = change;
                    }
                }

            }
            objectcourse.writedata();
        }
        //public void menu()
        //{
        //    Console.WriteLine("WELCOME :)");
        //    Console.WriteLine("if you want to add new student   press  1");
        //    Console.WriteLine("if you want to Add a new  course press  2");
        //    Console.WriteLine("if you want to  see a list of all students in a specific course press  3");
        //    Console.WriteLine("if you want to see Finished-Progressed for a student press  4");
        //    Console.WriteLine("if you want to edit data press 5 ");
        //    Console.WriteLine("if you want to edit pre-requsite of course press6");
        //    Console.WriteLine("if you want to want to close press 0");
        //    string choice2;
        //    choice2 = Console.ReadLine();
        //    if (choice2 == "1")
        //    {
        //        adminobject.ADDstudent();
        //    }
        //    else if (choice2 == "2")
        //    {
        //        adminobject.ADDcourse();
        //    }
        //    else if (choice2 == "3")
        //    {
        //        adminobject.studentincourse();
        //    }
        //    else if (choice2 == "4")
        //    {
        //        adminobject.finishedandprog();
        //    }
        //    else if (choice2 == "5")
        //    {
        //        adminobject.editcoursedata();
        //    }
        //    else if (choice2 == "6")
        //    {
        //        adminobject.coursepre();
        //    }
        //}
        //public void login()
        //{
        //    string username;

        //    do
        //    {
        //    line1:
        //        Console.WriteLine("Enter the ID ");
        //        username = Console.ReadLine();

        //        if (username == adminobject.id)
        //        {
        //        line2:
        //            Console.WriteLine("enter passcode");
        //            string passcode;
        //            passcode = Console.ReadLine();
        //            if (passcode == adminobject.password)
        //            {
        //                adminobject.menu();
        //                break;
        //            }
        //            else
        //            {
        //                Console.WriteLine("you enter wrong password ,please enter again");

        //                goto line2;
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("you enter wrong ID ,enter agian");
        //            goto line1;
        //        }

        //    } while (true);


        //}


    }//class
}//namespace
