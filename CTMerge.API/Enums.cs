namespace CTMerge.API
{
    public class Enums
    {
        public enum DatabaseType
        {
            MySql,
            Cache
        }

        public enum SearchType
        {
            HN,
            Name,
            IDCard
        }

        public enum MergedStatus
        {
            Unmerged,
            Merged
        }
    }
}