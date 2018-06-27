using Microsoft.Extensions.Configuration;

namespace SaveFood
{
    public interface IGreeter
    {
        string Greet();
    }

    public class Greeter : IGreeter
    {
        public Greeter(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public string Greet()
        {
           return this.Configuration["Greeting"];
        }
    }
}