using System;
using System.Text;

namespace Transcription.Win
{
    public class StringHelper
    {
        public static string Replace(string str, string[] from, string[] to)
        {
            if (string.IsNullOrEmpty(str) || from == null || from.Length == 0 || to == null || to.Length == 0)
                return str;

            if (from.Length != to.Length)
                throw new ArgumentException($"'{nameof(from)}' and '{nameof(to)}' params size must be same",
                    nameof(to));

            var sb = new StringBuilder(str);
            for (var i = 0; i < from.Length; i++)
            {
                sb.Replace(from[i], to[i]);
            }

            return sb.ToString();
        }

    }
}
