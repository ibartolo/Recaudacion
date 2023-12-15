using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using WebApplication1.Models;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        //Se declara una propiedad como un listado de participantes
        public List<Participante> ParticipantesList { get; set; }
        public List <Pago> PagosParticipantesList { get; set; }
        /// <summary>
        /// Método que se ejecuta al cargar la pagina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            //se instancia la propiedad siempre que la pagina se carge
            ParticipantesList = new List<Participante>();
            PagosParticipantesList = new List<Pago>();
            if (!IsPostBack)
            {
                //leemos el archivo con los participantes
                //Esta readlllines lee el archivo y regresa un arreglo de string por cada liena 
                //var participantesString = File.ReadAllLines(@"~\Participantes.csv");
                var participantesString = File.ReadAllLines(Server.MapPath("~/Participantes.csv"));
                //var pagosparticipantesString = File.ReadAllLines(Server.MapPath("~/Pagos.cvs"));

                //recorremos el arreglo e insertamos cada elemento al listado que tenemos de participantes
                foreach (var i in participantesString)
                {
                    //cada linea es una fila, y cada fila esta separada con una coma para identificar las colunas
                    //entonces con un split vamos a separar la fila y convertirla en 2 columnas 
                    //la primera columna será el Id y la segunda sera el nombre
                    //var columnas = i.Split(new char[',']);
                    var columnas = i.Split(',');

                    ParticipantesList.Add(new Participante()
                    {
                        //recuerda que en c# todos los listados y arreglos comienzan en la posición 0
                        Id = Convert.ToInt32(columnas[0]),
                        NombreParticipante = columnas[1]
                    });
                }

                //foreach (var i in pagosparticipantesString)
                //{
                //    var columnas = i.Split(',');

                //    PagosParticipantesList.Add(new Pago()
                //    {
                //        Id = Convert.ToInt32(columnas[0]),
                //        IdParticipante = Convert.ToInt32(columnas[1]),
                //        Fecha = Convert.ToDateTime(columnas[2]),
                //        Monto = Convert.ToInt32(columnas[3])
                //    });

                //}
            }

            
        }
    }
}