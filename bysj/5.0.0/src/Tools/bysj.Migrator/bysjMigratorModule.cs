using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using bysj.EntityFramework;

namespace bysj.Migrator
{
    [DependsOn(typeof(bysjDataModule))]
    public class bysjMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<bysjDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}