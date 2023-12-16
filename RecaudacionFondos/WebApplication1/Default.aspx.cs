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
        public List<string> Fechas { get; set; }
        /// <summary>
        /// Método que se ejecuta al cargar la pagina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            #region Fechas manuales
            Fechas = new List<string>();
            Fechas.Add("05-12-2023");
            Fechas.Add("10-12-2023");
            Fechas.Add("17-12-2023");
            Fechas.Add("24-12-2023");
            Fechas.Add("31-12-2023");
            Fechas.Add("07-01-2024");
            Fechas.Add("14-01-2024");
            Fechas.Add("21-01-2024");
            Fechas.Add("28-01-2024");
            Fechas.Add("04-02-2024");
            #endregion

            ParticipantesList = new List<Participante>();
            PagosParticipantesList = new List<Pago>();
            if (!IsPostBack)
            {
                var participantesString = File.ReadAllLines(Server.MapPath("~/Participantes.csv"));
                var pagosparticipantesString = File.ReadAllLines(Server.MapPath("~/Pagos.csv"));

                foreach (var i in participantesString)
                {
                    var columnas = i.Split(',');

                    ParticipantesList.Add(new Participante()
                    {
                        //recuerda que en c# todos los listados y arreglos comienzan en la posición 0
                        Id = Convert.ToInt32(columnas[0]),
                        NombreParticipante = columnas[1]
                    });
                }

                foreach (var i in pagosparticipantesString)
                {
                    var columnas = i.Split(',');

                    PagosParticipantesList.Add(new Pago()
                    {
                        Id = Convert.ToInt32(columnas[0]),
                        IdParticipante = Convert.ToInt32(columnas[1]),
                        Fecha = Convert.ToDateTime(columnas[2]),
                        Monto = Convert.ToInt32(columnas[3])
                    });

                }
            }

            
        }
    }
}