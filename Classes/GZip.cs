using System.IO;
using System.IO.Compression;

namespace Classes
{
    internal static class GZip
    {
        internal static byte[] Compress(byte[] Data)
        {
            using (MemoryStream stream = new MemoryStream())
            using (GZipStream gzip = new GZipStream(stream, CompressionMode.Compress, false))
            {
                gzip.Write(Data, 0, Data.Length);
                gzip.Close();
                return stream.ToArray();
            }
        }

        internal static byte[] Decompress(byte[] Data)
        {
            using (MemoryStream stream = new MemoryStream(Data))
            using (MemoryStream sr = new MemoryStream())
            using (GZipStream gzip = new GZipStream(stream, CompressionMode.Decompress, false))
            {
                gzip.CopyTo(sr);
                return sr.ToArray();
            }
        }
    }
}
