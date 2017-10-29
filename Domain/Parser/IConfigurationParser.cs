namespace Domain.Parser
{
    public interface IConfigurationParser
    {
        ProblemConfiguration Parse(string configuration);
    }
}
