using System;


namespace USC.GISResearchLab.Geocoding.Core.Algorithms.FeatureMatchingMethods
{

    [Flags]
    public enum FeatureMatchTypes
    {
        NoMatch = 1,
        Exact = 2,
        Relaxed = 4,
        Substring = 8,
        Soundex = 16,
        Composite = 32,
        Nearby = 64,
        Unknown = 128,
    };
}
