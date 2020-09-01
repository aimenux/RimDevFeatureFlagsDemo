using RimDev.AspNetCore.FeatureFlags;

namespace RimDevFeatureFlagsDemo.FeatureFlags
{
    public class CappuccinoFeatureFlag : Feature
    {
        public override string Description { get; } = "Enable Cappuccino coffee";
    }
}