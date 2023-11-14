using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContableV1.Clases
{
    public class Block
    {
        public int Index { get; set; }
        public DateTime TimeStamp { get; set; }
        public string PreviousHash { get; set; }
        public string Hash { get; set; }
        public AsientoContable Data { get; set; }

        public Block(DateTime timeStamp, string previousHash, AsientoContable data)
        {
            Index = 0;
            TimeStamp = timeStamp;
            PreviousHash = previousHash;
            Data = data;
            Hash = CalculateHash();
        }
        // Función para calcular el hash de cada bloque para garantizar que sea único
        public string CalculateHash()
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                string? v = Data.ToString() + PreviousHash;
                string rawData = v;
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                return Encoding.Default.GetString(bytes);
            }
        }
    }
}
