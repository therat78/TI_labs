using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace TI_lab3
{
    public class Algorithms
    {
        public static BigInteger ModPow(BigInteger number, BigInteger power, BigInteger modulus)
        {
            return BigInteger.ModPow(number, power, modulus);
        }

        public bool IsPrime(BigInteger n, int k = 10)
        {
            if (n < 2) return false;
            if (n == 2 || n == 3) return true;
            if (n % 2 == 0 || n % 3 == 0) return false;

            BigInteger d = n - 1;
            int s = 0;
            while (d % 2 == 0)
            {
                d /= 2;
                s++;
            }

            Random rand = new Random();
            for (int i = 0; i < k; i++)
            {
                BigInteger a;
                byte[] bytes = new byte[n.ToByteArray().LongLength];
                do
                {
                    rand.NextBytes(bytes);
                    a = new BigInteger(bytes);
                } while (a < 2 || a >= n - 2);

                BigInteger x = BigInteger.ModPow(a, d, n);
                if (x == 1 || x == n - 1)
                    continue;

                for (int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, n);
                    if (x == 1) return false;
                    if (x == n - 1) break;
                }

                if (x != n - 1) return false;
            }
            return true;
        }

        private List<BigInteger> GetPrimeFactors(BigInteger n)
        {
            var factors = new HashSet<BigInteger>();
            BigInteger d = 2;
            while (d * d <= n)
            {
                if (n % d == 0)
                {
                    factors.Add(d);
                    while (n % d == 0)
                    {
                        n /= d;
                    }
                }
                d++;
            }
            if (n > 1)
            {
                factors.Add(n);
            }
            return factors.ToList();
        }

        public List<BigInteger> FindAllPrimitiveRoots(BigInteger p)
        {
            var roots = new List<BigInteger>();
            if (!IsPrime(p))
            {
                return roots;
            }

            BigInteger phi = p - 1;
            List<BigInteger> phiFactors = GetPrimeFactors(phi);

            for (BigInteger g = 2; g < p; g++)
            {
                bool isPrimitive = true;
                foreach (var factor in phiFactors)
                {
                    if (ModPow(g, phi / factor, p) == 1)
                    {
                        isPrimitive = false;
                        break;
                    }
                }
                if (isPrimitive)
                {
                    roots.Add(g);
                }
            }
            return roots;
        }

        public static BigInteger Gcd(BigInteger a, BigInteger b, out BigInteger x, out BigInteger y)
        {
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }
            BigInteger x1, y1;
            BigInteger d = Gcd(b % a, a, out x1, out y1);
            x = y1 - (b / a) * x1;
            y = x1;
            return d;
        }

        public List<BigInteger> Encrypt(byte[] data, BigInteger p, BigInteger g, BigInteger y, BigInteger k)
        {
            var encryptedData = new List<BigInteger>();

            BigInteger a = ModPow(g, k, p);
            encryptedData.Add(a);

            foreach (byte m_byte in data)
            {
                BigInteger m = m_byte;
                BigInteger b = (ModPow(y, k, p) * m) % p;
                encryptedData.Add(b);
            }

            return encryptedData;
        }

        public byte[] Decrypt(List<BigInteger> encryptedData, BigInteger p, BigInteger x)
        {
            var decryptedBytes = new List<byte>();

            if (encryptedData.Count < 2)
            {
                throw new ArgumentException("Неверный формат зашифрованных данных.");
            }

            BigInteger a = encryptedData[0];

            BigInteger power = p - 1 - x;

            for (int i = 1; i < encryptedData.Count; i++)
            {
                BigInteger b = encryptedData[i];
                BigInteger m = (b * ModPow(a, power, p)) % p;
                decryptedBytes.Add((byte)m);
            }

            return decryptedBytes.ToArray();
        }
    }
}