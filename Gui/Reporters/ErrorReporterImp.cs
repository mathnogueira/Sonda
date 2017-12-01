using System;

namespace Gui.Reporters
{
    public class ErrorReporterImp : ErrorReporter
    {
        public void Report(Exception ex)
        {
            DisplayErrorMessage(ex.Message);
            if (ex.InnerException != null)
            {
                DisplayDetailMessage(ex.InnerException.Message);
            }
        }

        private void DisplayErrorMessage(string msg)
        {
            string errorMessage = String.Format("Error: {0}", msg);
            Console.WriteLine(errorMessage);
        }

        private void DisplayDetailMessage(string msg)
        {
            string detailMessage = String.Format("Detail: {0}", msg);
            Console.WriteLine(detailMessage);
        }
    }
}
