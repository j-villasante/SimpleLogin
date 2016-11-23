using Login.Entities;
using System.Linq;

namespace Login
{
    class PresentacionUsuario
    {
        private static PresentacionUsuario presentacion;

        public static PresentacionUsuario getInstance()
        {
            if (presentacion == null) presentacion = new PresentacionUsuario();
            return presentacion;
        }

        private PresentacionUsuario() { }

        public void guardarUsuario(Usuario usuario)
        {
            usuario.password = BCrypt.Net.BCrypt.HashPassword(usuario.password);

            using(var db = new PrimaxDataModel())
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();
            }
        }

        public static bool login(string username, string password)
        {
            using (var db = new PrimaxDataModel())
            {
                var query = from b in db.Usuarios
                            where b.usuario == username
                            select b;
                foreach (Usuario item in query)
                {
                    return BCrypt.Net.BCrypt.Verify(password, item.password);
                }                
            }
            return false;
        }
    }
}
