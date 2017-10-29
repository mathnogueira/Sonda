using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Exceptions;

namespace Gui.Reporters
{
    public class ErrorReporter : IErrorReporter
    {
        public void Report(SondaMovementException ex)
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
