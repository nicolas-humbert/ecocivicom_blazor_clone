using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ecocivicom_blazor_clone.Migrations
{
    /// <inheritdoc />
    public partial class SeedFormationsCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormationsCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Slug = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormationsCategories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FormationsCategories",
                columns: new[] { "Id", "Description", "Image", "Slug" },
                values: new object[,]
                {
                    { 1, "COCIVICOM vous accompagne dans votre démarche, en proposant des [formations éco-conduite pour entreprise](https://www.ecocivicom.com/Formation_eco-conduite.b.htm). Nous façonnons un programme adapté pour vos salariés, afin de les sensibiliser aux bonnes pratiques de l’éco-conduite.", "images/formations_categories/form_eco.webp", "eco-conduite" },
                    { 2, "En formant vos salariés au risque routier, vous pourrez diminuer le taux d'accidentologie de votre entreprise et réduirez également les coûts financiers et humains liés aux accidents de la route.", "images/formations_categories/form_rr.webp", "risque-routier" },
                    { 3, "ECOCIVICOM, a acquis au fur-à-mesure des années de l'expérience dans différents domaines en lien avec la formation des salariés sur les thèmes de la sécurité des Biens et des Personnes.", "images/formations_categories/form_secu.webp", "securite" },
                    { 4, "<u>Nouveau ! :</u> Nous proposons une partie de nos formations en classe virtuelle. Ces formations à distance via visioconférence nous permettent d'échanger et de faire des démonstrations pratiques avec nos stagiaires.", "images/formations_categories/form_cv.webp", "classe-virtuelle" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormationsCategories");
        }
    }
}
