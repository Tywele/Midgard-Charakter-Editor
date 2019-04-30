using Microsoft.EntityFrameworkCore.Migrations;

namespace Midgard_Charakter_Editor.Migrations
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
                name: "WeaponSkills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Damage = table.Column<string>(nullable: true),
                    MinStrength = table.Column<int>(nullable: false),
                    MinDexterity = table.Column<int>(nullable: false),
                    Protection = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponSkills", x => x.Id);
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
                    Casttime = table.Column<string>(nullable: true),
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
                name: "CharacterHasWeaponSkill",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CharacterId = table.Column<int>(nullable: true),
                    WeaponSkillId = table.Column<int>(nullable: true),
                    Value = table.Column<int>(nullable: false),
                    Specialization = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterHasWeaponSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterHasWeaponSkill_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharacterHasWeaponSkill_WeaponSkills_WeaponSkillId",
                        column: x => x.WeaponSkillId,
                        principalTable: "WeaponSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Alltag" });

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
                values: new object[] { 14, "Formen" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 12, "Erkennen" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 11, "Bewegung" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 13, "Erschaffen" });

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
                values: new object[] { 10, "Beherrschung" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[] { 9, "Or", "Ordenskrieger" });

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
                values: new object[] { 11, "Hx", "Hexer" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[] { 10, "Dr", "Druide" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[] { 8, "Ba", "Barde" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[] { 12, "Ma", "Magier" });

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
                values: new object[] { 7, "Wa", "Waldläufer" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[] { 3, "Gl", "Glücksritter" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[] { 2, "Bb", "Barbar" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[] { 1, "As", "Assassine" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 42, null, "Wissen", "in", "Schreiben: Sprache", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 41, null, "Fingerfertigkeit", "gs", "Schlösser öffnen", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 40, null, "Bewegung", "gw", "Schleichen", 3 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 39, null, "Kampf", "gs", "Scharfschießen", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 38, null, "Körperbeherrschung", "ko", "Körperresistenz", 10 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 35, null, "Bewegung", "gw", "Reiten", 6 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 36, null, "Kampf", "gw", "Reiterkampf", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 43, null, "Bewegung", "gw", "Schwimmen", 3 });

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
                values: new object[] { 37, null, "Körperbeherrschung", "in", "Geistresistenz", 10 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 44, null, "Fingerfertigkeit", "gs", "Seilkunst", 3 });

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
                values: new object[] { 48, null, "Entdeckung", "gw", "Tarnen", 3 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 49, null, "Bewegung", "ko", "Tauchen", 6 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 50, null, "Wissen", "in", "Tierkunde", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 51, null, "Wissen", "in", "Überleben: Gebirge", 6 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 52, null, "Wissen", "in", "Überleben: Steppe", 6 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 53, null, "Wissen", "in", "Überleben: Wald", 6 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 54, null, "Sozial", "pa", "Verführen", 3 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 55, null, "Sozial", "pa", "Verhören", 3 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 56, null, "Sozial", "pa", "Verstellen", 3 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 57, null, "Bewegung", "gs", "Wagenlenken", 3 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 31, null, "Kampf", "gs", "Meucheln", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 45, null, "Wissen", "in", "Sprechen: Sprache", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 30, null, "Sozial", "in", "Menschenkenntnis", 3 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 13, null, "Fingerfertigkeit", "gs", "Fälschen", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 28, null, "Wissen", "in", "Lesen von Zauberschrift", null });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 1, null, "Kampf", "gw", "Abwehr", 10 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 2, null, "Bewegung", "gw", "Akrobatik", 6 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 3, null, "Wissen", "in", "Alchemie", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 4, null, "Sozial", "pa", "Anführen", 6 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 5, null, "Körperbeherrschung", "st", "Athletik", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 6, null, "Bewegung", "gw", "Balancieren", 6 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 7, null, "Kampf", "gs", "Beidhändiger Kampf", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 8, null, "Sozial", "pa", "Beredsamkeit", 3 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 9, null, "Kampf", "gs", "Betäuben", 6 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 10, null, "Bewegung", "gs", "Bootfahren", 3 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 11, null, "Fingerfertigkeit", "gs", "Erste Hilfe", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 12, null, "Sozial", "in", "Etikette", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 58, null, "Wissen", "in", "Zauberkunde", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 14, null, "Entdeckung", "in", "Fallen entdecken", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 15, null, "Fingerfertigkeit", "gs", "Fallenmechanik", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 16, null, "Kampf", "gs", "Fechten", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 17, null, "Sozial", "in", "Gassenwissen", 0 });

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
                values: new object[] { 21, null, "Sozial", "in", "Geschäftssinn", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 22, null, "Fingerfertigkeit", "gs", "Glücksspiel", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 23, null, "Wissen", "in", "Heilkunde", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 24, null, "Kampf", "st", "Kampf in Vollrüstung", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 25, null, "Bewegung", "st", "Klettern", 6 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 26, null, "Wissen", "in", "Landeskunde", 6 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 27, null, "Bewegung", "ko", "Laufen", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 29, null, "Körperbeherrschung", "wk", "Meditieren", 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Field", "LeadingAttribute", "Name", "Untrained" },
                values: new object[] { 59, null, "Zaubern", "zt", "Zaubern", 3 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 85, 2, 10, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 22, 4, 3, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 23, 5, 3, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 24, 6, 3, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 25, 7, 3, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 26, 8, 3, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 27, 9, 3, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 28, 1, 4, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 29, 2, 4, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 30, 3, 4, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 31, 4, 4, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 32, 5, 4, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 33, 6, 4, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 34, 7, 4, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 35, 8, 4, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 36, 9, 4, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 37, 1, 5, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 38, 2, 5, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 39, 3, 5, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 40, 4, 5, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 21, 3, 3, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 41, 5, 5, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 20, 2, 3, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 18, 9, 2, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 92, 9, 10, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 91, 8, 10, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 1, 1, 1, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 2, 2, 1, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 3, 3, 1, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 4, 4, 1, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 5, 5, 1, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 6, 6, 1, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 7, 7, 1, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 8, 8, 1, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 9, 9, 1, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 10, 1, 2, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 11, 2, 2, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 12, 3, 2, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 13, 4, 2, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 14, 5, 2, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 15, 6, 2, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 16, 7, 2, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 17, 8, 2, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 19, 1, 3, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 42, 6, 5, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 43, 7, 5, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 44, 8, 5, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 69, 6, 8, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 70, 7, 8, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 71, 8, 8, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 72, 9, 8, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 73, 19, 8, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 74, 1, 9, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 75, 2, 9, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 76, 3, 9, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 77, 4, 9, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 78, 5, 9, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 79, 6, 9, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 80, 7, 9, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 81, 8, 9, 20 });

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
                values: new object[] { 90, 7, 10, 40 });

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
                values: new object[] { 45, 9, 5, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 46, 1, 6, 20 });

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
                values: new object[] { 93, 10, 10, 90 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 54, 9, 6, 30 });

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
                values: new object[] { 64, 1, 8, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 55, 1, 7, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 88, 5, 10, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 94, 11, 10, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 96, 13, 10, 90 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 162, 12, 14, 90 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 161, 11, 14, 90 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 160, 10, 14, 90 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 159, 9, 14, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 158, 8, 14, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 157, 7, 14, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 156, 6, 14, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 155, 5, 14, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 154, 4, 14, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 153, 3, 14, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 152, 2, 14, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 151, 1, 14, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 150, 17, 13, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 149, 16, 13, 90 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 148, 15, 13, 120 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 147, 14, 13, 120 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 146, 13, 13, 90 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 145, 12, 13, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 144, 11, 13, 90 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 163, 13, 14, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 143, 10, 13, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 164, 14, 14, 120 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 166, 16, 14, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 185, 18, 15, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 184, 17, 15, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 183, 16, 15, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 182, 15, 15, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 181, 14, 15, 120 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 180, 13, 15, 120 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 179, 12, 15, 60 });

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
                values: new object[] { 175, 8, 15, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 174, 7, 15, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 173, 6, 15, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 172, 5, 15, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 171, 4, 15, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 170, 3, 15, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 169, 2, 15, 10 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 168, 1, 15, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 167, 17, 14, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 165, 15, 14, 120 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 142, 9, 13, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 141, 8, 13, 40 });

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
                values: new object[] { 114, 14, 11, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 113, 13, 11, 90 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 112, 12, 11, 90 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 111, 11, 11, 90 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 110, 10, 11, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 109, 9, 11, 20 });

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
                values: new object[] { 106, 6, 11, 20 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 105, 5, 11, 30 });

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
                values: new object[] { 98, 15, 10, 90 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 97, 14, 10, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 116, 16, 11, 60 });

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
                values: new object[] { 95, 12, 10, 120 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 130, 13, 12, 60 });

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
                values: new object[] { 122, 5, 12, 30 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 121, 4, 12, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 120, 3, 12, 40 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 129, 12, 12, 60 });

            migrationBuilder.InsertData(
                table: "ClassCosts",
                columns: new[] { "Id", "CategoryId", "ClassId", "Value" },
                values: new object[] { 89, 6, 10, 30 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 1, 1, 0, 2, 1, 9, 5 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 96, 9, 20, 50, 50, 18, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 27, 3, 5, 20, 20, 15, 80 });

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
                values: new object[] { 35, 4, 0, 10, 2, 10, 20 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 26, 3, 2, 20, 10, 14, 50 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 36, 4, 0, 20, 5, 11, 20 });

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
                values: new object[] { 42, 4, 10, 100, 50, 17, 150 });

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
                values: new object[] { 46, 5, 0, 5, 2, 11, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 37, 4, 0, 20, 5, 12, 30 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 47, 5, 0, 5, 2, 12, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 25, 3, 1, 10, 10, 13, 30 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 23, 3, 0, 5, 5, 11, 20 });

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
                values: new object[] { 6, 1, 2, 10, 2, 14, 20 });

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
                values: new object[] { 10, 1, 20, 50, 20, 18, 100 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 11, 2, 1, 5, 2, 9, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 24, 3, 0, 10, 5, 12, 20 });

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
                values: new object[] { 13, 2, 1, 10, 5, 11, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 48, 5, 1, 10, 5, 13, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 9, 1, 10, 50, 10, 17, 100 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 50, 5, 5, 20, 10, 15, -1 });

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
                values: new object[] { 75, 8, 1, 2, 1, 7, 2 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 85, 8, 150, 300, 150, 17, 300 });

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
                values: new object[] { 49, 5, 2, 10, 10, 14, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 86, 8, 150, 300, 200, 18, 400 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 74, 8, 1, 1, 1, 6, 1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 91, 9, 2, 10, 10, 13, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 72, 7, 50, 100, 100, 17, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 73, 7, 50, 100, 100, 18, -1 });

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
                values: new object[] { 51, 5, 10, 20, 20, 16, -1 });

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
                values: new object[] { 54, 6, 2, 5, 2, 9, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 62, 6, 50, 100, 50, 17, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 61, 6, 20, 50, 50, 16, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 70, 7, 20, 80, 50, 15, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 68, 7, 10, 30, 20, 13, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 67, 7, 10, 20, 10, 12, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 69, 7, 20, 50, 20, 14, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 65, 7, 5, 10, 5, 10, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 64, 7, 2, 5, 5, 9, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 63, 6, 50, 100, 50, 18, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 66, 7, 5, 20, 10, 11, -1 });

            migrationBuilder.InsertData(
                table: "LearningCosts",
                columns: new[] { "Id", "CategoryId", "Easy", "Hard", "Normal", "Value", "VeryHard" },
                values: new object[] { 71, 7, 50, 80, 50, 16, -1 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 60, 1, 42 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 61, 9, 42 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 52, 4, 35 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 59, 7, 41 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 58, 7, 40 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 57, 2, 40 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 56, 4, 39 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 53, 4, 36 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 48, 9, 33 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 50, 9, 34 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 49, 2, 34 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 47, 2, 33 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 46, 1, 32 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 45, 7, 31 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 44, 6, 30 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 43, 9, 29 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 51, 1, 35 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 62, 1, 43 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 73, 5, 49 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 64, 1, 44 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 81, 6, 56 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 42, 5, 29 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 80, 6, 55 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 79, 6, 54 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 78, 2, 53 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 77, 2, 52 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 76, 2, 51 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 75, 9, 50 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 74, 2, 50 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 72, 7, 48 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 71, 2, 48 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 70, 7, 47 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 69, 3, 47 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 68, 7, 46 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 67, 2, 46 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 66, 9, 45 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 65, 1, 45 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 63, 5, 43 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 41, 9, 28 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 18, 1, 12 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 39, 9, 26 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 16, 1, 11 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 15, 1, 10 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 14, 4, 9 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 13, 3, 9 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 12, 6, 8 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 11, 4, 7 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 10, 3, 6 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 17, 9, 11 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 9, 5, 6 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 7, 4, 5 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 6, 6, 4 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 5, 4, 4 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 4, 9, 3 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 3, 5, 2 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 2, 3, 2 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 82, 1, 57 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 8, 5, 5 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 19, 6, 12 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 20, 3, 13 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 21, 7, 14 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 38, 5, 25 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 37, 3, 25 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 36, 1, 25 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 35, 4, 24 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 34, 9, 23 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 33, 3, 22 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 32, 1, 22 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 31, 1, 21 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 30, 1, 20 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 29, 5, 19 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 28, 4, 19 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 27, 3, 18 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 26, 7, 17 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 25, 6, 17 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 24, 3, 17 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 23, 4, 16 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 22, 7, 15 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 40, 5, 27 });

            migrationBuilder.InsertData(
                table: "SkillHasCategories",
                columns: new[] { "Id", "CategoryId", "SkillId" },
                values: new object[] { 83, 9, 58 });

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
                name: "IX_CharacterHasWeaponSkill_CharacterId",
                table: "CharacterHasWeaponSkill",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterHasWeaponSkill_WeaponSkillId",
                table: "CharacterHasWeaponSkill",
                column: "WeaponSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ClassId",
                table: "Characters",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_RaceId",
                table: "Characters",
                column: "RaceId");

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
                name: "IX_Spells_CategoryId",
                table: "Spells",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_ProcessId",
                table: "Spells",
                column: "ProcessId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterHasSkills");

            migrationBuilder.DropTable(
                name: "CharacterHasSpell");

            migrationBuilder.DropTable(
                name: "CharacterHasWeaponSkill");

            migrationBuilder.DropTable(
                name: "ClassCategoryAffinities");

            migrationBuilder.DropTable(
                name: "ClassCosts");

            migrationBuilder.DropTable(
                name: "LearningCosts");

            migrationBuilder.DropTable(
                name: "SkillHasCategories");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "WeaponSkills");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
