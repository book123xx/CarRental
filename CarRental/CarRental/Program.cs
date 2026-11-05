using CarRental.Customer;
using CarRental.People;
using CarRental.RentalTransaction;
using CarRental.User;
using CarRental.Vehicle;

namespace CarRental
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin());
        }
    }
}