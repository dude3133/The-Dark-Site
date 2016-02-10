using System.Web.Http;

namespace TheDarkSite.Controllers
{
    public class TestController : ApiController
    {
        public int Get()
        {
            return 69;
        }
        public TestClass Get(int id)
        {
            return new TestClass
            {
                Id = id,
                Smthn = "69!"
            };
        }
        public int Get(int a,int b)
        {
            return a + b;
        }
    }

    public class TestClass
    {
        public int Id { get; set; }
        public string Smthn { get; set; }
    }
}
