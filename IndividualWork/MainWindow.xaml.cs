using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IndividualWork
{
    class Student
    {
      
        public string Name { get; set; }
        public string Last_name { get; set; }
        public ushort Rating { get; set; }
        public ushort Ex_rating { get; set; }

        public Student(string name, string last_name, ushort rating, ushort ex_rating)
        {
            Name = name;
            Last_name = last_name;
            Rating = rating;
            Ex_rating = ex_rating;
        }

        public override string ToString()
        { 
            return Name +" "+ Last_name + "         " + Rating + "          " + Ex_rating.ToString(); 
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
          
            InitializeComponent();
            st_list.Items.Add("Անուն Ազգանուն--Ռեյթինգ--Գնահատական");
            Adds("Nona", "Hakobyan  ", 80, 15);
            Adds("Meri", "Barseghyan", 67, 14);
            Adds("Anna", "Yavryan   ", 78, 18);
            Adds("Hasmik", "Safaryan", 30, 9);
            Adds("Anna", "Voskanyan ", 20, 10);
            Adds("Hakob", "Hakobyan ", 30, 11);

        }

        public void Adds(string name, string lname, ushort rating, ushort ex_rating)
        {
            int k = 30;// K տրված թիվ 
            Student student = new Student(name, lname, rating, ex_rating);
            st_list.Items.Add(student).ToString();

            if (student.Rating - student.Ex_rating < k)
            {
                final_list.Items.Add(student.ToString());
            }

        }
      
    }
}
