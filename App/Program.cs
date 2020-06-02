using System;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Repository;

namespace ConsoleApplication2
{
    public class Program
    {
        public static TeamsRepository TeamsRepository;

        static async Task Main()
        {
            var dbConnected = await OpenDbConnection();
            if (!dbConnected)
            {
                return;
            }

            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            finally
            {
                CloseDbConnection();
            }
        }

        static Task<bool> OpenDbConnection()
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["AppDB"].ConnectionString;
                TeamsRepository = new TeamsRepository(connectionString);

                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),@"Помилка з'єднання із БД", MessageBoxButtons.OK);
                return Task.FromResult(false);
            }
        }

        static void CloseDbConnection()
        {
            try
            {
                TeamsRepository?.Dispose();
            }
            catch { }
        }
    }
}