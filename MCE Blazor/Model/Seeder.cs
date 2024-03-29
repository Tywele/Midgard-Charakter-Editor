﻿using Microsoft.EntityFrameworkCore;

namespace MCE.Model
{
    /// <summary>
    /// Class for initializing data for database through seeding.
    /// </summary>
    public class Seeder : ISeeder
    {
        /// <summary>
        /// Initializes Categories for the database.
        /// </summary>
        public void SeedCategories(ModelBuilder modelBuilder)
        {
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
            modelBuilder.Entity<Category>().HasData(new Category(10, "Beherrschen"));
            modelBuilder.Entity<Category>().HasData(new Category(11, "Bewegen"));
            modelBuilder.Entity<Category>().HasData(new Category(12, "Erkennen"));
            modelBuilder.Entity<Category>().HasData(new Category(13, "Erschaffen"));
            modelBuilder.Entity<Category>().HasData(new Category(14, "Formen"));
            modelBuilder.Entity<Category>().HasData(new Category(15, "Verändern"));
            modelBuilder.Entity<Category>().HasData(new Category(16, "Zerstören"));
            modelBuilder.Entity<Category>().HasData(new Category(17, "Wundertat"));
            modelBuilder.Entity<Category>().HasData(new Category(18, "Dweomer"));
            modelBuilder.Entity<Category>().HasData(new Category(19, "Lied"));
            modelBuilder.Entity<Category>().HasData(new Category(20, "Zauberspruch"));
        }

        /// <summary>
        /// Initializes SkillTrainingCosts for the database.
        /// </summary>
        /// <param name="modelBuilder"></param>
        public void SeedSkillTrainingCosts(ModelBuilder modelBuilder)
        {
            // Alltag
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(1, 9, 0, 1, 2, 5, 1));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(2, 10, 0, 1, 2, 5, 1));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(3, 11, 0, 1, 5, 10, 1));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(4, 12, 0, 1, 5, 10, 1));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(5, 13, 1, 2, 10, 20, 1));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(6, 14, 2, 2, 10, 20, 1));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(7, 15, 5, 5, 20, 50, 1));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(8, 16, 10, 10, 20, 50, 1));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(9, 17, 10, 10, 50, 100, 1));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(10, 18, 20, 20, 50, 100, 1));
            // Freiland
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(11, 9, 1, 2, 5, 2));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(12, 10, 1, 5, 5, 2));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(13, 11, 1, 5, 10, 2));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(14, 12, 2, 10, 10, 2));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(15, 13, 2, 10, 20, 2));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(16, 14, 2, 20, 20, 2));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(17, 15, 5, 20, 50, 2));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(18, 16, 5, 20, 50, 2));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(19, 17, 10, 50, 100, 2));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(20, 18, 10, 50, 100, 2));
            // Halbwelt
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(21, 9, 0, 2, 2, 5, 3));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(22, 10, 0, 2, 5, 10, 3));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(23, 11, 0, 5, 5, 20, 3));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(24, 12, 0, 5, 10, 20, 3));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(25, 13, 1, 10, 10, 30, 3));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(26, 14, 2, 10, 20, 50, 3));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(27, 15, 5, 20, 20, 80, 3));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(28, 16, 10, 20, 50, 80, 3));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(29, 17, 10, 50, 50, 100, 3));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(30, 18, 20, 50, 50, 100, 3));
            // Kampf
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(31, 6, 0, 0, 0, 2, 4));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(32, 7, 0, 0, 0, 5, 4));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(33, 8, 0, 0, 0, 10, 4));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(34, 9, 0, 2, 5, 10, 4));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(35, 10, 0, 2, 10, 20, 4));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(36, 11, 0, 5, 20, 20, 4));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(37, 12, 0, 5, 20, 30, 4));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(38, 13, 1, 10, 30, 50, 4));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(39, 14, 2, 10, 50, 50, 4));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(40, 15, 5, 20, 80, 100, 4));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(41, 16, 10, 20, 80, 100, 4));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(42, 17, 10, 50, 100, 150, 4));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(43, 18, 20, 50, 100, 200, 4));
            // Körperbeherrschung
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(44, 9, 0, 1, 2, 5));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(45, 10, 0, 1, 2, 5));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(46, 11, 0, 2, 5, 5));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(47, 12, 0, 2, 5, 5));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(48, 13, 1, 5, 10, 5));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(49, 14, 2, 10, 10, 5));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(50, 15, 5, 10, 20, 5));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(51, 16, 10, 20, 20, 5));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(52, 17, 10, 20, 50, 5));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(53, 18, 20, 50, 50, 5));
            // Sozial
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(54, 9, 2, 2, 5, 6));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(55, 10, 2, 2, 5, 6));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(56, 11, 5, 5, 10, 6));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(57, 12, 5, 10, 10, 6));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(58, 13, 10, 10, 20, 6));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(59, 14, 10, 20, 20, 6));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(60, 15, 20, 20, 50, 6));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(61, 16, 20, 50, 50, 6));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(62, 17, 50, 50, 100, 6));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(63, 18, 50, 50, 100, 6));
            // Unterwelt
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(64, 9, 2, 5, 5, 7));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(65, 10, 5, 5, 10, 7));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(66, 11, 5, 10, 20, 7));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(67, 12, 10, 10, 20, 7));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(68, 13, 10, 20, 30, 7));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(69, 14, 20, 20, 50, 7));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(70, 15, 20, 50, 80, 7));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(71, 16, 50, 50, 80, 7));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(72, 17, 50, 100, 100, 7));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(73, 18, 50, 100, 100, 7));
            // Waffen
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(74, 6, 1, 1, 1, 1, 8));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(75, 7, 1, 1, 2, 2, 8));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(76, 8, 1, 2, 2, 2, 8));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(77, 9, 2, 2, 5, 5, 8));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(78, 10, 2, 5, 5, 10, 8));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(79, 11, 5, 10, 10, 20, 8));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(80, 12, 10, 20, 20, 50, 8));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(81, 13, 20, 50, 50, 100, 8));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(82, 14, 50, 50, 100, 150, 8));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(83, 15, 100, 100, 150, 200, 8));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(84, 16, 100, 150, 200, 300, 8));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(85, 17, 150, 150, 300, 300, 8));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(86, 18, 150, 200, 300, 400, 8));
            // Wissen
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(87, 9, 1, 2, 2, 9));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(88, 10, 1, 2, 5, 9));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(89, 11, 1, 5, 5, 9));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(90, 12, 1, 5, 10, 9));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(91, 13, 2, 10, 10, 9));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(92, 14, 2, 10, 20, 9));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(93, 15, 5, 20, 20, 9));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(94, 16, 10, 20, 20, 9));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(95, 17, 10, 50, 50, 9));
            modelBuilder.Entity<SkillTrainingCost>().HasData(new SkillTrainingCost(96, 18, 20, 50, 50, 9));
        }

        /// <summary>
        /// Initializes Classes for the database.
        /// </summary>
        /// <param name="modelBuilder"></param>
        public void SeedClasses(ModelBuilder modelBuilder)
        {
            // 0 = Kämpfer
            modelBuilder.Entity<Class>().HasData(new Class(1, "Assassine", "As", 0));
            modelBuilder.Entity<Class>().HasData(new Class(2, "Barbar", "Bb", 0));
            modelBuilder.Entity<Class>().HasData(new Class(3, "Glücksritter", "Gl", 0));
            modelBuilder.Entity<Class>().HasData(new Class(4, "Händler", "Hä", 0));
            modelBuilder.Entity<Class>().HasData(new Class(5, "Krieger", "Kr", 0));
            modelBuilder.Entity<Class>().HasData(new Class(6, "Spitzbube", "Sp", 0));
            modelBuilder.Entity<Class>().HasData(new Class(7, "Waldläufer", "Wa", 0));
            // 1 = Zauberkundiger Kämpfer
            modelBuilder.Entity<Class>().HasData(new Class(8, "Barde", "Ba", 1));
            modelBuilder.Entity<Class>().HasData(new Class(9, "Ordenskrieger", "Or", 1));
            // 2 = Zauberer
            modelBuilder.Entity<Class>().HasData(new Class(10, "Druide", "Dr", 2));
            modelBuilder.Entity<Class>().HasData(new Class(11, "Hexer", "Hx", 2));
            modelBuilder.Entity<Class>().HasData(new Class(12, "Magier", "Ma", 2));
            modelBuilder.Entity<Class>().HasData(new Class(13, "Priester, Beschützer", "PB", 2));
            modelBuilder.Entity<Class>().HasData(new Class(14, "Priester, Streiter", "PS", 2));
            modelBuilder.Entity<Class>().HasData(new Class(15, "Schamane", "Sc", 2));
        }

        /// <summary>
        /// Initializes ClassCosts for the database.
        /// </summary>
        /// <param name="modelBuilder"></param>
        public void SeedClassCosts(ModelBuilder modelBuilder)
        {
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

        /// <summary>
        /// Initializes Skills for the database.
        /// </summary>
        /// <param name="modelBuilder"></param>
        public void SeedSkills(ModelBuilder modelBuilder)
        {
            // Allgemeine Fertigkeiten
            modelBuilder.Entity<Skill>().HasData(new Skill(1, "Abwehr", "gw", "Kampf", 10, false, 10));
            modelBuilder.Entity<Skill>().HasData(new Skill(2, "Akrobatik", "gw", "Bewegung", 8, true, 6));
            modelBuilder.Entity<Skill>().HasData(new Skill(3, "Alchemie", "in", "Wissen", 8, true, 0));
            modelBuilder.Entity<Skill>().HasData(new Skill(4, "Anführen", "pa", "Sozial", 8, true, 6));
            modelBuilder.Entity<Skill>().HasData(new Skill(5, "Athletik", "st", "Körperbeherrschung", 8, true, 0));
            modelBuilder.Entity<Skill>().HasData(new Skill(6, "Balancieren", "gw", "Bewegung", 12, true, 6));
            modelBuilder.Entity<Skill>().HasData(new Skill(7, "Beidhändiger Kampf", "gs", "Kampf", 5, false, 0));
            modelBuilder.Entity<Skill>().HasData(new Skill(8, "Beredsamkeit", "pa", "Sozial", 8, true, 3));
            modelBuilder.Entity<Skill>().HasData(new Skill(9, "Betäuben", "gs", "Kampf", 8, false, 6));
            modelBuilder.Entity<Skill>().HasData(new Skill(10, "Bootfahren", "gs", "Bewegung", 12, true, 3));
            modelBuilder.Entity<Skill>().HasData(new Skill(11, "Erste Hilfe", "gs", "Fingerfertigkeit", 8, true, 0));
            modelBuilder.Entity<Skill>().HasData(new Skill(12, "Etikette", "in", "Sozial", 8, true, 0));
            modelBuilder.Entity<Skill>().HasData(new Skill(13, "Fälschen", "gs", "Fingerfertigkeit", 12, true, 0));
            modelBuilder.Entity<Skill>().HasData(new Skill(14, "Fallen entdecken", "in", "Entdeckung", 8, true, 0));
            modelBuilder.Entity<Skill>()
                        .HasData(new Skill(15, "Fallenmechanik", "gs", "Fingerfertigkeit", 8, false, 0));
            modelBuilder.Entity<Skill>().HasData(new Skill(16, "Fechten", "gs", "Kampf", 5, false, 0));
            modelBuilder.Entity<Skill>().HasData(new Skill(17, "Gassenwissen", "in", "Sozial", 8, true, 0));
            modelBuilder.Entity<Skill>().HasData(new Skill(18, "Gaukeln", "gs", "Fingerfertigkeit", 12, true, 0));
            modelBuilder.Entity<Skill>().HasData(new Skill(19, "Geländelauf", "gw", "Bewegung", 12, true, 6));
            modelBuilder.Entity<Skill>().HasData(new Skill(20, "Gerätekunde", "in", "Wissen", 8, false, 0));
            modelBuilder.Entity<Skill>().HasData(new Skill(21, "Geschäftssinn", "in", "Sozial", 8, false, 0));
            modelBuilder.Entity<Skill>().HasData(new Skill(22, "Glücksspiel", "gs", "Fingerfertigkeit", 12, true, 0));
            modelBuilder.Entity<Skill>().HasData(new Skill(23, "Heilkunde", "in", "Wissen", 8, true, 0));
            modelBuilder.Entity<Skill>().HasData(new Skill(24, "Kampf in Vollrüstung", "st", "Kampf", 5, false, 0));
            modelBuilder.Entity<Skill>().HasData(new Skill(25, "Klettern", "st", "Bewegung", 12, true, 6));
            modelBuilder.Entity<Skill>().HasData(new Skill(26, "Landeskunde", "in", "Wissen", 8, true, 6));
            modelBuilder.Entity<Skill>().HasData(new Skill(27, "Laufen", "ko", "Bewegung", 8, true, 0));
            modelBuilder.Entity<Skill>().HasData(new Skill(28, "Lesen von Zauberschrift", "in", "Wissen", 8, true));
            modelBuilder.Entity<Skill>().HasData(new Skill(29, "Meditieren", "wk", "Körperbeherrschung", 8, true, 0));
            modelBuilder.Entity<Skill>().HasData(new Skill(30, "Menschenkenntnis", "in", "Sozial", 8, true, 3));
            modelBuilder.Entity<Skill>().HasData(new Skill(31, "Meucheln", "gs", "Kampf", 8, false, 0));
            modelBuilder.Entity<Skill>().HasData(new Skill(32, "Musizieren", "gs", "Fingerfertigkeit", 12, true));
            modelBuilder.Entity<Skill>().HasData(new Skill(33, "Naturkunde", "in", "Wissen", 8, true, 0));
            modelBuilder.Entity<Skill>().HasData(new Skill(34, "Pflanzenkunde", "in", "Wissen", 8, true, 0));
            modelBuilder.Entity<Skill>().HasData(new Skill(35, "Reiten", "gw", "Bewegung", 12, true, 6));
            modelBuilder.Entity<Skill>().HasData(new Skill(36, "Reiterkampf", "gw", "Kampf", 12, true, 0));
            modelBuilder.Entity<Skill>()
                        .HasData(new Skill(37, "Geistresistenz", "in", "Körperbeherrschung", 10, false, 10));
            modelBuilder.Entity<Skill>()
                        .HasData(new Skill(38, "Körperresistenz", "ko", "Körperbeherrschung", 10, false, 10));
            modelBuilder.Entity<Skill>().HasData(new Skill(39, "Scharfschießen", "gs", "Kampf", 5, false, 0));
            modelBuilder.Entity<Skill>().HasData(new Skill(40, "Schleichen", "gw", "Bewegung", 8, true, 3));
            modelBuilder.Entity<Skill>()
                        .HasData(new Skill(41, "Schlösser öffnen", "gs", "Fingerfertigkeit", 8, true, 0));
            modelBuilder.Entity<Skill>().HasData(new Skill(42, "Schreiben: Sprache", "in", "Wissen", 8, true));
            modelBuilder.Entity<Skill>().HasData(new Skill(43, "Schwimmen", "gw", "Bewegung", 12, true, 3));
            modelBuilder.Entity<Skill>().HasData(new Skill(44, "Seilkunst", "gs", "Fingerfertigkeit", 12, true, 3));
            modelBuilder.Entity<Skill>().HasData(new Skill(45, "Sprechen: Sprache", "in", "Wissen", 8, true));
            modelBuilder.Entity<Skill>().HasData(new Skill(46, "Spurensuche", "in", "Entdeckung", 8, true, 0));
            modelBuilder.Entity<Skill>().HasData(new Skill(47, "Stehlen", "gs", "Fingerfertigkeit", 8, true, 3));
            modelBuilder.Entity<Skill>().HasData(new Skill(48, "Tarnen", "gw", "Entdeckung", 8, true, 3));
            modelBuilder.Entity<Skill>().HasData(new Skill(49, "Tauchen", "ko", "Bewegung", 8, true, 6));
            modelBuilder.Entity<Skill>().HasData(new Skill(50, "Tierkunde", "in", "Wissen", 8, true, 0));
            modelBuilder.Entity<Skill>().HasData(new Skill(51, "Überleben: Gebirge", "in", "Wissen", 8, true, 6));
            modelBuilder.Entity<Skill>().HasData(new Skill(52, "Überleben: Steppe", "in", "Wissen", 8, true, 6));
            modelBuilder.Entity<Skill>().HasData(new Skill(53, "Überleben: Wald", "in", "Wissen", 8, true, 6));
            modelBuilder.Entity<Skill>().HasData(new Skill(54, "Verführen", "pa", "Sozial", 8, true, 3));
            modelBuilder.Entity<Skill>().HasData(new Skill(55, "Verhören", "pa", "Sozial", 3, true, 3));
            modelBuilder.Entity<Skill>().HasData(new Skill(56, "Verstellen", "pa", "Sozial", 8, true, 3));
            modelBuilder.Entity<Skill>().HasData(new Skill(57, "Wagenlenken", "gs", "Bewegung", 12, true, 3));
            modelBuilder.Entity<Skill>().HasData(new Skill(58, "Zauberkunde", "in", "Wissen", 8, true, 0));
            modelBuilder.Entity<Skill>().HasData(new Skill(59, "Zaubern", "zt", "Zaubern", 3, false, 3));
            // Waffengruppen
            modelBuilder.Entity<Skill>().HasData(new Skill(60, "Einhandschlagwaffen", null, "Nahkampfwaffe", 5, true));
            modelBuilder.Entity<Skill>().HasData(new Skill(61, "Einhandschwerter", null, "Nahkampfwaffe", 5, true));
            modelBuilder.Entity<Skill>().HasData(new Skill(62, "Fechtwaffen", null, "Nahkampfwaffe", 5, true));
            modelBuilder.Entity<Skill>().HasData(new Skill(63, "Kettenwaffen", null, "Nahkampfwaffe", 5, true));
            modelBuilder.Entity<Skill>().HasData(new Skill(64, "Spießwaffen", null, "Nahkampfwaffe", 5, true));
            modelBuilder.Entity<Skill>().HasData(new Skill(65, "Stichwaffen", null, "Nahkampfwaffe", 5, true));
            modelBuilder.Entity<Skill>().HasData(new Skill(66, "Stockwaffen", null, "Nahkampfwaffe", 5, true));
            modelBuilder.Entity<Skill>().HasData(new Skill(67, "Zauberstäbe", null, "Nahkampfwaffe", 5, true));
            modelBuilder.Entity<Skill>().HasData(new Skill(68, "Zweihandschlagwaffen", null, "Nahkampfwaffe", 5, true));
            modelBuilder.Entity<Skill>().HasData(new Skill(69, "Zweihandschwerter", null, "Nahkampfwaffe", 5, true));
            modelBuilder.Entity<Skill>().HasData(new Skill(70, "Waffenloser Kampf", null, "Nahkampfwaffe", 5, true));
            modelBuilder.Entity<Skill>().HasData(new Skill(71, "Schilde", null, "Verteidigungswaffe", 5, true));
            modelBuilder.Entity<Skill>().HasData(new Skill(72, "Parierwaffen", null, "Verteidigungswaffe", 5, true));
            modelBuilder.Entity<Skill>().HasData(new Skill(73, "Stielwurfwaffen", null, "Fernkampfwaffe", 5, true));
            modelBuilder.Entity<Skill>().HasData(new Skill(74, "Wurfklingen", null, "Fernkampfwaffe", 5, true));
            modelBuilder.Entity<Skill>().HasData(new Skill(75, "Wurfscheiben", null, "Fernkampfwaffe", 5, true));
            modelBuilder.Entity<Skill>().HasData(new Skill(76, "Wurfspieße", null, "Fernkampfwaffe", 5, true));
            modelBuilder.Entity<Skill>().HasData(new Skill(77, "Armbrüste", null, "Fernkampfwaffe", 5, true));
            modelBuilder.Entity<Skill>().HasData(new Skill(78, "Blasrohre", null, "Fernkampfwaffe", 5, true));
            modelBuilder.Entity<Skill>().HasData(new Skill(79, "Bögen", null, "Fernkampfwaffe", 5, true));
            modelBuilder.Entity<Skill>().HasData(new Skill(80, "Schleudern", null, "Fernkampfwaffe", 5, true));
        }

        /// <summary>
        /// Initializes SkillHasCategories for the database.
        /// </summary>
        /// <param name="modelBuilder"></param>
        public void SeedSkillHasCategories(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(1, , 1, ));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(2, 2, 2, 3));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(3, 3, 2, 5));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(4, 3, 3, 9));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(5, 2, 4, 4));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(6, 1, 4, 6));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(7, 2, 5, 4));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(8, 3, 5, 5));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(9, 1, 6, 5));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(10, 1, 6, 3));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(11, 4, 7, 4));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(12, 2, 8, 6));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(13, 4, 9, 3));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(14, 3, 9, 4));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(15, 1, 10, 1));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(16, 3, 11, 1));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(17, 2, 11, 9));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(18, 3, 12, 1));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(19, 1, 12, 6));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(20, 1, 13, 3));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(21, 2, 14, 7));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(22, 3, 15, 7));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(23, 4, 16, 4));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(24, 3, 17, 3));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(25, 2, 17, 6));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(26, 1, 17, 7));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(27, 1, 18, 3));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(28, 1, 19, 4));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(29, 1, 19, 5));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(30, 4, 20, 1));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(31, 4, 21, 1));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(32, 1, 22, 1));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(33, 1, 22, 3));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(34, 3, 23, 9));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(35, 4, 24, 4));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(36, 1, 25, 1));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(37, 1, 25, 3));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(38, 1, 25, 5));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(39, 3, 26, 9));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(40, 3, 27, 5));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(41, 1, 28, 9));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(42, 3, 29, 5));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(43, 2, 29, 9));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(44, 3, 30, 6));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(45, 3, 31, 7));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(46, 1, 32, 1));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(47, 2, 33, 2));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(48, 3, 33, 9));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(49, 2, 34, 2));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(50, 3, 34, 9));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(51, 1, 35, 1));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(52, 1, 35, 4));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(53, 1, 36, 4));
            //modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(54, , 37, ));
            //modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(55, , 38, ));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(56, 4, 39, 4));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(57, 3, 40, 2));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(58, 2, 40, 7));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(59, 2, 41, 7));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(60, 2, 42, 1));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(61, 1, 42, 9));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(62, 1, 43, 1));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(63, 1, 43, 5));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(64, 1, 44, 1));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(65, 2, 45, 1));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(66, 1, 45, 9));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(67, 3, 46, 2));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(68, 2, 46, 7));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(69, 3, 47, 3));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(70, 1, 47, 7));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(71, 3, 48, 2));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(72, 2, 48, 7));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(73, 2, 49, 5));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(74, 2, 50, 2));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(75, 3, 50, 9));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(76, 1, 51, 2));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(77, 1, 52, 2));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(78, 1, 53, 2));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(79, 1, 54, 6));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(80, 2, 55, 6));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(81, 1, 56, 6));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(82, 1, 57, 1));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(83, 3, 58, 9));
            //modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(84, , 59, ));
            // Waffengruppen
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(85, 2, 60, 8));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(86, 2, 61, 8));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(87, 3, 62, 8));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(88, 4, 63, 8));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(89, 1, 64, 8));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(90, 1, 65, 8));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(91, 4, 66, 8));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(92, 1, 67, 8));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(93, 3, 68, 8));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(94, 3, 69, 8));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(95, 4, 70, 8));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(96, 1, 71, 8));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(97, 2, 72, 8));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(98, 2, 73, 8));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(99, 2, 74, 8));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(100, 3, 75, 8));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(101, 2, 76, 8));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(102, 3, 77, 8));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(103, 3, 78, 8));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(104, 3, 79, 8));
            modelBuilder.Entity<SkillHasCategory>().HasData(new SkillHasCategory(105, 3, 80, 8));
        }

        /// <summary>
        /// Initializes Spells for the database.
        /// </summary>
        /// <param name="modelBuilder"></param>
        public void SeedSpells(ModelBuilder modelBuilder)
        {
            // Zaubersprüche
            modelBuilder.Entity<Spell>().HasData(new Spell(1, "Angst", "Wort", 10, "Feuer", "Wasser", "2 je Wesen",
                "Augenblick", "30 m", "Geist", "max 10 Wesen", "10 min", "dr", "", 2, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(2, "Anstacheln", "Wort", 10, "Luft", "Wasser", "2", "10 sec",
                "-", "Geist", "1 Wesen", "2 h", "dä", "", 2, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(3, "Anziehen", "Wort", 10, "Wasser", "Wasser", "2", "10 sec",
                "30 m", "Geist", "1 Wesen", "6 h", "dä", "", 2, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(4, "Auffrischen", "Geste", 14, "Magan", "Metall", "1",
                "10 sec", "15 m", "Umgebung", "1 Objekt", "30 min", "dr", "", 1, 1, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(5, "Auflösung", "Geste", 16, "Magan", "Metall", "8",
                "30 sec", "30 m", "Umgebung", "1 m Umkreis", "2 min, k", "dä",
                "Moder, Staub, Knochenmehl, Rostflocken (20 GS)", 12, 90, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(6, "Auskühlen", "Geste", 15, "Eis", "Erde", "2", "10 sec",
                "15 m", "Körper", "1 Wesen", "2 min", "el", "", 4, 3, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(7, "Bannen von Kälte", "Geste", 16, "Feuer", "Eis", "4",
                "10 min", "0 m", "Umgebung", "3 m Umkreis", "8 h", "el", "Holzkohlestück (1 SS)", 5, 5, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(8, "Bannen von Licht", "Wort", 16, "Eis", "Feuer", "1",
                "Augenblick", "0 m", "Umgebung", "9 m Umkreis", "10 min", "gö", "", 2, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(9, "Bannen von Zauberwerk", "Wort", 16, "Metall", "Magan",
                "4", "2 min", "15 m", "Umgebung", "1 Wesen/Objekt", "0", "dä", "", 4, 3, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(10, "Beeinflussen", "Wort", 10, "Feuer", "Luft", "3",
                "10 sec", "15 m", "Geist", "1 Wesen", "10 min", "dä", "", 5, 5, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(11, "Befestigen", "Geste", 11, "Magan", "Metall", "2",
                "1 min", "Berührung", "Umgebung", "1 Objekt", "1 Monat", "dä", "eigener Speichel", 2, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(12, "Besänftigen", "Wort", 10, "Wasser", "Wasser",
                "1 je Grad", "10 sec", "30 m", "Geist", "1 Wesen", "0", "dä", "", 3, 2, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(13, "Beschleunigen", "Geste", 15, "Magan", "Erde", "6",
                "10 sec", "15 m", "Körper", "1 Wesen", "1 min", "dä", "", 6, 10, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(14, "Binden des Vertrauten", "Gedanke", 10, "Wasser",
                "Wasser", "3", "Augenblick", "Berührung", "Geist", "1 km Umkreis", "2 h", "dä", "", 6, 10, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(15, "Blaue Bannsphäre", "Geste", 10, "Luft", "Eis", "2",
                "20 sec", "0 m", "Geist", "3 m Umkreis", "2 min", "gö", "", 3, 2, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(16, "Blauer Zwingkreis", "Geste", 10, "Luft", "Eis", "4",
                "20 sec", "30 m", "Geist", "6 m Umkreis", "10 min", "gö", "Eichenholzreif (20 GS)", 7, 15, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(17, "Blenden", "Geste", 13, "Feuer", "Feuer", "4",
                "Augenblick", "9 m Umkreis", "Umgebung", "-", "1 min", "gö", "", 8, 20, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(18, "Blendwerk", "Geste", 10, "Magan", "Feuer", "4",
                "10 sec", "50 m", "Geist", "1 Wesen/Objekt", "1W6x10 min", "dä", "Goldstaub (50 GS)", 8, 20, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(19, "Blitze schleudern", "Geste", 13, "Luft", "Feuer",
                "2 je Blitz", "10 sec", "200 m", "Umgebung", "1-10 Strahlen", "0", "dä",
                "getrocknetes Zitteraalherz (5 GS)", 6, 10, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(20, "Böser Blick", "Gedanke", 16, "Eis", "Holz", "2",
                "10 sec", "15 m", "Körper", "1 Wesen", "?", "sm", "", 4, 3, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(21, "Brot und Wasser", "Gedanke", 13, "Holz", "Wasser", "3",
                "10 min", "0 m", "Umgebung", "-", "0", "dä", "Mehlstaub und Wassertropfen (1 GS)", 1, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(22, "Dämonenfeuer", "Geste", 13, "Magan", "Magan", "3",
                "10 sec", "30 m", "Umgebung", "Strahl", "2 min, k", "dä", "Phosphor (50 GS)", 5, 5, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(23, "Dämonenkugeln", "Geste", 13, "Magan", "Magan", "4",
                "10 sec", "50 m", "Umgebung", "Strahl", "2 min, k", "dä", "Phosphor (50 GS)", 6, 10, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(24, "Dämonenschwert", "Geste", 13, "Magan", "Magan", "4",
                "10 sec", "0 m", "Umgebung", "-", "2 min", "dä", "Phosphor (50 GS)", 6, 10, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(25, "Dämonische Zaubermacht", "Wort", 15, "Magan", "Wasser",
                "1", "10 min", "-", "Körper", "Zauberer", "10 min", "dä", "", 3, 2, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(26, "Deckmantel", "Geste", 16, "Magan", "Magan", "6",
                "10 sec", "0 m", "Umgebung", "6 m Umkreis", "8 h, k", "dä", "Goldreif (50 GS)", 7, 15, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(27, "Dinge verbergen", "Gedanke", 16, "Magan", "Magan", "1",
                "10 min", "Berührung", "Geist", "1 Objekt", "12 h", "dä", "", 1, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(28, "Dinge wiederfinden", "Gedanke", 12, "Magan", "Metall",
                "1", "10 min", "unbegrenzt", "Geist", "1 Objekt", "10 min", "dä", "", 1, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(29, "Donnerkeil", "Geste", 13, "Luft", "Feuer", "4",
                "10 sec", "50 m", "Umgebung", "Strahl", "0", "dä", "Murmeln aus Donnerechsenhorn (50 GS)", 8, 20, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(30, "Drittes Auge", "Geste", 12, "Magan", "Feuer", "1",
                "10 sec", "0 m", "Umgebung", "100 m Umkreis", "10 min", "el", "Kristallauge (10 GS)", 1, 1, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(31, "Dschungelwand", "Geste", 13, "Holz", "Holz",
                "1 je m Breite", "10 sec", "15 m", "Umgebung", "-", "10 min", "el", "Smaragd (50 GS)", 4, 3, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(32, "Eisenhaut", "Geste", 15, "Metall", "Erde", "4",
                "20 sec", "Berührung", "Körper", "1 Wesen", "2 min", "dä", "Eisenpulver (20 GS)", 7, 15, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(33, "Eisiger Nebel", "Geste", 13, "Eis", "Eis", "1 je m²",
                "10 sec", "50 m", "Umgebung", "3 m Umkreis", "1 min", "el", "Bergkristall (20 GS)", 3, 2, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(34, "Eiswand", "Geste", 13, "Eis", "Eis", "1 je m Breite",
                "10 sec", "15 m", "Umgebung", "-", "10 min", "el", "Diamant (50 GS)", 4, 3, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(35, "Eiswandlung", "Geste", 14, "Wasser", "Eis", "3",
                "10 sec", "200 m", "Umgebung", "bis zu 10 m²", "var", "el", "reinstes Wasser (50 GS)", 5, 5, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(36, "Elementenwandlung", "Geste", 14, "Ausgangselement",
                "Zielelement", "6", "var", "5 m", "Umgebung", "bis zu 1 m²", "?", "el", "Edelstein (100 GS)", 5, 5,
                20));
            modelBuilder.Entity<Spell>().HasData(new Spell(37, "Entgiften", "Wort", 16, "Magan", "Eis", "2", "30 sec",
                "3 m", "Umgebung", "1 Objekt", "0", "dr", "", 4, 3, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(38, "Erdbeben", "Geste", 11, "Erde", "Erde", "6", "1 min",
                "0 m", "Umgebung", "1 km Umkreis", "10 min", "el", "", 9, 30, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(39, "Erdfessel", "Geste", 11, "Erde", "Erde", "3",
                "Augenblick", "50 m", "Umgebung", "1 m Umkreis", "2 min", "el", "Honig-Erd-Gemisch (5 GS)", 5, 5, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(40, "Erdwandlung", "Geste", 14, "Erde", "Erde", "6",
                "20 sec", "Berührung", "Umgebung", "1 m²", "?", "el", "Bernstein (100 GS)", 9, 30, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(41, "Erkennen von Leben", "Gedanke", 12, "Magan", "Wasser",
                "1", "Augenblick", "0 m", "Geist", "15 m Kegel", "1 min", "dä", "", 1, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(42, "Erkennen von Zauberei", "Gedanke", 12, "Magan", "Magan",
                "2", "Augenblick", "15 m", "Geist", "1 m²", "0", "dä", "", 4, 3, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(43, "Erscheinungen", "Geste", 10, "Magan", "Feuer", "6",
                "20 sec", "30 m", "Geist", "3 m Umkreis", "2 min, k", "dä", "Blütenstaub vom blauen Mohn (100 GS)", 10,
                40, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(44, "Erwecken", "Geste", 15, "Eis", "Erde", "3", "10 sec",
                "30 m", "Körper", "1 Wesen", "2 min", "sm", "", 5, 5, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(45, "Felsenfaust", "Geste", 15, "Erde", "Erde", "1",
                "10 sec", "Berührung", "Körper", "1 Wesen", "2 min", "el", "Kieselstein (1 SS)", 2, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(46, "Fesselbann", "Geste", 13, "Luft", "Magan", "2 je Grad",
                "10 sec", "30 m", "Körper", "1 Wesen", "10 min, k", "gö", "Fadenstück einer Riesenspinne (50 GS)", 6,
                10, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(47, "Feuerfinger", "Geste", 13, "Feuer", "Feuer", "1",
                "Augenblick", "0 m", "Umgebung", "Zauberer", "2 min, k", "el", "", 1, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(48, "Feuerkugel", "Geste", 13, "Feuer", "Feuer", "2",
                "10 sec", "50 m", "Umgebung", "3 m Umkreis", "2 min, k", "el", "Blutstein (30 GS)", 3, 2, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(49, "Feuerlanze", "Geste", 13, "Feuer", "Feuer", "3",
                "10 sec", "50 m", "Umgebung", "Strahl", "0", "el", "Korallenstück (20 GS)", 6, 10, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(50, "Feuerlauf", "Gedanke", 15, "Erde", "Erde", "3",
                "10 sec", "-", "Körper", "1 Wesen", "10 min", "el", "", 5, 5, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(51, "Feuermeisterschaft", "Geste", 14, "Feuer", "Feuer", "6",
                "20 sec", "30 m", "Umgebung", "2 m Umkreis", "2 min", "el", "Stück einer Drachenzunge (100 GS)", 9, 30,
                20));
            modelBuilder.Entity<Spell>().HasData(new Spell(52, "Feuerregen", "Geste", 13, "Feuer", "Feuer", "18",
                "30 sec", "100 m", "Umgebung", "30 m Umkreis", "1 min, k", "el",
                "Basaltstaub und Rubinsplitter (100 GS)", 12, 90, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(53, "Feuerring", "Geste", 13, "Feuer", "Feuer", "4",
                "20 sec", "0 m", "Umgebung", "6 m Umkreis", "30 min", "el", "Zwergdrachenflügel und Zauberöl (100 GS)",
                8, 20, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(54, "Feuerschild", "Geste", 13, "Eis", "Eis", "3", "10 sec",
                "15 m", "Umgebung", "-", "2 min", "el", "Diamantstaub (20 GS)", 6, 10, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(55, "Feuerwand", "Geste", 13, "Feuer", "Feuer",
                "1 je m Breite", "10 sec", "15 m", "Umgebung", "-", "10 min", "el", "Rubin (50 GS)", 4, 3, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(56, "Flammende Hand", "Geste", 13, "Feuer", "Feuer", "2",
                "10 sec", "0 m", "Umgebung", "Zauberer", "2 min", "el", "", 3, 2, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(57, "Flammenklinge", "Geste", 14, "Feuer", "Metall", "4",
                "1 min", "Berührung", "Umgebung", "1 Objekt", "10 min", "el", "Klinge aus Alchimistenmetall", 6, 10,
                20));
            modelBuilder.Entity<Spell>().HasData(new Spell(58, "Flammenkreis", "Geste", 13, "Holz", "Holz", "1",
                "Augenblick", "Berührung", "Umgebung", "1 Wesen", "2 min", "dr", "Zunder (1 SS)", 2, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(59, "Flammenteppich", "Geste", 13, "Feuer", "Feuer",
                "1 je m²", "10 sec", "50 m", "Umgebung", "bis zu 10 m²", "1 min", "el", "Feuertopas (20 GS)", 5, 5,
                20));
            modelBuilder.Entity<Spell>().HasData(new Spell(60, "Flicken", "Geste", 14, "Magan", "Metall", "1", "10 sec",
                "Berührung", "Umgebung", "1 Objekt", "10 min", "dr", "", 1, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(61, "Fliegen", "Geste", 11, "Luft", "Erde", "9", "30 sec",
                "-", "Körper", "Zauberer", "1 h, k", "dä", "Greifenschwungfeder (100 GS)", 11, 60, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(62, "Freundesauge", "Gedanke", 10, "Wasser", "Feuer", "4",
                "10 sec", "500 m", "Geist", "1 Wesen", "30 min, k", "dä", "", 7, 15, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(63, "Frostball", "Geste", 13, "Eis", "Eis", "1", "10 sec",
                "200 m", "Umgebung", "Strahl", "0", "el", "Silberperle oder Bergkristall (10 GS)", 2, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(64, "Funkenregen", "Geste", 10, "Feuer", "Feuer",
                "2 je Grad", "10 sec", "30 m", "Geist", "1 Wesen", "1 min", "dä", "Sternenstaub (20 GS)", 7, 15, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(65, "Geisterhorn", "Geste", 12, "Magan", "Eis", "1",
                "10 sec", "0 m", "Umgebung", "100 m Umkreis", "10 min", "dä", "Kristallpyramide (10 GS)", 1, 1, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(66, "Geistersperre", "Geste", 13, "Metall", "Metall",
                "1 je 5 m² Fläche", "10 sec", "Berührung", "Umgebung", "bis zu 100 m²", "8 h", "dä",
                "Eisenspäne (10 GS)", 6, 10, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(67, "Geistesschild", "Gedanke", 16, "Feuer", "Magan", "var",
                "Augenblick", "-", "Geist", "Zauberer", "10 min", "dä", "", 6, 10, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(68, "Geräusche dämpfen", "Geste", 14, "Metall", "Luft", "1",
                "Augenblick", "0 m", "Umgebung", "3 m Umkreis", "5 min", "dä", "", 2, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(69, "Goldener Panzer", "Geste", 14, "Metall", "Metall", "2",
                "10 sec", "Berührung", "Umgebung", "1 Wesen", "2 min", "dä", "Goldstaub (50 GS)", 4, 3, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(70, "Goldene Sphäre", "Geste", 16, "Metall", "Magan", "2",
                "20 sec", "0 m", "Umgebung", "3 m Umkreis", "2 min", "gö", "", 4, 3, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(71, "Graue Hand", "Geste", 16, "Eis", "Erde", "7", "10 sec",
                "Berührung", "Körper", "1 Wesen", "0", "sm", "", 10, 40, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(72, "Hagel", "Geste", 13, "Eis", "Eis", "12", "30 sec",
                "100 m", "Umgebung", "30 m Umkreis", "2 min, k", "el", "Wasser und Diamantsplitter (50 GS)", 12, 90,
                20));
            modelBuilder.Entity<Spell>().HasData(new Spell(73, "Hauch der Betäubung", "Geste", 13, "Eis", "Holz", "3",
                "Augenblick", "0 m", "Umgebung", "bis zu 18 m Umkreis", "1 min", "dä",
                "getrocknetes Vampirmoos (10 GS)", 5, 5, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(74, "Hauch der Verwesung", "Geste", 13, "Eis", "Erde", "2",
                "Augenblick", "0 m", "Umgebung", "bis zu 18 m Umkreis", "1 min", "dä", "Stinkmorschelasche (2 GS)", 4,
                3, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(75, "Hauch des Winters", "Geste", 14, "Eis", "Luft", "1",
                "Augenblick", "0 m", "Umgebung", "12 m Umkreis", "10 min", "el", "Schneewolfhaare (20 GS)", 1, 1, 20,
                true));
            modelBuilder.Entity<Spell>().HasData(new Spell(76, "Heimfeder", "Geste", 12, "Wasser", "Luft", "2", "1 min",
                "3 m", "Umgebung", "1 Objekt", "30 min", "dr", "Taubenschwungfeder (5 SS) und Wasser", 3, 2, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(77, "Heranholen", "Geste", 11, "Luft", "Metall", "1",
                "10 sec", "30 m", "Umgebung", "1 Objekt", "10 sec", "dä", "", 1, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(78, "Hexenstreich", "Geste", 15, "Magan", "Erde", "2",
                "10 sec", "15 m", "Körper", "1 Wesen", "?", "dä", "", 5, 5, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(79, "Himmelsleiter", "Geste", 13, "Metall", "Feuer", "6",
                "1 min", "50 m", "Umgebung", "-", "10 min", "gö", "", 9, 30, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(80, "Hitzeschutz", "Gedanke", 15, "Wasser", "Erde", "1",
                "Augenblick", "-", "Körper", "Zauberer", "2 min", "dä", "", 2, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(81, "Höhenblick", "Geste", 11, "Luft", "Feuer", "2",
                "10 sec", "50 m", "Umgebung", "-", "1 min, k", "dä", "Auge eines Greifvogels (50 GS)", 3, 2, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(82, "Hören der Geister", "Gedanke", 12, "Eis", "Luft",
                "1 je 10 sec Dauer", "10 sec", "0 m", "Körper", "6 m Umkreis", "10 sec je Grad", "dä", "", 5, 5, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(83, "Hören von Fernem", "Gedanke", 15, "Magan", "Wasser",
                "1", "1 min", "Berührung", "Körper", "1 Wesen", "10 min", "dä", "", 1, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(84, "Hörnerklang", "Wort", 14, "Magan", "Luft", "1",
                "Augenblick", "0 m", "Umgebung", "2 km Umkreis", "10 sec", "dä", "", 2, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(85, "Juwelenauge", "Geste", 11, "Erde", "Feuer", "2",
                "10 sec", "500 m", "Umgebung", "1 Objekt", "30 min", "dä", "2 Greifenaugenhälften", 5, 5, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(86, "Kälteschutz", "Gedanke", 15, "Feuer", "Erde", "1",
                "Augenblick", "-", "Körper", "Zauberer", "2 min", "dä", "", 2, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(87, "Kraft entziehen", "Geste", 16, "Eis", "Feuer", "1",
                "Augenblick", "Berührung", "Körper", "1 Wesen", "0", "sm", "", 2, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(88, "Kraftraub", "Geste", 16, "Magan", "Feuer", "2",
                "10 sec", "30 m", "Umgebung", "1 m²", "2 min, k", "dä", "", 3, 2, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(89, "Lähmung", "Geste", 15, "Metall", "Erde", "8", "20 sec",
                "30 m", "Körper", "1 Wesen", "24 h", "dä", "Basiliskenschuppe (100 GS)", 10, 40, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(90, "Lauschen", "Gedanke", 14, "Magan", "Metall", "1",
                "1 min", "30 cm", "Umgebung", "-", "10 min, k", "dä", "", 1, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(91, "Lichtbrücke", "Geste", 13, "Metall", "Feuer", "4",
                "1 min", "50 m", "Umgebung", "-", "10 min", "gö", "", 8, 20, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(92, "Lichtrunen", "Geste", 14, "Feuer", "Metall", "1",
                "10 min", "Berührung", "Umgebung", "1 m²", "?", "dä", "Nachtmarderhaarpinsel (50 GS)", 2, 1, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(93, "Liebeszauber", "Geste", 10, "Wasser", "Wasser", "4",
                "1 h", "-", "Geist", "1 Wesen", "?", "dä", "Liebestrank oder Locke", 8, 20, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(94, "Liniensicht", "Gedanke", 12, "Magan", "Holz", "1",
                "Augenblick", "bis zu 5 km", "Geist", "Zauberer", "10 sec", "dr", "", 1, 1, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(95, "Luftlauf", "Gedanke", 11, "Luft", "Erde", "4", "20 sec",
                "-", "Körper", "Zauberer", "2 min, k", "el", "", 7, 15, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(96, "Luftsphäre", "Geste", 13, "Luft", "Luft", "4", "20 sec",
                "0 m", "Umgebung", "3 m Umkreis", "1 h", "el", "Perle (100 GS)", 8, 20, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(97, "Macht über das Selbst", "Gedanke", 10, "Metall",
                "Feuer", "1", "10 sec", "-", "Körper", "Zauberer", "24 h, k", "dä", "", 1, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(98, "Macht über die belebte Natur", "Wort", 10, "Magan",
                "Wasser", "2 je Grad", "10 sec", "30 m", "Geist", "1 Wesen je Grad", "mind. 2 h", "dä", "", 4, 3, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(99, "Macht über die Sinne", "Geste", 10, "Magan", "Feuer",
                "1 je Variation", "10 sec", "50 m", "Geist", "Zauberer", "2-10 min", "dä", "", 2, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(100, "Macht über Leben", "Geste", 16, "Eis", "Erde",
                "mind. 8", "10 sec", "6 m", "Körper", "1 Wesen", "2 min", "dä", "", 9, 30, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(101, "Macht über magische Wesen", "Wort", 10, "Magan",
                "Magan", "3 je Grad", "20 sec", "30 m", "Geist", "1 Wesen je Grad", "var", "dä", "", 7, 15, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(102, "Macht über Menschen", "Wort", 10, "Magan", "Luft",
                "3 je Grad", "20 sec", "30 m", "Geist", "1 Wesen je Grad", "var", "dä", "", 6, 10, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(103, "Macht über Unbelebtes", "Geste", 11, "Feuer", "Metall",
                "2", "Augenblick", "30 m", "Umgebung", "-", "10 sec", "dä", "", 3, 2, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(104, "Mag. Kreis des Bewachens", "Geste", 12, "Magan",
                "Magan", "6", "30 min", "0 m", "Umgebung", "10 m Umkreis", "?", "dä", "Wächterwürfel", 6, 10, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(105, "Mag. Kreis des Verschleierns", "Geste", 16, "Magan",
                "Magan", "6", "30 min", "0 m", "Umgebung", "10 m Umkreis", "?", "dä", "Wächterwürfel", 6, 10, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(106, "Mag. Kreis des Widerstehens", "Geste", 14, "Magan",
                "Wasser", "6", "30 min", "0 m", "Umgebung", "10 m Umkreis", "?", "dä", "Wächterwürfel", 6, 10, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(107, "Magischer Kreis, klein", "Geste", 12, "Magan", "Magan",
                "6", "10 min", "0 m", "Umgebung", "6 m Umkreis", "8 h", "dr",
                "mit Eisendraht umwickelte Zweige von Eiche, Esche und Weißdorn (10 GS)", 6, 10, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(108, "Marmorhaut", "Geste", 15, "Erde", "Erde", "3",
                "10 sec", "Berührung", "Körper", "1 Wesen", "10 min", "el", "Marmorstaub (1 GS)", 5, 5, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(109, "Mitfühlen", "Gedanke", 12, "Wasser", "Wasser", "1",
                "Augenblick", "500 m", "Geist", "1 Wesen", "30 min, k", "dä", "", 2, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(110, "Namenloses Grauen", "Geste", 10, "Eis", "Wasser",
                "4 je Wesen", "20 sec", "30 m", "Geist", "1-3 Wesen", "2 min", "dä",
                "Schweiß von Albträumenden (20 GS)", 8, 20, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(111, "Nebel schaffen", "Geste", 13, "Wasser", "Wasser", "4",
                "20 sec", "0 m", "Umgebung", "50 m Umkreis", "30 min", "el",
                "versiegeltes Fläschchen voll Nebel (10 GS)", 7, 15, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(112, "Nebel wecken", "Geste", 14, "Wasser", "Luft", "2",
                "10 sec", "0 m", "Umgebung", "500 m Umkreis", "-", "el", "Staub (1 GS)", 3, 2, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(113, "Person wiederfinden", "Gedanke", 12, "Magan", "Luft",
                "2", "10 min", "unbegrenzt", "Geist", "1 Wesen", "10 min", "dä", "", 3, 2, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(114, "Pestklaue", "Geste", 16, "Eis", "Erde", "5",
                "Augenblick", "Berührung", "Körper", "1 Wesen", "0", "sm", "Pestkrötenklaue (50 GS)", 10, 40, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(115, "Pflanzenfessel", "Geste", 11, "Feuer", "Holz", "4",
                "20 sec", "50 m", "Umgebung", "10 m Umkreis", "2 min", "dr", "Samenmischung (10 GS)", 6, 10, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(116, "Rauchwolke", "Geste", 14, "Feuer", "Luft", "2",
                "10 sec", "30 m", "Umgebung", "9 m Umkreis", "10 min", "el", "Asche und Zunder (1 GS)", 4, 3, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(117, "Reaktionsschnelle", "Geste", 15, "Magan", "Feuer", "1",
                "30 sec", "30 m", "Geist", "1 Wesen", "10 min", "dä", "", 2, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(118, "Reise der Seele", "Gedanke", 11, "Luft", "Feuer", "6",
                "30 min", "-", "Geist", "Zauberer", "var", "dr", "", 8, 20, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(119, "Rost", "Geste", 14, "Eis", "Metall", "2", "Augenblick",
                "Berührung", "Umgebung", "1 Objekt", "0", "dä", "", 1, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(120, "Schallwächter", "Geste", 12, "Magan", "Luft", "2",
                "10 sec", "15 m", "Geist", "Zauberer", "10 min", "el", "Golddrahtreif (10 GS)", 3, 2, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(121, "Scharfblick", "Gedanke", 15, "Magan", "Feuer", "1",
                "1 min", "Berührung", "Körper", "1 Wesen", "10 min", "dä", "", 1, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(122, "Schattenrobe", "Wort", 14, "Magan", "Feuer", "2",
                "10 sec", "-", "Umgebung", "Zauberer", "10 min", "dä", "", 3, 2, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(123, "Schattenschrecken", "Geste", 11, "Eis", "Feuer", "4",
                "20 sec", "0 m", "Umgebung", "100 m Umkreis", "30 min", "dä", "", 7, 15, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(124, "Schatten verstärken", "Geste", 14, "Eis", "Feuer", "1",
                "Augenblick", "0 m", "Umgebung", "15 m Umkreis", "10 min", "dä", "", 1, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(125, "Schlaf", "Geste", 10, "Magan", "Wasser", "4 je Wesen",
                "10 sec", "30 m", "Körper", "bis zu 6 Wesen", "8 h", "dä", "Lotusblütenstaub (10 GS)", 5, 5, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(126, "Schlangenbiss", "Wort", 15, "Eis", "Holz", "4",
                "10 sec", "Berührung", "Körper", "1 Wesen", "2 min", "dä", "Schlangengift (20 GS)", 7, 15, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(127, "Schlummer", "Geste", 10, "Magan", "Wasser",
                "2 je Wesen", "10 sec", "30 m", "Körper", "bis zu 6 Wesen", "30 min", "dä", "Baldrianwurzel (5 GS)", 1,
                1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(128, "Schmerzen", "Geste", 16, "Magan", "Feuer", "2",
                "10 sec", "30 m", "Körper", "1 Wesen", "1 min", "dä", "Silber- oder Knochennadel (5 GS)", 4, 3, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(129, "Schrumpfen", "Geste", 15, "Holz", "Erde", "6",
                "20 sec", "Berührung", "Körper", "1 Wesen", "10 min", "dä", "", 6, 10, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(130, "Schutzgeste", "Geste", 15, "Metall", "Erde", "2",
                "Augenblick", "-", "Körper", "Zauberer", "0", "gö", "", 5, 5, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(131, "Schwäche", "Geste", 15, "Magan", "Erde", "1 je Wesen",
                "Augenblick", "30 m", "Körper", "1-10 Wesen", "2 min", "dä", "Eschenrinde (1 GS)", 1, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(132, "Schwarze Sphäre", "Gedanke", 16, "Magan", "Wasser",
                "var", "20 sec", "0 m", "Umgebung", "5 m Umkreis", "10 min", "dä", "", 7, 15, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(133, "Schwarze Zone", "Gedanke", 16, "Magan", "Magan", "var",
                "Augenblick", "0 m", "Umgebung", "5 m Umkreis", "10 min", "dä", "", 8, 20, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(134, "Schweben", "Geste", 11, "Luft", "Erde", "6", "20 sec",
                "-", "Körper", "Zauberer", "1 min", "dä", "Kolibriflügel (100 GS)", 9, 30, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(135, "Schwerelosigkeit", "Geste", 11, "Luft", "Metall", "4",
                "1 min", "Berührung", "Umgebung", "1 Objekt", "0", "el", "", 5, 5, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(136, "Seelenkompass", "Geste", 12, "Feuer", "Luft", "2",
                "1 min", "6 km", "Geist", "1 Wesen", "10 min", "dä", "Silbernadel (10 GS) und Haar der Zielperson", 3,
                2, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(137, "Sehen in Dunkelheit", "Gedanke", 15, "Feuer", "Feuer",
                "2", "1 min", "50 m", "Körper", "Zauberer", "30 min", "dä", "", 3, 2, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(138, "Sehen von Verborgenem", "Gedanke", 14, "Magan",
                "Metall", "1", "1 min", "30 cm", "Umgebung", "-", "10 min, k", "dä", "", 3, 2, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(139, "Silberne Bannsphäre", "Geste", 10, "Luft", "Feuer",
                "2", "20 sec", "0 m", "Geist", "3 m Umkreis", "2 min", "gö", "", 4, 3, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(140, "Silberner Zwingkreis", "Geste", 10, "Luft", "Feuer",
                "4", "20 sec", "30 m", "Geist", "6 m Umkreis", "10 min", "gö", "Silberreif (50 GS)", 8, 20, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(141, "Silberstaub", "Geste", 13, "Magan", "Metall", "1",
                "Augenblick", "Berührung", "Umgebung", "1 Wesen", "2 min", "dä", "Silberstaub (2 GS)", 2, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(142, "Spruch intensivieren", "Gedanke", 15, "Magan", "Magan",
                "6", "10 sec", "-", "Geist", "Zauberer", "30 sec", "dä", "", 9, 30, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(143, "Stärke", "Geste", 15, "Magan", "Erde", "1 je Wesen",
                "Augenblick", "30 m", "Körper", "1-10 Wesen", "2 min", "dä", "getrockneter Fliegenpilz (1 GS)", 2, 1,
                20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(144, "Steinkugel", "Geste", 13, "Erde", "Erde", "3",
                "10 sec", "50 m", "Umgebung", "3 m Umkreis", "2 min, k", "el", "Diamant (50 GS)", 4, 3, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(145, "Steinwand", "Geste", 13, "Erde", "Erde", "1 je m",
                "10 sec", "15 m", "Umgebung", "-", "10 min", "el", "Bernstein (50 GS)", 4, 3, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(146, "Stille", "Geste", 14, "Metall", "Luft", "2",
                "Augenblick", "0 m", "Umgebung", "3 m Umkreis", "1 min", "dä", "pulverisierte Eulenfedern (2 GS)", 3, 2,
                20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(147, "Stimmenwerfen", "Gedanke", 11, "Magan", "Luft", "1",
                "Augenblick", "15 m", "Umgebung", "-", "2 min", "dä", "", 2, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(148, "Sturmhand", "Geste", 11, "Luft", "Erde", "4", "10 sec",
                "Berührung", "Körper", "1 Wesen", "0", "el", "", 8, 20, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(149, "Sturmwind", "Geste", 11, "Luft", "Luft", "6", "20 sec",
                "0 m", "Umgebung", "30 m Kegel", "2 min, k", "el", "", 10, 40, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(150, "Sumpfboden", "Geste", 14, "Wasser", "Erde", "1",
                "10 sec", "50 m", "Umgebung", "15 m Umkreis", "2 min", "el", "Wasserlinsen (1 GS)", 3, 2, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(151, "Thursenstein", "Geste", 14, "Erde", "Erde", "6",
                "10 sec", "Berührung", "Umgebung", "1 Objekt", "10 sec", "dr", "Zauberkiesel", 9, 30, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(152, "Tierisches Handeln", "Geste", 10, "Wasser", "Luft",
                "6 je Wesen", "20 sec", "30 m", "Geist", "1-3 Wesen", "var", "dä", "Tierblutmischung (50 GS)", 9, 30,
                20));
            modelBuilder.Entity<Spell>().HasData(new Spell(153, "Tiersprache", "Wort", 12, "Wasser", "Luft", "4",
                "20 sec", "15 m", "Körper", "Zauberer", "2 min", "dr", "", 7, 15, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(154, "Todeshauch", "Geste", 13, "Eis", "Wasser", "3",
                "Augenblick", "0 m", "Umgebung", "bis zu 18 m Umkreis", "1 min", "dä", "Fliegenpilzasche (1 GS)", 5, 5,
                20));
            modelBuilder.Entity<Spell>().HasData(new Spell(155, "Todeskeule", "Geste", 14, "Eis", "Erde", "3", "10 sec",
                "Berührung", "Umgebung", "1 Objekt", "2 min", "dä", "Oberschenkelknochen", 6, 10, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(156, "Todeszauber", "Wort", 16, "Eis", "Holz",
                "1 je Schadenspunkt", "20 sec", "30 m", "Körper", "1 Wesen", "0", "dä", "", 11, 60, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(157, "Torwandeln", "Geste", 14, "Magan", "Holz", "4",
                "10 min", "Berührung", "Umgebung", "30 cm", "1 min", "el", "", 8, 20, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(158, "Umkehrschild", "Geste", 13, "Metall", "Magan",
                "6 je Seite", "30 sec", "-", "Umgebung", "Zauberer", "2 min", "dä",
                "versilberte Drachenschuppe (100 GS)", 9, 30, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(159, "Ungezieferplage", "Wort", 10, "Magan", "Wasser", "2",
                "30 sec", "0 m", "Geist", "1 Schwarm", "2 min", "dä", "", 4, 3, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(160, "Unsichtbarkeit", "Wort", 15, "Luft", "Metall", "4",
                "10 sec", "-", "Körper", "Zauberer", "10 min, k", "dä", "", 4, 3, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(161, "Verdorren", "Geste", 15, "Eis", "Erde", "5", "10 sec",
                "Berührung", "Körper", "1 Wesen", "?", "sm", "", 6, 10, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(162, "Vereisen", "Geste", 15, "Eis", "Erde", "7", "10 sec",
                "Berührung", "Körper", "1 Wesen", "?", "dä", "", 9, 30, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(163, "Vergiften", "Wort", 16, "Eis", "Erde", "2", "30 sec",
                "3 m", "Körper", "1 Wesen", "0", "sm", "", 4, 3, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(164, "Vergrößern", "Geste", 14, "Magan", "Metall", "6",
                "20 sec", "Berührung", "Umgebung", "1 Objekt", "10 min", "dä", "", 5, 5, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(165, "Verkleinern", "Geste", 14, "Magan", "Metall", "6",
                "20 sec", "Berührung", "Umgebung", "1 Objekt", "10 min", "dä", "", 5, 5, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(166, "Verlangsamen", "Geste", 15, "Metall", "Erde", "2",
                "10 sec", "15 m", "Körper", "1 Wesen", "1 min", "dä", "Blei (20 GS)", 4, 3, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(167, "Vermehren", "Geste", 14, "Magan", "Metall", "2",
                "10 sec", "15 m", "Umgebung", "1 Objekt", "30 min", "dr", "", 1, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(168, "Verschmutzen", "Geste", 14, "Magan", "Metall", "2",
                "10 sec", "15 m", "Umgebung", "1 Objekt", "0", "dr", "", 2, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(169, "Versetzen", "Geste", 11, "Magan", "Metall",
                "2 je Wesen", "20 sec", "500 m", "Umgebung", "1-6 Wesen", "24 h", "dä", "Phosphorkreide (200 GS)", 8,
                20, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(170, "Versteinern", "Geste", 15, "Erde", "Erde", "8",
                "10 sec", "Berührung", "Körper", "1 Wesen", "?", "sm", "", 10, 40, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(171, "Vertieren", "Geste", 10, "Wasser", "Luft", "3",
                "10 sec", "30 m", "Geist", "1 Wesen", "10 min", "dä", "Tierspeichelmischung (20 GS)", 5, 5, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(172, "Verursachen von Krankheit", "Geste", 15, "Eis", "Erde",
                "2", "Augenblick", "Berührung", "Körper", "1 Wesen", "3W6 Tage", "dä", "", 4, 3, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(173, "Verursachen schw. Wunden", "Geste", 16, "Eis", "Erde",
                "3", "Augenblick", "Berührung", "Körper", "1 Wesen", "0", "sm", "", 5, 5, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(174, "Verursachen von Wunden", "Geste", 16, "Eis", "Erde",
                "1", "Augenblick", "Berührung", "Körper", "1 Wesen", "0", "sm", "", 3, 2, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(175, "Verwandlung", "Geste", 15, "Holz", "Erde", "mind. 9",
                "30 sec", "Berührung", "Körper", "1 Wesen", "?", "dä", "Kern des Großen Kürbis (100 GS)", 11, 60, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(176, "Verwirren", "Geste", 10, "Magan", "Feuer", "1 je Grad",
                "Augenblick", "30 m", "Geist", "1 Wesen", "10 sec", "dä", "", 2, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(177, "Verwünschen", "Wort", 15, "Luft", "Wasser",
                "2 je Wesen", "10 sec", "15 m", "Körper", "bis zu 6 Wesen", "30 min", "dä", "", 4, 3, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(178, "Verzweiflung", "Geste", 15, "Magan", "Luft", "5",
                "10 sec", "Berührung", "Geist", "1 Wesen", "1 h", "dä", "in Alkohol gelöste Kräutermischung (50 GS)", 8,
                20, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(179, "Wachsen", "Geste", 15, "Holz", "Erde", "6", "20 sec",
                "Berührung", "Körper", "1 Wesen", "10 min", "dä", "", 6, 10, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(180, "Wahnsinn", "Geste", 16, "Magan", "Luft", "7", "20 sec",
                "15 m", "Geist", "1 Wesen", "?", "dä", "Birkenrinde und Blüten des Wahnsinnkrautes (50 GS)", 9, 30,
                20));
            modelBuilder.Entity<Spell>().HasData(new Spell(181, "Wahrsehen", "Geste", 12, "Magan", "Magan", "6",
                "20 sec", "15 m", "Geist", "3 m Umkreis", "10 min", "gö", "vierblättriger Klee (10 GS)", 9, 30, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(182, "Wandwandeln", "Geste", 14, "Magan", "Erde", "6",
                "10 min", "Berührung", "Umgebung", "-", "1 min", "el", "", 9, 30, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(183, "Warnung", "Geste", 12, "Luft", "Eis", "2", "10 sec",
                "0 m", "Geist", "15 m Umkreis", "10 min", "dä", "Einhornhaar und Espenholz (50 GS)", 3, 2, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(184, "Wasseratmen", "Geste", 15, "Luft", "Wasser", "2",
                "10 sec", "Berührung", "Körper", "1 Wesen", "8 h", "el", "", 3, 2, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(185, "Wasserlauf", "Gedanke", 11, "Wasser", "Erde", "3",
                "20 sec", "-", "Körper", "Zauberer", "10 min", "el", "", 5, 5, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(186, "Wassermeisterschaft", "Geste", 11, "Wasser", "Wasser",
                "6", "20 sec", "-", "Umgebung", "1 Wesen/Objekt", "1 h", "el", "Perle (100 GS)", 10, 40, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(187, "Wasserstrahl", "Geste", 13, "Wasser", "Wasser", "4",
                "20 sec", "5 m", "Umgebung", "Strahl", "1 min, k", "el", "Riesenkrakentrichter (100 GS)", 8, 20, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(188, "Wasserwandlung", "Geste", 14, "Eis", "Wasser", "4",
                "20 sec", "200 m", "Umgebung", "bis zu 10 m²", "var", "el", "reines Eis (50 GS)", 7, 15, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(189, "Windmeisterschaft", "Geste", 11, "Luft", "Luft", "4",
                "20 sec", "0 m", "Umgebung", "1 km Umkreis", "1 h", "el", "Sturmvogelfedern (10 GS)", 8, 20, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(190, "Windstoß", "Geste", 11, "Luft", "Luft", "1",
                "Augenblick", "0 m", "Umgebung", "30 m Kegel", "10 sec", "el", "", 2, 1, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(191, "Wirbelwind", "Geste", 11, "Luft", "Luft", "9",
                "30 sec", "0 m", "Umgebung", "3-6 m Umkreis", "2 min, k", "el", "", 12, 90, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(192, "Zauberauge", "Geste", 11, "Luft", "Feuer", "4",
                "20 sec", "500 m", "Umgebung", "-", "30 min, k", "dä", "Auge eines Toten (50 GS)", 8, 20, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(193, "Zauberhand", "Geste", 14, "Erde", "Luft", "4",
                "20 sec", "50 m", "Umgebung", "1 Wesen", "1 min, k", "dä", "Wachspuppe (20 GS)", 8, 20, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(194, "Zauberschild", "Geste", 13, "Metall", "Magan",
                "4 je Seite", "20 sec", "-", "Umgebung", "Zauberer", "2 min", "dä", "Drachenschuppe (100 GS)", 7, 15,
                20));
            modelBuilder.Entity<Spell>().HasData(new Spell(195, "Zauberschlaf", "Geste", 10, "Magan", "Wasser",
                "6 je Wesen", "10 sec", "30 m", "Körper", "bis zu 6 Wesen", "24 h", "dä",
                "Lotusblütenstaub und Blutrosendorn (20 GS)", 8, 20, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(196, "Zauberschloss", "Geste", 11, "Metall", "Holz", "1",
                "10 sec", "Berührung", "Umgebung", "1 Objekt", "12 h", "dä", "Silberschlüssel (50 GS)", 2, 1, 20,
                true));
            modelBuilder.Entity<Spell>().HasData(new Spell(197, "Zauberschlüssel", "Geste", 11, "Magan", "Holz", "2",
                "10 sec", "Berührung", "Umgebung", "1 Objekt", "0", "dä", "Springwurzspan (50 GS)", 3, 2, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(198, "Zauberschmiede", "Geste", 14, "Magan", "Metall",
                "03. Sep", "1 min", "Berührung", "Umgebung", "1 Objekt", "10 min", "dä", "Waffe aus Alchimistenmetall",
                5, 5, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(199, "Zauberstimme", "Geste", 13, "Magan", "Luft", "2",
                "10 min", "50 m", "Umgebung", "-", "12 h", "dä", "Papageienzunge (20 GS)", 3, 2, 20, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(200, "Zauberwirklichkeit", "Geste", 10, "Magan", "Feuer",
                "9", "3 h", "50 m", "Geist", "6 m Umkreis", "30 min", "dä",
                "Blütenstaub, Essenzen, Edelmetallsplitter (200 GS)", 12, 90, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(201, "Zauberzunge", "Geste", 12, "Luft", "Luft", "4",
                "1 min", "-", "Geist", "Zauberer", "30 min", "dä", "Papageienhirn und -zunge (50 GS)", 7, 15, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(202, "Zielsuche", "Geste", 14, "Luft", "Holz", "2", "10 sec",
                "Berührung", "Umgebung", "1 Objekt", "10 min", "dr", "", 5, 5, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(203, "Zweite Haut", "Gedanke", 16, "Erde", "Magan", "var",
                "Augenblick", "-", "Körper", "Zauberer", "10 min", "dä", "", 8, 20, 20));
            modelBuilder.Entity<Spell>().HasData(new Spell(204, "Zwiesprache", "Wort", 12, "Feuer", "Luft", "1",
                "Augenblick", "500 m", "Körper", "Zauberer", "10 min, k", "dä", "", 2, 1, 20, true));
            // Wundertaten
            modelBuilder.Entity<Spell>().HasData(new Spell(205, "Allheilung", "Geste", 13, "Holz", "Erde", "6",
                "30 min", "Berührung", "Körper", "1 Wesen", "0", "gö", "", 9, 30, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(206, "Arm der götter", "Geste", 15, "Metall", "Holz", "2",
                "10 sec", "-", "Körper", "Zauberer", "2 min", "gö", "", 3, 2, 17, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(207, "Austreibung des Bösen", "Wort", 11, "Magan", "Feuer",
                "5", "10 min", "15 m", "Körper", "1 Wesen", "0", "gö", "", 4, 3, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(208, "Bannen von Dunkelheit", "Wort", 13, "Feuer", "Feuer",
                "1", "Augenblick", "0 m", "Umgebung", "9 m Umkreis", "10 min", "gö", "", 2, 1, 17, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(209, "Bannen von Finsterwerk", "Wort", 16, "Magan", "Magan",
                "4", "10 sec", "15 m", "Umgebung", "1 Wesen/Objekt", "0", "gö", "", 4, 3, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(210, "Bannen von Gift", "Wort", 16, "Holz", "Eis", "4",
                "10 sec", "3m", "Körper", "1 Wesen", "0", "dr", "", 4, 3, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(211, "Beruhigen", "Wort", 10, "Luft", "Wasser", "1 je Grad",
                "10 sec", "0 m", "Geist", "15 m Umkreis", "0", "gö", "", 5, 5, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(212, "Blutmeisterschaft", "Gedanke", 15, "Erde", "Holz",
                "1 + 1 je Wunde", "10 sec", "-", "Körper", "Zauberer", "60 min", "gö", "", 2, 1, 17, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(213, "Erheben der Toten", "Wort", 13, "Luft", "Holz", "alle",
                "6 h", "1 m", "Körper", "1 Wesen", "0", "gö", "", 12, 90, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(214, "Erholung", "Geste", 13, "Luft", "Feuer", "4", "20 sec",
                "Berührung", "Körper", "1 Wesen", "0", "gö", "", 4, 3, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(215, "Erkennen der Aura", "Gedanke", 12, "Luft", "Luft", "1",
                "Augenblick", "0 m", "Geist", "30 m Kegel", "0", "gö", "", 2, 1, 17, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(216, "Erkennen von Besessenheit", "Gedanke", 12, "Luft",
                "Feuer", "2", "10 sec", "0 m", "Geist", "30 m Kegel", "10 sec", "gö", "", 3, 2, 17, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(217, "Erkennen von Krankheit", "Gedanke", 12, "Luft", "Eis",
                "1", "10 min", "Berührung", "Geist", "1 Wesen", "0", "dr", "", 2, 1, 17, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(218, "Goldene Wehr", "Geste", 14, "Luft", "Metall", "3",
                "1 min", "Berührung", "Umgebung", "1 Objekt", "10 min", "gö", "geweihte Waffe", 5, 5, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(219, "Gottesgabe", "Geste", 15, "Luft", "Wasser", "4",
                "1 min", "0 m", "Körper", "Zauberer", "10 min", "gö", "", 5, 5, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(220, "Göttliche Eingebung", "Gedanke", 12, "Luft", "Luft",
                "4", "30 min", "-", "Geist", "Zauberer", "10 min", "gö", "", 8, 20, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(221, "Göttlicher Blitz", "Geste", 13, "Luft", "Feuer", "3",
                "10 sec", "30 m", "Umgebung", "Strahl", "2 min, k", "gö", "", 5, 5, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(222, "Göttlicher Schirm", "Geste", 16, "Metall", "Magan",
                "2", "10 sec", "0 m", "Umgebung", "3 m Umkreis", "2 min, k", "gö", "", 4, 3, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(223, "Göttlicher Schutz v. d. Bösen", "Wort", 15, "Luft",
                "Wasser", "2", "10 min", "-", "Körper", "Zauberer", "1 h", "gö", "", 1, 1, 17, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(224, "Göttlicher Schutz vor Magie", "Wort", 15, "Metall",
                "Wasser", "3 je Person", "5 min", "0 m", "Körper", "6 m Umkreis", "1 h", "gö", "", 5, 5, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(225, "Handauflegen", "Geste", 13, "Luft", "Feuer", "1",
                "10 sec", "Berührung", "Körper", "1 Wesen", "0", "gö", "", 2, 1, 17, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(226, "Heilen schwerer Wunden", "Geste", 13, "Holz", "Erde",
                "4", "10 min", "Berührung", "Körper", "1 Wesen", "0", "gö", "", 6, 10, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(227, "Heilen von Krankheit", "Geste", 16, "Holz", "Eis", "2",
                "10 min", "Berührung", "Körper", "1 Wesen", "0", "gö", "", 4, 3, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(228, "Heilen von Wunden", "Geste", 13, "Luft", "Erde", "3",
                "1 min", "Berührung", "Körper", "1 Wesen", "0", "gö", "", 4, 3, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(229, "Heiliger Zorn", "Gedanke", 15, "Luft", "Erde", "2",
                "Augenblick", "-", "Körper", "Zauberer", "2 min", "gö", "", 2, 1, 17, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(230, "Heiliges Wort", "Wort", 16, "Metall", "Magan", "6",
                "10 sec", "0 m", "Körper", "9 m Umkreis", "var", "gö", "", 7, 15, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(231, "Himmlicher Beschützer", "Geste", 11, "Luft", "Erde",
                "3", "1 min", "Berührung", "Umgebung", "1 Wesen", "bis zu 10 min", "gö", "", 4, 3, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(232, "Himmlicher Helfer", "Wort", 10, "Magan", "Wasser",
                "3-9", "10 sec", "2 km", "Geist", "1-10 Wesen", "10 min", "gö", "", 4, 3, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(233, "Reinigen", "Geste", 16, "Holz", "Eis", "1", "10 min",
                "1 m", "Umgebung", "1 kg", "0", "gö", "", 1, 1, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(234, "Rüstung der Rechtschaffenen", "Geste", 15, "Luft",
                "Erde", "5", "20 sec", "Berührung", "Körper", "Zauberer", "2 min", "gö", "", 8, 20, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(235, "Schützende Hülle", "Wort", 13, "Feuer", "Holz",
                "1 + 1 je 10 sec", "10 sec", "-", "Körper", "Zauberer", "var, k", "gö", "", 2, 1, 17, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(236, "Schwingenkeule", "Geste", 14, "Luft", "Holz", "1",
                "10 sec", "Berührung", "Umgebung", "1 Objekt", "2 min", "gö", "Wurfkeule aus Holz", 2, 1, 17, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(237, "Seelenheilung", "Wort", 15, "Holz", "Luft", "2",
                "10 min", "3 m", "Geist", "1 Wesen", "0", "gö", "", 4, 3, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(238, "Segnen", "Geste", 15, "Luft", "Wasser", "2", "1 min",
                "Berührung", "Körper", "1 Wesen", "10 min", "gö", "", 3, 2, 17, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(239, "Strahlender Panzer", "Geste", 14, "Feuer", "Metall",
                "2", "1 sec", "Berührung", "Umgebung", "Zauberer", "2 min", "gö", "", 4, 3, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(240, "Verfluchen", "Wort", 15, "Luft", "Wasser", "2",
                "10 sec", "15 m", "Körper", "1 Wesen", "10 min", "gö", "", 3, 2, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(241, "Vision", "Geste", 12, "Wasser", "Luft",
                "alle (mind. 3)", "6 h", "-", "Geist", "Zauberer", "1 h", "gö", "Lebensmittel, Kräute, Pulver (20 GS)",
                6, 10, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(242, "Waffensegen", "Geste", 14, "Luft", "Metall", "3-9",
                "1 min", "Berührung", "Umgebung", "1 Objekt", "10 min", "gö", "", 5, 5, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(243, "Waffenwirbel", "Wort", 15, "Luft", "Erde", "6",
                "10 sec", "15 m", "Körper", "Zauberer", "1 min", "gö", "", 6, 10, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(244, "Wagemut", "Geste", 15, "Luft", "Feuer", "2", "10 sec",
                "15 m", "Geist", "1 Wesen", "2 min", "gö", "", 3, 2, 17, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(245, "Wort des Lebens", "Wort", 16, "Holz", "Eis", "6",
                "10 sec", "0 m", "Körper", "9 m Umkreis", "var", "gö", "", 8, 20, 17));
            modelBuilder.Entity<Spell>().HasData(new Spell(246, "Wort der Trauer", "Wort", 16, "Luft", "Eis", "6",
                "10 sec", "0 m", "Geist", "9 m Umkreis", "var", "gö", "", 8, 20, 17));
            // Dweomer
            modelBuilder.Entity<Spell>().HasData(new Spell(247, "Bärenwut", "Geste", 15, "Holz", "Erde", "2",
                "Augenblick", "-", "Körper", "Zauberer", "2 min", "dr", "eigenes Blut", 2, 1, 18, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(248, "Bannen von Gift", "Wort", 16, "Holz", "Eis", "4",
                "10 sec", "3 m", "Körper", "1 Wesen", "0", "dr", "-", 4, 3, 18));
            modelBuilder.Entity<Spell>().HasData(new Spell(249, "Baum", "Gedanke", 15, "Holz", "Erde", "1",
                "Augenblick", "-", "Körper", "Zauberer", "90 min", "dr", "-", 2, 1, 18, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(250, "Elfenfeuer", "Geste", 13, "Holz", "Holz", "3",
                "10 sec", "30 m", "Umgebung", "Strahl", "2 min, k", "dr", "Turmalin (50 GS)", 5, 5, 18));
            modelBuilder.Entity<Spell>().HasData(new Spell(251, "Elfenklinge", "Geste", 14, "Holz", "Metall", "2",
                "10 sec", "Berührung", "Umgebung", "1 Objekt", "10 min", "dr", "Waffe mit Elfenstahlklinge", 5, 5, 18));
            modelBuilder.Entity<Spell>().HasData(new Spell(252, "Entgiften", "Wort", 16, "Holz", "Eis", "2", "30 sec",
                "3 m", "Umgebung", "1 Objekt", "0", "dr", "-", 4, 3, 18));
            modelBuilder.Entity<Spell>().HasData(new Spell(253, "Erkennen von Gift", "Gedanke", 12, "Holz", "Eis", "2",
                "Augenblick", "15 m", "Geist", "1 m²", "0", "dr", "-", 4, 3, 18));
            modelBuilder.Entity<Spell>().HasData(new Spell(254, "Erkennen von Krankheit", "Gedanke", 12, "Holz", "Eis",
                "1", "10 min", "Berührung", "Geist", "1 Wesen", "0", "dr", "-", 2, 1, 18, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(255, "Fährtendurft", "Geste", 15, "Holz", "Erde",
                "1 je Wesen", "1 min", "Berührung", "Körper", "1-6 Wesen", "30 min", "dr", "Tierkot (1 GS)", 3, 2, 18,
                true));
            modelBuilder.Entity<Spell>().HasData(new Spell(256, "Feenfluch", "Geste", 15, "Holz", "Erde", "2", "10 sec",
                "15 m", "Körper", "1 Wesen", "?", "dr", "-", 5, 5, 18));
            modelBuilder.Entity<Spell>().HasData(new Spell(257, "Feenschutz", "Geste", 15, "Holz", "Luft", "6",
                "10 min", "30 m", "Geist", "bis zu 7 Wesen", "8 h", "dr",
                "Zweige von Eiche, Esche und Weißdorn (2 GS), Stück Kaltes Eisen", 6, 10, 18));
            modelBuilder.Entity<Spell>().HasData(new Spell(258, "Feenschwert", "Geste", 13, "Holz", "Holz", "4",
                "10 sec", "0 m", "Umgebung", "-", "2 min", "dr", "Turmalin (50 GS)", 6, 10, 18));
            modelBuilder.Entity<Spell>().HasData(new Spell(259, "Feuerbienen", "Geste", 13, "Holz", "Holz", "4",
                "10 sec", "50 m", "Umgebung", "Strahl", "2 min, k", "dr", "Turmalin (50 GS)", 6, 10, 18));
            modelBuilder.Entity<Spell>().HasData(new Spell(260, "Grüne Hand", "Geste", 14, "Holz", "Holz", "6",
                "20 sec", "Berührung", "Umgebung", "Pflanzen", "2 min", "dr",
                "pulverisierte Wurzeln, Frühlingsregen (20 GS)", 9, 30, 18));
            modelBuilder.Entity<Spell>().HasData(new Spell(261, "Kraftspende", "Geste", 11, "Holz", "Feuer", "1",
                "Augenblick", "30 m", "Körper", "1 Wesen", "0", "dr", "-", 1, 1, 18, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(262, "Laufen wie der Wind", "Geste", 15, "Holz", "Erde", "3",
                "10 sec", "-", "Körper", "Zauberer", "10 min", "dr", "-", 5, 5, 18));
            modelBuilder.Entity<Spell>().HasData(new Spell(263, "Lebensflammen", "Geste", 13, "Holz", "Holz",
                "1 je Wesen", "10 sec", "Berührung", "Umgebung", "bis zu 6 Wesen", "2 min", "dr", "Zunder (1 SS)", 3, 2,
                18, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(264, "Lebenskeule", "Geste", 14, "Holz", "Holz", "2",
                "10 sec", "Berührung", "Umgebung", "1 Objekt", "2 min", "dr", "Waffe aus Holz", 5, 5, 18));
            modelBuilder.Entity<Spell>().HasData(new Spell(265, "Lebensrettung", "Geste", 13, "Holz", "Erde", "3",
                "1 min", "Berührung", "Körper", "1 Wesen", "0", "dr", "-", 5, 5, 18));
            modelBuilder.Entity<Spell>().HasData(new Spell(266, "Lebensstärkung", "Geste", 13, "Holz", "Feuer", "4",
                "20 sec", "Berührung", "Körper", "1 Wesen", "30 min", "dr", "-", 4, 3, 18));
            modelBuilder.Entity<Spell>().HasData(new Spell(267, "Lindern von Entkräftung", "Geste", 13, "Holz", "Feuer",
                "5", "10 min", "Berührung", "Körper", "1 Wesen", "0", "dr", "-", 7, 15, 18));
            modelBuilder.Entity<Spell>().HasData(new Spell(268, "Lindern von Krankheit", "Geste", 16, "Holz", "Eis",
                "2", "10 min", "Berührung", "Körper", "1 Wesen", "0", "dr", "-", 3, 2, 18, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(269, "Linienlesen", "Gedanke", 12, "Holz", "Holz", "1",
                "Augenblick", "bis zu 5 km", "Geist", "Zauberer", "10 sec", "dr", "-", 1, 1, 18, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(270, "Linienwanderung", "Gedanke", 11, "Luft", "Feuer", "4",
                "20 sec", "-", "Körper", "Zauberer", "1 h", "dr", "-", 8, 20, 18));
            modelBuilder.Entity<Spell>().HasData(new Spell(271, "Mutlosigkeit", "Wort", 10, "Holz", "Wasser",
                "2 je Wesen", "Augenblick", "30 m", "Geist", "bis zu 10 Wesen", "10 min", "dr", "-", 2, 1, 18, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(272, "Naturgeist rufen", "Geste", 10, "Holz", "Holz", "3",
                "5 min", "500 m", "Geist", "-", "2 min", "dr", "Weißdornpfeife bzw. Schamanentrommel", 4, 3, 18));
            modelBuilder.Entity<Spell>().HasData(new Spell(273, "Rindenhaut", "Geste", 15, "Holz", "Erde", "2",
                "10 sec", "Berührung", "Körper", "1 Wesen", "10 min", "dr", "Eichenrinde (2 SS)", 4, 3, 18));
            modelBuilder.Entity<Spell>().HasData(new Spell(274, "Ring des Lebens", "Geste", 16, "Holz", "Eis", "4",
                "Augenblick", "0 m", "Umgebung", "bis zu 18 m Umkreis", "1 min", "dr", "Samen des Lebenskrautes (5 GS)",
                5, 5, 18));
            modelBuilder.Entity<Spell>().HasData(new Spell(275, "Schlachtenwahnsinn", "Geste", 15, "Holz", "Erde", "6",
                "10 sec", "-", "Körper", "Zauberer", "1 min", "dr", "-", 8, 20, 18));
            modelBuilder.Entity<Spell>().HasData(new Spell(276, "Schnellheilung", "Geste", 13, "Holz", "Erde", "4",
                "10 min", "Berührung", "Körper", "1 Wesen", "0", "dr", "-", 6, 10, 18));
            modelBuilder.Entity<Spell>().HasData(new Spell(277, "Schutzgeist", "Geste", 11, "Luft", "Erde", "3",
                "10 sec", "Berührung", "Umgebung", "Zauberer", "bis zu 30 min", "dr", "-", 5, 5, 18));
            modelBuilder.Entity<Spell>().HasData(new Spell(278, "Schwarm", "Wort", 11, "Holz", "Erde", "2", "10 sec",
                "50 m", "Umgebung", "-", "1 min, k", "dr", "-", 4, 3, 18));
            modelBuilder.Entity<Spell>().HasData(new Spell(279, "Tiere rufen", "Wort", 10, "Holz", "Wasser", "3-9",
                "10 sec", "2 km", "Geist", "1-10 Wesen", "10 min", "dr", "-", 5, 5, 18));
            modelBuilder.Entity<Spell>().HasData(new Spell(280, "Tiergestalt", "Geste", 15, "Wasser", "Erde", "6",
                "20 sec", "-", "Körper", "Zauberer", "?", "dr", "Fellstück, Feder usw. (1 GS)", 9, 30, 18));
            modelBuilder.Entity<Spell>().HasData(new Spell(281, "Tierischer Helfer", "Wort", 10, "Holz", "Wasser",
                "2 je Grad", "10 sec", "30 m", "Geist", "1 Wesen je Grad", "mind. 2 h", "dr", "-", 4, 3, 18));
            modelBuilder.Entity<Spell>().HasData(new Spell(282, "Wandeln wie der Wind", "Geste", 14, "Holz", "Erde",
                "1", "Augenblick", "0 m", "Umgebung", "1 m Umkreis", "10 min", "dr",
                "Flugsamen verschiedener Pflanzen (5 SS)", 2, 1, 18, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(283, "Wittern", "Geste", 15, "Holz", "Erde", "2", "10 sec",
                "-", "Körper", "Zauberer", "30 min", "dr", "Spürhundhaare (5 GS)", 3, 2, 18, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(284, "Wundersame Tarnung", "Gedanke", 14, "Holz", "Erde",
                "1", "Augenblick", "-", "Umgebung", "Zauberer", "30 min", "dr", "-", 2, 1, 18, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(285, "Zähmen", "Wort", 10, "Holz", "Wasser", "1 je Grad",
                "10 sec", "30 m", "Geist", "1 Wesen je Grad", "2 h", "dr", "-", 2, 1, 18, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(286, "Zaubersprung", "Geste", 15, "Holz", "Erde", "2",
                "10 sec", "-", "Körper", "Zauberer", "10 sec", "dr", "-", 3, 2, 18, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(287, "Zeichen des Lebens", "Geste", 16, "Holz", "Eis", "6",
                "20 sec", "0", "Körper", "9 m Umkreis", "10 min", "dr", "-", 8, 20, 18));
            // Zauberlieder
            modelBuilder.Entity<Spell>().HasData(new Spell(288, "Das Lied des Erinnerns", "-", 15, "Magan", "Luft", "2",
                "1 min", "-", "Geist", "15 m Umkreis", "0", "-", "Harfe oder Laute, Stimme", 7, 15, 19));
            modelBuilder.Entity<Spell>().HasData(new Spell(289, "Das Lied der Feier", "-", 15, "Luft", "Luft", "0",
                "1 min", "-", "Geist", "30 m Umkreis", "30 min", "-", "Flöte, Harfe oder Laute", 1, 1, 19, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(290, "Das Lied des Fesselns", "-", 10, "Luft", "Luft", "2",
                "Augenblick", "-", "Geist", "30 m Umkreis", "3 min", "-", "Flöte, Harfe oder Laute", 3, 2, 19, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(291, "Das Lied des Friedens", "-", 10, "Metall", "Wasser",
                "2", "1 min", "-", "Geist", "15 m Umkreis", "10 min", "-", "Harfe oder Laute, Stimme", 10, 40, 19));
            modelBuilder.Entity<Spell>().HasData(new Spell(292, "Das Lied des Grauens", "-", 10, "Eis", "Wasser", "4",
                "1 min", "-", "Geist", "200 m Kegel", "1 min", "-", "Flöte, Stimme", 9, 30, 19));
            modelBuilder.Entity<Spell>().HasData(new Spell(293, "Das Lied der Liebe", "-", 10, "Wasser", "Wasser", "0",
                "1 min", "15 m", "Geist", "1 Wesen", "?", "-", "Harfe oder Laute, Stimme", 7, 15, 19));
            modelBuilder.Entity<Spell>().HasData(new Spell(294, "Das Lied der Lockung", "-", 10, "Magan", "Wasser", "2",
                "1 min", "-", "Geist", "200 m Kegel", "1 min", "-", "Flöte", 8, 20, 19));
            modelBuilder.Entity<Spell>().HasData(new Spell(295, "Das Lied der Ruhe", "-", 10, "Wasser", "Wasser", "2",
                "1 min", "-", "Geist", "30 m Umkreis", "2 h", "-", "Flöte, Harfe oder Laute", 3, 2, 19, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(296, "Das Lied des Spottes", "-", 15, "Luft", "Luft", "2",
                "3 min", "-", "Geist", "30 m Umkreis", "?", "-", "Harfe oder Laute, Stimme", 3, 2, 19));
            modelBuilder.Entity<Spell>().HasData(new Spell(297, "Das Lied der Tanzlust", "-", 10, "Magan", "Erde", "2",
                "1 min", "-", "Geist", "30 m Umkreis", "1 min", "-", "Flöte", 5, 5, 19));
            modelBuilder.Entity<Spell>().HasData(new Spell(298, "Das Lied der Tapferkeit", "-", 15, "Luft", "Luft", "0",
                "10 min", "-", "Geist", "15 m Umkreis", "30 min", "-", "Flöte, Harfe oder Laute, Stimme", 1, 1, 19,
                true));
            modelBuilder.Entity<Spell>().HasData(new Spell(299, "Das Lied der verborgenen Kraft", "-", 15, "Magan",
                "Feuer", "2", "1 min", "-", "Körper", "15 m Umkreis", "0", "-", "Flöte, Stimme", 6, 10, 19));
            modelBuilder.Entity<Spell>().HasData(new Spell(300, "Das Lied der Verführung", "-", 10, "Wasser", "Wasser",
                "2", "1 min", "5 m", "Geist", "1 Wesen", "6 h", "-", "Harfe oder Laute, Stimme", 3, 2, 19, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(301, "Das Lied des Vergessens", "-", 15, "Magan", "Luft",
                "2", "1 min", "-", "Geist", "15 m Umkreis", "?", "-", "Harfe oder Laute, Stimme", 7, 15, 19));
            modelBuilder.Entity<Spell>().HasData(new Spell(302, "Das Lied der Verzweiflung", "-", 15, "Magan", "Luft",
                "4", "3 min", "15 m", "Geist", "1 Wesen", "30 min", "-", "Flöte, Harfe oder Laute, Stimme", 7, 15, 19));
            modelBuilder.Entity<Spell>().HasData(new Spell(303, "Das Lied des Wagemuts", "-", 15, "Luft", "Feuer", "2",
                "1 min", "-", "Geist", "15 m Umkreis", "30 min", "-", "Flöte, Harfe oder Laute, Stimme", 3, 2, 19,
                true));
            modelBuilder.Entity<Spell>().HasData(new Spell(304, "Das Lied des Wahnsinns", "-", 16, "Magan", "Luft", "4",
                "3 min", "-", "Geist", "30 m Umkreis", "?", "-", "Flöte, Stimme", 9, 30, 19));
            modelBuilder.Entity<Spell>().HasData(new Spell(305, "Das Lied des Zorns", "-", 10, "Wasser", "Wasser", "2",
                "1 min", "-", "Geist", "30 m Umkreis", "2 min", "-", "Flöte, Stimme", 11, 60, 19));
            modelBuilder.Entity<Spell>().HasData(new Spell(306, "Das Lied der Zwietracht", "-", 10, "Magan", "Wasser",
                "2", "1 min", "-", "Geist", "15 m Umkreis", "10 min", "-", "Harfe oder Laute, Stimme", 10, 40, 19));
            modelBuilder.Entity<Spell>().HasData(new Spell(307, "Das Loblied", "-", 15, "Luft", "Luft", "2", "1 min",
                "-", "Geist", "30 m Umkreis", "1-3 Tage", "-", "Harfe oder Laute, Stimme", 3, 2, 19));
            modelBuilder.Entity<Spell>().HasData(new Spell(308, "Der betäubende Gesang", "-", 10, "Magan", "Wasser",
                "4", "3 min", "-", "Geist", "15 m Umkreis", "1 min", "-", "Harfe oder Laute, Stimme", 6, 10, 19));
            modelBuilder.Entity<Spell>().HasData(new Spell(309, "Der einschläfernde Gesang", "-", 10, "Magan", "Wasser",
                "2", "3 min", "-", "Geist", "15 m Umkreis", "1 min", "-", "Harfe oder Laute, Stimme", 4, 3, 19));
            modelBuilder.Entity<Spell>().HasData(new Spell(310, "Der frohlockende Gesang", "-", 15, "Luft", "Luft", "2",
                "1 min", "-", "Geist", "15 m Umkreis", "1 min", "-", "Harfe oder Laute, Stimme", 4, 3, 19));
            modelBuilder.Entity<Spell>().HasData(new Spell(311, "Der traurige Gesang", "-", 15, "Magan", "Luft", "2",
                "1 min", "-", "Geist", "15 m Umkreis", "1 min", "-", "Harfe oder Laute, Stimme", 4, 3, 19));
            modelBuilder.Entity<Spell>().HasData(new Spell(312, "Der verunsichernde Gesang", "-", 10, "Feuer", "Luft",
                "2", "1 min", "-", "Geist", "15 m Umkreis", "1 min", "-", "Flöte, Harfe oder Laute, Stimme", 3, 2, 19));
            modelBuilder.Entity<Spell>().HasData(new Spell(313, "Die anfeuernde Ballade", "-", 15, "Magan", "Luft", "2",
                "1 min", "50 m", "Körper", "1 Wesen", "1 min", "-", "Flöte", 2, 1, 19, true));
            modelBuilder.Entity<Spell>().HasData(new Spell(314, "Die stählende Ballade", "-", 15, "Metall", "Luft", "2",
                "1 min", "-", "Geist", "15 m Umkreis", "1 min", "-", "Flöte, Harfe oder Laute, Stimme", 2, 1, 19));
            modelBuilder.Entity<Spell>().HasData(new Spell(315, "Die Hymne der Ordnung", "-", 16, "Metall", "Magan",
                "2", "Augenblick", "-", "Umgebung", "15 m Umkreis", "1 min", "-", "Flöte, Harfe oder Laute, Stimme", 6,
                10, 19));
            modelBuilder.Entity<Spell>().HasData(new Spell(316, "Die Klänge der Genesung", "-", 15, "Magan", "Erde",
                "2", "1 min", "-", "Körper", "15 m Umkreis", "0", "-", "Flöte, Harfe oder Laute, Stimme", 6, 10, 19));
            modelBuilder.Entity<Spell>().HasData(new Spell(317, "Die Klänge der Linderung", "-", 15, "Metall", "Luft",
                "1", "5 min", "15 m", "Geist", "1 Wesen", "0", "-", "Harfe oder Laute, Stimme", 5, 5, 19));
            modelBuilder.Entity<Spell>().HasData(new Spell(318, "Die Klänge des Zusammenwachsens", "-", 15, "Magan",
                "Erde", "2", "3 min", "-", "Körper", "15 m Umkreis", "0", "-", "Flöte, Harfe oder Laute, Stimme", 5, 5,
                19));
            modelBuilder.Entity<Spell>().HasData(new Spell(319, "Die überzeugende Stimme", "-", 10, "Feuer", "Luft",
                "2", "1 min", "15 m", "Geist", "1 Wesen", "2 min", "-", "Stimme", 5, 5, 19));
        }

        /// <summary>
        /// Initializes DefenseWeaponTrainingCosts for the database.
        /// </summary>
        /// <param name="modelBuilder"></param>
        public void SeedDefenseWeaponTrainingCosts(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DefenseWeaponTrainingCost>().HasData(new DefenseWeaponTrainingCost(1, 2, 1));
            modelBuilder.Entity<DefenseWeaponTrainingCost>().HasData(new DefenseWeaponTrainingCost(2, 3, 2));
            modelBuilder.Entity<DefenseWeaponTrainingCost>().HasData(new DefenseWeaponTrainingCost(3, 4, 10));
            modelBuilder.Entity<DefenseWeaponTrainingCost>().HasData(new DefenseWeaponTrainingCost(4, 5, 30));
            modelBuilder.Entity<DefenseWeaponTrainingCost>().HasData(new DefenseWeaponTrainingCost(5, 6, 50));
            modelBuilder.Entity<DefenseWeaponTrainingCost>().HasData(new DefenseWeaponTrainingCost(6, 7, 100));
            modelBuilder.Entity<DefenseWeaponTrainingCost>().HasData(new DefenseWeaponTrainingCost(7, 8, 150));
        }

        /// <summary>
        /// Initializes Races for the database.
        /// </summary>
        /// <param name="modelBuilder"></param>
        public void SeedRaces(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Race>().HasData(new Race(1, "Mensch", 0, 0));
            modelBuilder.Entity<Race>().HasData(new Race(2, "Elf", 2, 0));
            modelBuilder.Entity<Race>().HasData(new Race(3, "Gnom", 4, -3));
            modelBuilder.Entity<Race>().HasData(new Race(4, "Halbling", 4, -2));
            modelBuilder.Entity<Race>().HasData(new Race(5, "Zwerg", 3, 1));
        }

        /// <summary>
        /// Initializes SocialClasses for the database.
        /// </summary>
        /// <param name="modelBuilder"></param>
        public void SeedSocialClasses(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SocialClass>().HasData(new SocialClass(1, "Unfrei", 3));
            modelBuilder.Entity<SocialClass>().HasData(new SocialClass(2, "Volk", 1));
            modelBuilder.Entity<SocialClass>().HasData(new SocialClass(3, "Mittelschicht", 9));
            modelBuilder.Entity<SocialClass>().HasData(new SocialClass(4, "Adel", 6));
        }

        /// <summary>
        /// Initializes Weapons for the database.
        /// </summary>
        /// <param name="modelBuilder"></param>
        public void SeedWeapons(ModelBuilder modelBuilder)
        {
            // Nahkampf
            modelBuilder.Entity<Weapon>().HasData(new Weapon(1, "Handaxt", "1W6", "", "", 11, 0, 0, "", "nah", 60));
            modelBuilder.Entity<Weapon>().HasData(new Weapon(2, "Keule", "1W6-1", "", "", 0, 0, 0, "", "nah", 60));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(3, "Kriegshammer", "1W6", "", "", 61, 11, 0, "", "nah", 60));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(4, "Schlachtbeil", "1W6+1", "", "", 91, 21, 0, "", "nah", 60));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(5, "Streitaxt", "1W6-1", "", "", 61, 11, 0, "", "nah", 60));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(6, "Streitkolben", "1W6", "", "", 31, 0, 0, "", "nah", 60));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(7, "Anderthalbhänder", "1W6+1", "", "", 81, 21, 0, "", "nah", 61));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(8, "Krummschwert", "1W6", "", "", 31, 11, 0, "", "nah", 61));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(9, "Langschwert", "1W6+1", "", "", 31, 21, 0, "", "nah", 61));
            modelBuilder.Entity<Weapon>().HasData(new Weapon(10, "Florett", "", "", "", 0, 81, 0, "", "nah", 62));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(11, "Fuchtel", "", "", "", 61, 31, 0, "nur Parade", "nah", 62));
            modelBuilder.Entity<Weapon>().HasData(new Weapon(12, "Rapier", "", "", "", 11, 51, 0, "", "nah", 62));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(13, "Kriegsflegel", "2W6-1", "", "", 61, 31, 0, "zweihändig", "nah", 63));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(14, "Morgenstern", "1W6+2", "", "", 61, 61, 0, "", "nah", 63));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(15, "NunChaku", "1W6-1", "", "", 31, 61, 0, "entwaffnen", "nah", 63));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(16, "Glefe", "1W6", "1W6+2", "", 11, 61, 0, "", "nah", 64));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(17, "Hellebarde", "1W6", "1W6+2", "", 61, 61, 0, "", "nah", 64));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(18, "Speer, leichter", "", "1W6+1", "", 0, 0, 0, "", "nah", 64));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(19, "Stielhammer", "1W6", "1W6-1", "", 81, 31, 0, "", "nah", 64));
            modelBuilder.Entity<Weapon>().HasData(new Weapon(20, "Stoßspeer", "", "2W6", "", 31, 11, 0, "", "nah", 64));
            modelBuilder.Entity<Weapon>().HasData(new Weapon(21, "Dolch", "1W6-1", "", "", 0, 0, 0, "", "nah", 65));
            modelBuilder.Entity<Weapon>().HasData(new Weapon(22, "Kurzschwert", "1W6", "", "", 0, 0, 0, "", "nah", 65));
            modelBuilder.Entity<Weapon>().HasData(new Weapon(23, "Ochsenzunge", "", "", "", 0, 31, 0, "", "nah", 65));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(24, "Bo-Stab", "1W6", "", "", 21, 61, 0, "Abwehr, Entwaffnen", "nah", 66));
            modelBuilder.Entity<Weapon>().HasData(new Weapon(25, "Kampfstab", "1W6", "", "", 31, 61, 0,
                "Abwehr, Entwaffnen", "nah", 66));
            modelBuilder.Entity<Weapon>().HasData(new Weapon(26, "Magierstab", "1W6", "", "", 0, 31, 0,
                "bei Kämpfer wie Keule", "nah", 67));
            modelBuilder.Entity<Weapon>().HasData(new Weapon(27, "Magierstecken", "", "", "", 31, 31, 0,
                "Abwehr, Entwaffnen", "nah", 67));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(28, "Barbarenstreitaxt", "2W6", "", "", 81, 31, 0, "", "nah", 68));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(29, "Glefe", "1W6+2", "1W6+2", "", 11, 61, 0, "", "nah", 68));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(30, "Hellebarde", "2W6-1", "1W6+2", "", 61, 61, 0, "", "nah", 68));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(31, "Ogerhammer", "4W6-4", "", "", 91, 61, 0, "", "nah", 68));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(32, "Schlachtbeil", "1W6+3", "", "", 91, 21, 0, "", "nah", 68));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(33, "Stabkeule", "2W6-2", "", "", 81, 0, 0, "", "nah", 68));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(34, "Stielhammer", "2W6", "1W6+1", "", 81, 31, 0, "", "nah", 68));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(35, "Anderthalbhänder", "1W6+2", "", "", 81, 21, 0, "", "nah", 69));
            modelBuilder.Entity<Weapon>().HasData(new Weapon(36, "Bihänder", "2W6", "", "", 61, 31, 0, "", "nah", 69));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(37, "Faustkampf", "1W6-4", "", "", 31, 21, 21, "betäuben", "nah", 70));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(38, "Ringen", "1W6-4", "", "", 21, 31, 31, "erstetzt Raufen", "nah", 70));
            modelBuilder.Entity<Weapon>().HasData(new Weapon(39, "Buckler", "", "2 AP", "", 0, 61, 0,
                "gegen Einhandschwert, Zauberstab, Stich-, Stock- , Spießwaffe, Fecht-, Parierwaffe oder Buckler",
                "nah", 71));
            modelBuilder.Entity<Weapon>().HasData(new Weapon(40, "Schild, großer", "", "0 AP", "", 61, 0, 0,
                "gegen alle Angriffe, auch Schuss- und Wurfwaffen sowie zweihändige Hiebwaffen", "nah", 71));
            modelBuilder.Entity<Weapon>().HasData(new Weapon(41, "Schild, kleiner", "", "1 AP", "", 31, 11, 0,
                "gegen alle Nahkampfangriffe ausgenommen zweihändige Hiebwaffen sowie Schuss und Wurfwaffen", "nah",
                71));
            modelBuilder.Entity<Weapon>().HasData(new Weapon(42, "Kampfgabeln", "(1W6-3)/(1W6-4)", "2 AP", "", 31, 61,
                0, "gegen Einhandschwert, Zauberstab, Stich-, Stock-, Spießwaffe, Buckler oder andere Parierwaffe",
                "nah", 72));
            modelBuilder.Entity<Weapon>().HasData(new Weapon(43, "Parierdolch", "", "1 AP", "", 0, 61, 0,
                "gegen Einhandschwert, Zauberstab, Stich-, Stock-, Spießwaffe, Buckler oder andere Parierwaffe", "nah",
                72));
            // Fernkampf
            modelBuilder.Entity<Weapon>().HasData(new Weapon(44, "Wurfaxt", "1W6", "", "", 31, 31, 0,
                "Nahkampf wie Handaxt", "10/20/30", 73));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(45, "Wurfeisen", "1W6", "", "", 61, 61, 0, "", "10/20/50", 73));
            modelBuilder.Entity<Weapon>().HasData(new Weapon(46, "Wurfhammer", "1W6", "", "", 61, 31, 0,
                "Nahkampf w. Kriegshammer", "10/20/30", 73));
            modelBuilder.Entity<Weapon>().HasData(new Weapon(47, "Wurfkeule", "1W6-1", "", "", 31, 31, 0,
                "Nahkampf wie Keule", "10/20/50", 73));
            modelBuilder.Entity<Weapon>().HasData(new Weapon(48, "Wurfmesser", "1W6-1", "", "", 0, 61, 0,
                "Nahkampf wie Dolch", "10/15/20", 74));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(49, "Wurfpfeil", "1W6-2", "", "", 11, 31, 0, "", "10/20/30", 74));
            modelBuilder.Entity<Weapon>().HasData(new Weapon(50, "Wurfscheibe", "1W6-2", "", "", 61, 61, 0,
                "pro Runde 2 Angriffe", "10/20/30", 75));
            modelBuilder.Entity<Weapon>().HasData(new Weapon(51, "Wurfstern", "1W6-3", "", "", 0, 61, 0,
                "pro Runde 3 Angriffe", "5/10/15", 75));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(52, "Speerschleuder", "1W6", "", "", 31, 61, 0, "", "20/40/70", 76));
            modelBuilder.Entity<Weapon>().HasData(new Weapon(53, "Wurfspeer", "1W6-1", "", "", 31, 21, 0,
                "Nahkampf wie Speer, leicht", "10/30/50", 76));
            modelBuilder.Entity<Weapon>().HasData(new Weapon(54, "Wurfspie?", "1W6", "", "", 61, 21, 0,
                "Nahkampf wie Speer, leicht", "10/20/30", 76));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(55, "Armbrust, leichte", "1W6", "", "", 0, 61, 0, "", "30/120/220", 77));
            modelBuilder.Entity<Weapon>().HasData(new Weapon(56, "Armbrust, schwere", "2W6-1", "", "", 61, 31, 0,
                "Schuss jede 2. Runde", "30/120/240", 77));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(57, "Handarmbrust", "1W6-1", "", "", 0, 31, 0, "", "20/40/70", 77));
            modelBuilder.Entity<Weapon>().HasData(new Weapon(58, "Blasrohr, lang", "(Gift)", "", "", 0, 61, 0,
                "(Gift 3W6-5W6 Schaden)", "10/15/20", 78));
            modelBuilder.Entity<Weapon>().HasData(new Weapon(59, "Blasrohr, kurz", "(Gift)", "", "", 0, 61, 0,
                "(Gift 3W6-5W6 Schaden)", "5/7/10", 78));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(60, "Bogen", "1W6", "", "", 31, 31, 0, "", "30/100/180", 79));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(61, "Kompositbogen", "1W6+1", "", "", 61, 61, 0, "", "30/120/200", 79));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(62, "Kurzbogen", "1W6-1", "", "", 11, 31, 0, "", "30/80/120", 79));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(63, "Langbogen", "1W6+1", "", "", 61, 61, 0, "", "30/120/200", 79));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(64, "Schleuder", "1W6", "", "", 0, 61, 0, "", "30/60/90", 80));
            modelBuilder.Entity<Weapon>()
                        .HasData(new Weapon(65, "Stockschleuder", "2W6-2", "", "", 31, 81, 0, "", "50/100/180", 80));
        }

        /// <summary>
        /// Initializes SkillLearningCosts for the database.
        /// </summary>
        /// <param name="modelBuilder"></param>
        public void SeedSkillLearningCosts(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(1, 1, 1, 1));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(2, 1, 2, 1));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(3, 1, 3, 2));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(4, 1, 4, 10));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(5, 2, 1, 1));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(6, 2, 2, 2));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(7, 2, 3, 4));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(8, 3, 1, 1));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(9, 3, 2, 2));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(10, 3, 3, 2));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(11, 3, 4, 10));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(12, 4, 1, 1));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(13, 4, 2, 2));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(14, 4, 3, 10));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(15, 4, 4, 10));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(16, 5, 1, 1));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(17, 5, 2, 1));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(18, 5, 3, 2));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(19, 6, 1, 2));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(20, 6, 2, 2));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(21, 6, 3, 4));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(22, 7, 1, 2));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(23, 7, 2, 4));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(24, 7, 3, 10));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(25, 8, 1, 2));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(26, 8, 2, 4));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(27, 8, 3, 6));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(28, 8, 4, 8));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(29, 9, 1, 1));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(30, 9, 2, 2));
            modelBuilder.Entity<SkillLearningCost>().HasData(new SkillLearningCost(31, 9, 3, 2));
        }

        /// <summary>
        /// Initializes Languages for the database.
        /// </summary>
        /// <param name="modelBuilder"></param>
        public void SeedLanguages(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>().HasData(new Language(1, "Albisch"));
            modelBuilder.Entity<Language>().HasData(new Language(2, "Aranisch"));
            modelBuilder.Entity<Language>().HasData(new Language(3, "Chryseisch"));
            modelBuilder.Entity<Language>().HasData(new Language(4, "Erainnisch"));
            modelBuilder.Entity<Language>().HasData(new Language(5, "Hurritisch"));
            modelBuilder.Entity<Language>().HasData(new Language(6, "KanThaiTun"));
            modelBuilder.Entity<Language>().HasData(new Language(7, "Kibulugi"));
            modelBuilder.Entity<Language>().HasData(new Language(8, "Medjisisch"));
            modelBuilder.Entity<Language>().HasData(new Language(9, "Minangpahitisch"));
            modelBuilder.Entity<Language>().HasData(new Language(10, "Moravisch"));
            modelBuilder.Entity<Language>().HasData(new Language(11, "Nahuatlantisch"));
            modelBuilder.Entity<Language>().HasData(new Language(12, "Neu-Vallinga"));
            modelBuilder.Entity<Language>().HasData(new Language(13, "Ongana"));
            modelBuilder.Entity<Language>().HasData(new Language(14, "Rawindi"));
            modelBuilder.Entity<Language>().HasData(new Language(15, "Scharidisch"));
            modelBuilder.Entity<Language>().HasData(new Language(16, "Tegarisch"));
            modelBuilder.Entity<Language>().HasData(new Language(17, "Twyneddisch"));
            modelBuilder.Entity<Language>().HasData(new Language(18, "Vallinga"));
            modelBuilder.Entity<Language>().HasData(new Language(19, "Waelska"));
            modelBuilder.Entity<Language>().HasData(new Language(20, "Dvarska"));
            modelBuilder.Entity<Language>().HasData(new Language(21, "Eldalyn"));
            modelBuilder.Entity<Language>().HasData(new Language(22, "Gnomenon"));
            modelBuilder.Entity<Language>().HasData(new Language(23, "Halftan"));
            modelBuilder.Entity<Language>().HasData(new Language(24, "Altoqua"));
            modelBuilder.Entity<Language>().HasData(new Language(25, "Eradórisch"));
            modelBuilder.Entity<Language>().HasData(new Language(26, "Hochcoraniaid"));
            modelBuilder.Entity<Language>().HasData(new Language(27, "Maralinga"));
            modelBuilder.Entity<Language>().HasData(new Language(28, "Meketisch"));
            modelBuilder.Entity<Language>().HasData(new Language(29, "Tuskisch"));
        }

        /// <summary>
        /// Initializes Lands for the database.
        /// </summary>
        /// <param name="modelBuilder"></param>
        public void SeedLands(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Land>().HasData(new Land(1, "Alba"));
            modelBuilder.Entity<Land>().HasData(new Land(2, "Aran"));
            modelBuilder.Entity<Land>().HasData(new Land(3, "Buluga"));
            modelBuilder.Entity<Land>().HasData(new Land(4, "Chryseia"));
            modelBuilder.Entity<Land>().HasData(new Land(5, "Clanngadarn"));
            modelBuilder.Entity<Land>().HasData(new Land(6, "Erainn"));
            modelBuilder.Entity<Land>().HasData(new Land(7, "Eschar"));
            modelBuilder.Entity<Land>().HasData(new Land(8, "Ikengabecken"));
            modelBuilder.Entity<Land>().HasData(new Land(9, "KanThaiPan (Ost)"));
            modelBuilder.Entity<Land>().HasData(new Land(10, "KanThaiPan (TsaiChen-Tal)"));
            modelBuilder.Entity<Land>().HasData(new Land(11, "Küstenstaaten"));
            modelBuilder.Entity<Land>().HasData(new Land(12, "Medjis"));
            modelBuilder.Entity<Land>().HasData(new Land(13, "Minangpahit"));
            modelBuilder.Entity<Land>().HasData(new Land(14, "Moravod"));
            modelBuilder.Entity<Land>().HasData(new Land(15, "Nahuatlan"));
            modelBuilder.Entity<Land>().HasData(new Land(16, "Rawindra"));
            modelBuilder.Entity<Land>().HasData(new Land(17, "Tegarische Steppe"));
            modelBuilder.Entity<Land>().HasData(new Land(18, "Urruti"));
            modelBuilder.Entity<Land>().HasData(new Land(19, "Valian"));
            modelBuilder.Entity<Land>().HasData(new Land(20, "Waeland"));
            modelBuilder.Entity<Land>().HasData(new Land(21, "Ywerddon"));
        }

        /// <summary>
        /// Initializes InnateSkills for the database.
        /// </summary>
        /// <param name="modelBuilder"></param>
        public void SeedInnateSkills(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InnateSkill>().HasData(new InnateSkill(1, "Berserkergang", "+(18-Wk/5)", 96, 99));
            modelBuilder.Entity<InnateSkill>().HasData(new InnateSkill(2, "Einprägen", "+4", 91, 95));
            modelBuilder.Entity<InnateSkill>().HasData(new InnateSkill(3, "Gute Reflexe", "+9", 56, 60));
            modelBuilder.Entity<InnateSkill>().HasData(new InnateSkill(4, "Raufen", "+(St+Gw)/20", 0, 0));
            modelBuilder.Entity<InnateSkill>().HasData(new InnateSkill(5, "Richtungssinn", "+12", 61, 65));
            modelBuilder.Entity<InnateSkill>().HasData(new InnateSkill(6, "Robustheit", "+9", 66, 70));
            modelBuilder.Entity<InnateSkill>().HasData(new InnateSkill(7, "Schmerzunempfindlichkeit", "+9", 71, 75));
            modelBuilder.Entity<InnateSkill>().HasData(new InnateSkill(8, "Trinken", "+12", 76, 80));
            modelBuilder.Entity<InnateSkill>().HasData(new InnateSkill(9, "Trinken", "+Ko/10", 0, 0));
            modelBuilder.Entity<InnateSkill>().HasData(new InnateSkill(10, "Wachgabe", "+6", 81, 85));
            modelBuilder.Entity<InnateSkill>().HasData(new InnateSkill(11, "Wahrnehmung", "+6", 0, 0));
            modelBuilder.Entity<InnateSkill>().HasData(new InnateSkill(12, "Wahrnehmung", "+8", 86, 90));
            modelBuilder.Entity<InnateSkill>().HasData(new InnateSkill(13, "Sehen", "+2", 21, 30));
            modelBuilder.Entity<InnateSkill>().HasData(new InnateSkill(14, "Sehen", "-2", 1, 5));
            modelBuilder.Entity<InnateSkill>().HasData(new InnateSkill(15, "Hören", "+2", 31, 40));
            modelBuilder.Entity<InnateSkill>().HasData(new InnateSkill(16, "Hören", "-2", 6, 10));
            modelBuilder.Entity<InnateSkill>().HasData(new InnateSkill(17, "Riechen", "+2", 41, 50));
            modelBuilder.Entity<InnateSkill>().HasData(new InnateSkill(18, "Riechen", "-2", 11, 15));
            modelBuilder.Entity<InnateSkill>().HasData(new InnateSkill(19, "Sechster Sinn", "+2", 16, 20));
            modelBuilder.Entity<InnateSkill>().HasData(new InnateSkill(20, "Nachtsicht", "+2", 51, 55));
        }

        /// <summary>
        /// Initializes ClassCategoryAffinities for the database.
        /// </summary>
        /// <param name="modelBuilder"></param>
        public void SeedClassCategoryAffinities(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(1, 1, 1, 1));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(2, 1, 2, 3));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(3, 1, 4, 6));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(4, 1, 8, 7));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(5, 1, 24, 8));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(6, 2, 2, 1));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(7, 2, 4, 2));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(8, 2, 1, 4));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(9, 2, 2, 5));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(10, 2, 24, 8));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(11, 3, 2, 1));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(12, 3, 3, 3));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(13, 3, 8, 6));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(14, 3, 24, 8));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(15, 4, 4, 1));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(16, 4, 8, 6));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(17, 4, 4, 9));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(18, 4, 20, 8));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(19, 5, 2, 1));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(20, 5, 3, 4));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(21, 5, 1, 5));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(22, 5, 36, 8));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(23, 6, 2, 1));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(24, 6, 6, 3));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(25, 6, 12, 7));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(26, 6, 20, 8));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(27, 7, 1, 1));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(28, 7, 11, 2));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(29, 7, 4, 5));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(30, 7, 20, 8));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(31, 8, 2, 1));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(32, 8, 4, 6));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(33, 8, 4, 9));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(34, 8, 16, 8));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(35, 8, 3, 19));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(36, 9, 2, 1));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(37, 9, 3, 4));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(38, 9, 2, 9));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(39, 9, 18, 8));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(40, 9, 3, 17));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(41, 10, 2, 1));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(42, 10, 4, 2));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(43, 10, 2, 9));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(44, 10, 6, 8));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(45, 10, 5, 18));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(46, 11, 3, 1));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(47, 11, 2, 6));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(48, 11, 2, 9));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(49, 11, 2, 8));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(50, 11, 6, 10, 15));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(51, 12, 1, 1));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(52, 12, 5, 9));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(53, 12, 2, 8));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(54, 12, 7, 20));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(55, 13, 2, 1));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(56, 13, 2, 6));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(57, 13, 3, 9));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(58, 13, 6, 8));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(59, 13, 5, 17));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(60, 14, 3, 1));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(61, 14, 2, 4));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(62, 14, 2, 9));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(63, 14, 8, 8));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(64, 14, 5, 17));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(65, 15, 2, 1));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(66, 15, 4, 5));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(67, 15, 2, 9));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(68, 15, 6, 8));
            modelBuilder.Entity<ClassCategoryAffinity>().HasData(new ClassCategoryAffinity(69, 15, 5, 17, 18));
        }
    }
}