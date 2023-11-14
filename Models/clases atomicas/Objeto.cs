using GarciaMarkelPersonal.Controllers;
using System.ComponentModel.DataAnnotations;

namespace GarciaMarkelPersonal.Models.clases_atomicas
{
	public class Objeto : GestorObjetos
	{
		private int idObjeto;
		private double precio;
		private string titulo;
		private string descripcion;
		private string foto;
		private int idUser;

		public Objeto(int idObjeto, double precio, string titulo, string descripcion, string foto, int idUser)
		{
			this.idObjeto = idObjeto;
			this.precio = precio;
			this.titulo = titulo;
			this.descripcion = descripcion;
			this.foto = foto;
			this.idUser = idUser;
		}
		[Key]
		public int IdObjeto { get => idObjeto; set => idObjeto = value; }
		public double Precio { get => precio; set => precio = value; }
		public string Titulo { get => titulo; set => titulo = value; }
		public string Descripcion { get => descripcion; set => descripcion = value; }
		public string Foto { get => foto; set => foto = value; }
		public int IdUser { get => idUser; set => idUser = value; }
	}
}
