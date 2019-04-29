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
            // Skill Categories
            modelBuilder.Entity<Category>().HasData(new Category(1, "Alltag"));
            modelBuilder.Entity<Category>().HasData(new Category(2, "Freiland"));
            modelBuilder.Entity<Category>().HasData(new Category(3, "Halbwelt"));
            modelBuilder.Entity<Category>().HasData(new Category(4, "Kampf"));
            modelBuilder.Entity<Category>().HasData(new Category(5, "Körperbeherrschung"));
            modelBuilder.Entity<Category>().HasData(new Category(6, "Sozial"));
            modelBuilder.Entity<Category>().HasData(new Category(7, "Unterwelt"));
            modelBuilder.Entity<Category>().HasData(new Category(8, "Waffen"));
            modelBuilder.Entity<Category>().HasData(new Category(9, "Wissen"));
            // Spell Categories
            modelBuilder.Entity<Category>().HasData(new Category(10, "Beherrschung"));
            modelBuilder.Entity<Category>().HasData(new Category(11, "Bewegung"));
            modelBuilder.Entity<Category>().HasData(new Category(12, "Erkennen"));
            modelBuilder.Entity<Category>().HasData(new Category(13, "Erschaffen"));
            modelBuilder.Entity<Category>().HasData(new Category(14, "Formen"));
            modelBuilder.Entity<Category>().HasData(new Category(15, "Verändern"));
            modelBuilder.Entity<Category>().HasData(new Category(16, "Zerstören"));
            modelBuilder.Entity<Category>().HasData(new Category(17, "Wundertat"));
            modelBuilder.Entity<Category>().HasData(new Category(18, "Dweomer"));
            modelBuilder.Entity<Category>().HasData(new Category(19, "Lied"));

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

            // Init Classes
            modelBuilder.Entity<Class>().HasData(new Class(1, "Assassine", "As"));
            modelBuilder.Entity<Class>().HasData(new Class(2, "Barbar", "Bb"));
            modelBuilder.Entity<Class>().HasData(new Class(3, "Glücksritter", "Gl"));
            modelBuilder.Entity<Class>().HasData(new Class(4, "Händler", "Hä"));
            modelBuilder.Entity<Class>().HasData(new Class(5, "Krieger", "Kr"));
            modelBuilder.Entity<Class>().HasData(new Class(6, "Spitzbube", "Sp"));
            modelBuilder.Entity<Class>().HasData(new Class(7, "Waldläufer", "Wa"));
            modelBuilder.Entity<Class>().HasData(new Class(8, "Barde", "Ba"));
            modelBuilder.Entity<Class>().HasData(new Class(9, "Ordenskrieger", "Or"));
            modelBuilder.Entity<Class>().HasData(new Class(10, "Druide", "Dr"));
            modelBuilder.Entity<Class>().HasData(new Class(11, "Hexer", "Hx"));
            modelBuilder.Entity<Class>().HasData(new Class(12, "Magier", "Ma"));
            modelBuilder.Entity<Class>().HasData(new Class(13, "Priester, Beschützer", "PB"));
            modelBuilder.Entity<Class>().HasData(new Class(14, "Priester, Streiter", "PS"));
            modelBuilder.Entity<Class>().HasData(new Class(15, "Schamane", "Sc"));

            // Init ClassCosts
            // Assassine
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(1, 20, 1, 1));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(2, 20, 1, 2));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(3, 20, 1, 3));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(4, 30, 1, 4));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(5, 10, 1, 5));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(6, 20, 1, 6));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(7, 10, 1, 7));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(8, 20, 1, 8));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(9, 20, 1, 9));
            // Barbar
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(10, 20, 2, 1));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(11, 10, 2, 2));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(12, 30, 2, 3));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(13, 10, 2, 4));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(14, 10, 2, 5));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(15, 30, 2, 6));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(16, 30, 2, 7));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(17, 20, 2, 8));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(18, 40, 2, 9));
            // Glücksritter
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(19, 20, 3, 1));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(20, 30, 3, 2));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(21, 10, 3, 3));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(22, 20, 3, 4));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(23, 30, 3, 5));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(24, 10, 3, 6));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(25, 30, 3, 7));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(26, 20, 3, 8));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(27, 20, 3, 9));
            // Händler
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(28, 10, 4, 1));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(29, 20, 4, 2));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(30, 20, 4, 3));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(31, 20, 4, 4));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(32, 20, 4, 5));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(33, 10, 4, 6));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(34, 40, 4, 7));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(35, 20, 4, 8));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(36, 20, 4, 9));
            // Krieger
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(37, 20, 5, 1));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(38, 30, 5, 2));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(39, 30, 5, 3));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(40, 10, 5, 4));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(41, 20, 5, 5));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(42, 20, 5, 6));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(43, 30, 5, 7));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(44, 10, 5, 8));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(45, 40, 5, 9));
            // Spitzbube
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(46, 20, 6, 1));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(47, 30, 6, 2));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(48, 10, 6, 3));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(49, 40, 6, 4));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(50, 10, 6, 5));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(51, 10, 6, 6));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(52, 10, 6, 7));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(53, 20, 6, 8));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(54, 30, 6, 9));
            // Waldläufer
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(55, 20, 7, 1));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(56, 10, 7, 2));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(57, 20, 7, 3));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(58, 20, 7, 4));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(59, 10, 7, 5));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(60, 30, 7, 6));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(61, 30, 7, 7));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(62, 20, 7, 8));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(63, 20, 7, 9));
            // Barde
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(64, 20, 8, 1));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(65, 20, 8, 2));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(66, 20, 8, 3));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(67, 30, 8, 4));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(68, 20, 8, 5));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(69, 10, 8, 6));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(70, 40, 8, 7));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(71, 20, 8, 8));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(72, 20, 8, 9));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(73, 30, 8, 19));
            // Ordenskrieger
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(74, 20, 9, 1));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(75, 20, 9, 2));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(76, 40, 9, 3));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(77, 20, 9, 4));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(78, 10, 9, 5));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(79, 20, 9, 6));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(80, 40, 9, 7));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(81, 20, 9, 8));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(82, 30, 9, 9));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(83, 30, 9, 17));
            // Druide
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(84, 20, 10, 1));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(85, 10, 10, 2));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(86, 40, 10, 3));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(87, 40, 10, 4));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(88, 20, 10, 5));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(89, 30, 10, 6));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(90, 40, 10, 7));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(91, 40, 10, 8));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(92, 10, 10, 9));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(93, 90, 10, 10));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(94, 60, 10, 11));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(95, 120, 10, 12));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(96, 90, 10, 13));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(97, 60, 10, 14));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(98, 90, 10, 15));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(99, 120, 10, 16));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(100, 30, 10, 18));
            // Hexer
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(101, 20, 11, 1));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(102, 20, 11, 2));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(103, 30, 11, 3));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(104, 40, 11, 4));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(105, 30, 11, 5));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(106, 20, 11, 6));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(107, 30, 11, 7));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(108, 40, 11, 8));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(109, 20, 11, 9));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(110, 30, 11, 10));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(111, 90, 11, 11));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(112, 90, 11, 12));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(113, 90, 11, 13));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(114, 60, 11, 14));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(115, 30, 11, 15));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(116, 60, 11, 16));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(117, 90, 11, 18));
            // Magier
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(118, 20, 12, 1));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(119, 30, 12, 2));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(120, 40, 12, 3));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(121, 40, 12, 4));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(122, 30, 12, 5));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(123, 30, 12, 6));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(124, 40, 12, 7));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(125, 40, 12, 8));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(126, 10, 12, 9));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(127, 60, 12, 10));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(128, 60, 12, 11));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(129, 60, 12, 12));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(130, 60, 12, 13));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(131, 60, 12, 14));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(132, 60, 12, 15));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(133, 60, 12, 16));
            // Priester, Beschützer
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(134, 20, 13, 1));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(135, 30, 13, 2));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(136, 30, 13, 3));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(137, 40, 13, 4));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(138, 30, 13, 5));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(139, 10, 13, 6));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(140, 40, 13, 7));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(141, 40, 13, 8));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(142, 20, 13, 9));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(143, 60, 13, 10));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(144, 90, 13, 11));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(145, 60, 13, 12));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(146, 90, 13, 13));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(147, 120, 13, 14));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(148, 120, 13, 15));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(149, 90, 13, 16));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(150, 30, 13, 17));
            // Priester, Streiter
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(151, 20, 14, 1));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(152, 30, 14, 2));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(153, 40, 14, 3));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(154, 30, 14, 4));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(155, 30, 14, 5));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(156, 30, 14, 6));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(157, 40, 14, 7));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(158, 30, 14, 8));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(159, 20, 14, 9));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(160, 90, 14, 10));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(161, 90, 14, 11));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(162, 90, 14, 12));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(163, 60, 14, 13));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(164, 120, 14, 14));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(165, 120, 14, 15));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(166, 60, 14, 16));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(167, 30, 14, 17));
            // Schamane
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(168, 20, 15, 1));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(169, 10, 15, 2));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(170, 40, 15, 3));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(171, 40, 15, 4));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(172, 20, 15, 5));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(173, 20, 15, 6));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(174, 40, 15, 7));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(175, 40, 15, 8));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(176, 20, 15, 9));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(177, 60, 15, 10));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(178, 90, 15, 11));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(179, 60, 15, 12));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(180, 120, 15, 13));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(181, 120, 15, 14));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(182, 60, 15, 15));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(183, 60, 15, 16));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(184, 60, 15, 17));
            modelBuilder.Entity<ClassCost>().HasData(new ClassCost(185, 60, 15, 18));
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
