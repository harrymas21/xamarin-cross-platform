namespace izCarbo
{
    public interface IPersistentPage
    {
        void Save(string prefix);

        void Restore(string prefix);
    }
}
