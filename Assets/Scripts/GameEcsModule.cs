namespace AleVerDes.LeoEcsLiteZoo.Example
{
    public class GameEcsModule : IEcsModule
    {
        public IEcsFeatures AddFeatures(IEcsFeatures features)
        {
            return features
                .Add(new PlayerFeature())
                ;
        }
    }
}