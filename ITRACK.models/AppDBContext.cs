using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class ItrackContext : DbContext

    {

        public ItrackContext()
            : base("AppDbContext")
        {
            //Create database always, even If exists
            Database.SetInitializer<ItrackContext>(new ItrackContextInitializer());
        }

      

        public DbSet<Group> Group { get; set; }

        public DbSet<Company> Company { get; set; }

        public DbSet<Buyer> Buyer { get; set; }

        public DbSet<Style> Style { get; set; }

        public DbSet<SketchDefinition> SketchDefinition { get; set; }

        public DbSet<User> User { get; set; }


        public DbSet<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }


        public DbSet<PurchaseOrderItems> PurchaseOrderItems { get; set; }

        public DbSet<Employee> Employee { get; set; }

        public DbSet<Promotion> Promotion { get; set; }

        public DbSet<Award> Award { get; set; }

        public DbSet<PastEmployeement> PastEmployeement { get; set; }


        public DbSet<Workflow> Workflow { get; set; }

        public DbSet<WorkflowSetup> WorkflowSetup { get; set; }

        public DbSet<Workstation> Workstation { get; set; }

        public DbSet<Werehouse> Werehouse { get; set; }

        public DbSet<Rack> Rack { get; set; }

        public DbSet<Bin> Bin { get; set; }

        public DbSet<OperationPool> Operation { get; set; }

        public DbSet<CuttingHeader> CuttingHeader { get; set; }

        public DbSet<CuttingItem> CuttingItem { get; set; }

        public DbSet<StyleOperation> StyleOperation { get; set; }

        public DbSet<PartDefinition> PartDefinition { get; set; }

        public DbSet<TempOpration> TempOpration { get; set; }

        public DbSet<DividingPlanHeader> DividingPlanHeader { get; set; }


        public DbSet<DividingPlanItem> DividingPlanItem { get; set; }


        public DbSet<BundleHeader> BundleHeader { get; set; }


        public DbSet<BundleDetails> BundleDetails { get; set; }


        public DbSet<OprationBarcodes> OprationBarcodes { get; set; }

        public DbSet<CustomeFieldSetup> CustomeFieldSetup { get; set; }

        public DbSet<PO> PO { get; set; }

        public DbSet<Items> Items { get; set; }

        public DbSet<VehicleRequisition> VehicleRequisition { get; set; }

      


        public DbSet<DividingPlanTemp> DividingPlanTemp { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();


            //create one to one or one to zero replationsip in Employee - user Entity
            modelBuilder.Entity<User>()
                            .HasKey(t => t.UserID);

            modelBuilder.Entity<Employee>()
                .HasOptional(t => t.User)
                .WithOptionalPrincipal(t => t.Employee);

            // one to one relationship between workstation - worklow rule
            modelBuilder.Entity<WorkflowSetup>()
                           .HasKey(t => t.WorkflowSetupID);

            modelBuilder.Entity<Workstation>()
                .HasOptional(t => t.WorkflowSetup)
                .WithOptionalPrincipal(t => t.Workstation);



            //create one to one or one to zero replationsip in Employee - Workstation Entity
            modelBuilder.Entity<Workstation>()
                            .HasKey(t => t.WorkstationID);

            modelBuilder.Entity<Employee>()
                .HasOptional(t => t.Workstation)
                .WithOptionalPrincipal(t => t.Employee);


      

        }

    }
}
