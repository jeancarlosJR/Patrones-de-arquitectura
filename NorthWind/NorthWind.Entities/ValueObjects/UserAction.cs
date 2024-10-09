namespace NorthWind.Entities.ValueObjects
{
    public class UserAction(string useer, string description)
    {
        public DateTime CreatedDateTime { get; } = DateTime.Now;
        public string User => User;
        public string Description => Description;
    }
}
