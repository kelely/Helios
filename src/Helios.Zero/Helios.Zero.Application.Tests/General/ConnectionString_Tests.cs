using System.Data.SqlClient;
using Shouldly;
using Xunit;

namespace Helios.Zero.Application.Tests.General
{
    public class ConnectionString_Tests
    {
        [Fact]
        public void SqlConnectionStringBuilder_Test()
        {
            var csb = new SqlConnectionStringBuilder("Server=localhost; Database=HeliosZero; Trusted_Connection=True;");
            csb["Database"].ShouldBe("HeliosZero");
        }
    }
}
