namespace Login
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Entities;

    public partial class PrimaxDataModel : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public PrimaxDataModel(): base("name=PrimaxDataModel"){}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
