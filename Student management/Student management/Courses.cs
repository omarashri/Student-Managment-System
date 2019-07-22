using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management
{
    class Courses
    {
        public string name;
        public string code;
        public int max_st;
        public int no_of_students;
        public string pre_req;
        public string hours;
        public List<Courses> course_list = new List<Courses>();
        public static Courses single_course = new Courses();
        public Student a7a = new Student();




        public void read()
        {
            StreamReader reader2 = new StreamReader("Courses data.txt");
            string record;
            char[] dels = { ':', ',', '\t' };
            record = reader2.ReadLine();
            while (record != null)
            {
                if (record.Contains("Name"))
                {
                    string[] substring1 = record.Split(dels).ToArray();
                    for (int i = 1; i < substring1.Length; i++)
                    {
                        single_course.name = substring1[i].ToString();
                    }
                }

                /*------------------------------------------------------*/

                else if (record.Contains("Code"))
                {
                    string[] substring1 = record.Split(dels).ToArray();

                    for (int i = 1; i < substring1.Length; i++)
                    {
                        single_course.code = substring1[i].ToString();
                    }

                }

                /*------------------------------------------------------*/

                else if (record.Contains("Maxstudents"))
                {
                    string[] substring1 = record.Split(dels).ToArray();

                    for (int i = 1; i < substring1.Length; i++)
                    {
                        single_course.max_st = Convert.ToInt32(substring1[i]);
                    }
                }

                /*------------------------------------------------------*/


                else if (record.Contains("Prereq"))
                {
                    string[] substring1 = record.Split(dels).ToArray();

                    for (int i = 1; i < substring1.Length; i++)
                    {
                        single_course.pre_req = substring1[i];
                    }
                }

                /*------------------------------------------------------*/

                else if (record.Contains("Hours"))
                {
                    string[] substring1 = record.Split(dels).ToArray();
                    for (int i = 1; i < substring1.Length; i++)
                    {
                        single_course.hours = substring1[i];
                    }
                }
                /*------------------------------------------------------*/

                else if (record.Contains("Students"))
                {
                    string[] substring1 = record.Split(dels).ToArray();

                    for (int i = 1; i < substring1.Length; i++)
                    {
                        single_course.no_of_students = Convert.ToInt32(substring1[i]);
                    }
                }


                /*------------------------------------------------------*/


                else if (record.Contains("---------------"))
                {
                    course_list.Add(single_course);
                    single_course = new Courses();

                }
                record = reader2.ReadLine();
            }
            reader2.Close();
        }



        public List<string> details(string x)
        {
            List<string> crs = new List<string>();
            read();
           
            StreamReader detail = new StreamReader("Courses data.txt");
            string det;
            char[] dels = { ':', ',', '.', '\t' };
            det = detail.ReadLine();
           // Console.WriteLine("write the name of the course");
           // x = Console.ReadLine();
            while (det != null)
            {
                for (int i = 0; i < course_list.Count; i++)
                {
                    if (course_list[i].name == x)
                    {
                        //Console.WriteLine("Name:" + course_list[i].name);
                        //Console.WriteLine("Code:" + course_list[i].code);
                        //Console.WriteLine("Max Students:" + course_list[i].max_st);
                        //Console.WriteLine("pre:" + course_list[i].pre_req);
                        //Console.WriteLine("Hours:" + course_list[i].hours);
                        crs.Add(course_list[i].name);
                        crs.Add(course_list[i].code);
                        crs.Add(course_list[i].max_st.ToString());
                        crs.Add(course_list[i].pre_req);
                        crs.Add(course_list[i].hours);




                    }
                }
                break;
                //det = detail.ReadLine();

            }
            return crs;
        }


        public void writedata()
        {
            StreamWriter writer1 = new StreamWriter("Courses data.txt");
            writer1.WriteLine("First year:MathII,Intro,Physics,MathI,,Structural Programming,Biology");
            writer1.WriteLine("Second year:MathIII,Cell Biology,DS,Biophysics,Probability");
            for (int i = 0; i < course_list.Count; i++)
            {
                writer1.WriteLine("Name" + ":" + course_list[i].name);
                writer1.WriteLine("Code" + ":" + course_list[i].code);
                writer1.WriteLine("Maxstudents" + ":" + course_list[i].max_st);
                writer1.WriteLine("Prereq" + ":" + course_list[i].pre_req);
                writer1.WriteLine("Students" + ":" + course_list[i].no_of_students);
                writer1.WriteLine("Hours" + ":" + course_list[i].hours);
                writer1.WriteLine("----------------------------");
            }
            writer1.Close();

        }

    }
}
