using GalaSoft.MvvmLight.Command;
using System;
using System.Windows;

namespace JellyParfait.Data {

    public class MusicData {

        public int QuereId { get; set; }

        public string Title { get; set; }

        public string Id { get; set; }

        public string Url { get; set; }

        public string YoutubeUrl { get; set; }

        public Visibility Visibility { get; set; }

        public string Color { get; set; }
    }
}
