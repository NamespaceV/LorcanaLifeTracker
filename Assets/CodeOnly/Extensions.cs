using System.Collections.Generic;

namespace Assets.CodeOnly
{
    public static class Extensions
    {
        public static T Random<T>(this List<T> list)
        {
            var idx = UnityEngine.Random.Range(0, list.Count);
            return list[idx];
        }

    }
}
