using System;
using System.Collections.Generic;

namespace SupaPlayerLib
{
    public static class MediaTools
    {
        public static List<string> Media { get; set; } = new List<string>();
        public static string Current { get; set; } = string.Empty;

        public static void LoadMedia(string[] playlist)
        {
            foreach (string media in playlist) Media.Add(media);
            Current = playlist[0];
        }
    }
}
