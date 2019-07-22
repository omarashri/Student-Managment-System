using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management
{
    class Student 
    {

        public string name;
        public string ID;
        public string pass;
        public string academic_year;
        public List<string> finished_courses = new List<string>();
        public List<string> courses_progress = new List<string>();
        public static Courses course_object = new Courses();


        public List<Student> student_list = new List<Student>();
        public static Student single_student = new Student();
        public static Courses hamada = new Courses();
        public List<string> shayl = new List<string>();
        public static Student logged_in = new Student();


        /*------------Logged in student data---------------*/
        public static string _name;//bta3et el logged in
        public static string _ac_year;//bta3et el logged in
        public static string _ID;//bta3et el logged in
        public static string _pass;//bta3et el logged in
        public static List<string> _finished_courses = new List<string>();//bta3et el logged in
        public static List<string> _courses_progress = new List<string>();//bta3et el logged in
        /*------------------------------------------------*/


        public static Courses som3a = new Courses();





        public void readdata()
        {
            StreamReader read = new StreamReader("student.txt");
            string record;
            char[] dels = { ':', ',', '.', '-' };
            record = read.ReadLine();
            while (record != null)
            {
                if (record.Contains("Name:"))
                {
                    string[] substring = record.Split(dels).ToArray();
                    for (int i = 1; i < substring.Length; i++)
                    {
                        single_student.name = substring[i].ToString();
                    }
                }
                else if (record.Contains("ID"))
                {

                    string[] substring = record.Split(dels).ToArray();

                    for (int i = 1; i < substring.Length; i++)
                    {

                        single_student.ID = substring[i].ToString();
                    }
                }
                else if (record.Contains("Password"))
                {

                    string[] substring = record.Split(dels).ToArray();

                    for (int i = 1; i < substring.Length; i++)
                    {

                        single_student.pass = substring[i].ToString();
                    }
                }
                else if (record.Contains("AcYear:"))
                {

                    string[] substring = record.Split(':').ToArray();

                    for (int i = 1; i < substring.Length; i++)
                    {
                        single_student.academic_year = substring[i].ToString();
                    }
                }
                else if (record.Contains("Finished:"))
                {
                    string[] substring = record.Split(dels).ToArray();

                    for (int i = 1; i < substring.Length; i++)
                    {

                        single_student.finished_courses.Add(substring[i].ToString());
                    }
                }

                else if (record.Contains("progress:"))
                {
                    string[] substring = record.Split(dels).ToArray();

                    for (int i = 1; i < substring.Length; i++)
                    {

                        single_student.courses_progress.Add(substring[i].ToString());
                    }
                }

                else if (record.Contains("-----------------"))
                {
                    student_list.Add(single_student);

                    single_student = new Student();
                }
                record = read.ReadLine();
            }
            read.Close();
           

        }

        //public void login()
        //{

        //    readdata();
        //    string iD;
        //    string passwordd;
        //start: Console.WriteLine("Write your ID :");
        //    iD = Console.ReadLine();
        //label2: Console.WriteLine("Enter your Pass : ");
        //    passwordd = Console.ReadLine();

        //    for (int i = 0; i < student_list.Count; i++)
        //    {
        //        if (iD == student_list[i].ID)
        //        {
        //            if (passwordd == student_list[i].pass)
        //            {
        //                logged_in.name = student_list[i].name;
        //                logged_in.pass = student_list[i].pass;
        //                logged_in.ID = student_list[i].ID;
        //                logged_in.finished_courses = student_list[i].finished_courses;
        //                logged_in.courses_progress = student_list[i].courses_progress;
        //                logged_in.academic_year = student_list[i].academic_year;
        //                // return logged_in;
        //                Console.Clear();
        //                menu();
        //                return;
        //            }
        //            else
        //            {

        //                Console.WriteLine("re-enter your pass");

        //                goto label2;

        //            }

        //        }


        //    }
        //    Console.WriteLine("wrong id");
        //    goto start;
        //}

        public void login2(string x)//x is the entered ID
        {
            
            for (int i = 0; i < student_list.Count; i++)
            {
                if (x == student_list[i].ID)
                {
                    _name = student_list[i].name;
                    _ac_year = student_list[i].academic_year;
                    _ID = student_list[i].ID;
                    _pass = student_list[i].pass;
                    for (int j = 0; j < student_list[i].finished_courses.Count; j++)
                    {
                        _finished_courses.Add(student_list[i].finished_courses[j]);
                    }
                    for (int j = 0; j < student_list[i].courses_progress.Count; j++)
                    {
                        _courses_progress.Add(student_list[i].courses_progress[j]);
                    }
                    break;
                }
            }
        }



        public List<string> avcourse()
        {
            
            List<string> crs = new List<string>();//a list to hold the available courses to return 

            string avrec;
            char[] del = { ':', ',', '.', '\t' };
            StreamReader av = new StreamReader("Courses data.txt");
            avrec = av.ReadLine();
            readdata();
            som3a.course_list.Clear();
            som3a.read();

         

            while (avrec != null)
            {
                if (_ac_year == "1")
                {
                    if (avrec.Contains("First year:"))
                    {
                        string[] sub = avrec.Split(del).ToArray();
                        for (int i = 1; i < sub.Length; i++)
                        {

                            shayl.Add(sub[i]);

                        }
                        for (int i = 0; i < shayl.Count; i++)
                        {
                            for (int j = 0; j < som3a.course_list.Count; j++)
                            {
                                if (shayl[i] == som3a.course_list[j].name)
                                {

                                    for (int k = 0; k < _finished_courses.Count; k++)
                                    {
                                        if (som3a.course_list[j].pre_req == "_")
                                        {

                                            
                                           crs.Add(shayl[i]);

                                         

                                            break;
                                        }
                                        if (som3a.course_list[j].pre_req == _finished_courses[k])
                                        {

                                           
                                            crs.Add(shayl[i]);

                                            
                                            break;
                                        }
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                if (_ac_year == "2")
                {
                 
                    if (avrec.Contains("Second year:"))
                    {
                        string[] sub = avrec.Split(del).ToArray();
                        for (int i = 1; i < sub.Length; i++)
                        {

                            shayl.Add(sub[i]);

                        }
                    
                        for (int i = 0; i < shayl.Count; i++)
                        {
                            
                            for (int j = 0; j < som3a.course_list.Count; j++)
                            {
                               
                                if (shayl[i] == som3a.course_list[j].name)
                                {
                                  
                                    for (int k = 0; k < _finished_courses.Count; k++)
                                    {
                                        if (som3a.course_list[j].pre_req == "_")
                                        {
                                            crs.Add(shayl[i]);
                                            break;
                                        }
                                        else if (som3a.course_list[j].pre_req == _finished_courses[k])
                                        {
                                            crs.Add(shayl[i]);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                avrec = av.ReadLine();
            }
            av.Close();
            return crs;
           
        }




        public string register(string g)
        {
            string condition;

           // StreamReader read = new StreamReader("student.txt");
           // string record;
            char[] dels = { ':', ',', '.', '-' };
        //    record = read.ReadLine();
            readdata();
            course_object.read();
          //  string g;
           // Console.WriteLine("please enter the name of the course you want to apply in : ");
            //g = Console.ReadLine();

            for (int i = 0; i < course_object.course_list.Count; i++)
            {
                if (g == course_object.course_list[i].name)
                {
                    for (int j = 0; j < _finished_courses.Count; j++)
                    {
                        if (course_object.course_list[i].pre_req == _finished_courses[j] || course_object.course_list[i].pre_req == "_")
                        {
                            if (course_object.course_list[i].no_of_students < course_object.course_list[i].max_st)
                            {

                                //                 Console.WriteLine("Registeration Completed");
                                condition = "Registeration Completed !";
                                course_object.course_list[i].no_of_students++;
                                _courses_progress.Add(course_object.course_list[i].code);
                                //  Console.WriteLine(logged_in.courses_progress.Last());
                                for (int z = 0; z < student_list.Count; z++)
                                {
                                    if (_ID == student_list[z].ID)
                                    {
                                        student_list[z].courses_progress = _courses_progress;
                                    }
                                }
                                writedata();
                                
                                course_object.writedata();
                                return condition;
                               
                            }
                            else if (course_object.course_list[i].no_of_students > course_object.course_list[i].max_st)
                            {
                                condition = "Maxed to !";
                               // read.Close();
                                return condition;
                            }
                        }
                    }

                }
            }

       //     read.Close();

            condition = "No Courses with this name !!";
            return condition;

        }


        public void writedata()
        {
            StreamWriter writer1 = new StreamWriter("student.txt");
            for (int i = 0; i < student_list.Count; i++)
            {
                writer1.WriteLine("Name" + ":" + student_list[i].name);
                writer1.WriteLine("ID" + ":" + student_list[i].ID);
                writer1.WriteLine("Password" + ":" + student_list[i].pass);
                writer1.WriteLine("AcYear" + ":" + student_list[i].academic_year);
                for (int j = 0; j < student_list[i].finished_courses.Count; j++)
                {
                    if (j == 0)
                        writer1.Write("Finished" + ":" + student_list[i].finished_courses[j]);
                    else
                    {
                        writer1.Write("," + student_list[i].finished_courses[j]);
                      
                    }
                    
                }
                writer1.WriteLine();
                for (int k = 0; k < student_list[i].courses_progress.Count; k++)
                {
                    if (k == 0)
                        writer1.Write("progress" + ":" + student_list[i].courses_progress[k]);
                    else
                    {
                        writer1.Write("," + student_list[i].courses_progress[k]);
                       
                    }
                      
                }
                writer1.WriteLine();
                writer1.WriteLine("------------------------");
            }
            writer1.Close();
        }


        public List<string> viewcourses()
        {
           
            List<string> crs = new List<string>();

            for (int j = 0; j < _courses_progress.Count; j++)
            {
                {
                    //Console.WriteLine("Finished :" + _courses_progress[j]);
                    //count1++;
                    crs.Add(_courses_progress[j]);
                }
            }
            //if (count1 == 0)
            //{
            //    Console.WriteLine("There is no courses in progress");
            //}

            return crs;
        }


        public void editdata(string new_name,string new_pass)
        {

            readdata();
            string old_name;
            string old_pass;


            old_name = _name;
            old_pass = _pass;

            _name = new_name;
            _pass = new_pass;


            for (int i=0;i<student_list.Count;i++)
            {
                if(student_list[i].ID==_ID)
                {

                    string text = File.ReadAllText("student.txt");
                    text = text.Replace(old_name, _name);
                    File.WriteAllText("student.txt", text);
                    

                    string text2 = File.ReadAllText("student.txt");
                    text2 = text2.Replace(old_pass, _pass);
                    File.WriteAllText("student.txt", text2);
                }
            }
           
        }
    }
}
