using System;

namespace Composition
{
  
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new dbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();

            installer.Install();
        }
    }
}