using System;
using System.Data.Entity;
using System.Linq;
using WcfService1.Models;

namespace WcfService1
{
    public class Model : DbContext
    {
        public Model()
    : base("name=ModelClinic")
        {
        }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Diagnosis> Diagnoses { get; set; }
        public virtual DbSet<Adress> Adresses { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Street> Streets { get; set; }
        public virtual DbSet<Ivent> Doctors { get; set; }
        public virtual DbSet<IventStatus> DocStatuses { get; set; }
    }
}