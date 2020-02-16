using Microsoft.EntityFrameworkCore;

namespace MidgardCharakterEditor.Database
{
    public interface IMidgardContext
    {
        DbSet<Category> Categories { get; set; }
        DbSet<CharacterHasInnateSkill> CharacterHasInnateSkills { get; set; }
        DbSet<CharacterHasLanguage> CharacterHasLanguages { get; set; }
        DbSet<CharacterHasSkill> CharacterHasSkills { get; set; }
        DbSet<CharacterHasSpell> CharacterHasSpells { get; set; }
        DbSet<CharacterHasWeapon> CharacterHasWeapons { get; set; }
        DbSet<Character> Characters { get; set; }
        DbSet<ClassCategoryAffinity> ClassCategoryAffinities { get; set; }
        DbSet<ClassCost> ClassCosts { get; set; }
        DbSet<Class> Classes { get; set; }
        DbSet<DefenseWeaponTrainingCost> DefenseWeaponSkillTrainingCosts { get; set; }
        DbSet<InnateSkill> InnateSkills { get; set; }
        DbSet<Land> Lands { get; set; }
        DbSet<Language> Languages { get; set; }
        DbSet<Race> Races { get; set; }
        DbSet<SkillHasCategory> SkillHasCategories { get; set; }
        DbSet<SkillLearningCost> SkillLearningCost { get; set; }
        DbSet<Skill> Skills { get; set; }
        DbSet<SkillTrainingCost> SkillTrainingCosts { get; set; }
        DbSet<SocialClass> SocialClasses { get; set; }
        DbSet<Spell> Spells { get; set; }
        DbSet<Weapon> Weapons { get; set; }
    }
}