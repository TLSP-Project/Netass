
using TLSP.Common.Cryptography;

namespace TLSP.Netass.Utilities
{
    public static class UUIDHelper
    {
        public static string CompleteNetGameUUID(string roleName, uint userID)
        {
            var result = HashHelper.SafeCompleteMD5(Encoding.UTF8.GetBytes(roleName));

            var enUserID = BitConverter.GetBytes(UUIDCodec.Encrypt(userID));

            Buffer.BlockCopy(enUserID, 0, result, 12, enUserID.Length);

            result[6] &= 0xf;
            result[6] |= 0x40;

            result[8] &= 0x3f;
            result[8] |= 0x80;

            return result.ToHex(true);

        }


        public static uint CompleteUserIdFromUUID(string uuid)
        {
            uuid = uuid.Replace("-", "");
            if (uuid.Length != 32)
                throw new ArgumentException("UUID长度必须为32字符");
            byte[] value = uuid.HexToBytes();
            uint userIDEn = BitConverter.ToUInt32(value, 12);
            return UUIDCodec.Decrypt(userIDEn);
        }

        public static Skip32 UUIDCodec { get; } = new Skip32(Encoding.UTF8.GetBytes("SaintSteve"));
    }
}
