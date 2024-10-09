namespace NorthWind.Core.Services
{
    internal class AppLogger(IEnumerable<IUserActionWriter> writers) : IAppLogger
    {
        public void Writelog(string message)
        {
            UserAction Log = new UserAction("System", message);
            foreach (var Writer in writers)
            { Writer.Write(Log); }
        }
    }
}
