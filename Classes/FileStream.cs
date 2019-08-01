using System;
using System.Collections.Generic;

namespace TCPSocket
{
    [Serializable]
    public class FStream
    {
        public _File File = new _File();
        public _Items Items = new _Items();
        private readonly string[] Files;
        private long _ChunkSize = 2 * 512000;
        
        /// <summary>
        /// <code>Initializes a new instance of the <see cref="FStream"/> class</code>
        /// </summary>
        /// <exception cref="System.IO.FileNotFoundException"/>
        /// <exception cref="System.IO.PathTooLongException"/>
        /// <param name="Files">A collection of files with their fully qualified names</param>
        /// 
        public FStream(string[] Files, long ChunkSize)
        {
            foreach (string file in Files)
            { Length += new System.IO.FileInfo(file).Length; }
            Items.Length = Files.Length;
            this.Files = Files; this._ChunkSize = ChunkSize;
        }

        public IEnumerable<byte[]> ReadFiles()
        {
            foreach (string file in Files)
            {
                Items.Count += 1;
                foreach (byte[] buffer in GetChunk(file))
                { yield return buffer; }
            }
        }

        private IEnumerable<byte[]> GetChunk(string file)
        {
            long ChunkSize = _ChunkSize;
            using (System.IO.FileStream fs = System.IO.File.OpenRead(file))
            {
                while (fs.Position < fs.Length)
                {
                    ChunkSize = Math.Min(ChunkSize, fs.Length);
                    byte[] data = new byte[ChunkSize];
                    fs.Read(data, 0, data.Length);
                    if ((fs.Length - fs.Position) < ChunkSize)
                    { ChunkSize = (fs.Length - fs.Position); }
                    
                    FileName = System.IO.Path.GetFileName(file);
                    File.Position = fs.Position;
                    File.Length = fs.Length;
                    File.Buffer = data;
                    Position += File.Buffer.Length;

                    yield return data;
                }
            }
        }
        public string ID
        {
            get;
            private set;
        } = Guid.NewGuid().ToString();
        public string FileName
        {
            get;
            set;
        }
        public float  Length
        {
            get;
            set;
        }
        public float  Position
        {
            get;
            set;
        }
        [Serializable]
        public class _Items
        {
            public int Length
            {
                get;
                set;
            }
            public int Count
            {
                get;
                set;
            }
        }
        [Serializable]
        public class _File
        {
            public float Position
            {
                get;
                set;
            }
            public float Length
            {
                get;
                set;
            }
            public byte[] Buffer
            {
                get;
                set;
            }
        }
    }
}
