using System;

namespace DataEncryptionTest.src.algorithms
{
    public class SpeckCompression
    {
        public enum CryptAction { Encrypt, Decrypt };

        const UInt16 MASK16 = 0xFFFF;
        const UInt32 MASK24 = 0xFFFFFF;
        const UInt32 MASK32 = 0xFFFFFFFF;
        const UInt64 MASK48 = 0xFFFFFFFFFFFF;
        const UInt64 MASK64 = 0xFFFFFFFFFFFFFFFF;

        private ushort word;
        private ushort typeBits;
        private ushort keyLen;
        private ushort maxRounds;
        private ulong mask;
        private ushort alpha;
        private ushort beta;

        public SpeckCompression()
        {

        }

        private bool configSpeck(ushort dataSize)
        {
            this.keyLen = 4;
            this.alpha = 8;
            this.beta = 3;

            switch (dataSize)
            {
                case 4:

                    this.word = 16;
                    this.typeBits = 16;
                    this.maxRounds = 22;
                    this.mask = MASK16;
                    this.alpha = 7;
                    this.beta = 2;

                    break;
                case 6:

                    this.word = 24;
                    this.typeBits = 32;
                    this.maxRounds = 23;
                    this.mask = MASK24;

                    break;
                case 8:

                    this.word = 32;
                    this.typeBits = 32;
                    this.maxRounds = 27;
                    this.mask = MASK32;

                    break;
                case 12:

                    this.word = 48;
                    this.typeBits = 64;
                    this.keyLen = 3;
                    this.maxRounds = 29;
                    this.mask = MASK48;

                    break;
                case 16:

                    this.word = 64;
                    this.typeBits = 64;
                    this.maxRounds = 34;
                    this.mask = MASK64;

                    break;

                default:
                    return false;
            }

            return true;
        }

        private ulong rotateRight(ulong x, int n)
        {
            return (((x << (word - n)) | (x >> n)) & mask) & mask;
        }

        private ulong rotateLeft(ulong x, int n)
        {
            return (((x >> (word - n)) | (x << n)) & mask) & mask;
        }

        private void rotate(ref ulong x, ref ulong y, ulong k)
        {
            x = rotateRight(x, alpha);
            x = (x + y) & mask;
            x ^= k;
            y = rotateLeft(y, beta);
            y ^= x;
        }

        private void reverse(ref ulong x, ref ulong y, ulong k)
        {
            y ^= x;
            y = rotateRight(y, beta);
            x ^= k;
            x = (x - y) & mask;
            x = rotateLeft(x, alpha);
        }

        private ulong[] encrypt(ulong[] plainText, ulong[] key, ushort rounds)
        {
            ulong k1 = key[0];
            ulong[] kn = new ulong[keyLen - 1];
            ulong[] cipherText = new ulong[2];

            cipherText[0] = plainText[0];
            cipherText[1] = plainText[1];

            for (ushort i = 0; i < (keyLen - 1); i++)
            {
                kn[i] = key[i + 1];
            }

            rotate(ref cipherText[1], ref cipherText[0], k1);

            for (ushort i = 0; i < rounds - 1; i++)
            {
                rotate(ref kn[i % (keyLen - 1)], ref k1, i);
                rotate(ref cipherText[1], ref cipherText[0], k1);
            }

            return cipherText;
        }

        private ulong[] decrypt(ulong[] cipherText, ulong[] key, ushort rounds)
        {
            ulong kIndex = 0;
            ulong rIndex = 0;

            ulong k1 = key[0];
            ulong[] kn = new ulong[keyLen - 1];
            ulong[] plainText = new ulong[2];

            plainText[0] = cipherText[0];
            plainText[1] = cipherText[1];

            for (ushort i = 0; i < (keyLen - 1); i++)
            {
                kn[i] = key[i + 1];
            }

            for (ushort i = 0; i < rounds - 1; i++)
            {
                rotate(ref kn[i % (keyLen - 1)], ref k1, i);
            }

            for (ushort i = 0; i < rounds; i++)
            {
                kIndex = (ulong)((rounds - 2) - i) % (ulong)(keyLen - 1);
                rIndex = (((ulong)rounds - 2) - i);

                reverse(ref plainText[1], ref plainText[0], k1);
                reverse(ref kn[kIndex], ref k1, rIndex);
            }

            return plainText;
        }

        public byte[] executeCrypt(CryptAction action, byte[] text, ushort dataSize, byte[] key, ushort rounds)
        {
            ulong[] t = new ulong[2];
            ulong[] result = new ulong[2];
            ulong[] k;

            if (!configSpeck(dataSize))
                throw new InvalidDataSizeException(dataSize.ToString());

            byte[] r = new byte[this.word * 2 / 8];

            if (rounds > this.maxRounds)
                rounds = this.maxRounds;

            k = new ulong[keyLen];

            for (int i = 0; i < keyLen; i++)
            {
                Buffer.BlockCopy(key, (this.word / 8) * i, k, (64 / 8) * i, this.word / 8);
            }

            Buffer.BlockCopy(text, 0, t, 0, this.word / 8);

            Buffer.BlockCopy(text, this.word / 8, t, 64 / 8, this.word / 8);

            if (action == CryptAction.Encrypt)
                result = encrypt(t, k, rounds);
            else
                result = decrypt(t, k, rounds);

            Buffer.BlockCopy(result, 0, r, 0, this.word / 8);

            Buffer.BlockCopy(result, 64 / 8, r, this.word / 8, this.word / 8);

            return r;
        }

    }

    public class InvalidDataSizeException : Exception
    {
        public InvalidDataSizeException()
        {
        }

        public InvalidDataSizeException(string dataSize)
             : base(String.Format("Invalid Data Size: {0}", dataSize))
        {

        }

    }
}