using ecocivicom_blazor_clone.Shared;
using Microsoft.AspNetCore.Components;

namespace ecocivicom_blazor_clone.Pages
{

    public partial class Index : ComponentBase
    {
        readonly List<MainMenuSubElement> HighlightedElements = new()
        {
            new MainMenuSubElement("Eco-Conduite & Risque Routier", "nos-formations/eco-conduite-risque-routier"),
            new MainMenuSubElement("Sécurité des Biens et des Personnes", "nos-ateliers/sécurité-environnement"),
            new MainMenuSubElement("Bien-être", "nos-ateliers/bien-etre"),
            new MainMenuSubElement("Réalité Virtuelle", "nos-ateliers/réalité-virtuelle"),
            new MainMenuSubElement("Escape Games", "escape-games/risque-routier"),
        };

        readonly string knowMoreLink = "nos-ateliers/réalité-virtuelle";

        public List<AtelierFormationCard> AtelierFormationCards = new()
        {
            new AtelierFormationCard
            {
                TitleWithLink = new CasualLink("Nos formations en Prévention des Risques", "nos-formations"),
                Description = "Nous intervenons sur différents domaines dans la prévention des risques. Nos  sessions de formations ont une durée de 3h30 à 14 H. Nos formations se déroulent en intra-entreprise ou inter-entreprise. Nous innovons constamment pour proposer des formations avec du matériel ludique. Nous adaptons constamment à nos clients pour leur proposer des sessions sur mesure tenant compte des contraintes de leur activité. Nous proposons 3 grandes familles de formation :",
                ImageLink = $"images/prévention.jpg",
                ImageAlternativeText = "formation prévention",
                MainColor = "bg-lightblue",
                Links = new List<CasualLink>()
                {
                    new CasualLink("Formation Eco-Conduite", "nos-formations/eco-conduite"),
                    new CasualLink("Formation Risque Routier", "nos-formations/risque-routier"),
                    new CasualLink("Formation Sécurité & Environnement", "nos-formations/sécurité-environnement"),
                }
            },
            new AtelierFormationCard
            {
                TitleWithLink = new CasualLink("Nos Ateliers Safety Day", "nos-ateliers"),
                Description = "Nous proposons plus de 60 ateliers de prévention en entreprise, et utilisons tous les moyens de simulation modernes pour sensibiliser de manière ludique vos salariés. Nous intervenons partout en France et dans tous types de'entreprise (Bureau, entrepôts, usines, ERP,...). Nous couvrons plus de 15 risques en entreprise, et proposons plus de 20 ateliers sur le Risque Routier (Voiture Tonneau, Simulateur de conduite, réalité Virtuelle, Escape Game...). Nos ateliers Safety Day sont présentés sous 4 thématiques : ",
                ImageLink = $"images/prévention2.jpg",
                ImageAlternativeText = "formation prévention",
                MainColor = "bg-orange",
                Links = new List<CasualLink>()
                {
                    new CasualLink("Atelier Eco-Conduite & Risque Routier", "nos-ateliers/eco-conduite-risque-routier"),
                    new CasualLink("Atelier Bien Etre", "nos-ateliers/bien-etre"),
                    new CasualLink("Atelier Sécurité & Environnement", "nos-ateliers/sécurité-environnement"),
                    new CasualLink("Atelier Réalité Virtuelle", "nos-ateliers/réalité-virtuelle"),
                }
            },
        };

        public string SectionTitlePrestations = "Découvrez nos prestations en vidéo";
        public string SectionTitleInterventions = "Intervention France Entière";
        public string SectionTitleHistory = "Notre histoire";
    }
}