using Blog.DAL.Repository;
using Blog.DAL.Tests.Fixtures;
using NUnit.Framework;
using TDD.DbTestHelpers.Core;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Blog.DAL.Tests
{

    [TestFixture]
    public class RepositoryTests : DbBaseTest<BlogFixtures>
    {

        [Test]
        public void GetAllPost_OnePostInDb_ReturnOnePost()
        {
            // arrange
            // String connectionString = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("BloggingDatabase");
            
            String connectionString = "Server=localhost;Database=master;Trusted_Connection=True;encrypt=false;";
            // //String connectionString = GetConnectionString("BloggingDatabase");
            // var context = new BlogContext(connectionString);
            // context.Database.EnsureCreated();
            
            var repository = new BlogRepository(connectionString);

            // act
            // todo: te fixtures zajebane nie dziala...
            var result = repository.GetAllPosts();
            // assert
            Assert.AreEqual(1, result.Count());
        }
    }
}
