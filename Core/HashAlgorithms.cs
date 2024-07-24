using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charon_Hash_Detector.Core
{
    class HashAlgorithms
    {
        // CRC16
        public static void CRC16(string hash)
        {
            string hs = "4607";
            if (hash.Length == hs.Length && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("101020");
            }
        }

        // CRC16CCITT
        public static void CRC16CCITT(string hash)
        {
            string hs = "3d08";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("101040");
            }
        }

        // FCS16
        public static void FCS16(string hash)
        {
            string hs = "0e5b";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("101060");
            }
        }

        // CRC32
        public static void CRC32(string hash)
        {
            string hs = "b33fd057";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("102040");
            }
        }

        // ADLER32
        public static void ADLER32(string hash)
        {
            string hs = "0607cb42";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("102020");
            }
        }

        // CRC32B
        public static void CRC32B(string hash)
        {
            string hs = "b764a0d9";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("102060");
            }
        }

        // XOR32
        public static void XOR32(string hash)
        {
            string hs = "0000003f";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("102080");
            }
        }

        // GHash323
        public static void GHash323(string hash)
        {
            string hs = "80000000";
            if (hash.Length == hs.Length && hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("103040");
            }
        }

        // GHash325
        public static void GHash325(string hash)
        {
            string hs = "85318985";
            if (hash.Length == hs.Length && hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("103020");
            }
        }

        // DESUnix
        public static void DESUnix(string hash)
        {
            string hs = "ZiY8YtDKXJwYQ";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter))
            {
                Config.jerar.Add("104020");
            }
        }

        // MD5Half
        public static void MD5Half(string hash)
        {
            string hs = "ae11fd697ec92c7c";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("105060");
            }
        }

        // MD5Middle
        public static void MD5Middle(string hash)
        {
            string hs = "7ec92c7c98de3fac";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("105040");
            }
        }

        // MySQL
        public static void MySQL(string hash)
        {
            string hs = "63cea4673fd25f46";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("105020");
            }
        }


        // DomainCachedCredentials method converted to C#
        public static void DomainCachedCredentials(string hash)
        {
            string hs = "f42005ec1afe77967cbc83dce1b4d714";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106025");
            }
        }

        // Haval128 method converted to C#
        public static void Haval128(string hash)
        {
            string hs = "d6e3ec49aa0f138a619f27609022df10";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106160");
            }
        }

        // Haval128HMAC method converted to C#
        public static void Haval128HMAC(string hash)
        {
            string hs = "3ce8b0ffd75bc240fc7d967729cd6637";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106165");
            }
        }

        // MD2 method converted to C#
        public static void MD2(string hash)
        {
            string hs = "08bbef4754d98806c373f2cd7d9a43c4";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106060");
            }
        }

        // MD2HMAC method converted to C#
        public static void MD2HMAC(string hash)
        {
            string hs = "4b61b72ead2b0eb0fa3b8a56556a6dca";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106120");
            }
        }

        // MD4 method converted to C#
        public static void MD4(string hash)
        {
            string hs = "a2acde400e61410e79dacbdfc3413151";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106040");
            }
        }

        // MD4HMAC method converted to C#
        public static void MD4HMAC(string hash)
        {
            string hs = "6be20b66f2211fe937294c1c95d1cd4f";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106100");
            }
        }

        // MD5 method converted to C#
        public static void MD5(string hash)
        {
            string hs = "ae11fd697ec92c7c98de3fac23aba525";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106020");
            }
        }

        // MD5HMAC method converted to C#
        public static void MD5HMAC(string hash)
        {
            string hs = "d57e43d2c7e397bf788f66541d6fdef9";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106080");
            }
        }

        // MD5HMACWordpress method converted to C#
        public static void MD5HMACWordpress(string hash)
        {
            string hs = "3f47886719268dfa83468630948228f6";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106140");
            }
        }

        // NTLM method converted to C#
        public static void NTLM(string hash)
        {
            string hs = "cc348bace876ea440a28ddaeb9fd3550";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106029");
            }
        }

        // RAdminv2x method converted to C#
        public static void RAdminv2x(string hash)
        {
            string hs = "baea31c728cbf0cd548476aa687add4b";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106027");
            }
        }

        // RipeMD128 method converted to C#
        public static void RipeMD128(string hash)
        {
            string hs = "4985351cd74aff0abc5a75a0c8a54115";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106180");
            }
        }



        // RipeMD128HMAC
        public static void RipeMD128HMAC(string hash)
        {
            string hs = "ae1995b931cf4cbcf1ac6fbf1a83d1d3";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106185");
            }
        }

        // SNEFRU128
        public static void SNEFRU128(string hash)
        {
            string hs = "4fb58702b617ac4f7ca87ec77b93da8a";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106200");
            }
        }

        // SNEFRU128HMAC
        public static void SNEFRU128HMAC(string hash)
        {
            string hs = "59b2b9dcc7a9a7d089cecf1b83520350";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106205");
            }
        }

        // Tiger128
        public static void Tiger128(string hash)
        {
            string hs = "c086184486ec6388ff81ec9f23528727";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106220");
            }
        }

        // Tiger128HMAC
        public static void Tiger128HMAC(string hash)
        {
            string hs = "c87032009e7c4b2ea27eb6f99723454b";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106225");
            }
        }

        // md5passsalt
        public static void md5passsalt(string hash)
        {
            string hs = "5634cc3b922578434d6e9342ff5913f7";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106240");
            }
        }

        // md5saltmd5pass
        public static void md5saltmd5pass(string hash)
        {
            string hs = "245c5763b95ba42d4b02d44bbcd916f1";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106260");
            }
        }

        // md5saltpass
        public static void md5saltpass(string hash)
        {
            string hs = "22cc5ce1a1ef747cd3fa06106c148dfa";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106280");
            }
        }

        // md5saltpasssalt
        public static void md5saltpasssalt(string hash)
        {
            string hs = "469e9cdcaff745460595a7a386c4db0c";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106300");
            }
        }

        // md5saltpassusername
        public static void md5saltpassusername(string hash)
        {
            string hs = "9ae20f88189f6e3a62711608ddb6f5fd";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106320");
            }
        }

        // md5saltmd5pass
        public static void md5saltmd5pass2(string hash)
        {
            string hs = "aca2a052962b2564027ee62933d2382f";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106340");
            }
        }

        // md5saltmd5passsalt
        public static void md5saltmd5passsalt(string hash)
        {
            string hs = "de0237dc03a8efdf6552fbe7788b2fdd";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106360");
            }
        }

        // md5saltmd5passsalt
        public static void md5saltmd5passsalt2(string hash)
        {
            string hs = "5b8b12ca69d3e7b2a3e2308e7bef3e6f";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106380");
            }
        }

        // md5saltmd5saltpass
        public static void md5saltmd5saltpass(string hash)
        {
            string hs = "d8f3b3f004d387086aae24326b575b23";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106400");
            }
        }


        public static void md5saltmd5md5passsalt(string hash)
        {
            string hs = "81f181454e23319779b03d74d062b1a2";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106420");
            }
        }

        public static void md5username0pass(string hash)
        {
            string hs = "e44a60f8f2106492ae16581c91edb3ba";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106440");
            }
        }

        public static void md5usernameLFpass(string hash)
        {
            string hs = "654741780db415732eaee12b1b909119";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106460");
            }
        }

        public static void md5usernamemd5passsalt(string hash)
        {
            string hs = "954ac5505fd1843bbb97d1b2cda0b98f";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106480");
            }
        }

        public static void md5md5pass(string hash)
        {
            string hs = "a96103d267d024583d5565436e52dfb3";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106500");
            }
        }

        public static void md5md5passsalt(string hash)
        {
            string hs = "5848c73c2482d3c2c7b6af134ed8dd89";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106520");
            }
        }

        public static void md5md5passmd5salt(string hash)
        {
            string hs = "8dc71ef37197b2edba02d48c30217b32";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106540");
            }
        }

        public static void md5md5saltpass(string hash)
        {
            string hs = "9032fabd905e273b9ceb1e124631bd67";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106560");
            }
        }

        public static void md5md5saltmd5pass(string hash)
        {
            string hs = "8966f37dbb4aca377a71a9d3d09cd1ac";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106580");
            }
        }

        public static void md5md5usernamepasssalt(string hash)
        {
            string hs = "4319a3befce729b34c3105dbc29d0c40";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106600");
            }
        }

        public static void md5md5md5pass(string hash)
        {
            string hs = "ea086739755920e732d0f4d8c1b6ad8d";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106620");
            }
        }

        public static void md5md5md5md5pass(string hash)
        {
            string hs = "02528c1f2ed8ac7d83fe76f3cf1c133f";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106640");
            }
        }

        public static void md5md5md5md5md5pass(string hash)
        {
            string hs = "4548d2c062933dff53928fd4ae427fc0";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106660");
            }
        }

        public static void md5sha1pass(string hash)
        {
            string hs = "cb4ebaaedfd536d965c452d9569a6b1e";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit))
            {
                Config.jerar.Add("106680");
            }
        }



        // =========================================================
        public static void md5sha1md5pass(string hash)
        {
            string hs = "099b8a59795e07c334a696a10c0ebce0";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("106700");
            }
        }

        public static void md5sha1md5sha1pass(string hash)
        {
            string hs = "06e4af76833da7cc138d90602ef80070";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("106720");
            }
        }

        public static void md5strtouppermd5pass(string hash)
        {
            string hs = "519de146f1a658ab5e5e2aa9b7d2eec8";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("106740");
            }
        }

        public static void LineageIIC4(string hash)
        {
            string hs = "0x49a57f66bd3d5ba6abda5579c264a0e4";
            if (IsHashValid(hash, hs) && hash.StartsWith("0x"))
            {
                Config.jerar.Add("107080");
            }
        }

        public static void MD5phpBB3(string hash)
        {
            string hs = "$H$9kyOtE8CDqMJ44yfn9PFz2E.L2oVzL1";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && !hash.All(char.IsLetterOrDigit) && hash.StartsWith("$H$"))
            {
                Config.jerar.Add("107040");
            }
        }

        public static void MD5Unix(string hash)
        {
            string hs = "$1$cTuJH0Ju$1J8rI.mJReeMvpKUZbSlY/";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && !hash.All(char.IsLetterOrDigit) && hash.StartsWith("$1$"))
            {
                Config.jerar.Add("107060");
            }
        }

        public static void MD5Wordpress(string hash)
        {
            string hs = "$P$BiTOhOj3ukMgCci2juN0HRbCdDRqeh.";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && !hash.All(char.IsLetterOrDigit) && hash.StartsWith("$P$"))
            {
                Config.jerar.Add("107020");
            }
        }

        public static void MD5APR(string hash)
        {
            string hs = "$apr1$qAUKoKlG$3LuCncByN76eLxZAh/Ldr1";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.StartsWith("$apr"))
            {
                Config.jerar.Add("108020");
            }
        }

        public static void Haval160(string hash)
        {
            string hs = "a106e921284dd69dad06192a4411ec32fce83dbb";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109100");
            }
        }

        public static void Haval160HMAC(string hash)
        {
            string hs = "29206f83edc1d6c3f680ff11276ec20642881243";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109200");
            }
        }

        public static void MySQL5(string hash)
        {
            string hs = "9bb2fb57063821c762cc009f7584ddae9da431ff";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109040");
            }
        }

        public static void MySQL160bit(string hash)
        {
            string hs = "*2470c0c06dee42fd1618bb99005adca2ec9d1e19";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && !hash.All(char.IsLetterOrDigit) && hash.StartsWith("*"))
            {
                Config.jerar.Add("109060");
            }
        }

        public static void RipeMD160(string hash)
        {
            string hs = "dc65552812c66997ea7320ddfb51f5625d74721b";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109120");
            }
        }

        public static void RipeMD160HMAC(string hash)
        {
            string hs = "ca28af47653b4f21e96c1235984cb50229331359";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109180");
            }
        }


        // =========================================================

        public static void SHA1(string hash)
        {
            string hs = "4a1d4dbc1e193ec3ab2e9213876ceb8f4db72333";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109020");
            }
        }

        public static void SHA1HMAC(string hash)
        {
            string hs = "6f5daac3fee96ba1382a09b1ba326ca73dccf9e7";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109140");
            }
        }

        public static void SHA1MaNGOS(string hash)
        {
            string hs = "a2c0cdb6d1ebd1b9f85c6e25e0f8732e88f02f96";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109220");
            }
        }

        public static void SHA1MaNGOS2(string hash)
        {
            string hs = "644a29679136e09d0bd99dfd9e8c5be84108b5fd";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109240");
            }
        }

        public static void Tiger160(string hash)
        {
            string hs = "c086184486ec6388ff81ec9f235287270429b225";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109080");
            }
        }

        public static void Tiger160HMAC(string hash)
        {
            string hs = "6603161719da5e56e1866e4f61f79496334e6a10";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109160");
            }
        }

        public static void sha1passsalt(string hash)
        {
            string hs = "f006a1863663c21c541c8d600355abfeeaadb5e4";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109260");
            }
        }

        public static void sha1saltpass(string hash)
        {
            string hs = "299c3d65a0dcab1fc38421783d64d0ecf4113448";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109280");
            }
        }

        public static void sha1saltmd5pass(string hash)
        {
            string hs = "860465ede0625deebb4fbbedcb0db9dc65faec30";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109300");
            }
        }

        public static void sha1saltmd5passsalt(string hash)
        {
            string hs = "6716d047c98c25a9c2cc54ee6134c73e6315a0ff";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109320");
            }
        }

        public static void sha1saltsha1pass(string hash)
        {
            string hs = "58714327f9407097c64032a2fd5bff3a260cb85f";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109340");
            }
        }

        public static void sha1saltsha1saltsha1pass(string hash)
        {
            string hs = "cc600a2903130c945aa178396910135cc7f93c63";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109360");
            }
        }

        public static void sha1usernamepass(string hash)
        {
            string hs = "3de3d8093bf04b8eb5f595bc2da3f37358522c9f";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109380");
            }
        }

        public static void sha1usernamepasssalt(string hash)
        {
            string hs = "00025111b3c4d0ac1635558ce2393f77e94770c5";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109400");
            }
        }

        // ===============================================================

        public static void sha1md5pass(string hash)
        {
            string hs = "fa960056c0dea57de94776d3759fb555a15cae87";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("1094202");
            }
        }

        public static void sha1md5passsalt(string hash)
        {
            string hs = "1dad2b71432d83312e61d25aeb627593295bcc9a";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109440");
            }
        }

        public static void sha1md5sha1pass(string hash)
        {
            string hs = "8bceaeed74c17571c15cdb9494e992db3c263695";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109460");
            }
        }

        public static void sha1sha1pass(string hash)
        {
            string hs = "3109b810188fcde0900f9907d2ebcaa10277d10e";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109480");
            }
        }

        public static void sha1sha1passsalt(string hash)
        {
            string hs = "780d43fa11693b61875321b6b54905ee488d7760";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109500");
            }
        }

        public static void sha1sha1passsubstrpass03(string hash)
        {
            string hs = "5ed6bc680b59c580db4a38df307bd4621759324e";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109520");
            }
        }

        public static void sha1sha1saltpass(string hash)
        {
            string hs = "70506bac605485b4143ca114cbd4a3580d76a413";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109540");
            }
        }

        public static void sha1sha1sha1pass(string hash)
        {
            string hs = "3328ee2a3b4bf41805bd6aab8e894a992fa91549";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109560");
            }
        }

        public static void sha1strtolowerusernamepass(string hash)
        {
            string hs = "79f575543061e158c2da3799f999eb7c95261f07";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("109580");
            }
        }

        public static void Haval192(string hash)
        {
            string hs = "cd3a90a3bebd3fa6b6797eba5dab8441f16a7dfa96c6e641";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("110040");
            }
        }

        public static void Haval192HMAC(string hash)
        {
            string hs = "39b4d8ecf70534e2fd86bb04a877d01dbf9387e640366029";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("110080");
            }
        }

        public static void Tiger192(string hash)
        {
            string hs = "c086184486ec6388ff81ec9f235287270429b2253b248a70";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("110020");
            }
        }

        public static void Tiger192HMAC(string hash)
        {
            string hs = "8e914bb64353d4d29ab680e693272d0bd38023afa3943a41";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("110060");
            }
        }

        public static void MD5passsaltjoomla1(string hash)
        {
            string hs = "35d1c0d69a2df62be2df13b087343dc9:BeKMviAfcXeTPTlX";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && !hash.All(char.IsLetterOrDigit) && hash.Substring(32, 1) == ":")
            {
                Config.jerar.Add("112020");
            }
        }


        // =====================================================
        public static void SHA1Django(string hash)
        {
            string hs = "sha1$Zion3R$299c3d65a0dcab1fc38421783d64d0ecf4113448";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && !hash.All(char.IsLetterOrDigit) && hash.Substring(0, 5).Contains("sha1$"))
            {
                Config.jerar.Add("113020");
            }
        }

        public static void Haval224(string hash)
        {
            string hs = "f65d3c0ef6c56f4c74ea884815414c24dbf0195635b550f47eac651a";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("114040");
            }
        }

        public static void Haval224HMAC(string hash)
        {
            string hs = "f10de2518a9f7aed5cf09b455112114d18487f0c894e349c3c76a681";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("114080");
            }
        }

        public static void SHA224(string hash)
        {
            string hs = "e301f414993d5ec2bd1d780688d37fe41512f8b57f6923d054ef8e59";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("114020");
            }
        }

        public static void SHA224HMAC(string hash)
        {
            string hs = "c15ff86a859892b5e95cdfd50af17d05268824a6c9caaa54e4bf1514";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("114060");
            }
        }

        public static void SHA256(string hash)
        {
            string hs = "2c740d20dab7f14ec30510a11f8fd78b82bc3a711abe8a993acdb323e78e6d5e";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("115020");
            }
        }

        public static void SHA256HMAC(string hash)
        {
            string hs = "d3dd251b7668b8b6c12e639c681e88f2c9b81105ef41caccb25fcde7673a1132";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("115120");
            }
        }

        public static void Haval256(string hash)
        {
            string hs = "7169ecae19a5cd729f6e9574228b8b3c91699175324e6222dec569d4281d4a4a";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("115040");
            }
        }

        public static void Haval256HMAC(string hash)
        {
            string hs = "6aa856a2cfd349fb4ee781749d2d92a1ba2d38866e337a4a1db907654d4d4d7a";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("115140");
            }
        }

        public static void GOSTR341194(string hash)
        {
            string hs = "ab709d384cce5fda0793becd3da0cb6a926c86a8f3460efb471adddee1c63793";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("115060");
            }
        }

        public static void RipeMD256(string hash)
        {
            string hs = "5fcbe06df20ce8ee16e92542e591bdea706fbdc2442aecbf42c223f4461a12af";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("115080");
            }
        }

        public static void RipeMD256HMAC(string hash)
        {
            string hs = "43227322be1b8d743e004c628e0042184f1288f27c13155412f08beeee0e54bf";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("115160");
            }
        }

        public static void SNEFRU256(string hash)
        {
            string hs = "3a654de48e8d6b669258b2d33fe6fb179356083eed6ff67e27c5ebfa4d9732bb";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("115100");
            }
        }

        public static void SNEFRU256HMAC(string hash)
        {
            string hs = "4e9418436e301a488f675c9508a2d518d8f8f99e966136f2dd7e308b194d74f9";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("115180");
            }
        }

        // ====================================================================

        public static void SHA256md5pass(string hash)
        {
            string hs = "b419557099cfa18a86d1d693e2b3b3e979e7a5aba361d9c4ec585a1a70c7bde4";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("115200");
            }
        }

        public static void SHA256sha1pass(string hash)
        {
            string hs = "afbed6e0c79338dbfe0000efe6b8e74e3b7121fe73c383ae22f5b505cb39c886";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("115220");
            }
        }

        public static void MD5passsaltjoomla2(string hash)
        {
            string hs = "fb33e01e4f8787dc8beb93dac4107209:fxJUXVjYRafVauT77Cze8XwFrWaeAYB2";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && !hash.All(char.IsLetterOrDigit) && hash.Substring(32, 1).Contains(":"))
            {
                Config.jerar.Add("116020");
            }
        }

        public static void SAM(string hash)
        {
            string hs = "4318B176C3D8E3DEAAD3B435B51404EE:B7C899154197E8A2A33121D76A240AB5";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && !hash.All(char.IsLetterOrDigit) && !hash.ToLower().Equals(hash) && hash.Substring(32, 1).Contains(":"))
            {
                Config.jerar.Add("116040");
            }
        }

        public static void SHA256Django(string hash)
        {
            string hs = "sha256$Zion3R$9e1a08aa28a22dfff722fad7517bae68a55444bb5e2f909d340767cec9acf2c3";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && !hash.All(char.IsLetterOrDigit) && hash.Substring(0, 6).Contains("sha256"))
            {
                Config.jerar.Add("117020");
            }
        }

        public static void RipeMD320(string hash)
        {
            string hs = "b4f7c8993a389eac4f421b9b3b2bfb3a241d05949324a8dab1286069a18de69aaf5ecc3c2009d8ef";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("118020");
            }
        }

        public static void RipeMD320HMAC(string hash)
        {
            string hs = "244516688f8ad7dd625836c0d0bfc3a888854f7c0161f01de81351f61e98807dcd55b39ffe5d7a78";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("118040");
            }
        }

        public static void SHA384(string hash)
        {
            string hs = "3b21c44f8d830fa55ee9328a7713c6aad548fe6d7a4a438723a0da67c48c485220081a2fbc3e8c17fd9bd65f8d4b4e6b";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("119020");
            }
        }

        public static void SHA384HMAC(string hash)
        {
            string hs = "bef0dd791e814d28b4115eb6924a10beb53da47d463171fe8e63f68207521a4171219bb91d0580bca37b0f96fddeeb8b";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("119040");
            }
        }

        public static void SHA256s(string hash)
        {
            string hs = "$6$g4TpUQzk$OmsZBJFwvy6MwZckPvVYfDnwsgktm2CckOlNJGy9HNwHSuHFvywGIuwkJ6Bjn3kKbB6zoyEjIYNMpHWBNxJ6g.";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && !hash.All(char.IsLetterOrDigit) && hash.Substring(0, 3).Contains("$6$"))
            {
                Config.jerar.Add("120020");
            }
        }

        public static void SHA384Django(string hash)
        {
            string hs = "sha384$Zion3R$88cfd5bc332a4af9f09aa33a1593f24eddc01de00b84395765193c3887f4deac46dc723ac14ddeb4d3a9b958816b7bba";
            if (hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && !hash.All(char.IsLetterOrDigit) && hash.Substring(0, 6).Contains("sha384"))
            {
                Config.jerar.Add("121020");
            }
        }

        public static void SHA512(string hash)
        {
            string hs = "ea8e6f0935b34e2e6573b89c0856c81b831ef2cadfdee9f44eb9aa0955155ba5e8dd97f85c73f030666846773c91404fb0e12fb38936c56f8cf38a33ac89a24e";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("122020");
            }
        }

        public static void SHA512HMAC(string hash)
        {
            string hs = "dd0ada8693250b31d9f44f3ec2d4a106003a6ce67eaa92e384b356d1b4ef6d66a818d47c1f3a2c6e8a9a9b9bdbd28d485e06161ccd0f528c8bbb5541c3fef36f";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("122060");
            }
        }

        public static void Whirlpool(string hash)
        {
            string hs = "76df96157e632410998ad7f823d82930f79a96578acc8ac5ce1bfc34346cf64b4610aefa8a549da3f0c1da36dad314927cebf8ca6f3fcd0649d363c5a370dddb";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("122040");
            }
        }

        public static void WhirlpoolHMAC(string hash)
        {
            string hs = "77996016cf6111e97d6ad31484bab1bf7de7b7ee64aebbc243e650a75a2f9256cef104e504d3cf29405888fca5a231fcac85d36cd614b1d52fce850b53ddf7f9";
            if (IsHashValid(hash, hs))
            {
                Config.jerar.Add("122080");
            }
        }


        // ========================================================







        public static void IdentifyHash(string hash)
        {
            Config.jerar.Clear();

            ADLER32(hash);
            CRC16(hash);
            CRC16CCITT(hash);
            CRC32(hash);
            CRC32B(hash);
            DESUnix(hash);
            DomainCachedCredentials(hash);
            FCS16(hash);
            GHash323(hash);
            GHash325(hash);
            GOSTR341194(hash);
            Haval128(hash);
            Haval128HMAC(hash);
            Haval160(hash);
            Haval160HMAC(hash);
            Haval192(hash);
            Haval192HMAC(hash);
            Haval224(hash);
            Haval224HMAC(hash);
            Haval256(hash);
            Haval256HMAC(hash);
            LineageIIC4(hash);
            MD2(hash);
            MD2HMAC(hash);
            MD4(hash);
            MD4HMAC(hash);
            MD5(hash);
            MD5APR(hash);
            MD5HMAC(hash);
            MD5HMACWordpress(hash);
            MD5phpBB3(hash);
            MD5Unix(hash);
            MD5Wordpress(hash);
            MD5Half(hash);
            MD5Middle(hash);
            MD5passsaltjoomla1(hash);
            MD5passsaltjoomla2(hash);
            MySQL(hash);
            MySQL5(hash);
            MySQL160bit(hash);
            NTLM(hash);
            RAdminv2x(hash);
            RipeMD128(hash);
            RipeMD128HMAC(hash);
            RipeMD160(hash);
            RipeMD160HMAC(hash);
            RipeMD256(hash);
            RipeMD256HMAC(hash);
            RipeMD320(hash);
            RipeMD320HMAC(hash);
            SAM(hash);
            SHA1(hash);
            SHA1Django(hash);
            SHA1HMAC(hash);
            SHA1MaNGOS(hash);
            SHA1MaNGOS2(hash);
            SHA224(hash);
            SHA224HMAC(hash);
            SHA256(hash);
            SHA256s(hash);
            SHA256Django(hash);
            SHA256HMAC(hash);
            SHA256md5pass(hash);
            SHA256sha1pass(hash);
            SHA384(hash);
            SHA384Django(hash);
            SHA384HMAC(hash);
            SHA512(hash);
            SHA512HMAC(hash);
            SNEFRU128(hash);
            SNEFRU128HMAC(hash);
            SNEFRU256(hash);
            SNEFRU256HMAC(hash);
            Tiger128(hash);
            Tiger128HMAC(hash);
            Tiger160(hash);
            Tiger160HMAC(hash);
            Tiger192(hash);
            Tiger192HMAC(hash);
            Whirlpool(hash);
            WhirlpoolHMAC(hash);
            XOR32(hash);
            md5passsalt(hash);
            md5saltmd5pass(hash);
            md5saltpass(hash);
            md5saltpasssalt(hash);
            md5saltpassusername(hash);
            md5saltmd5pass(hash);
            md5saltmd5passsalt(hash);
            md5saltmd5passsalt(hash);
            md5saltmd5saltpass(hash);
            md5saltmd5md5passsalt(hash);
            md5username0pass(hash);
            md5usernameLFpass(hash);
            md5usernamemd5passsalt(hash);
            md5md5pass(hash);
            md5md5passsalt(hash);
            md5md5passmd5salt(hash);
            md5md5saltpass(hash);
            md5md5saltmd5pass(hash);
            md5md5usernamepasssalt(hash);
            md5md5md5pass(hash);
            md5md5md5md5pass(hash);
            md5md5md5md5md5pass(hash);
            md5sha1pass(hash);
            md5sha1md5pass(hash);
            md5sha1md5sha1pass(hash);
            md5strtouppermd5pass(hash);
            sha1passsalt(hash);
            sha1saltpass(hash);
            sha1saltmd5pass(hash);
            sha1saltmd5passsalt(hash);
            sha1saltsha1pass(hash);
            sha1saltsha1saltsha1pass(hash);
            sha1usernamepass(hash);
            sha1usernamepasssalt(hash);
            sha1md5pass(hash);
            sha1md5passsalt(hash);
            sha1md5sha1pass(hash);
            sha1sha1pass(hash);
            sha1sha1passsalt(hash);
            sha1sha1passsubstrpass03(hash);
            sha1sha1saltpass(hash);
            sha1sha1sha1pass(hash);
            sha1strtolowerusernamepass(hash);


        }


        public static bool IsHashValid(string hash, string hs)
        {
            return hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && hash.All(char.IsLetterOrDigit);

            //hash.Length == hs.Length && !hash.All(char.IsDigit) && !hash.All(char.IsLetter) && !hash.All(char.IsLetterOrDigit)
        }

    }
}
