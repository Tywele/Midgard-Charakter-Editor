using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace Midgard_Charakter_Editor.Database
{
	public class MidgardContext : DbContext
	{
		private static bool _created;

		public MidgardContext()
		{
			if (!_created)
			{
				_created = true;
				Database.EnsureDeleted();
				Database.EnsureCreated();
			}
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite($"Data Source={Path.Combine(Environment.CurrentDirectory, "m5editor.db")}");
		}

		public DbSet<Character> Characters { get; set; }
		public DbSet<Race> Races { get; set; }
		public DbSet<Class> Classes { get; set; }
		public DbSet<Spell> Spells { get; set; }
 	}
}
