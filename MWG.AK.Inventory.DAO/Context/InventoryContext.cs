using Microsoft.EntityFrameworkCore;
using MWG.AK.Inventory.BO.AggregatesModel;
using MWG.AK.Inventory.DAO.Entities;

namespace MWG.AK.Inventory.Context
{

    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(AppSettings.ConnectionStringPHA);
        }

        public DbSet<OutputVoucher> OutputVoucher { get; set; }
    }
}
