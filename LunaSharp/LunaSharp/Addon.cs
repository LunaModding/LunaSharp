namespace LunaSharp
{
    public class Addon
    {
        private string _id;
        private AddonMetadata _metadata;

        public Addon(string id, AddonMetadata metadata)
        {
            _id = id;
            _metadata = metadata;
        }

        public string Id { get => _id; }
        public AddonMetadata Metadata { get => _metadata; }
    }
}
