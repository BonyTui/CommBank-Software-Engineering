using MongoDB.Driver;
using System;

class Program
{
    static void Main()
    {
        var client = new MongoClient("mongodb+srv://tony:XLnIknDDp6PQH63Y@commcluster.nrasfmm.mongodb.net/");
        var db = client.GetDatabase("CommBank");
        var collections = db.ListCollectionNames().ToList();
        Console.WriteLine("Collections: " + string.Join(", ", collections));
    }
}