using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using TB.EntityFramework;

namespace TB.Migrator
{
    [DependsOn(typeof(TBDataModule))]
    public class TBMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<TBDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}