using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Parser
{
    public interface IConfigurationParser
    {
        ProblemConfiguration Parse(string configuration);
    }
}
