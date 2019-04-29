using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace Midgard_Charakter_Editor.Database
{
    public class MidgardContext : DbContext
    {
        public MidgardContext()
        {
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={Path.Combine(Environment.CurrentDirectory, "m5editor.db")}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Init Categories
            modelBuilder.Entity<Category>().HasData(new Category(1, "Alltag"));
            modelBuilder.Entity<Category>().HasData(new Category(2, "Freiland"));
            modelBuilder.Entity<Category>().HasData(new Category(3, "Halbwelt"));
            modelBuilder.Entity<Category>().HasData(new Category(4, "Kampf"));
            modelBuilder.Entity<Category>().HasData(new Category(5, "Körperbeherrschung"));
            modelBuilder.Entity<Category>().HasData(new Category(6, "Sozial"));
            modelBuilder.Entity<Category>().HasData(new Category(7, "Unterwelt"));
            modelBuilder.Entity<Category>().HasData(new Category(8, "Waffen"));
            modelBuilder.Entity<Category>().HasData(new Category(9, "Wissen"));

            // Init LearningCosts
            // Alltag
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(1, 9, 0, 1, 2, 5, 1));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(2, 10, 0, 1, 2, 5, 1));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(3, 11, 0, 1, 5, 10, 1));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(4, 12, 0, 1, 5, 10, 1));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(5, 13, 1, 2, 10, 20, 1));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(6, 14, 2, 2, 10, 20, 1));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(7, 15, 5, 5, 20, 50, 1));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(8, 16, 10, 10, 20, 50, 1));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(9, 17, 10, 10, 50, 100, 1));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(10, 18, 20, 20, 50, 100, 1));
            // Freiland
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(11, 9, 1, 2, 5, 2));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(12, 10, 1, 5, 5, 2));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(13, 11, 1, 5, 10, 2));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(14, 12, 2, 10, 10, 2));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(15, 13, 2, 10, 20, 2));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(16, 14, 2, 20, 20, 2));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(17, 15, 5, 20, 50, 2));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(18, 16, 5, 20, 50, 2));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(19, 17, 10, 50, 100, 2));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(20, 18, 10, 50, 100, 2));
            // Halbwelt
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(21, 9, 0, 2, 2, 5, 3));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(22, 10, 0, 2, 5, 10, 3));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(23, 11, 0, 5, 5, 20, 3));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(24, 12, 0, 5, 10, 20, 3));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(25, 13, 1, 10, 10, 30, 3));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(26, 14, 2, 10, 20, 50, 3));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(27, 15, 5, 20, 20, 80, 3));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(28, 16, 10, 20, 50, 80, 3));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(29, 17, 10, 50, 50, 100, 3));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(30, 18, 20, 50, 50, 100, 3));
            // Kampf
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(31, 6, 0, 0, 0, 2, 4));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(32, 7, 0, 0, 0, 5, 4));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(33, 8, 0, 0, 0, 10, 4));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(34, 9, 0, 2, 5, 10, 4));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(35, 10, 0, 2, 10, 20, 4));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(36, 11, 0, 5, 20, 20, 4));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(37, 12, 0, 5, 20, 30, 4));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(38, 13, 1, 10, 30, 50, 4));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(39, 14, 2, 10, 50, 50, 4));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(40, 15, 5, 20, 80, 100, 4));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(41, 16, 10, 20, 80, 100, 4));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(42, 17, 10, 50, 100, 150, 4));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(43, 18, 20, 50, 100, 200, 4));
            // Körperbeherrschung
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(44, 9, 0, 1, 2, 5));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(45, 10, 0, 1, 2, 5));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(46, 11, 0, 2, 5, 5));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(47, 12, 0, 2, 5, 5));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(48, 13, 1, 5, 10, 5));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(49, 14, 2, 10, 10, 5));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(50, 15, 5, 10, 20, 5));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(51, 16, 10, 20, 20, 5));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(52, 17, 10, 20, 50, 5));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(53, 18, 20, 50, 50, 5));
            // Sozial
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(54, 9, 2, 2, 5, 6));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(55, 10, 2, 2, 5, 6));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(56, 11, 5, 5, 10, 6));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(57, 12, 5, 10, 10, 6));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(58, 13, 10, 10, 20, 6));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(59, 14, 10, 20, 20, 6));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(60, 15, 20, 20, 50, 6));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(61, 16, 20, 50, 50, 6));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(62, 17, 50, 50, 100, 6));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(63, 18, 50, 50, 100, 6));
            // Unterwelt
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(64, 9, 2, 5, 5, 7));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(65, 10, 5, 5, 10, 7));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(66, 11, 5, 10, 20, 7));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(67, 12, 10, 10, 20, 7));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(68, 13, 10, 20, 30, 7));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(69, 14, 20, 20, 50, 7));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(70, 15, 20, 50, 80, 7));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(71, 16, 50, 50, 80, 7));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(72, 17, 50, 100, 100, 7));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(73, 18, 50, 100, 100, 7));
            // Waffen
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(74, 6, 1, 1, 1, 1, 8));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(75, 7, 1, 1, 2, 2, 8));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(76, 8, 1, 2, 2, 2, 8));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(77, 9, 2, 2, 5, 5, 8));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(78, 10, 2, 5, 5, 10, 8));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(79, 11, 5, 10, 10, 20, 8));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(80, 12, 10, 20, 20, 50, 8));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(81, 13, 20, 50, 50, 100, 8));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(82, 14, 50, 50, 100, 150, 8));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(83, 15, 100, 100, 150, 200, 8));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(84, 16, 100, 150, 200, 300, 8));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(85, 17, 150, 150, 300, 300, 8));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(86, 18, 150, 200, 300, 400, 8));
            // Wissen
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(87, 9, 1, 2, 2, 9));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(88, 10, 1, 2, 5, 9));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(89, 11, 1, 5, 5, 9));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(90, 12, 1, 5, 10, 9));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(91, 13, 2, 10, 10, 9));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(92, 14, 2, 10, 20, 9));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(93, 15, 5, 20, 20, 9));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(94, 16, 10, 20, 20, 9));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(95, 17, 10, 50, 50, 9));
            modelBuilder.Entity<LearningCost>().HasData(new LearningCost(96, 18, 20, 50, 50, 9));
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<CharacterHasSkill> CharacterHasSkills { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassCategoryAffinity> ClassCategoryAffinities { get; set; }
        public DbSet<ClassCost> ClassCosts { get; set; }
        public DbSet<LearningCost> LearningCosts { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Spell> Spells { get; set; }
        public DbSet<WeaponSkill> WeaponSkills { get; set; }
    }
}
