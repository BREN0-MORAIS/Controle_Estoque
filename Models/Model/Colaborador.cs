using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace DataAcess.Model
{
    public class Colaborador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Tipo { get; set; }
        public string Senha { get; set; }
    }
}
