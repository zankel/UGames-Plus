using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace RestWithASPNETUdemy.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly MySQLContext _context;

        public UsuarioRepository(MySQLContext context)
        {
            _context = context;
        }

        public Usuario ValidateCredentials(UsuarioVO usuario)
        {
            var pass = ComputeHash(usuario.Password, new SHA256CryptoServiceProvider());
            return _context.Usuarios.FirstOrDefault(u => (u.UserName == usuario.UserName) && (u.Password == pass));
        }

        public Usuario ValidateCredentials(string userName)
        {
            return _context.Usuarios.SingleOrDefault(u => (u.UserName == userName));
        }

        public bool RevokeToken(string userName)
        {
            var user = _context.Usuarios.SingleOrDefault(u => (u.UserName == userName));
            if (user is null) return false;
            user.RefreshToken = null;
            _context.SaveChanges();
            return true;
        }

        public Usuario RefreshUserInfo(Usuario usuario)
        {
            if (!_context.Usuarios.Any(u => u.Id.Equals(usuario.Id))) return null;

            var result = _context.Usuarios.SingleOrDefault(p => p.Id.Equals(usuario.Id));
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(usuario);
                    _context.SaveChanges();
                    return result;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return result;
        }

        private string ComputeHash(string input, SHA256CryptoServiceProvider algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);
            return BitConverter.ToString(hashedBytes);
        }

    }
}
