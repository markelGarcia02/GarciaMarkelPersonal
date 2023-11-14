using GarciaMarkelPersonal.Models.clases_atomicas;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GarciaMarkelPersonal.Data
{
	public class objetoDBContext : DbContext
	{

		public objetoDBContext(DbContextOptions<objetoDBContext> options) : base(options){ }

		public DbSet<Objeto> Objeto { get; set; }

	}
}
