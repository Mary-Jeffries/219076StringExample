/* Mary Jeffries
 * Feb 11 2020
 * Demonstrate Strings
 */
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

namespace String_Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Run when button pressed, deals with strings.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            //Declare varibales and assign them values 
            string student = "Jeffries,Mary,219076";
            
            int PositionOfFirstComma = -1;
            int PositionOfSecondComma = -1;
            string firstname;
            string lastname;
            string studentNumber;

            lblOutput.Content = student;

            //Get the first name 
            PositionOfFirstComma = student.IndexOf(",");
            MessageBox.Show(PositionOfFirstComma.ToString());
            PositionOfSecondComma = student.IndexOf(",", PositionOfFirstComma + 1);
            MessageBox.Show(PositionOfSecondComma.ToString());

            firstname = student.Substring(PositionOfFirstComma +1,
                PositionOfSecondComma - (PositionOfFirstComma + 1));
            lastname = student.Substring(0, PositionOfFirstComma); //get last name
            studentNumber = student.Substring(PositionOfSecondComma + 1);///get student number
            MessageBox.Show(lastname);
            MessageBox.Show(firstname);

            //Output
            lblOutput.Content = student + Environment.NewLine; 
            lblOutput.Content += firstname + "" + Environment.NewLine;
            lblOutput.Content += lastname + "" + Environment.NewLine; 
            lblOutput.Content += studentNumber + "@tldsb.me";  
        }
    }
}
