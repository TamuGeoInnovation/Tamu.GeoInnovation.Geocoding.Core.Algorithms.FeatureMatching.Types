using System;
using System.Collections.Generic;


namespace USC.GISResearchLab.Geocoding.Core.Algorithms.FeatureMatchingMethods
{
    public enum FeatureMatchingAmbiguityType { None, ReferenceFeatureMultipleInstances, ReferenceFeatureOverlappingAddressRanges, InputAddressIncompleteMultiplePossibilities, InputAddressIncorrectMultiplePossibilities, SomethingElse, AmbiguityTypeNotComputable };
}
