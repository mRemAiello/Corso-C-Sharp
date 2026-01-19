using System.Collections;

namespace PatternEDatabase.Iterator;

public class SpotifyCollection : IEnumerable<Song>
{
    private readonly Dictionary<string, Song> _songs = new();

    public void Add(Song song) => _songs.Add(song.Title, song);

    public IEnumerator<Song> GetEnumerator() => new SongIterator(_songs.Values.ToList());

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerable<Song> Favorites()
    {
        foreach (var song in this)
        {
            if (song.IsFavorite)
            {
                yield return song;
            }
        }
    }

    private class SongIterator : IEnumerator<Song>
    {
        private readonly List<Song> _items;
        private int _position = -1;

        public SongIterator(List<Song> items)
        {
            _items = items;
        }

        public Song Current
        {
            get
            {
                if (_position < 0 || _position >= _items.Count)
                {
                    throw new InvalidOperationException("Iteratore in una posizione non valida.");
                }

                return _items[_position];
            }
        }

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            _position++;
            return _position < _items.Count;
        }

        public void Reset() => _position = -1;

        public void Dispose()
        {
        }
    }
}
