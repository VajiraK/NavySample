using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace NavySampleSite.Engine
{
    public class TextMaker
    {
        public string SiteName 
        { 
            get
            { 
                return "ශ්‍රී ලංකා නාවික හමුදාව;
            }
        }

        public string SiteDescription
        { 
            get
            { 
                return ReadTextFile("SiteDescription.txt");
            }
        }

        public string Email 
        { 
            get
            { 
                return "wac@navy.lk";
            }
        }

        public string SecretCode 
        { 
            get
            { 
                string input = ReadTextFile("Secret.txt");
                return CalculateMD5Hash(input);
            }
        }

        public string CalculateMD5Hash(string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }

        public string ContactDetails
        { 
            get
            { 
                return ReadTextFile("ContactDetails.txt");
            }
        }

        public string ReadTextFile(string fileName)
        { 
            string text;
            string path = @"C:\Vajira\Navy\Data\" + fileName;
            var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

            using (var streamReader = new StreamReader(fileStream))
            {
                text = streamReader.ReadToEnd();
            }

            return text;
        }
    }
}