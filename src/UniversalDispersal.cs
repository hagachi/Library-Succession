using Landis.Core;
using Landis.SpatialModeling;

namespace Landis.Library.Succession
{
    /// <summary>
    /// Seeding algorithm where every species can seed any site; a species does
    /// not even need to be present in any neighboring site.
    /// </summary>
    public static class UniversalDispersal
    {
        public static (bool, string) Algorithm(ISpecies   species,
                                               ActiveSite site)
        {
            // 2020.10.30 Chihiro
            bool isSeed;
            string estLoc;
            (isSeed, estLoc) = Reproduction.SufficientResources(species, site);
            return (isSeed && Reproduction.Establish(species, site),
                    estLoc);
            //return Reproduction.SufficientResources(species, site) &&
            //       Reproduction.Establish(species, site);
        }
    }
}
