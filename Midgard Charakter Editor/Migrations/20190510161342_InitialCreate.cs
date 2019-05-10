using Microsoft.EntityFrameworkCore.Migrations;

namespace MidgardCharakterEditor.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Abbreviation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DefenseWeaponLearningCosts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Value = table.Column<int>(nullable: false),
                    Cost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefenseWeaponLearningCosts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    ResistanceBonus = table.Column<int>(nullable: false),
                    HealthBonus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    LeadingAttribute = table.Column<string>(nullable: true),
                    Field = table.Column<string>(nullable: true),
                    Untrained = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LearningCosts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Value = table.Column<int>(nullable: false),
                    Easy = table.Column<int>(nullable: false),
                    Normal = table.Column<int>(nullable: false),
                    Hard = table.Column<int>(nullable: false),
                    VeryHard = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearningCosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LearningCosts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SocialClass",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    BonusCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialClass_Categories_BonusCategoryId",
                        column: x => x.BonusCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    ProcessId = table.Column<int>(nullable: false),
                    Agent = table.Column<string>(nullable: true),
                    Reagent = table.Column<string>(nullable: true),
                    CastingCost = table.Column<string>(nullable: true),
                    CastingTime = table.Column<string>(nullable: true),
                    Range = table.Column<string>(nullable: true),
                    Target = table.Column<string>(nullable: true),
                    AffectedArea = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Origin = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    LearningCost = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spells_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Spells_Categories_ProcessId",
                        column: x => x.ProcessId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassCategoryAffinities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClassId = table.Column<int>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassCategoryAffinities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassCategoryAffinities_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassCategoryAffinities_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassCosts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Value = table.Column<int>(nullable: false),
                    ClassId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassCosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassCosts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassCosts_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillHasCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Difficulty = table.Column<int>(nullable: false),
                    SkillId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillHasCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillHasCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillHasCategories_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Damage = table.Column<string>(nullable: true),
                    StormDamage = table.Column<string>(nullable: true),
                    Protection = table.Column<string>(nullable: true),
                    MinStrength = table.Column<int>(nullable: false),
                    MinDexterity = table.Column<int>(nullable: false),
                    MinAgility = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Range = table.Column<string>(nullable: true),
                    WeaponGroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weapons_Skills_WeaponGroupId",
                        column: x => x.WeaponGroupId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    RaceId = table.Column<int>(nullable: true),
                    ClassId = table.Column<int>(nullable: true),
                    Handedness = table.Column<string>(nullable: true),
                    Build = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    SocialClassId = table.Column<int>(nullable: true),
                    Origin = table.Column<string>(nullable: true),
                    Religion = table.Column<string>(nullable: true),
                    Story = table.Column<string>(nullable: true),
                    Strength = table.Column<int>(nullable: false),
                    Dexterity = table.Column<int>(nullable: false),
                    Agility = table.Column<int>(nullable: false),
                    Constitution = table.Column<int>(nullable: false),
                    Intelligence = table.Column<int>(nullable: false),
                    MagicTalent = table.Column<int>(nullable: false),
                    Health = table.Column<int>(nullable: false),
                    Stamina = table.Column<int>(nullable: false),
                    Appearance = table.Column<int>(nullable: false),
                    Charisma = table.Column<int>(nullable: false),
                    Defense = table.Column<int>(nullable: false),
                    Resistance = table.Column<int>(nullable: false),
                    Movement = table.Column<int>(nullable: false),
                    Xp = table.Column<int>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    OpenXp = table.Column<int>(nullable: false),
                    SpellId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Characters_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Characters_SocialClass_SocialClassId",
                        column: x => x.SocialClassId,
                        principalTable: "SocialClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Characters_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharacterHasSkills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CharacterId = table.Column<int>(nullable: true),
                    SkillId = table.Column<int>(nullable: true),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterHasSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterHasSkills_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharacterHasSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharacterHasSpell",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CharacterId = table.Column<int>(nullable: true),
                    SpellId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterHasSpell", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterHasSpell_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharacterHasSpell_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharacterHasWeapon",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CharacterId = table.Column<int>(nullable: false),
                    WeaponId = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false),
                    Specialization = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterHasWeapon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterHasWeapon_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterHasWeapon_Weapons_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Alltag" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 20, "Zauberspruch" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 19, "Lied" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 18, "Dweomer" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 17, "Wundertat" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 16, "Zerstören" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 15, "Verändern" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 13, "Erschaffen" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 12, "Erkennen" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 11, "Bewegen" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 14, "Formen" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 9, "Wissen" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 8, "Waffen" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 7, "Unterwelt" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "Sozial" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Körperbeherrschung" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Kampf" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Halbwelt" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Freiland" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 10, "Beherrschen" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[] { 10, "Dr", "Druide" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[] { 15, "Sc", "Schamane" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[] { 14, "PS", "Priester, Streiter" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[] { 13, "PB", "Priester, Beschützer" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[] { 12, "Ma", "Magier" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[] { 11, "Hx", "Hexer" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[] { 9, "Or", "Ordenskrieger" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[] { 2, "Bb", "Barbar" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[] { 7, "Wa", "Waldläufer" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[] { 6, "Sp", "Spitzbube" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[] { 5, "Kr", "Krieger" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[] { 4, "Hä", "Händler" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[] { 3, "Gl", "Glücksritter" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[] { 1, "As", "Assassine" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[] { 8, "Ba", "Barde" });

            migrationBuilder.InsertData(
                table: "DefenseWeaponLearningCosts",
                columns: new[] { "Id", "Cost", "Value" },
                values: new object[] { 1, 1, 2 });

            migrationBuilder.InsertData(
                table: "DefenseWeaponLearningCosts",
                columns: new[] { "Id", "Cost", "Value" },
                values: new object[] { 2, 2, 3 });

            migrationBuilder.InsertData(
                table: "DefenseWeaponLearningCosts",
                columns: new[] { "Id", "Cost", "Value" },
                values: new object[] { 3, 10, 4 });

            migrationBuilder.InsertData(
                table: "DefenseWeaponLearningCosts",
                columns: new[] { "Id", "Cost", "Value" },
                values: new object[] { 4, 30, 5 });

            migrationBuilder.InsertData(
                table: "DefenseWeaponLearningCosts",
                columns: new[] { "Id", "Cost", "Value" },
                values: new object[] { 5, 50, 6 });

            migrationBuilder.InsertData(
                table: "DefenseWeaponLearningCosts",
                columns: new[] { "Id", "Cost", "Value" },
                values: new object[] { 6, 100, 7 });

            migrationBuilder.InsertData(
                table: "DefenseWeaponLearningCosts",
                columns: new[] { "Id", "Cost", "Value" },
                values: new object[] { 7, 150, 8 });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "HealthBonus", "Name", "ResistanceBonus" },
                values: new object[] { 5, 1, "Zwerg", 3 });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "HealthBonus", "Name", "ResistanceBonus" },
                values: new object[] { 4, -2, "Halbling", 4 });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "HealthBonus", "Name", "ResistanceBonus" },
                values: new object[] { 1, 0, "Mensch", 0 });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "HealthBonus", "Name", "ResistanceBonus" },
                values: new object[] { 2, 0, "Elf", 2 });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "HealthBonus", "Name", "ResistanceBonus" },
                values: new object[] { 3, -3, "Gnom", 4 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 43, null, "Bewegung", "gw", "Schwimmen", 3 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 58, null, "Wissen", "in", "Zauberkunde", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 57, null, "Bewegung", "gs", "Wagenlenken", 3 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 56, null, "Sozial", "pa", "Verstellen", 3 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 55, null, "Sozial", "pa", "Verhören", 3 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 54, null, "Sozial", "pa", "Verführen", 3 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 53, null, "Wissen", "in", "Überleben: Wald", 6 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 52, null, "Wissen", "in", "Überleben: Steppe", 6 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 51, null, "Wissen", "in", "Überleben: Gebirge", 6 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 59, null, "Zaubern", "zt", "Zaubern", 3 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 49, null, "Bewegung", "ko", "Tauchen", 6 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 48, null, "Entdeckung", "gw", "Tarnen", 3 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 47, null, "Fingerfertigkeit", "gs", "Stehlen", 3 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 46, null, "Entdeckung", "in", "Spurensuche", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 45, null, "Wissen", "in", "Sprechen: Sprache", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 44, null, "Fingerfertigkeit", "gs", "Seilkunst", 3 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 42, null, "Wissen", "in", "Schreiben: Sprache", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 50, null, "Wissen", "in", "Tierkunde", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 60, null, "Nahkampfwaffe", null, "Einhandschlagwaffen", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 62, null, "Nahkampfwaffe", null, "Fechtwaffen", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 41, null, "Fingerfertigkeit", "gs", "Schlösser öffnen", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 78, null, "Fernkampfwaffe", null, "Blasrohre", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 77, null, "Fernkampfwaffe", null, "Armbrüste", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 76, null, "Fernkampfwaffe", null, "Wurfspieße", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 75, null, "Fernkampfwaffe", null, "Wurfscheiben", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 74, null, "Fernkampfwaffe", null, "Wurfklingen", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 73, null, "Fernkampfwaffe", null, "Stielwurfwaffen", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 72, null, "Verteidigungswaffe", null, "Parierwaffen", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 71, null, "Verteidigungswaffe", null, "Schilde", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 70, null, "Nahkampfwaffe", null, "Waffenloser Kampf", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 69, null, "Nahkampfwaffe", null, "Zweihandschwerter", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 68, null, "Nahkampfwaffe", null, "Zweihandschlagwaffen", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 67, null, "Nahkampfwaffe", null, "Zauberstäbe", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 66, null, "Nahkampfwaffe", null, "Stockwaffen", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 65, null, "Nahkampfwaffe", null, "Stichwaffen", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 64, null, "Nahkampfwaffe", null, "Spießwaffen", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 63, null, "Nahkampfwaffe", null, "Kettenwaffen", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 61, null, "Nahkampfwaffe", null, "Einhandschwerter", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 40, null, "Bewegung", "gw", "Schleichen", 3 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 17, null, "Sozial", "in", "Gassenwissen", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 38, null, "Körperbeherrschung", "ko", "Körperresistenz", 10 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 16, null, "Kampf", "gs", "Fechten", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 15, null, "Fingerfertigkeit", "gs", "Fallenmechanik", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 14, null, "Entdeckung", "in", "Fallen entdecken", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 13, null, "Fingerfertigkeit", "gs", "Fälschen", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 12, null, "Sozial", "in", "Etikette", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 11, null, "Fingerfertigkeit", "gs", "Erste Hilfe", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 10, null, "Bewegung", "gs", "Bootfahren", 3 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 79, null, "Fernkampfwaffe", null, "Bögen", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 9, null, "Kampf", "gs", "Betäuben", 6 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 7, null, "Kampf", "gs", "Beidhändiger Kampf", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 6, null, "Bewegung", "gw", "Balancieren", 6 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 5, null, "Körperbeherrschung", "st", "Athletik", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 4, null, "Sozial", "pa", "Anführen", 6 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 3, null, "Wissen", "in", "Alchemie", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 2, null, "Bewegung", "gw", "Akrobatik", 6 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 1, null, "Kampf", "gw", "Abwehr", 10 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 8, null, "Sozial", "pa", "Beredsamkeit", 3 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 18, null, "Fingerfertigkeit", "gs", "Gaukeln", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 19, null, "Bewegung", "gw", "Geländelauf", 6 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 20, null, "Wissen", "in", "Gerätekunde", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 37, null, "Körperbeherrschung", "in", "Geistresistenz", 10 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 36, null, "Kampf", "gw", "Reiterkampf", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 35, null, "Bewegung", "gw", "Reiten", 6 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 34, null, "Wissen", "in", "Pflanzenkunde", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 33, null, "Wissen", "in", "Naturkunde", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 32, null, "Fingerfertigkeit", "gs", "Musizieren", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 31, null, "Kampf", "gs", "Meucheln", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 30, null, "Sozial", "in", "Menschenkenntnis", 3 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 29, null, "Körperbeherrschung", "wk", "Meditieren", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 28, null, "Wissen", "in", "Lesen von Zauberschrift", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 27, null, "Bewegung", "ko", "Laufen", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 26, null, "Wissen", "in", "Landeskunde", 6 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 25, null, "Bewegung", "st", "Klettern", 6 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 24, null, "Kampf", "st", "Kampf in Vollrüstung", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 23, null, "Wissen", "in", "Heilkunde", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 22, null, "Fingerfertigkeit", "gs", "Glücksspiel", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 21, null, "Sozial", "in", "Geschäftssinn", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 39, null, "Kampf", "gs", "Scharfschießen", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 80, null, "Fernkampfwaffe", null, "Schleudern", null });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 45, 9, 5, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 82, 9, 9, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 83, 17, 9, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 84, 1, 10, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 85, 2, 10, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 86, 3, 10, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 87, 4, 10, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 88, 5, 10, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 89, 6, 10, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 90, 7, 10, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 91, 8, 10, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 92, 9, 10, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 93, 10, 10, 90 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 94, 11, 10, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 95, 12, 10, 120 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 96, 13, 10, 90 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 97, 14, 10, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 98, 15, 10, 90 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 180, 13, 15, 120 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 181, 14, 15, 120 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 182, 15, 15, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 183, 16, 15, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 184, 17, 15, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 185, 18, 15, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 81, 8, 9, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 106, 6, 11, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 104, 4, 11, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 103, 3, 11, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 102, 2, 11, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 101, 1, 11, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 100, 18, 10, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 99, 16, 10, 120 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 105, 5, 11, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 179, 12, 15, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 80, 7, 9, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 78, 5, 9, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 47, 2, 6, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 48, 3, 6, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 49, 4, 6, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 50, 5, 6, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 51, 6, 6, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 52, 7, 6, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 53, 8, 6, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 54, 9, 6, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 55, 1, 7, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 56, 2, 7, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 57, 3, 7, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 58, 4, 7, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 59, 5, 7, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 60, 6, 7, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 61, 7, 7, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 62, 8, 7, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 63, 9, 7, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 77, 4, 9, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 76, 3, 9, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 75, 2, 9, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 74, 1, 9, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 73, 19, 8, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 72, 9, 8, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 79, 6, 9, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 71, 8, 8, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 69, 6, 8, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 68, 5, 8, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 67, 4, 8, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 66, 3, 8, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 65, 2, 8, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 64, 1, 8, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 70, 7, 8, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 178, 11, 15, 90 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 177, 10, 15, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 176, 9, 15, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 139, 6, 13, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 138, 5, 13, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 137, 4, 13, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 136, 3, 13, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 135, 2, 13, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 134, 1, 13, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 133, 16, 12, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 132, 15, 12, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 131, 14, 12, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 130, 13, 12, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 129, 12, 12, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 128, 11, 12, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 127, 10, 12, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 126, 9, 12, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 125, 8, 12, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 124, 7, 12, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 123, 6, 12, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 109, 9, 11, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 110, 10, 11, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 111, 11, 11, 90 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 112, 12, 11, 90 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 113, 13, 11, 90 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 114, 14, 11, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 140, 7, 13, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 115, 15, 11, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 117, 18, 11, 90 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 118, 1, 12, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 119, 2, 12, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 120, 3, 12, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 121, 4, 12, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 122, 5, 12, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 116, 16, 11, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 141, 8, 13, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 142, 9, 13, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 143, 10, 13, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 162, 12, 14, 90 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 163, 13, 14, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 164, 14, 14, 120 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 165, 15, 14, 120 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 166, 16, 14, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 167, 17, 14, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 161, 11, 14, 90 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 168, 1, 15, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 170, 3, 15, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 171, 4, 15, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 172, 5, 15, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 173, 6, 15, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 174, 7, 15, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 175, 8, 15, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 169, 2, 15, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 46, 1, 6, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 160, 10, 14, 90 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 158, 8, 14, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 144, 11, 13, 90 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 145, 12, 13, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 146, 13, 13, 90 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 147, 14, 13, 120 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 148, 15, 13, 120 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 149, 16, 13, 90 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 159, 9, 14, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 150, 17, 13, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 152, 2, 14, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 153, 3, 14, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 154, 4, 14, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 155, 5, 14, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 156, 6, 14, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 157, 7, 14, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 151, 1, 14, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 108, 8, 11, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 107, 7, 11, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 43, 7, 5, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 19, 1, 3, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 18, 9, 2, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 17, 8, 2, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 16, 7, 2, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 15, 6, 2, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 14, 5, 2, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 13, 4, 2, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 11, 2, 2, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 10, 1, 2, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 9, 9, 1, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 8, 8, 1, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 7, 7, 1, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 6, 6, 1, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 5, 5, 1, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 4, 4, 1, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 1, 1, 1, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 3, 3, 1, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 2, 2, 1, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 44, 8, 5, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 20, 2, 3, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 21, 3, 3, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 12, 3, 2, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 23, 5, 3, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 40, 4, 5, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 41, 5, 5, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 22, 4, 3, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 42, 6, 5, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 38, 2, 5, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 37, 1, 5, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 36, 9, 4, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 39, 3, 5, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 34, 7, 4, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 33, 6, 4, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 35, 8, 4, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 31, 4, 4, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 30, 3, 4, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 29, 2, 4, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 28, 1, 4, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 27, 9, 3, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 26, 8, 3, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 25, 7, 3, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 24, 6, 3, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 32, 5, 4, 20 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 28, 3, 10, 50, 20, 16, 80 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 29, 3, 10, 50, 50, 17, 100 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 30, 3, 20, 50, 50, 18, 100 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 31, 4, 0, 0, 0, 6, 2 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 32, 4, 0, 0, 0, 7, 5 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 33, 4, 0, 0, 0, 8, 10 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 34, 4, 0, 5, 2, 9, 10 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 42, 4, 10, 100, 50, 17, 150 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 36, 4, 0, 20, 5, 11, 20 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 37, 4, 0, 20, 5, 12, 30 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 38, 4, 1, 30, 10, 13, 50 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 39, 4, 2, 50, 10, 14, 50 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 40, 4, 5, 80, 20, 15, 100 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 41, 4, 10, 80, 20, 16, 100 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 43, 4, 20, 100, 50, 18, 200 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 44, 5, 0, 2, 1, 9, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 45, 5, 0, 2, 1, 10, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 27, 3, 5, 20, 20, 15, 80 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 35, 4, 0, 10, 2, 10, 20 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 26, 3, 2, 20, 10, 14, 50 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 6, 1, 2, 10, 2, 14, 20 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 24, 3, 0, 10, 5, 12, 20 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 2, 1, 0, 2, 1, 10, 5 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 3, 1, 0, 5, 1, 11, 10 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 4, 1, 0, 5, 1, 12, 10 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 5, 1, 1, 10, 2, 13, 20 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 46, 5, 0, 5, 2, 11, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 7, 1, 5, 20, 5, 15, 50 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 8, 1, 10, 20, 10, 16, 50 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 9, 1, 10, 50, 10, 17, 100 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 10, 1, 20, 50, 20, 18, 100 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 11, 2, 1, 5, 2, 9, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 25, 3, 1, 10, 10, 13, 30 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 12, 2, 1, 5, 5, 10, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 14, 2, 2, 10, 10, 12, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 15, 2, 2, 20, 10, 13, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 16, 2, 2, 20, 20, 14, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 17, 2, 5, 50, 20, 15, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 18, 2, 5, 50, 20, 16, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 19, 2, 10, 100, 50, 17, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 20, 2, 10, 100, 50, 18, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 21, 3, 0, 2, 2, 9, 5 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 22, 3, 0, 5, 2, 10, 10 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 23, 3, 0, 5, 5, 11, 20 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 13, 2, 1, 10, 5, 11, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 47, 5, 0, 5, 2, 12, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 67, 7, 10, 20, 10, 12, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 49, 5, 2, 10, 10, 14, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 76, 8, 1, 2, 2, 8, 2 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 77, 8, 2, 5, 2, 9, 5 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 78, 8, 2, 5, 5, 10, 10 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 79, 8, 5, 10, 10, 11, 20 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 80, 8, 10, 20, 20, 12, 50 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 81, 8, 20, 50, 50, 13, 100 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 82, 8, 50, 100, 50, 14, 150 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 83, 8, 100, 150, 100, 15, 200 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 84, 8, 100, 200, 150, 16, 300 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 85, 8, 150, 300, 150, 17, 300 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 86, 8, 150, 300, 200, 18, 400 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 87, 9, 1, 2, 2, 9, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 88, 9, 1, 5, 2, 10, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 89, 9, 1, 5, 5, 11, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 90, 9, 1, 10, 5, 12, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 91, 9, 2, 10, 10, 13, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 92, 9, 2, 20, 10, 14, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 93, 9, 5, 20, 20, 15, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 94, 9, 10, 20, 20, 16, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 95, 9, 10, 50, 50, 17, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 96, 9, 20, 50, 50, 18, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 75, 8, 1, 2, 1, 7, 2 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 48, 5, 1, 10, 5, 13, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 74, 8, 1, 1, 1, 6, 1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 72, 7, 50, 100, 100, 17, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 50, 5, 5, 20, 10, 15, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 51, 5, 10, 20, 20, 16, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 52, 5, 10, 50, 20, 17, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 53, 5, 20, 50, 50, 18, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 54, 6, 2, 5, 2, 9, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 55, 6, 2, 5, 2, 10, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 56, 6, 5, 10, 5, 11, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 57, 6, 5, 10, 10, 12, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 58, 6, 10, 20, 10, 13, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 59, 6, 10, 20, 20, 14, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 60, 6, 20, 50, 20, 15, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 61, 6, 20, 50, 50, 16, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 62, 6, 50, 100, 50, 17, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 63, 6, 50, 100, 50, 18, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 64, 7, 2, 5, 5, 9, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 65, 7, 5, 10, 5, 10, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 66, 7, 5, 20, 10, 11, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 68, 7, 10, 30, 20, 13, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 69, 7, 20, 50, 20, 14, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 70, 7, 20, 80, 50, 15, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 71, 7, 50, 80, 50, 16, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 73, 7, 50, 100, 100, 18, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 1, 1, 0, 2, 1, 9, 5 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 86, 8, 2, 1 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 2, 3, 2, 2 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 57, 2, 3, 40 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 56, 4, 4, 39 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 53, 4, 1, 36 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 52, 4, 1, 35 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 51, 1, 1, 35 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 50, 9, 3, 34 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 49, 2, 2, 34 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 48, 9, 3, 33 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 47, 2, 2, 33 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 46, 1, 1, 32 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 45, 7, 3, 31 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 44, 6, 3, 30 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 43, 9, 2, 29 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 42, 5, 3, 29 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 40, 5, 3, 27 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 39, 9, 3, 26 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 38, 5, 1, 25 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 37, 3, 1, 25 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 36, 1, 1, 25 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 35, 4, 4, 24 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 34, 9, 3, 23 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 58, 7, 2, 40 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 59, 7, 2, 41 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 60, 1, 2, 42 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 61, 9, 1, 42 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 83, 9, 3, 58 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 82, 1, 1, 57 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 81, 6, 1, 56 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 80, 6, 2, 55 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 79, 6, 1, 54 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 78, 2, 1, 53 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 77, 2, 1, 52 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 76, 2, 1, 51 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 75, 9, 3, 50 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 74, 2, 2, 50 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 33, 3, 1, 22 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 73, 5, 2, 49 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 71, 2, 3, 48 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 70, 7, 1, 47 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 69, 3, 3, 47 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 68, 7, 2, 46 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 67, 2, 3, 46 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 66, 9, 1, 45 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 65, 1, 2, 45 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 64, 1, 1, 44 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 63, 5, 1, 43 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 62, 1, 1, 43 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 72, 7, 2, 48 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 32, 1, 1, 22 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 41, 9, 1, 28 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 31, 1, 4, 21 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 15, 1, 1, 10 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 94, 8, 3, 9 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 14, 4, 3, 9 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 13, 3, 4, 9 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 93, 8, 1, 8 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 12, 6, 2, 8 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 106, 8, 3, 21 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 11, 4, 4, 7 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 91, 8, 1, 6 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 10, 3, 1, 6 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 95, 8, 3, 10 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 9, 5, 1, 6 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 8, 5, 3, 5 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 7, 4, 2, 5 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 89, 8, 4, 4 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 6, 6, 1, 4 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 5, 4, 2, 4 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 88, 8, 3, 3 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 85, 1, 4, 3 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 4, 9, 3, 3 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 87, 8, 2, 2 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 3, 5, 3, 2 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 90, 8, 1, 5 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 16, 1, 3, 11 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 92, 8, 4, 7 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 96, 8, 4, 11 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 105, 8, 3, 20 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 30, 1, 4, 20 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 17, 9, 2, 11 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 29, 5, 1, 19 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 28, 4, 1, 19 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 103, 8, 3, 18 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 27, 3, 1, 18 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 102, 8, 2, 17 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 26, 7, 1, 17 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 25, 6, 2, 17 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 24, 3, 3, 17 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 104, 8, 3, 19 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 23, 4, 4, 16 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 101, 8, 3, 16 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 19, 6, 1, 12 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 97, 8, 1, 12 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 20, 3, 1, 13 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 98, 8, 2, 13 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 18, 1, 3, 12 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 99, 8, 2, 14 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 22, 7, 3, 15 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 100, 8, 2, 15 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "Difficulty", "SkillId" },
                values: new object[] { 21, 7, 2, 14 });

            migrationBuilder.InsertData(
                table: "SocialClass",
                columns: new[] { "Id", "BonusCategoryId", "Name" },
                values: new object[] { 3, 9, "Mittelschicht" });

            migrationBuilder.InsertData(
                table: "SocialClass",
                columns: new[] { "Id", "BonusCategoryId", "Name" },
                values: new object[] { 4, 6, "Adel" });

            migrationBuilder.InsertData(
                table: "SocialClass",
                columns: new[] { "Id", "BonusCategoryId", "Name" },
                values: new object[] { 1, 3, "Unfrei" });

            migrationBuilder.InsertData(
                table: "SocialClass",
                columns: new[] { "Id", "BonusCategoryId", "Name" },
                values: new object[] { 2, 1, "Volk" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 191, "3-6 m Umkreis", "Luft", "9", "30 sec", 20, null, "2 min, k", 90, 12, "", "Wirbelwind", "el", 11, "0 m", "Luft", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 196, "1 Objekt", "Metall", "1", "10 sec", 20, null, "12 h", 1, 2, "Silberschlüssel (50 GS)", "Zauberschloss", "dä", 11, "Berührung", "Holz", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 192, "-", "Luft", "4", "20 sec", 20, null, "30 min, k", 20, 8, "Auge eines Toten (50 GS)", "Zauberauge", "dä", 11, "500 m", "Feuer", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 193, "1 Wesen", "Erde", "4", "20 sec", 20, null, "1 min, k", 20, 8, "Wachspuppe (20 GS)", "Zauberhand", "dä", 14, "50 m", "Luft", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 194, "Zauberer", "Metall", "4 je Seite", "20 sec", 20, null, "2 min", 15, 7, "Drachenschuppe (100 GS)", "Zauberschild", "dä", 13, "-", "Magan", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 195, "bis zu 6 Wesen", "Magan", "6 je Wesen", "10 sec", 20, null, "24 h", 20, 8, "Lotusblütenstaub und Blutrosendorn (20 GS)", "Zauberschlaf", "dä", 10, "30 m", "Wasser", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 197, "1 Objekt", "Magan", "2", "10 sec", 20, null, "0", 2, 3, "Springwurzspan (50 GS)", "Zauberschlüssel", "dä", 11, "Berührung", "Holz", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 204, "Zauberer", "Feuer", "1", "Augenblick", 20, null, "10 min, k", 1, 2, "", "Zwiesprache", "dä", 12, "500 m", "Luft", "Körper", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 199, "-", "Magan", "2", "10 min", 20, null, "12 h", 2, 3, "Papageienzunge (20 GS)", "Zauberstimme", "dä", 13, "50 m", "Luft", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 200, "6 m Umkreis", "Magan", "9", "3 h", 20, null, "30 min", 90, 12, "Blütenstaub, Essenzen, Edelmetallsplitter (200 GS)", "Zauberwirklichkeit", "dä", 10, "50 m", "Feuer", "Geist", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 201, "Zauberer", "Luft", "4", "1 min", 20, null, "30 min", 15, 7, "Papageienhirn und -zunge (50 GS)", "Zauberzunge", "dä", 12, "-", "Luft", "Geist", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 202, "1 Objekt", "Luft", "2", "10 sec", 20, null, "10 min", 5, 5, "", "Zielsuche", "dr", 14, "Berührung", "Holz", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 203, "Zauberer", "Erde", "var", "Augenblick", 20, null, "10 min", 20, 8, "", "Zweite Haut", "dä", 16, "-", "Magan", "Körper", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 190, "30 m Kegel", "Luft", "1", "Augenblick", 20, null, "10 sec", 1, 2, "", "Windstoß", "el", 11, "0 m", "Luft", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 198, "1 Objekt", "Magan", "03. Sep", "1 min", 20, null, "10 min", 5, 5, "Waffe aus Alchimistenmetall", "Zauberschmiede", "dä", 14, "Berührung", "Metall", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 189, "1 km Umkreis", "Luft", "4", "20 sec", 20, null, "1 h", 20, 8, "Sturmvogelfedern (10 GS)", "Windmeisterschaft", "el", 11, "0 m", "Luft", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 171, "1 Wesen", "Wasser", "3", "10 sec", 20, null, "10 min", 5, 5, "Tierspeichelmischung (20 GS)", "Vertieren", "dä", 10, "30 m", "Luft", "Geist", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 187, "Strahl", "Wasser", "4", "20 sec", 20, null, "1 min, k", 20, 8, "Riesenkrakentrichter (100 GS)", "Wasserstrahl", "el", 13, "5 m", "Wasser", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 300, "1 Wesen", "Wasser", "2", "1 min", 19, null, "6 h", 2, 3, "Harfe oder Laute, Stimme", "Das Lied der Verführung", "-", 10, "5 m", "Wasser", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 301, "15 m Umkreis", "Magan", "2", "1 min", 19, null, "?", 15, 7, "Harfe oder Laute, Stimme", "Das Lied des Vergessens", "-", 15, "-", "Luft", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 302, "1 Wesen", "Magan", "4", "3 min", 19, null, "30 min", 15, 7, "Flöte, Harfe oder Laute, Stimme", "Das Lied der Verzweiflung", "-", 15, "15 m", "Luft", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 303, "15 m Umkreis", "Luft", "2", "1 min", 19, null, "30 min", 2, 3, "Flöte, Harfe oder Laute, Stimme", "Das Lied des Wagemuts", "-", 15, "-", "Feuer", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 304, "30 m Umkreis", "Magan", "4", "3 min", 19, null, "?", 30, 9, "Flöte, Stimme", "Das Lied des Wahnsinns", "-", 16, "-", "Luft", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 305, "30 m Umkreis", "Wasser", "2", "1 min", 19, null, "2 min", 60, 11, "Flöte, Stimme", "Das Lied des Zorns", "-", 10, "-", "Wasser", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 306, "15 m Umkreis", "Magan", "2", "1 min", 19, null, "10 min", 40, 10, "Harfe oder Laute, Stimme", "Das Lied der Zwietracht", "-", 10, "-", "Wasser", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 307, "30 m Umkreis", "Luft", "2", "1 min", 19, null, "1-3 Tage", 2, 3, "Harfe oder Laute, Stimme", "Das Loblied", "-", 15, "-", "Luft", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 308, "15 m Umkreis", "Magan", "4", "3 min", 19, null, "1 min", 10, 6, "Harfe oder Laute, Stimme", "Der betäubende Gesang", "-", 10, "-", "Wasser", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 309, "15 m Umkreis", "Magan", "2", "3 min", 19, null, "1 min", 3, 4, "Harfe oder Laute, Stimme", "Der einschläfernde Gesang", "-", 10, "-", "Wasser", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 310, "15 m Umkreis", "Luft", "2", "1 min", 19, null, "1 min", 3, 4, "Harfe oder Laute, Stimme", "Der frohlockende Gesang", "-", 15, "-", "Luft", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 311, "15 m Umkreis", "Magan", "2", "1 min", 19, null, "1 min", 3, 4, "Harfe oder Laute, Stimme", "Der traurige Gesang", "-", 15, "-", "Luft", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 312, "15 m Umkreis", "Feuer", "2", "1 min", 19, null, "1 min", 2, 3, "Flöte, Harfe oder Laute, Stimme", "Der verunsichernde Gesang", "-", 10, "-", "Luft", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 313, "1 Wesen", "Magan", "2", "1 min", 19, null, "1 min", 1, 2, "Flöte", "Die anfeuernde Ballade", "-", 15, "50 m", "Luft", "Körper", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 314, "15 m Umkreis", "Metall", "2", "1 min", 19, null, "1 min", 1, 2, "Flöte, Harfe oder Laute, Stimme", "Die stählende Ballade", "-", 15, "-", "Luft", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 299, "15 m Umkreis", "Magan", "2", "1 min", 19, null, "0", 10, 6, "Flöte, Stimme", "Das Lied der verborgenen Kraft", "-", 15, "-", "Feuer", "Körper", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 315, "15 m Umkreis", "Metall", "2", "Augenblick", 19, null, "1 min", 10, 6, "Flöte, Harfe oder Laute, Stimme", "Die Hymne der Ordnung", "-", 16, "-", "Magan", "Umgebung", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 298, "15 m Umkreis", "Luft", "0", "10 min", 19, null, "30 min", 1, 1, "Flöte, Harfe oder Laute, Stimme", "Das Lied der Tapferkeit", "-", 15, "-", "Luft", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 296, "30 m Umkreis", "Luft", "2", "3 min", 19, null, "?", 2, 3, "Harfe oder Laute, Stimme", "Das Lied des Spottes", "-", 15, "-", "Luft", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 281, "1 Wesen je Grad", "Holz", "2 je Grad", "10 sec", 18, null, "mind. 2 h", 3, 4, "-", "Tierischer Helfer", "dr", 10, "30 m", "Wasser", "Geist", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 282, "1 m Umkreis", "Holz", "1", "Augenblick", 18, null, "10 min", 1, 2, "Flugsamen verschiedener Pflanzen (5 SS)", "Wandeln wie der Wind", "dr", 14, "0 m", "Erde", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 283, "Zauberer", "Holz", "2", "10 sec", 18, null, "30 min", 2, 3, "Spürhundhaare (5 GS)", "Wittern", "dr", 15, "-", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 284, "Zauberer", "Holz", "1", "Augenblick", 18, null, "30 min", 1, 2, "-", "Wundersame Tarnung", "dr", 14, "-", "Erde", "Umgebung", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 285, "1 Wesen je Grad", "Holz", "1 je Grad", "10 sec", 18, null, "2 h", 1, 2, "-", "Zähmen", "dr", 10, "30 m", "Wasser", "Geist", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 286, "Zauberer", "Holz", "2", "10 sec", 18, null, "10 sec", 2, 3, "-", "Zaubersprung", "dr", 15, "-", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 287, "9 m Umkreis", "Holz", "6", "20 sec", 18, null, "10 min", 20, 8, "-", "Zeichen des Lebens", "dr", 16, "0", "Eis", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 288, "15 m Umkreis", "Magan", "2", "1 min", 19, null, "0", 15, 7, "Harfe oder Laute, Stimme", "Das Lied des Erinnerns", "-", 15, "-", "Luft", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 289, "30 m Umkreis", "Luft", "0", "1 min", 19, null, "30 min", 1, 1, "Flöte, Harfe oder Laute", "Das Lied der Feier", "-", 15, "-", "Luft", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 290, "30 m Umkreis", "Luft", "2", "Augenblick", 19, null, "3 min", 2, 3, "Flöte, Harfe oder Laute", "Das Lied des Fesselns", "-", 10, "-", "Luft", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 291, "15 m Umkreis", "Metall", "2", "1 min", 19, null, "10 min", 40, 10, "Harfe oder Laute, Stimme", "Das Lied des Friedens", "-", 10, "-", "Wasser", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 292, "200 m Kegel", "Eis", "4", "1 min", 19, null, "1 min", 30, 9, "Flöte, Stimme", "Das Lied des Grauens", "-", 10, "-", "Wasser", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 293, "1 Wesen", "Wasser", "0", "1 min", 19, null, "?", 15, 7, "Harfe oder Laute, Stimme", "Das Lied der Liebe", "-", 10, "15 m", "Wasser", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 294, "200 m Kegel", "Magan", "2", "1 min", 19, null, "1 min", 20, 8, "Flöte", "Das Lied der Lockung", "-", 10, "-", "Wasser", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 295, "30 m Umkreis", "Wasser", "2", "1 min", 19, null, "2 h", 2, 3, "Flöte, Harfe oder Laute", "Das Lied der Ruhe", "-", 10, "-", "Wasser", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 297, "30 m Umkreis", "Magan", "2", "1 min", 19, null, "1 min", 5, 5, "Flöte", "Das Lied der Tanzlust", "-", 10, "-", "Erde", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 280, "Zauberer", "Wasser", "6", "20 sec", 18, null, "?", 30, 9, "Fellstück, Feder usw. (1 GS)", "Tiergestalt", "dr", 15, "-", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 316, "15 m Umkreis", "Magan", "2", "1 min", 19, null, "0", 10, 6, "Flöte, Harfe oder Laute, Stimme", "Die Klänge der Genesung", "-", 15, "-", "Erde", "Körper", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 318, "15 m Umkreis", "Magan", "2", "3 min", 19, null, "0", 5, 5, "Flöte, Harfe oder Laute, Stimme", "Die Klänge des Zusammenwachsens", "-", 15, "-", "Erde", "Körper", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 19, "1-10 Strahlen", "Luft", "2 je Blitz", "10 sec", 20, null, "0", 10, 6, "getrocknetes Zitteraalherz (5 GS)", "Blitze schleudern", "dä", 13, "200 m", "Feuer", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 20, "1 Wesen", "Eis", "2", "10 sec", 20, null, "?", 3, 4, "", "Böser Blick", "sm", 16, "15 m", "Holz", "Körper", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 21, "-", "Holz", "3", "10 min", 20, null, "0", 1, 1, "Mehlstaub und Wassertropfen (1 GS)", "Brot und Wasser", "dä", 13, "0 m", "Wasser", "Umgebung", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 22, "Strahl", "Magan", "3", "10 sec", 20, null, "2 min, k", 5, 5, "Phosphor (50 GS)", "Dämonenfeuer", "dä", 13, "30 m", "Magan", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 23, "Strahl", "Magan", "4", "10 sec", 20, null, "2 min, k", 10, 6, "Phosphor (50 GS)", "Dämonenkugeln", "dä", 13, "50 m", "Magan", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 24, "-", "Magan", "4", "10 sec", 20, null, "2 min", 10, 6, "Phosphor (50 GS)", "Dämonenschwert", "dä", 13, "0 m", "Magan", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 25, "Zauberer", "Magan", "1", "10 min", 20, null, "10 min", 2, 3, "", "Dämonische Zaubermacht", "dä", 15, "-", "Wasser", "Körper", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 26, "6 m Umkreis", "Magan", "6", "10 sec", 20, null, "8 h, k", 15, 7, "Goldreif (50 GS)", "Deckmantel", "dä", 16, "0 m", "Magan", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 27, "1 Objekt", "Magan", "1", "10 min", 20, null, "12 h", 1, 1, "", "Dinge verbergen", "dä", 16, "Berührung", "Magan", "Geist", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 28, "1 Objekt", "Magan", "1", "10 min", 20, null, "10 min", 1, 1, "", "Dinge wiederfinden", "dä", 12, "unbegrenzt", "Metall", "Geist", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 29, "Strahl", "Luft", "4", "10 sec", 20, null, "0", 20, 8, "Murmeln aus Donnerechsenhorn (50 GS)", "Donnerkeil", "dä", 13, "50 m", "Feuer", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 30, "100 m Umkreis", "Magan", "1", "10 sec", 20, null, "10 min", 1, 1, "Kristallauge (10 GS)", "Drittes Auge", "el", 12, "0 m", "Feuer", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 31, "-", "Holz", "1 je m Breite", "10 sec", 20, null, "10 min", 3, 4, "Smaragd (50 GS)", "Dschungelwand", "el", 13, "15 m", "Holz", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 32, "1 Wesen", "Metall", "4", "20 sec", 20, null, "2 min", 15, 7, "Eisenpulver (20 GS)", "Eisenhaut", "dä", 15, "Berührung", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 33, "3 m Umkreis", "Eis", "1 je m²", "10 sec", 20, null, "1 min", 2, 3, "Bergkristall (20 GS)", "Eisiger Nebel", "el", 13, "50 m", "Eis", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 18, "1 Wesen/Objekt", "Magan", "4", "10 sec", 20, null, "1W6x10 min", 20, 8, "Goldstaub (50 GS)", "Blendwerk", "dä", 10, "50 m", "Feuer", "Geist", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 317, "1 Wesen", "Metall", "1", "5 min", 19, null, "0", 5, 5, "Harfe oder Laute, Stimme", "Die Klänge der Linderung", "-", 15, "15 m", "Luft", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 17, "-", "Feuer", "4", "Augenblick", 20, null, "1 min", 20, 8, "", "Blenden", "gö", 13, "9 m Umkreis", "Feuer", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 15, "3 m Umkreis", "Luft", "2", "20 sec", 20, null, "2 min", 2, 3, "", "Blaue Bannsphäre", "gö", 10, "0 m", "Eis", "Geist", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 319, "1 Wesen", "Feuer", "2", "1 min", 19, null, "2 min", 5, 5, "Stimme", "Die überzeugende Stimme", "-", 10, "15 m", "Luft", "Geist", "-" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 1, "max 10 Wesen", "Feuer", "2 je Wesen", "Augenblick", 20, null, "10 min", 1, 2, "", "Angst", "dr", 10, "30 m", "Wasser", "Geist", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 2, "1 Wesen", "Luft", "2", "10 sec", 20, null, "2 h", 1, 2, "", "Anstacheln", "dä", 10, "-", "Wasser", "Geist", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 3, "1 Wesen", "Wasser", "2", "10 sec", 20, null, "6 h", 1, 2, "", "Anziehen", "dä", 10, "30 m", "Wasser", "Geist", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 188, "bis zu 10 m²", "Eis", "4", "20 sec", 20, null, "var", 15, 7, "reines Eis (50 GS)", "Wasserwandlung", "el", 14, "200 m", "Wasser", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 5, "1 m Umkreis", "Magan", "8", "30 sec", 20, null, "2 min, k", 90, 12, "Moder, Staub, Knochenmehl, Rostflocken (20 GS)", "Auflösung", "dä", 16, "30 m", "Metall", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 6, "1 Wesen", "Eis", "2", "10 sec", 20, null, "2 min", 3, 4, "", "Auskühlen", "el", 15, "15 m", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 7, "3 m Umkreis", "Feuer", "4", "10 min", 20, null, "8 h", 5, 5, "Holzkohlestück (1 SS)", "Bannen von Kälte", "el", 16, "0 m", "Eis", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 8, "9 m Umkreis", "Eis", "1", "Augenblick", 20, null, "10 min", 1, 2, "", "Bannen von Licht", "gö", 16, "0 m", "Feuer", "Umgebung", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 9, "1 Wesen/Objekt", "Metall", "4", "2 min", 20, null, "0", 3, 4, "", "Bannen von Zauberwerk", "dä", 16, "15 m", "Magan", "Umgebung", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 10, "1 Wesen", "Feuer", "3", "10 sec", 20, null, "10 min", 5, 5, "", "Beeinflussen", "dä", 10, "15 m", "Luft", "Geist", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 11, "1 Objekt", "Magan", "2", "1 min", 20, null, "1 Monat", 1, 2, "eigener Speichel", "Befestigen", "dä", 11, "Berührung", "Metall", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 12, "1 Wesen", "Wasser", "1 je Grad", "10 sec", 20, null, "0", 2, 3, "", "Besänftigen", "dä", 10, "30 m", "Wasser", "Geist", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 13, "1 Wesen", "Magan", "6", "10 sec", 20, null, "1 min", 10, 6, "", "Beschleunigen", "dä", 15, "15 m", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 14, "1 km Umkreis", "Wasser", "3", "Augenblick", 20, null, "2 h", 10, 6, "", "Binden des Vertrauten", "dä", 10, "Berührung", "Wasser", "Geist", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 16, "6 m Umkreis", "Luft", "4", "20 sec", 20, null, "10 min", 15, 7, "Eichenholzreif (20 GS)", "Blauer Zwingkreis", "gö", 10, "30 m", "Eis", "Geist", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 34, "-", "Eis", "1 je m Breite", "10 sec", 20, null, "10 min", 3, 4, "Diamant (50 GS)", "Eiswand", "el", 13, "15 m", "Eis", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 279, "1-10 Wesen", "Holz", "3-9", "10 sec", 18, null, "10 min", 5, 5, "-", "Tiere rufen", "dr", 10, "2 km", "Wasser", "Geist", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 277, "Zauberer", "Luft", "3", "10 sec", 18, null, "bis zu 30 min", 5, 5, "-", "Schutzgeist", "dr", 11, "Berührung", "Erde", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 224, "6 m Umkreis", "Metall", "3 je Person", "5 min", 17, null, "1 h", 5, 5, "", "göttlicher Schutz vor Magie", "gö", 15, "0 m", "Wasser", "Körper", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 225, "1 Wesen", "Luft", "1", "10 sec", 17, null, "0", 1, 2, "", "Handauflegen", "gö", 13, "Berührung", "Feuer", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 226, "1 Wesen", "Holz", "4", "10 min", 17, null, "0", 10, 6, "", "Heilen schwerer Wunden", "gö", 13, "Berührung", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 227, "1 Wesen", "Holz", "2", "10 min", 17, null, "0", 3, 4, "", "Heilen von Krankheit", "gö", 16, "Berührung", "Eis", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 228, "1 Wesen", "Luft", "3", "1 min", 17, null, "0", 3, 4, "", "Heilen von Wunden", "gö", 13, "Berührung", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 229, "Zauberer", "Luft", "2", "Augenblick", 17, null, "2 min", 1, 2, "", "Heiliger Zorn", "gö", 15, "-", "Erde", "Körper", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 230, "9 m Umkreis", "Metall", "6", "10 sec", 17, null, "var", 15, 7, "", "Heiliges Wort", "gö", 16, "0 m", "Magan", "Körper", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 231, "1 Wesen", "Luft", "3", "1 min", 17, null, "bis zu 10 min", 3, 4, "", "Himmlicher Beschützer", "gö", 11, "Berührung", "Erde", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 232, "1-10 Wesen", "Magan", "3-9", "10 sec", 17, null, "10 min", 3, 4, "", "Himmlicher Helfer", "gö", 10, "2 km", "Wasser", "Geist", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 233, "1 kg", "Holz", "1", "10 min", 17, null, "0", 1, 1, "", "Reinigen", "gö", 16, "1 m", "Eis", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 234, "Zauberer", "Luft", "5", "20 sec", 17, null, "2 min", 20, 8, "", "Rüstung der Rechtschaffenen", "gö", 15, "Berührung", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 235, "Zauberer", "Feuer", "1 + 1 je 10 sec", "10 sec", 17, null, "var, k", 1, 2, "", "Schützende Hülle", "gö", 13, "-", "Holz", "Körper", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 236, "1 Objekt", "Luft", "1", "10 sec", 17, null, "2 min", 1, 2, "Wurfkeule aus Holz", "Schwingenkeule", "gö", 14, "Berührung", "Holz", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 237, "1 Wesen", "Holz", "2", "10 min", 17, null, "0", 3, 4, "", "Seelenheilung", "gö", 15, "3 m", "Luft", "Geist", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 238, "1 Wesen", "Luft", "2", "1 min", 17, null, "10 min", 2, 3, "", "Segnen", "gö", 15, "Berührung", "Wasser", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 223, "Zauberer", "Luft", "2", "10 min", 17, null, "1 h", 1, 1, "", "göttlicher Schutz v. d. Bösen", "gö", 15, "-", "Wasser", "Körper", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 239, "Zauberer", "Feuer", "2", "1 sec", 17, null, "2 min", 3, 4, "", "Strahlender Panzer", "gö", 14, "Berührung", "Metall", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 222, "3 m Umkreis", "Metall", "2", "10 sec", 17, null, "2 min, k", 3, 4, "", "göttlicher Schirm", "gö", 16, "0 m", "Magan", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 220, "Zauberer", "Luft", "4", "30 min", 17, null, "10 min", 20, 8, "", "göttliche Eingebung", "gö", 12, "-", "Luft", "Geist", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 205, "1 Wesen", "Holz", "6", "30 min", 17, null, "0", 30, 9, "", "Allheilung", "gö", 13, "Berührung", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 206, "Zauberer", "Metall", "2", "10 sec", 17, null, "2 min", 2, 3, "", "Arm der götter", "gö", 15, "-", "Holz", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 207, "1 Wesen", "Magan", "5", "10 min", 17, null, "0", 3, 4, "", "Austreibung des Bösen", "gö", 11, "15 m", "Feuer", "Körper", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 208, "9 m Umkreis", "Feuer", "1", "Augenblick", 17, null, "10 min", 1, 2, "", "Bannen von Dunkelheit", "gö", 13, "0 m", "Feuer", "Umgebung", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 209, "1 Wesen/Objekt", "Magan", "4", "10 sec", 17, null, "0", 3, 4, "", "Bannen von Finsterwerk", "gö", 16, "15 m", "Magan", "Umgebung", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 210, "1 Wesen", "Holz", "4", "10 sec", 17, null, "0", 3, 4, "", "Bannen von Gift", "dr", 16, "3m", "Eis", "Körper", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 211, "15 m Umkreis", "Luft", "1 je Grad", "10 sec", 17, null, "0", 5, 5, "", "Beruhigen", "gö", 10, "0 m", "Wasser", "Geist", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 212, "Zauberer", "Erde", "1 + 1 je Wunde", "10 sec", 17, null, "60 min", 1, 2, "", "Blutmeisterschaft", "gö", 15, "-", "Holz", "Körper", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 213, "1 Wesen", "Luft", "alle", "6 h", 17, null, "0", 90, 12, "", "Erheben der Toten", "gö", 13, "1 m", "Holz", "Körper", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 214, "1 Wesen", "Luft", "4", "20 sec", 17, null, "0", 3, 4, "", "Erholung", "gö", 13, "Berührung", "Feuer", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 215, "30 m Kegel", "Luft", "1", "Augenblick", 17, null, "0", 1, 2, "", "Erkennen der Aura", "gö", 12, "0 m", "Luft", "Geist", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 216, "30 m Kegel", "Luft", "2", "10 sec", 17, null, "10 sec", 2, 3, "", "Erkennen von Besessenheit", "gö", 12, "0 m", "Feuer", "Geist", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 217, "1 Wesen", "Luft", "1", "10 min", 17, null, "0", 1, 2, "", "Erkennen von Krankheit", "dr", 12, "Berührung", "Eis", "Geist", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 218, "1 Objekt", "Luft", "3", "1 min", 17, null, "10 min", 5, 5, "geweihte Waffe", "Goldene Wehr", "gö", 14, "Berührung", "Metall", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 219, "Zauberer", "Luft", "4", "1 min", 17, null, "10 min", 5, 5, "", "Gottesgabe", "gö", 15, "0 m", "Wasser", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 221, "Strahl", "Luft", "3", "10 sec", 17, null, "2 min, k", 5, 5, "", "göttlicher Blitz", "gö", 13, "30 m", "Feuer", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 278, "-", "Holz", "2", "10 sec", 18, null, "1 min, k", 3, 4, "-", "Schwarm", "dr", 11, "50 m", "Erde", "Umgebung", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 240, "1 Wesen", "Luft", "2", "10 sec", 17, null, "10 min", 2, 3, "", "Verfluchen", "gö", 15, "15 m", "Wasser", "Körper", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 242, "1 Objekt", "Luft", "3-9", "1 min", 17, null, "10 min", 5, 5, "", "Waffensegen", "gö", 14, "Berührung", "Metall", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 262, "Zauberer", "Holz", "3", "10 sec", 18, null, "10 min", 5, 5, "-", "Laufen wie der Wind", "dr", 15, "-", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 263, "bis zu 6 Wesen", "Holz", "1 je Wesen", "10 sec", 18, null, "2 min", 2, 3, "Zunder (1 SS)", "Lebensflammen", "dr", 13, "Berührung", "Holz", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 264, "1 Objekt", "Holz", "2", "10 sec", 18, null, "2 min", 5, 5, "Waffe aus Holz", "Lebenskeule", "dr", 14, "Berührung", "Holz", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 265, "1 Wesen", "Holz", "3", "1 min", 18, null, "0", 5, 5, "-", "Lebensrettung", "dr", 13, "Berührung", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 266, "1 Wesen", "Holz", "4", "20 sec", 18, null, "30 min", 3, 4, "-", "Lebensstärkung", "dr", 13, "Berührung", "Feuer", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 267, "1 Wesen", "Holz", "5", "10 min", 18, null, "0", 15, 7, "-", "Lindern von Entkräftung", "dr", 13, "Berührung", "Feuer", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 268, "1 Wesen", "Holz", "2", "10 min", 18, null, "0", 2, 3, "-", "Lindern von Krankheit", "dr", 16, "Berührung", "Eis", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 269, "Zauberer", "Holz", "1", "Augenblick", 18, null, "10 sec", 1, 1, "-", "Linienlesen", "dr", 12, "bis zu 5 km", "Holz", "Geist", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 270, "Zauberer", "Luft", "4", "20 sec", 18, null, "1 h", 20, 8, "-", "Linienwanderung", "dr", 11, "-", "Feuer", "Körper", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 271, "bis zu 10 Wesen", "Holz", "2 je Wesen", "Augenblick", 18, null, "10 min", 1, 2, "-", "Mutlosigkeit", "dr", 10, "30 m", "Wasser", "Geist", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 272, "-", "Holz", "3", "5 min", 18, null, "2 min", 3, 4, "Weißdornpfeife bzw. Schamanentrommel", "Naturgeist rufen", "dr", 10, "500 m", "Holz", "Geist", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 273, "1 Wesen", "Holz", "2", "10 sec", 18, null, "10 min", 3, 4, "Eichenrinde (2 SS)", "Rindenhaut", "dr", 15, "Berührung", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 274, "bis zu 18 m Umkreis", "Holz", "4", "Augenblick", 18, null, "1 min", 5, 5, "Samen des Lebenskrautes (5 GS)", "Ring des Lebens", "dr", 16, "0 m", "Eis", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 275, "Zauberer", "Holz", "6", "10 sec", 18, null, "1 min", 20, 8, "-", "Schlachtenwahnsinn", "dr", 15, "-", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 276, "1 Wesen", "Holz", "4", "10 min", 18, null, "0", 10, 6, "-", "Schnellheilung", "dr", 13, "Berührung", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 261, "1 Wesen", "Holz", "1", "Augenblick", 18, null, "0", 1, 1, "-", "Kraftspende", "dr", 11, "30 m", "Feuer", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 241, "Zauberer", "Wasser", "alle (mind. 3)", "6 h", 17, null, "1 h", 10, 6, "Lebensmittel, Kräute, Pulver (20 GS)", "Vision", "gö", 12, "-", "Luft", "Geist", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 260, "Pflanzen", "Holz", "6", "20 sec", 18, null, "2 min", 30, 9, "pulverisierte Wurzeln, Frühlingsregen (20 GS)", "Grüne Hand", "dr", 14, "Berührung", "Holz", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 258, "-", "Holz", "4", "10 sec", 18, null, "2 min", 10, 6, "Turmalin (50 GS)", "Feenschwert", "dr", 13, "0 m", "Holz", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 243, "Zauberer", "Luft", "6", "10 sec", 17, null, "1 min", 10, 6, "", "Waffenwirbel", "gö", 15, "15 m", "Erde", "Körper", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 244, "1 Wesen", "Luft", "2", "10 sec", 17, null, "2 min", 2, 3, "", "Wagemut", "gö", 15, "15 m", "Feuer", "Geist", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 245, "9 m Umkreis", "Holz", "6", "10 sec", 17, null, "var", 20, 8, "", "Wort des Lebens", "gö", 16, "0 m", "Eis", "Körper", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 246, "9 m Umkreis", "Luft", "6", "10 sec", 17, null, "var", 20, 8, "", "Wort der Trauer", "gö", 16, "0 m", "Eis", "Geist", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 247, "Zauberer", "Holz", "2", "Augenblick", 18, null, "2 min", 1, 2, "eigenes Blut", "Bärenwut", "dr", 15, "-", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 248, "1 Wesen", "Holz", "4", "10 sec", 18, null, "0", 3, 4, "-", "Bannen von Gift", "dr", 16, "3 m", "Eis", "Körper", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 249, "Zauberer", "Holz", "1", "Augenblick", 18, null, "90 min", 1, 2, "-", "Baum", "dr", 15, "-", "Erde", "Körper", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 250, "Strahl", "Holz", "3", "10 sec", 18, null, "2 min, k", 5, 5, "Turmalin (50 GS)", "Elfenfeuer", "dr", 13, "30 m", "Holz", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 251, "1 Objekt", "Holz", "2", "10 sec", 18, null, "10 min", 5, 5, "Waffe mit Elfenstahlklinge", "Elfenklinge", "dr", 14, "Berührung", "Metall", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 252, "1 Objekt", "Holz", "2", "30 sec", 18, null, "0", 3, 4, "-", "Entgiften", "dr", 16, "3 m", "Eis", "Umgebung", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 253, "1 m²", "Holz", "2", "Augenblick", 18, null, "0", 3, 4, "-", "Erkennen von Gift", "dr", 12, "15 m", "Eis", "Geist", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 254, "1 Wesen", "Holz", "1", "10 min", 18, null, "0", 1, 2, "-", "Erkennen von Krankheit", "dr", 12, "Berührung", "Eis", "Geist", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 255, "1-6 Wesen", "Holz", "1 je Wesen", "1 min", 18, null, "30 min", 2, 3, "Tierkot (1 GS)", "Fährtendurft", "dr", 15, "Berührung", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 256, "1 Wesen", "Holz", "2", "10 sec", 18, null, "?", 5, 5, "-", "Feenfluch", "dr", 15, "15 m", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 257, "bis zu 7 Wesen", "Holz", "6", "10 min", 18, null, "8 h", 10, 6, "Zweige von Eiche, Esche und Weißdorn (2 GS), Stück Kaltes Eisen", "Feenschutz", "dr", 15, "30 m", "Luft", "Geist", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 259, "Strahl", "Holz", "4", "10 sec", 18, null, "2 min, k", 10, 6, "Turmalin (50 GS)", "Feuerbienen", "dr", 13, "50 m", "Holz", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 35, "bis zu 10 m²", "Wasser", "3", "10 sec", 20, null, "var", 5, 5, "reinstes Wasser (50 GS)", "Eiswandlung", "el", 14, "200 m", "Eis", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 4, "1 Objekt", "Magan", "1", "10 sec", 20, null, "30 min", 1, 1, "", "Auffrischen", "dr", 14, "15 m", "Metall", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 37, "1 Objekt", "Magan", "2", "30 sec", 20, null, "0", 3, 4, "", "Entgiften", "dr", 16, "3 m", "Eis", "Umgebung", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 133, "5 m Umkreis", "Magan", "var", "Augenblick", 20, null, "10 min", 20, 8, "", "Schwarze Zone", "dä", 16, "0 m", "Magan", "Umgebung", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 134, "Zauberer", "Luft", "6", "20 sec", 20, null, "1 min", 30, 9, "Kolibriflügel (100 GS)", "Schweben", "dä", 11, "-", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 135, "1 Objekt", "Luft", "4", "1 min", 20, null, "0", 5, 5, "", "Schwerelosigkeit", "el", 11, "Berührung", "Metall", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 136, "1 Wesen", "Feuer", "2", "1 min", 20, null, "10 min", 2, 3, "Silbernadel (10 GS) und Haar der Zielperson", "Seelenkompass", "dä", 12, "6 km", "Luft", "Geist", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 137, "Zauberer", "Feuer", "2", "1 min", 20, null, "30 min", 2, 3, "", "Sehen in Dunkelheit", "dä", 15, "50 m", "Feuer", "Körper", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 138, "-", "Magan", "1", "1 min", 20, null, "10 min, k", 2, 3, "", "Sehen von Verborgenem", "dä", 14, "30 cm", "Metall", "Umgebung", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 139, "3 m Umkreis", "Luft", "2", "20 sec", 20, null, "2 min", 3, 4, "", "Silberne Bannsphäre", "gö", 10, "0 m", "Feuer", "Geist", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 140, "6 m Umkreis", "Luft", "4", "20 sec", 20, null, "10 min", 20, 8, "Silberreif (50 GS)", "Silberner Zwingkreis", "gö", 10, "30 m", "Feuer", "Geist", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 141, "1 Wesen", "Magan", "1", "Augenblick", 20, null, "2 min", 1, 2, "Silberstaub (2 GS)", "Silberstaub", "dä", 13, "Berührung", "Metall", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 142, "Zauberer", "Magan", "6", "10 sec", 20, null, "30 sec", 30, 9, "", "Spruch intensivieren", "dä", 15, "-", "Magan", "Geist", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 143, "1-10 Wesen", "Magan", "1 je Wesen", "Augenblick", 20, null, "2 min", 1, 2, "getrockneter Fliegenpilz (1 GS)", "Stärke", "dä", 15, "30 m", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 36, "bis zu 1 m²", "Ausgangselement", "6", "var", 20, null, "?", 5, 5, "Edelstein (100 GS)", "Elementenwandlung", "el", 14, "5 m", "Zielelement", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 145, "-", "Erde", "1 je m", "10 sec", 20, null, "10 min", 3, 4, "Bernstein (50 GS)", "Steinwand", "el", 13, "15 m", "Erde", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 146, "3 m Umkreis", "Metall", "2", "Augenblick", 20, null, "1 min", 2, 3, "pulverisierte Eulenfedern (2 GS)", "Stille", "dä", 14, "0 m", "Luft", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 147, "-", "Magan", "1", "Augenblick", 20, null, "2 min", 1, 2, "", "Stimmenwerfen", "dä", 11, "15 m", "Luft", "Umgebung", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 132, "5 m Umkreis", "Magan", "var", "20 sec", 20, null, "10 min", 15, 7, "", "Schwarze Sphäre", "dä", 16, "0 m", "Wasser", "Umgebung", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 148, "1 Wesen", "Luft", "4", "10 sec", 20, null, "0", 20, 8, "", "Sturmhand", "el", 11, "Berührung", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 131, "1-10 Wesen", "Magan", "1 je Wesen", "Augenblick", 20, null, "2 min", 1, 1, "Eschenrinde (1 GS)", "Schwäche", "dä", 15, "30 m", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 129, "1 Wesen", "Holz", "6", "20 sec", 20, null, "10 min", 10, 6, "", "Schrumpfen", "dä", 15, "Berührung", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 114, "1 Wesen", "Eis", "5", "Augenblick", 20, null, "0", 40, 10, "Pestkrötenklaue (50 GS)", "Pestklaue", "sm", 16, "Berührung", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 115, "10 m Umkreis", "Feuer", "4", "20 sec", 20, null, "2 min", 10, 6, "Samenmischung (10 GS)", "Pflanzenfessel", "dr", 11, "50 m", "Holz", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 116, "9 m Umkreis", "Feuer", "2", "10 sec", 20, null, "10 min", 3, 4, "Asche und Zunder (1 GS)", "Rauchwolke", "el", 14, "30 m", "Luft", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 117, "1 Wesen", "Magan", "1", "30 sec", 20, null, "10 min", 1, 2, "", "Reaktionsschnelle", "dä", 15, "30 m", "Feuer", "Geist", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 118, "Zauberer", "Luft", "6", "30 min", 20, null, "var", 20, 8, "", "Reise der Seele", "dr", 11, "-", "Feuer", "Geist", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 119, "1 Objekt", "Eis", "2", "Augenblick", 20, null, "0", 1, 1, "", "Rost", "dä", 14, "Berührung", "Metall", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 120, "Zauberer", "Magan", "2", "10 sec", 20, null, "10 min", 2, 3, "Golddrahtreif (10 GS)", "Schallwächter", "el", 12, "15 m", "Luft", "Geist", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 121, "1 Wesen", "Magan", "1", "1 min", 20, null, "10 min", 1, 1, "", "Scharfblick", "dä", 15, "Berührung", "Feuer", "Körper", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 122, "Zauberer", "Magan", "2", "10 sec", 20, null, "10 min", 2, 3, "", "Schattenrobe", "dä", 14, "-", "Feuer", "Umgebung", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 123, "100 m Umkreis", "Eis", "4", "20 sec", 20, null, "30 min", 15, 7, "", "Schattenschrecken", "dä", 11, "0 m", "Feuer", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 124, "15 m Umkreis", "Eis", "1", "Augenblick", 20, null, "10 min", 1, 1, "", "Schatten verstärken", "dä", 14, "0 m", "Feuer", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 125, "bis zu 6 Wesen", "Magan", "4 je Wesen", "10 sec", 20, null, "8 h", 5, 5, "Lotusblütenstaub (10 GS)", "Schlaf", "dä", 10, "30 m", "Wasser", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 126, "1 Wesen", "Eis", "4", "10 sec", 20, null, "2 min", 15, 7, "Schlangengift (20 GS)", "Schlangenbiss", "dä", 15, "Berührung", "Holz", "Körper", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 127, "bis zu 6 Wesen", "Magan", "2 je Wesen", "10 sec", 20, null, "30 min", 1, 1, "Baldrianwurzel (5 GS)", "Schlummer", "dä", 10, "30 m", "Wasser", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 128, "1 Wesen", "Magan", "2", "10 sec", 20, null, "1 min", 3, 4, "Silber- oder Knochennadel (5 GS)", "Schmerzen", "dä", 16, "30 m", "Feuer", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 130, "Zauberer", "Metall", "2", "Augenblick", 20, null, "0", 5, 5, "", "Schutzgeste", "gö", 15, "-", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 113, "1 Wesen", "Magan", "2", "10 min", 20, null, "10 min", 2, 3, "", "Person wiederfinden", "dä", 12, "unbegrenzt", "Luft", "Geist", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 149, "30 m Kegel", "Luft", "6", "20 sec", 20, null, "2 min, k", 40, 10, "", "Sturmwind", "el", 11, "0 m", "Luft", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 151, "1 Objekt", "Erde", "6", "10 sec", 20, null, "10 sec", 30, 9, "Zauberkiesel", "Thursenstein", "dr", 14, "Berührung", "Erde", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 172, "1 Wesen", "Eis", "2", "Augenblick", 20, null, "3W6 Tage", 3, 4, "", "Verursachen von Krankheit", "dä", 15, "Berührung", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 173, "1 Wesen", "Eis", "3", "Augenblick", 20, null, "0", 5, 5, "", "Verursachen schw. Wunden", "sm", 16, "Berührung", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 174, "1 Wesen", "Eis", "1", "Augenblick", 20, null, "0", 2, 3, "", "Verursachen von Wunden", "sm", 16, "Berührung", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 175, "1 Wesen", "Holz", "mind. 9", "30 sec", 20, null, "?", 60, 11, "Kern des Großen Kürbis (100 GS)", "Verwandlung", "dä", 15, "Berührung", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 176, "1 Wesen", "Magan", "1 je Grad", "Augenblick", 20, null, "10 sec", 1, 2, "", "Verwirren", "dä", 10, "30 m", "Feuer", "Geist", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 177, "bis zu 6 Wesen", "Luft", "2 je Wesen", "10 sec", 20, null, "30 min", 3, 4, "", "Verwünschen", "dä", 15, "15 m", "Wasser", "Körper", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 178, "1 Wesen", "Magan", "5", "10 sec", 20, null, "1 h", 20, 8, "in Alkohol gelöste Kräutermischung (50 GS)", "Verzweiflung", "dä", 15, "Berührung", "Luft", "Geist", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 179, "1 Wesen", "Holz", "6", "20 sec", 20, null, "10 min", 10, 6, "", "Wachsen", "dä", 15, "Berührung", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 180, "1 Wesen", "Magan", "7", "20 sec", 20, null, "?", 30, 9, "Birkenrinde und Blüten des Wahnsinnkrautes (50 GS)", "Wahnsinn", "dä", 16, "15 m", "Luft", "Geist", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 181, "3 m Umkreis", "Magan", "6", "20 sec", 20, null, "10 min", 30, 9, "vierblättriger Klee (10 GS)", "Wahrsehen", "gö", 12, "15 m", "Magan", "Geist", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 182, "-", "Magan", "6", "10 min", 20, null, "1 min", 30, 9, "", "Wandwandeln", "el", 14, "Berührung", "Erde", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 183, "15 m Umkreis", "Luft", "2", "10 sec", 20, null, "10 min", 2, 3, "Einhornhaar und Espenholz (50 GS)", "Warnung", "dä", 12, "0 m", "Eis", "Geist", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 184, "1 Wesen", "Luft", "2", "10 sec", 20, null, "8 h", 2, 3, "", "Wasseratmen", "el", 15, "Berührung", "Wasser", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 185, "Zauberer", "Wasser", "3", "20 sec", 20, null, "10 min", 5, 5, "", "Wasserlauf", "el", 11, "-", "Erde", "Körper", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 186, "1 Wesen/Objekt", "Wasser", "6", "20 sec", 20, null, "1 h", 40, 10, "Perle (100 GS)", "Wassermeisterschaft", "el", 11, "-", "Wasser", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 170, "1 Wesen", "Erde", "8", "10 sec", 20, null, "?", 40, 10, "", "Versteinern", "sm", 15, "Berührung", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 150, "15 m Umkreis", "Wasser", "1", "10 sec", 20, null, "2 min", 2, 3, "Wasserlinsen (1 GS)", "Sumpfboden", "el", 14, "50 m", "Erde", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 169, "1-6 Wesen", "Magan", "2 je Wesen", "20 sec", 20, null, "24 h", 20, 8, "Phosphorkreide (200 GS)", "Versetzen", "dä", 11, "500 m", "Metall", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 167, "1 Objekt", "Magan", "2", "10 sec", 20, null, "30 min", 1, 1, "", "Vermehren", "dr", 14, "15 m", "Metall", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 152, "1-3 Wesen", "Wasser", "6 je Wesen", "20 sec", 20, null, "var", 30, 9, "Tierblutmischung (50 GS)", "Tierisches Handeln", "dä", 10, "30 m", "Luft", "Geist", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 153, "Zauberer", "Wasser", "4", "20 sec", 20, null, "2 min", 15, 7, "", "Tiersprache", "dr", 12, "15 m", "Luft", "Körper", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 154, "bis zu 18 m Umkreis", "Eis", "3", "Augenblick", 20, null, "1 min", 5, 5, "Fliegenpilzasche (1 GS)", "Todeshauch", "dä", 13, "0 m", "Wasser", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 155, "1 Objekt", "Eis", "3", "10 sec", 20, null, "2 min", 10, 6, "Oberschenkelknochen", "Todeskeule", "dä", 14, "Berührung", "Erde", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 156, "1 Wesen", "Eis", "1 je Schadenspunkt", "20 sec", 20, null, "0", 60, 11, "", "Todeszauber", "dä", 16, "30 m", "Holz", "Körper", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 157, "30 cm", "Magan", "4", "10 min", 20, null, "1 min", 20, 8, "", "Torwandeln", "el", 14, "Berührung", "Holz", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 158, "Zauberer", "Metall", "6 je Seite", "30 sec", 20, null, "2 min", 30, 9, "versilberte Drachenschuppe (100 GS)", "Umkehrschild", "dä", 13, "-", "Magan", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 159, "1 Schwarm", "Magan", "2", "30 sec", 20, null, "2 min", 3, 4, "", "Ungezieferplage", "dä", 10, "0 m", "Wasser", "Geist", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 160, "Zauberer", "Luft", "4", "10 sec", 20, null, "10 min, k", 3, 4, "", "Unsichtbarkeit", "dä", 15, "-", "Metall", "Körper", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 161, "1 Wesen", "Eis", "5", "10 sec", 20, null, "?", 10, 6, "", "Verdorren", "sm", 15, "Berührung", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 162, "1 Wesen", "Eis", "7", "10 sec", 20, null, "?", 30, 9, "", "Vereisen", "dä", 15, "Berührung", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 163, "1 Wesen", "Eis", "2", "30 sec", 20, null, "0", 3, 4, "", "Vergiften", "sm", 16, "3 m", "Erde", "Körper", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 164, "1 Objekt", "Magan", "6", "20 sec", 20, null, "10 min", 5, 5, "", "Vergrößern", "dä", 14, "Berührung", "Metall", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 165, "1 Objekt", "Magan", "6", "20 sec", 20, null, "10 min", 5, 5, "", "Verkleinern", "dä", 14, "Berührung", "Metall", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 166, "1 Wesen", "Metall", "2", "10 sec", 20, null, "1 min", 3, 4, "Blei (20 GS)", "Verlangsamen", "dä", 15, "15 m", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 168, "1 Objekt", "Magan", "2", "10 sec", 20, null, "0", 1, 2, "", "Verschmutzen", "dr", 14, "15 m", "Metall", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 112, "500 m Umkreis", "Wasser", "2", "10 sec", 20, null, "-", 2, 3, "Staub (1 GS)", "Nebel wecken", "el", 14, "0 m", "Luft", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 144, "3 m Umkreis", "Erde", "3", "10 sec", 20, null, "2 min, k", 3, 4, "Diamant (50 GS)", "Steinkugel", "el", 13, "50 m", "Erde", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 110, "1-3 Wesen", "Eis", "4 je Wesen", "20 sec", 20, null, "2 min", 20, 8, "Schweiß von Albträumenden (20 GS)", "Namenloses Grauen", "dä", 10, "30 m", "Wasser", "Geist", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 57, "1 Objekt", "Feuer", "4", "1 min", 20, null, "10 min", 10, 6, "Klinge aus Alchimistenmetall", "Flammenklinge", "el", 14, "Berührung", "Metall", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 58, "1 Wesen", "Holz", "1", "Augenblick", 20, null, "2 min", 1, 2, "Zunder (1 SS)", "Flammenkreis", "dr", 13, "Berührung", "Holz", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 59, "bis zu 10 m²", "Feuer", "1 je m²", "10 sec", 20, null, "1 min", 5, 5, "Feuertopas (20 GS)", "Flammenteppich", "el", 13, "50 m", "Feuer", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 60, "1 Objekt", "Magan", "1", "10 sec", 20, null, "10 min", 1, 1, "", "Flicken", "dr", 14, "Berührung", "Metall", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 61, "Zauberer", "Luft", "9", "30 sec", 20, null, "1 h, k", 60, 11, "Greifenschwungfeder (100 GS)", "Fliegen", "dä", 11, "-", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 62, "1 Wesen", "Wasser", "4", "10 sec", 20, null, "30 min, k", 15, 7, "", "Freundesauge", "dä", 10, "500 m", "Feuer", "Geist", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 63, "Strahl", "Eis", "1", "10 sec", 20, null, "0", 1, 2, "Silberperle oder Bergkristall (10 GS)", "Frostball", "el", 13, "200 m", "Eis", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 64, "1 Wesen", "Feuer", "2 je Grad", "10 sec", 20, null, "1 min", 15, 7, "Sternenstaub (20 GS)", "Funkenregen", "dä", 10, "30 m", "Feuer", "Geist", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 65, "100 m Umkreis", "Magan", "1", "10 sec", 20, null, "10 min", 1, 1, "Kristallpyramide (10 GS)", "Geisterhorn", "dä", 12, "0 m", "Eis", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 66, "bis zu 100 m²", "Metall", "1 je 5 m² Fläche", "10 sec", 20, null, "8 h", 10, 6, "Eisenspäne (10 GS)", "Geistersperre", "dä", 13, "Berührung", "Metall", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 67, "Zauberer", "Feuer", "var", "Augenblick", 20, null, "10 min", 10, 6, "", "Geistesschild", "dä", 16, "-", "Magan", "Geist", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 68, "3 m Umkreis", "Metall", "1", "Augenblick", 20, null, "5 min", 1, 2, "", "Geräusche dämpfen", "dä", 14, "0 m", "Luft", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 69, "1 Wesen", "Metall", "2", "10 sec", 20, null, "2 min", 3, 4, "Goldstaub (50 GS)", "Goldener Panzer", "dä", 14, "Berührung", "Metall", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 70, "3 m Umkreis", "Metall", "2", "20 sec", 20, null, "2 min", 3, 4, "", "Goldene Sphäre", "gö", 16, "0 m", "Magan", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 71, "1 Wesen", "Eis", "7", "10 sec", 20, null, "0", 40, 10, "", "Graue Hand", "sm", 16, "Berührung", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 56, "Zauberer", "Feuer", "2", "10 sec", 20, null, "2 min", 2, 3, "", "Flammende Hand", "el", 13, "0 m", "Feuer", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 72, "30 m Umkreis", "Eis", "12", "30 sec", 20, null, "2 min, k", 90, 12, "Wasser und Diamantsplitter (50 GS)", "Hagel", "el", 13, "100 m", "Eis", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 55, "-", "Feuer", "1 je m Breite", "10 sec", 20, null, "10 min", 3, 4, "Rubin (50 GS)", "Feuerwand", "el", 13, "15 m", "Feuer", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 53, "6 m Umkreis", "Feuer", "4", "20 sec", 20, null, "30 min", 20, 8, "Zwergdrachenflügel und Zauberöl (100 GS)", "Feuerring", "el", 13, "0 m", "Feuer", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 38, "1 km Umkreis", "Erde", "6", "1 min", 20, null, "10 min", 30, 9, "", "Erdbeben", "el", 11, "0 m", "Erde", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 39, "1 m Umkreis", "Erde", "3", "Augenblick", 20, null, "2 min", 5, 5, "Honig-Erd-Gemisch (5 GS)", "Erdfessel", "el", 11, "50 m", "Erde", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 40, "1 m²", "Erde", "6", "20 sec", 20, null, "?", 30, 9, "Bernstein (100 GS)", "Erdwandlung", "el", 14, "Berührung", "Erde", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 41, "15 m Kegel", "Magan", "1", "Augenblick", 20, null, "1 min", 1, 1, "", "Erkennen von Leben", "dä", 12, "0 m", "Wasser", "Geist", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 111, "50 m Umkreis", "Wasser", "4", "20 sec", 20, null, "30 min", 15, 7, "versiegeltes Fläschchen voll Nebel (10 GS)", "Nebel schaffen", "el", 13, "0 m", "Wasser", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 43, "3 m Umkreis", "Magan", "6", "20 sec", 20, null, "2 min, k", 40, 10, "Blütenstaub vom blauen Mohn (100 GS)", "Erscheinungen", "dä", 10, "30 m", "Feuer", "Geist", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 44, "1 Wesen", "Eis", "3", "10 sec", 20, null, "2 min", 5, 5, "", "Erwecken", "sm", 15, "30 m", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 45, "1 Wesen", "Erde", "1", "10 sec", 20, null, "2 min", 1, 2, "Kieselstein (1 SS)", "Felsenfaust", "el", 15, "Berührung", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 46, "1 Wesen", "Luft", "2 je Grad", "10 sec", 20, null, "10 min, k", 10, 6, "Fadenstück einer Riesenspinne (50 GS)", "Fesselbann", "gö", 13, "30 m", "Magan", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 47, "Zauberer", "Feuer", "1", "Augenblick", 20, null, "2 min, k", 1, 1, "", "Feuerfinger", "el", 13, "0 m", "Feuer", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 48, "3 m Umkreis", "Feuer", "2", "10 sec", 20, null, "2 min, k", 2, 3, "Blutstein (30 GS)", "Feuerkugel", "el", 13, "50 m", "Feuer", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 49, "Strahl", "Feuer", "3", "10 sec", 20, null, "0", 10, 6, "Korallenstück (20 GS)", "Feuerlanze", "el", 13, "50 m", "Feuer", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 50, "1 Wesen", "Erde", "3", "10 sec", 20, null, "10 min", 5, 5, "", "Feuerlauf", "el", 15, "-", "Erde", "Körper", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 51, "2 m Umkreis", "Feuer", "6", "20 sec", 20, null, "2 min", 30, 9, "Stück einer Drachenzunge (100 GS)", "Feuermeisterschaft", "el", 14, "30 m", "Feuer", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 52, "30 m Umkreis", "Feuer", "18", "30 sec", 20, null, "1 min, k", 90, 12, "Basaltstaub und Rubinsplitter (100 GS)", "Feuerregen", "el", 13, "100 m", "Feuer", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 54, "-", "Eis", "3", "10 sec", 20, null, "2 min", 10, 6, "Diamantstaub (20 GS)", "Feuerschild", "el", 13, "15 m", "Eis", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 73, "bis zu 18 m Umkreis", "Eis", "3", "Augenblick", 20, null, "1 min", 5, 5, "getrocknetes Vampirmoos (10 GS)", "Hauch der Betäubung", "dä", 13, "0 m", "Holz", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 42, "1 m²", "Magan", "2", "Augenblick", 20, null, "0", 3, 4, "", "Erkennen von Zauberei", "dä", 12, "15 m", "Magan", "Geist", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 75, "12 m Umkreis", "Eis", "1", "Augenblick", 20, null, "10 min", 1, 1, "Schneewolfhaare (20 GS)", "Hauch des Winters", "el", 14, "0 m", "Luft", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 95, "Zauberer", "Luft", "4", "20 sec", 20, null, "2 min, k", 15, 7, "", "Luftlauf", "el", 11, "-", "Erde", "Körper", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 96, "3 m Umkreis", "Luft", "4", "20 sec", 20, null, "1 h", 20, 8, "Perle (100 GS)", "Luftsphäre", "el", 13, "0 m", "Luft", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 97, "Zauberer", "Metall", "1", "10 sec", 20, null, "24 h, k", 1, 1, "", "Macht über das Selbst", "dä", 10, "-", "Feuer", "Körper", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 98, "1 Wesen je Grad", "Magan", "2 je Grad", "10 sec", 20, null, "mind. 2 h", 3, 4, "", "Macht über die belebte Natur", "dä", 10, "30 m", "Wasser", "Geist", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 99, "Zauberer", "Magan", "1 je Variation", "10 sec", 20, null, "2-10 min", 1, 2, "", "Macht über die Sinne", "dä", 10, "50 m", "Feuer", "Geist", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 100, "1 Wesen", "Eis", "mind. 8", "10 sec", 20, null, "2 min", 30, 9, "", "Macht über Leben", "dä", 16, "6 m", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 101, "1 Wesen je Grad", "Magan", "3 je Grad", "20 sec", 20, null, "var", 15, 7, "", "Macht über magische Wesen", "dä", 10, "30 m", "Magan", "Geist", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 102, "1 Wesen je Grad", "Magan", "3 je Grad", "20 sec", 20, null, "var", 10, 6, "", "Macht über Menschen", "dä", 10, "30 m", "Luft", "Geist", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 103, "-", "Feuer", "2", "Augenblick", 20, null, "10 sec", 2, 3, "", "Macht über Unbelebtes", "dä", 11, "30 m", "Metall", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 104, "10 m Umkreis", "Magan", "6", "30 min", 20, null, "?", 10, 6, "Wächterwürfel", "Mag. Kreis des Bewachens", "dä", 12, "0 m", "Magan", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 105, "10 m Umkreis", "Magan", "6", "30 min", 20, null, "?", 10, 6, "Wächterwürfel", "Mag. Kreis des Verschleierns", "dä", 16, "0 m", "Magan", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 106, "10 m Umkreis", "Magan", "6", "30 min", 20, null, "?", 10, 6, "Wächterwürfel", "Mag. Kreis des Widerstehens", "dä", 14, "0 m", "Wasser", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 108, "1 Wesen", "Erde", "3", "10 sec", 20, null, "10 min", 5, 5, "Marmorstaub (1 GS)", "Marmorhaut", "el", 15, "Berührung", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 109, "1 Wesen", "Wasser", "1", "Augenblick", 20, null, "30 min, k", 1, 2, "", "Mitfühlen", "dä", 12, "500 m", "Wasser", "Geist", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 74, "bis zu 18 m Umkreis", "Eis", "2", "Augenblick", 20, null, "1 min", 3, 4, "Stinkmorschelasche (2 GS)", "Hauch der Verwesung", "dä", 13, "0 m", "Erde", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 94, "Zauberer", "Magan", "1", "Augenblick", 20, null, "10 sec", 1, 1, "", "Liniensicht", "dr", 12, "bis zu 5 km", "Holz", "Geist", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 93, "1 Wesen", "Wasser", "4", "1 h", 20, null, "?", 20, 8, "Liebestrank oder Locke", "Liebeszauber", "dä", 10, "-", "Wasser", "Geist", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 107, "6 m Umkreis", "Magan", "6", "10 min", 20, null, "8 h", 10, 6, "mit Eisendraht umwickelte Zweige von Eiche, Esche und Weißdorn (10 GS)", "Magischer Kreis, klein", "dr", 12, "0 m", "Magan", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 91, "-", "Metall", "4", "1 min", 20, null, "10 min", 20, 8, "", "Lichtbrücke", "gö", 13, "50 m", "Feuer", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 92, "1 m²", "Feuer", "1", "10 min", 20, null, "?", 1, 2, "Nachtmarderhaarpinsel (50 GS)", "Lichtrunen", "dä", 14, "Berührung", "Metall", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 77, "1 Objekt", "Luft", "1", "10 sec", 20, null, "10 sec", 1, 1, "", "Heranholen", "dä", 11, "30 m", "Metall", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 79, "-", "Metall", "6", "1 min", 20, null, "10 min", 30, 9, "", "Himmelsleiter", "gö", 13, "50 m", "Feuer", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 80, "Zauberer", "Wasser", "1", "Augenblick", 20, null, "2 min", 1, 2, "", "Hitzeschutz", "dä", 15, "-", "Erde", "Körper", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 81, "-", "Luft", "2", "10 sec", 20, null, "1 min, k", 2, 3, "Auge eines Greifvogels (50 GS)", "Höhenblick", "dä", 11, "50 m", "Feuer", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 82, "6 m Umkreis", "Eis", "1 je 10 sec Dauer", "10 sec", 20, null, "10 sec je Grad", 5, 5, "", "Hören der Geister", "dä", 12, "0 m", "Luft", "Körper", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 83, "1 Wesen", "Magan", "1", "1 min", 20, null, "10 min", 1, 1, "", "Hören von Fernem", "dä", 15, "Berührung", "Wasser", "Körper", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 78, "1 Wesen", "Magan", "2", "10 sec", 20, null, "?", 5, 5, "", "Hexenstreich", "dä", 15, "15 m", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 85, "1 Objekt", "Erde", "2", "10 sec", 20, null, "30 min", 5, 5, "2 Greifenaugenhälften", "Juwelenauge", "dä", 11, "500 m", "Feuer", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 84, "2 km Umkreis", "Magan", "1", "Augenblick", 20, null, "10 sec", 1, 2, "", "Hörnerklang", "dä", 14, "0 m", "Luft", "Umgebung", "Wort" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 90, "-", "Magan", "1", "1 min", 20, null, "10 min, k", 1, 1, "", "Lauschen", "dä", 14, "30 cm", "Metall", "Umgebung", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 89, "1 Wesen", "Metall", "8", "20 sec", 20, null, "24 h", 40, 10, "Basiliskenschuppe (100 GS)", "Lähmung", "dä", 15, "30 m", "Erde", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 76, "1 Objekt", "Wasser", "2", "1 min", 20, null, "30 min", 2, 3, "Taubenschwungfeder (5 SS) und Wasser", "Heimfeder", "dr", 12, "3 m", "Luft", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 87, "1 Wesen", "Eis", "1", "Augenblick", 20, null, "0", 1, 2, "", "Kraft entziehen", "sm", 16, "Berührung", "Feuer", "Körper", "Geste" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 86, "Zauberer", "Feuer", "1", "Augenblick", 20, null, "2 min", 1, 2, "", "Kälteschutz", "dä", 15, "-", "Erde", "Körper", "Gedanke" });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "AffectedArea", "Agent", "CastingCost", "CastingTime", "CategoryId", "Description", "Duration", "LearningCost", "Level", "Material", "Name", "Origin", "ProcessId", "Range", "Reagent", "Target", "Type" },
                values: new object[] { 88, "1 m²", "Magan", "2", "10 sec", 20, null, "2 min, k", 2, 3, "", "Kraftraub", "dä", 16, "30 m", "Feuer", "Umgebung", "Geste" });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 36, "2W6", null, 0, 31, 61, "Bihänder", "", "", "nah", "", 69 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 47, "1W6-1", null, 0, 31, 31, "Wurfkeule", "Nahkampf wie Keule", "", "10/20/50", "", 73 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 46, "1W6", null, 0, 31, 61, "Wurfhammer", "Nahkampf w. Kriegshammer", "", "10/20/30", "", 73 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 45, "1W6", null, 0, 61, 61, "Wurfeisen", "", "", "10/20/50", "", 73 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 44, "1W6", null, 0, 31, 31, "Wurfaxt", "Nahkampf wie Handaxt", "", "10/20/30", "", 73 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 43, "", null, 0, 61, 0, "Parierdolch", "gegen Einhandschwert, Zauberstab, Stich-, Stock-, Spießwaffe, Buckler oder andere Parierwaffe", "", "nah", "1 AP", 72 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 42, "(1W6-3)/(1W6-4)", null, 0, 61, 31, "Kampfgabeln", "gegen Einhandschwert, Zauberstab, Stich-, Stock-, Spießwaffe, Buckler oder andere Parierwaffe", "", "nah", "2 AP", 72 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 41, "", null, 0, 11, 31, "Schild, kleiner", "gegen alle Nahkampfangriffe ausgenommen zweihändige Hiebwaffen sowie Schuss und Wurfwaffen", "", "nah", "1 AP", 71 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 40, "", null, 0, 0, 61, "Schild, großer", "gegen alle Angriffe, auch Schuss- und Wurfwaffen sowie zweihändige Hiebwaffen", "", "nah", "0 AP", 71 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 38, "1W6-4", null, 31, 31, 21, "Ringen", "erstetzt Raufen", "", "nah", "", 70 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 37, "1W6-4", null, 21, 21, 31, "Faustkampf", "betäuben", "", "nah", "", 70 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 48, "1W6-1", null, 0, 61, 0, "Wurfmesser", "Nahkampf wie Dolch", "", "10/15/20", "", 74 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 35, "1W6+2", null, 0, 21, 81, "Anderthalbhänder", "", "", "nah", "", 69 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 39, "", null, 0, 61, 0, "Buckler", "gegen Einhandschwert, Zauberstab, Stich-, Stock- , Spießwaffe, Fecht-, Parierwaffe oder Buckler", "", "nah", "2 AP", 71 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 56, "2W6-1", null, 0, 31, 61, "Armbrust, schwere", "Schuss jede 2. Runde", "", "30/120/240", "", 77 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 50, "1W6-2", null, 0, 61, 61, "Wurfscheibe", "pro Runde 2 Angriffe", "", "10/20/30", "", 75 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 51, "1W6-3", null, 0, 61, 0, "Wurfstern", "pro Runde 3 Angriffe", "", "5/10/15", "", 75 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 52, "1W6", null, 0, 61, 31, "Speerschleuder", "", "", "20/40/70", "", 76 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 53, "1W6-1", null, 0, 21, 31, "Wurfspeer", "Nahkampf wie Speer, leicht", "", "10/30/50", "", 76 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 54, "1W6", null, 0, 21, 61, "Wurfspie?", "Nahkampf wie Speer, leicht", "", "10/20/30", "", 76 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 55, "1W6", null, 0, 61, 0, "Armbrust, leichte", "", "", "30/120/220", "", 77 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 57, "1W6-1", null, 0, 31, 0, "Handarmbrust", "", "", "20/40/70", "", 77 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 58, "(Gift)", null, 0, 61, 0, "Blasrohr, lang", "(Gift 3W6-5W6 Schaden)", "", "10/15/20", "", 78 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 59, "(Gift)", null, 0, 61, 0, "Blasrohr, kurz", "(Gift 3W6-5W6 Schaden)", "", "5/7/10", "", 78 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 60, "1W6", null, 0, 31, 31, "Bogen", "", "", "30/100/180", "", 79 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 61, "1W6+1", null, 0, 61, 61, "Kompositbogen", "", "", "30/120/200", "", 79 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 62, "1W6-1", null, 0, 31, 11, "Kurzbogen", "", "", "30/80/120", "", 79 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 34, "2W6", null, 0, 31, 81, "Stielhammer", "", "", "nah", "1W6+1", 68 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 63, "1W6+1", null, 0, 61, 61, "Langbogen", "", "", "30/120/200", "", 79 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 49, "1W6-2", null, 0, 31, 11, "Wurfpfeil", "", "", "10/20/30", "", 74 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 33, "2W6-2", null, 0, 0, 81, "Stabkeule", "", "", "nah", "", 68 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 15, "1W6-1", null, 0, 61, 31, "NunChaku", "entwaffnen", "", "nah", "", 63 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 31, "4W6-4", null, 0, 61, 91, "Ogerhammer", "", "", "nah", "", 68 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 64, "1W6", null, 0, 61, 0, "Schleuder", "", "", "30/60/90", "", 80 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 1, "1W6", null, 0, 0, 11, "Handaxt", "", "", "nah", "", 60 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 2, "1W6-1", null, 0, 0, 0, "Keule", "", "", "nah", "", 60 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 3, "1W6", null, 0, 11, 61, "Kriegshammer", "", "", "nah", "", 60 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 4, "1W6+1", null, 0, 21, 91, "Schlachtbeil", "", "", "nah", "", 60 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 5, "1W6-1", null, 0, 11, 61, "Streitaxt", "", "", "nah", "", 60 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 6, "1W6", null, 0, 0, 31, "Streitkolben", "", "", "nah", "", 60 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 7, "1W6+1", null, 0, 21, 81, "Anderthalbhänder", "", "", "nah", "", 61 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 8, "1W6", null, 0, 11, 31, "Krummschwert", "", "", "nah", "", 61 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 9, "1W6+1", null, 0, 21, 31, "Langschwert", "", "", "nah", "", 61 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 10, "", null, 0, 81, 0, "Florett", "", "", "nah", "", 62 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 11, "", null, 0, 31, 61, "Fuchtel", "nur Parade", "", "nah", "", 62 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 12, "", null, 0, 51, 11, "Rapier", "", "", "nah", "", 62 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 13, "2W6-1", null, 0, 31, 61, "Kriegsflegel", "zweihändig", "", "nah", "", 63 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 32, "1W6+3", null, 0, 21, 91, "Schlachtbeil", "", "", "nah", "", 68 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 14, "1W6+2", null, 0, 61, 61, "Morgenstern", "", "", "nah", "", 63 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 17, "1W6", null, 0, 61, 61, "Hellebarde", "", "", "nah", "1W6+2", 64 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 18, "", null, 0, 0, 0, "Speer, leichter", "", "", "nah", "1W6+1", 64 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 19, "1W6", null, 0, 31, 81, "Stielhammer", "", "", "nah", "1W6-1", 64 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 20, "", null, 0, 11, 31, "Stoßspeer", "", "", "nah", "2W6", 64 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 21, "1W6-1", null, 0, 0, 0, "Dolch", "", "", "nah", "", 65 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 22, "1W6", null, 0, 0, 0, "Kurzschwert", "", "", "nah", "", 65 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 23, "", null, 0, 31, 0, "Ochsenzunge", "", "", "nah", "", 65 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 24, "1W6", null, 0, 61, 21, "Bo-Stab", "Abwehr, Entwaffnen", "", "nah", "", 66 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 25, "1W6", null, 0, 61, 31, "Kampfstab", "Abwehr, Entwaffnen", "", "nah", "", 66 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 26, "1W6", null, 0, 31, 0, "Magierstab", "bei Kämpfer wie Keule", "", "nah", "", 67 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 27, "", null, 0, 31, 31, "Magierstecken", "Abwehr, Entwaffnen", "", "nah", "", 67 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 28, "2W6", null, 0, 31, 81, "Barbarenstreitaxt", "", "", "nah", "", 68 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 29, "1W6+2", null, 0, 61, 11, "Glefe", "", "", "nah", "1W6+2", 68 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 30, "2W6-1", null, 0, 61, 61, "Hellebarde", "", "", "nah", "1W6+2", 68 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 16, "1W6", null, 0, 61, 11, "Glefe", "", "", "nah", "1W6+2", 64 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Damage", "Description", "MinAgility", "MinDexterity", "MinStrength", "Name", "Note", "Protection", "Range", "StormDamage", "WeaponGroupId" },
                values: new object[] { 65, "2W6-2", null, 0, 81, 31, "Stockschleuder", "", "", "50/100/180", "", 80 });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterHasSkills_CharacterId",
                table: "CharacterHasSkills",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterHasSkills_SkillId",
                table: "CharacterHasSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterHasSpell_CharacterId",
                table: "CharacterHasSpell",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterHasSpell_SpellId",
                table: "CharacterHasSpell",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterHasWeapon_CharacterId",
                table: "CharacterHasWeapon",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterHasWeapon_WeaponId",
                table: "CharacterHasWeapon",
                column: "WeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ClassId",
                table: "Characters",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_RaceId",
                table: "Characters",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_SocialClassId",
                table: "Characters",
                column: "SocialClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_SpellId",
                table: "Characters",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassCategoryAffinities_CategoryId",
                table: "ClassCategoryAffinities",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassCategoryAffinities_ClassId",
                table: "ClassCategoryAffinities",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassCosts_CategoryId",
                table: "ClassCosts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassCosts_ClassId",
                table: "ClassCosts",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_LearningCosts_CategoryId",
                table: "LearningCosts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillHasCategories_CategoryId",
                table: "SkillHasCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillHasCategories_SkillId",
                table: "SkillHasCategories",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialClass_BonusCategoryId",
                table: "SocialClass",
                column: "BonusCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_CategoryId",
                table: "Spells",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_ProcessId",
                table: "Spells",
                column: "ProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_WeaponGroupId",
                table: "Weapons",
                column: "WeaponGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterHasSkills");

            migrationBuilder.DropTable(
                name: "CharacterHasSpell");

            migrationBuilder.DropTable(
                name: "CharacterHasWeapon");

            migrationBuilder.DropTable(
                name: "ClassCategoryAffinities");

            migrationBuilder.DropTable(
                name: "ClassCosts");

            migrationBuilder.DropTable(
                name: "DefenseWeaponLearningCosts");

            migrationBuilder.DropTable(
                name: "LearningCosts");

            migrationBuilder.DropTable(
                name: "SkillHasCategories");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "SocialClass");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
