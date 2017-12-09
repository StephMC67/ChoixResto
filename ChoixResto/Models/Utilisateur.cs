using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace ChoixResto.Models
{
    public class Utilisateur
    {

        private string EncodeMD5(string motDePasse)
        {
            string motDePasseSel = "ChoixResto" + motDePasse + "ASP.NET MVC";
            return BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.Default.GetBytes(motDePasseSel)));
        }

        public int Id { get; set; }
        [Required, MaxLength(80)]
        public string Prenom { get; set; }
        [Required]
        public string MotDePasse { get; set; }
    }
}