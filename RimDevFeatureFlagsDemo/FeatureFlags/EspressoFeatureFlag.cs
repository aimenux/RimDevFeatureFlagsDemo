using RimDev.AspNetCore.FeatureFlags;

namespace RimDevFeatureFlagsDemo.FeatureFlags
{
    public class EspressoFeatureFlag : Feature
    {
        public override string Description { get; } = "Enable Espresso coffee";

        public EspressoFeatureFlag()
        {
            Value = true;
        }
    }
}