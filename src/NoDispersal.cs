using Landis.Core;
using Landis.SpatialModeling;

namespace Landis.Library.Succession
{
    /// <summary>
    /// Seeding algorithm where no species can seed a neighboring site.
    /// Only the current site is checked.
    /// </summary>
    public static class NoDispersal
    {
        public static (bool, string) Algorithm(ISpecies   species,
                                               ActiveSite site)
        {
            // 2020.10.30 Chihiro
            bool isSeed;
            string estLoc;
            (isSeed, estLoc) = Reproduction.SufficientResources(species, site);
            return (isSeed &&
                    Reproduction.Establish(species, site) &&
                    Reproduction.MaturePresent(species, site),
                    estLoc);
            //return Reproduction.SufficientResources(species, site) &&
            //       Reproduction.Establish(species, site) &&
            //       Reproduction.MaturePresent(species, site);
            //       //SiteVars.Cohorts[site].IsMaturePresent(species);
        }
    }
}
