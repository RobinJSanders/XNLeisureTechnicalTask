namespace XNLeasureTechnicalTask.Services.Interfaces
{
    public interface ICharacterCountService
    {
        int GetNoOfCharacters(string input, string stringToCount, bool ignoreCase);
    }
}