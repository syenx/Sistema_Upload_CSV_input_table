using System.Data.Entity.Migrations;
using OP.PortalOncoprod.Infra.CrossCutting.Logging.Data;

namespace OP.PortalOncoprod.Infra.CrossCutting.Logging.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<LogginContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LogginContext context)
        {

        }
    }
}
