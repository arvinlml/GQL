namespace ConferencePlanner.GraphQL
{
    using System.Linq;
    using HotChocolate;
    using ConferencePlanner.GraphQL.Data;

    public class Query
    {
        public IQueryable<Speaker> GetSpeakers([Service] ApplicationDbContext context) =>
            context.Speakers;
    }
}