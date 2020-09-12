namespace DanielGoodmanOnline.Models
{
    using MongoDB.Driver;
    public interface IDGOContext
    {
        IMongoCollection<Todo> Todos { get; }
    }
}