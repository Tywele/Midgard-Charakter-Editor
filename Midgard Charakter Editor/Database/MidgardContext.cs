using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace MidgardCharakterEditor.Database
{
    public class MidgardContext : DbContext, IMidgardContext
    {
        private readonly ISeeder _seeder;

        public MidgardContext(ISeeder seeder)
        {
            _seeder = seeder;
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={Path.Combine(Environment.CurrentDirectory, "m5editor.db")}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _seeder.SeedCategories(modelBuilder);
            _seeder.SeedSkillTrainingCosts(modelBuilder);
            _seeder.SeedClasses(modelBuilder);
            _seeder.SeedClassCosts(modelBuilder);
            _seeder.SeedSkills(modelBuilder);
            _seeder.SeedSkillHasCategories(modelBuilder);
            _seeder.SeedSpells(modelBuilder);
            _seeder.SeedDefenseWeaponTrainingCosts(modelBuilder);
            _seeder.SeedRaces(modelBuilder);
            _seeder.SeedSocialClasses(modelBuilder);
            _seeder.SeedWeapons(modelBuilder);
            _seeder.SeedSkillLearningCosts(modelBuilder);
            _seeder.SeedLanguages(modelBuilder);
            _seeder.SeedLands(modelBuilder);
            _seeder.SeedInnateSkills(modelBuilder);
            _seeder.SeedClassCategoryAffinities(modelBuilder);
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
