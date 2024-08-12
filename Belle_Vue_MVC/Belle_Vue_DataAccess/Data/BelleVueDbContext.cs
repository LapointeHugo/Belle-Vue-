//using Belle_Vue_Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belle_Vue_DataAccess.Data
{
	public class BelleVueDbContext : IdentityDbContext
	{

		public BelleVueDbContext(DbContextOptions<BelleVueDbContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			//// Seed data using the HasData method
			//ModelBuilderDataGenerator.GenerateData(modelBuilder);
		}
	}
}
