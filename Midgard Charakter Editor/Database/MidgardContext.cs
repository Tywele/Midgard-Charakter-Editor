using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace MidgardCharakterEditor.Database
{
    public class MidgardContext : DbContext, IMidgardContext
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
            var seeder = new Seeder();

            seeder.SeedCategories(modelBuilder);
            seeder.SeedSkillTrainingCosts(modelBuilder);
            seeder.SeedClasses(modelBuilder);
            seeder.SeedClassCosts(modelBuilder);
            seeder.SeedSkills(modelBuilder);
            seeder.SeedSkillHasCategories(modelBuilder);
            seeder.SeedSpells(modelBuilder);
            seeder.SeedDefenseWeaponTrainingCosts(modelBuilder);
            seeder.SeedRaces(modelBuilder);
            seeder.SeedSocialClasses(modelBuilder);
            seeder.SeedWeapons(modelBuilder);
            seeder.SeedSkillLearningCosts(modelBuilder);
            seeder.SeedLanguages(modelBuilder);
            seeder.SeedLands(modelBuilder);
            seeder.SeedInnateSkills(modelBuilder);
            seeder.SeedClassCategoryAffinities(modelBuilder);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<CharacterHasInnateSkill> CharacterHasInnateSkills { get; set; }
        public DbSet<CharacterHasLanguage> CharacterHasLanguages { get; set; }
        public DbSet<CharacterHasSkill> CharacterHasSkills { get; set; }
        public DbSet<CharacterHasSpell> CharacterHasSpells { get; set; }
        public DbSet<CharacterHasWeapon> CharacterHasWeapons { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassCategoryAffinity> ClassCategoryAffinities { get; set; }
        public DbSet<ClassCost> ClassCosts { get; set; }
        public DbSet<DefenseWeaponTrainingCost> DefenseWeaponSkillTrainingCosts { get; set; }
        public DbSet<InnateSkill> InnateSkills { get; set; }
        public DbSet<Land> Lands { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillHasCategory> SkillHasCategories { get; set; }
        public DbSet<SkillLearningCost> SkillLearningCost { get; set; }
        public DbSet<SkillTrainingCost> SkillTrainingCosts { get; set; }
        public DbSet<SocialClass> SocialClasses { get; set; }
        public DbSet<Spell> Spells { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
    }
}
