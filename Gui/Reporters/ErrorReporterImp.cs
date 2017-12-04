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
            DisplayMessage("Error", msg);
        }

        private void DisplayDetailMessage(string msg)
        {
            DisplayMessage("Detail", msg);
        }

        private void DisplayMessage(string prefix, string msg)
        {
            string formattedMessage = String.Format("{0}: {1}", prefix, msg);
            Console.WriteLine(formattedMessage);
        }
    }
}
