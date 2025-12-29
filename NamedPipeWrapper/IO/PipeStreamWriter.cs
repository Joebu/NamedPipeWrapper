using System;
using System.IO;
using System.IO.Pipes;
using System.Net;
using System.Text.Json;

namespace NamedPipeWrapper.IO
{
    /// <summary>
    /// Wraps a <see cref="PipeStream"/> object and writes to it. Serializes .NET CLR objects specified by <typeparamref name="T"/>
    /// into binary form and sends them over the named pipe for a <see cref="PipeStreamWriter{T}"/> to read and deserialize.
    /// </summary>
    /// <typeparam name="T">Reference type to serialize</typeparam>
    public class PipeStreamWriter<T> where T : class
    {
        /// <summary>
        /// Gets the underlying <c>PipeStream</c> object.
        /// </summary>
        public PipeStream BaseStream { get; private set; }

        /// <summary>
        /// Constructs a new <c>PipeStreamWriter</c> object that writes to given <paramref name="stream"/>.
        /// </summary>
        /// <param name="stream">Pipe to write to</param>
        public PipeStreamWriter(PipeStream stream)
        {
            BaseStream = stream;
        }

        #region Private stream writers

        private byte[] Serialize(T obj)
        {
            try
            {
                return JsonSerializer.SerializeToUtf8Bytes(obj);
            }
            catch
            {
                // If any exception in the serialize, it will stop named pipe wrapper, so ignore any exception.
                return null;
            }
        }

        private void WriteLength(int len)
        {
            var lenbuf = BitConverter.GetBytes(IPAddress.HostToNetworkOrder(len));
            BaseStream.Write(lenbuf, 0, lenbuf.Length);
        }

        private void WriteObject(byte[] data)
        {
            BaseStream.Write(data, 0, data.Length);
        }

        private void Flush()
        {
            BaseStream.Flush();
        }

        #endregion

        /// <summary>
        /// Writes an object to the pipe. This method blocks until all data is sent.
        /// </summary>
        /// <param name="obj">Object to write to the pipe</param>
        public void WriteObject(T obj)
        {
            var data = Serialize(obj);
            WriteLength(data.Length);
            WriteObject(data);
            Flush();
        }

        /// <summary>
        /// Waits for the other end of the pipe to read all sent bytes.
        /// </summary>
        public void WaitForPipeDrain()
        {
            BaseStream.WaitForPipeDrain();
        }
    }
}