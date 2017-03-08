using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharpExercises
{
    public struct TrackData
    {
        public string trackName;

        public string artistName;

        public string albumName;

        public float trackTime; 

        public int trackNumber; 

        public TrackData(string track)
        {
            trackName = track;
            artistName = "";
            albumName = "";
            trackTime = 0;
            trackNumber = 0;
        }
        public TrackData(string track, float duration)
        {
            trackName = track;
            trackTime = duration;
            artistName = "";
            albumName = "";
            trackNumber = 0;
        }
        public TrackData(string track, float duration,string artist)
        {
            trackName = track;
            trackTime = duration;
            artistName = artist;
            albumName = "";
            trackNumber = 0;
        }
        public TrackData(string track, float duration, string artist, string album)
        {
            trackName = track;
            trackTime = duration;
            artistName = artist;
            albumName = album;
            trackNumber = 0;
        }

        public static bool operator  == (TrackData lhs, TrackData rhs)
        {
            return (lhs.trackName == rhs.trackName &&
                    lhs.trackTime == rhs.trackTime &&
                    lhs.artistName== rhs.artistName&&
                    lhs.albumName == rhs.albumName &&
                    lhs.trackNumber==rhs.trackNumber);
        }
        public static bool operator != (TrackData lhs, TrackData rhs)
        {
            return (lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            return obj is TrackData && this == (TrackData)obj;
        }
        public override int GetHashCode()
        {
            return trackName.GetHashCode() ^ artistName.GetHashCode() ^ albumName.GetHashCode() ^ trackTime.GetHashCode() ^ trackNumber.GetHashCode();
        }
        public override string ToString()
        {
            return String.Format("[{0},{1},{2},{3},{4}]", trackName, artistName,albumName,trackTime,trackNumber);
        }
    }
}

