namespace Talk.DataAccess.Interfaces
{
    public interface IAccountDataAccess
    {
        bool Verify(string account, string password);
    }
}