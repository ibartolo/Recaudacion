using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;

namespace WebApplication1
{
    public partial class AltaPagos : System.Web.UI.Page
    {
        public List<Participante> ParticipantesList { get; set; }
        public List<Pago> PagosParticipantesList { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ParticipantesList = new List<Participante>();
            if (!IsPostBack)
            {
                var participantesString = File.ReadAllLines(Server.MapPath("~/Participantes.csv"));
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

                ddlNombre.DataSource = ParticipantesList;
                ddlNombre.DataTextField = "NombreParticipante";
                ddlNombre.DataValueField = "Id";
                ddlNombre.DataBind();

                Calendar1.SelectedDate = DateTime.Today;
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //leemos todos los pagos que ya tenemos
            var pagosparticipantesString = File.ReadAllLines(Server.MapPath("~/Pagos.csv"));
            var nuevoPago = $"\n{pagosparticipantesString.Length + 1},{Convert.ToInt32(ddlNombre.SelectedValue)}, {Calendar1.SelectedDate.ToString("dd-MM-yyyy")},{Convert.ToInt32(txtMonto.Text)}";
            using (StreamWriter file = new StreamWriter(Server.MapPath("~/Pagos.csv"), true))
            {
                file.WriteLine(nuevoPago);
                file.Close();
            }

            Response.Redirect(@"~\Default.aspx");
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

            ////vamos a agregar el nuevo pago 
            ////pero primero tenemos que ver cual es el maximo id, la función Max sabe que habklamos de un numero
            /////por eso lo pone en Int
            //var maximoId = PagosParticipantesList.Max(x => x.Id);

            //PagosParticipantesList.Add(new Pago()
            //{
            //    Id = maximoId + 1,
            //    IdParticipante = Convert.ToInt32(ddlNombre.SelectedValue),
            //    Fecha = Calendar1.SelectedDate,
            //    Monto = Convert.ToInt32(txtMonto.Text)
            //});

            ////estoy pensando no me carbura la ardilla jejeje en como guardarlo
            //se que tengo que hacer, estoy oensando como hacerlo
        }
    }
}