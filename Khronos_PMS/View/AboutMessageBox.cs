using System;
using System.Windows;

namespace Khronos_PMS.View
{
    internal class AboutMessageBox
    {
        public AboutMessageBox()
        {
            String message;
            message = "    Khronos Project Managment System is created as a assignment as part of the course \"Information Systems\" at the Faculty of Electrical Engineering in Banja Luka.\n\n";
            message += "    It simulates the operation of the organization of projects within a company, which works for external customers. Options that are supported within application, among other things, allows you to track work on the project, as a whole and its parts, finances, generate business reports, a comprehensive insight into the project, and other things that are necessary for the successful business.Employees with different authorization have different levels of access to data.\n";
            message += "\nStudents that were assigned:\n    Marko Stijak\n    Vladan Stojnic\n    Nenad Golubovic\n    Nemanja Lukic\n    Dusko Vrljanovic";
            MessageBox.Show(message, "About Khronos Project Managment System                                                ", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}