using RimDev.AspNetCore.FeatureFlags;

namespace RimDevFeatureFlagsDemo.FeatureFlags
{
    public class LatteFeatureFlag : Feature
    {
        public override string Description { get; } = "Enable Latte coffee";
    }
}
