using JellyParfait.MVVM.Model;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JellyParfait.MVVM.ViewModel
{
    public interface IPlayer
    {
        TimeSpan Current { get; }
        TimeSpan Total { get; }
        int TotalSec { get; }
        int Elapsed { get; }
        bool Loop { get; set; }
        bool Shuffle { get; set; }
        bool WithPlaylist { get; set; }
        bool IsPlaying { get; }
        Music Music { get; set; }

        event EventHandler<StoppedEventArgs> PlayerStopped;

        void Play();
        void Pause();
        void Stop();
    }
}
