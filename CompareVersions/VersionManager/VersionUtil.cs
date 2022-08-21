
namespace VersionManager
{
    public static class VersionUtil
    {
        /// <summary>
        /// Utility method that compare two version numbers and returns 1 whether the first version is greater than the second. Returns -1 whether the 
        /// second parameter is greater than the first. And returns 0 for all other cases.
        /// </summary>
        /// <param name="version1">Version Number 1</param>
        /// <param name="version2">Version Number 2</param>
        /// <returns></returns>
        public static int Compare(string version1, string version2)
        {
            var v1Number = version1.Replace(".", "");
            var v2Number = version2.Replace(".", "");

            int len = 0;

            if (v1Number.Length > v2Number.Length)
                len = v1Number.Length;
            else 
                len = v2Number.Length;

            for (int i = 0; i < len; i++)
            {
                var v1 = v1Number.ElementAtOrDefault(i);
                var v2 = v2Number.ElementAtOrDefault(i);

                if (v1 == v2)
                    continue;

                return v1 > v2 ? 1 : -1;
            }

            return 0;
        }
    }
}
