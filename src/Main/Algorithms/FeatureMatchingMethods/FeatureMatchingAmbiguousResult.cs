using System;
using System.Collections.Generic;
using USC.GISResearchLab.Common.Addresses;
using USC.GISResearchLab.Common.Core.Geocoders.FeatureMatching;

namespace USC.GISResearchLab.Geocoding.Core.Algorithms.FeatureMatchingMethods
{
    public enum FeatureMatchingAmbiguityType { None, ReferenceFeatureMultipleInstances, ReferenceFeatureOverlappingAddressRanges, InputAddressIncompleteMultiplePossibilities, InputAddressIncorrectMultiplePossibilities, SomethingElse, AmbiguityTypeNotComputable };
}
