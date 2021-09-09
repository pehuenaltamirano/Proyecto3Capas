using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Logica
{
    public class Empleados
    {
        public static List<Datos.empleados> Get()
        {
            using (Datos.PehuenDBEntities db = new Datos.PehuenDBEntities())
            {
                return db.empleados.ToList();
            }
        }

        public static void Insert(string name, string lastname, string cuilt, int dni, string dom, string tel, string legajo, string email)
        {
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-78923DT\\SQLEXPRESS;Initial Catalog=PehuenDB;Integrated Security=True");
            //SqlConnection cnn = new SqlConnection("Data source = 192.168.0.29; Initial Catalog = u1;User ID=u1;Password=u1" );
            cnn.Open();
            const string query = "insert into empleados (name,lastname,cuilt,dni,domicilio,telefono,legajo,email) VALUES (@nombre,@apellido,@cuil,@dni,@dom,@tel,@legajo,@email)";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@nombre", name);
            cmd.Parameters.AddWithValue("@apellido", lastname);
            cmd.Parameters.AddWithValue("@cuil", cuilt);
            cmd.Parameters.AddWithValue("@dni", dni);
            cmd.Parameters.AddWithValue("@dom", dom);
            cmd.Parameters.AddWithValue("@tel", tel);
            cmd.Parameters.AddWithValue("@legajo", legajo);
            cmd.Parameters.AddWithValue("@email",email);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Modificar(int id, string name, string lastname, string cuilt, int dni, string dom, string tel, string legajo, string email)
        {
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-78923DT\\SQLEXPRESS;Initial Catalog=PehuenDB;Integrated Security=True");
            cnn.Open();
            const string query = "UPDATE empleados SET name=@nombre,lastname=@apellido,cuilt=@cuil,dni=@dni,domicilio=@dom,telefono=@tel,legajo=@legajo,email=@email WHERE id=@id1";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@id1", id);
            cmd.Parameters.AddWithValue("@nombre", name);
            cmd.Parameters.AddWithValue("@apellido", lastname);
            cmd.Parameters.AddWithValue("@cuil", cuilt);
            cmd.Parameters.AddWithValue("@dni", dni);
            cmd.Parameters.AddWithValue("@dom", dom);
            cmd.Parameters.AddWithValue("@tel", tel);
            cmd.Parameters.AddWithValue("@legajo", legajo);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Eliminar(int id)
        {
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-78923DT\\SQLEXPRESS;Initial Catalog=PehuenDB;Integrated Security=True");
            cnn.Open();
            const string query = "DELETE FROM empleados WHERE id=@id1";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@id1", id);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
