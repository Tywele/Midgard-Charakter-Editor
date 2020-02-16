using Microsoft.EntityFrameworkCore;

namespace MidgardCharakterEditor.Database
{
    public interface ISeeder
    {
        void SeedCategories(ModelBuilder modelBuilder);
        void SeedClassCategoryAffinities(ModelBuilder modelBuilder);
        void SeedClassCosts(ModelBuilder modelBuilder);
        void SeedClasses(ModelBuilder modelBuilder);
        void SeedDefenseWeaponTrainingCosts(ModelBuilder modelBuilder);
        void SeedInnateSkills(ModelBuilder modelBuilder);
        void SeedLands(ModelBuilder modelBuilder);
        void SeedLanguages(ModelBuilder modelBuilder);
        void SeedRaces(ModelBuilder modelBuilder);
        void SeedSkillHasCategories(ModelBuilder modelBuilder);
        void SeedSkillLearningCosts(ModelBuilder modelBuilder);
        void SeedSkills(ModelBuilder modelBuilder);
        void SeedSkillTrainingCosts(ModelBuilder modelBuilder);
        void SeedSocialClasses(ModelBuilder modelBuilder);
        void SeedSpells(ModelBuilder modelBuilder);
        void SeedWeapons(ModelBuilder modelBuilder);
    }
}