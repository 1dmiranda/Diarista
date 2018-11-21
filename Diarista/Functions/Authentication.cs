using Diarista.Data;
using Diarista.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diarista.Functions
{
    public class Authentication
    {
        public static User Login(string email, string password)
        {
            using (var db = new DatabaseContext())
            {
                var users = db.Users;
                var usuario = users.Include("Perfil").Where(u => u.Email == email && u.Password == password ).FirstOrDefault();

                if (usuario == null)
                    throw new Exception("Usuário Inválido");

                return usuario;
            }
        }
    }
}