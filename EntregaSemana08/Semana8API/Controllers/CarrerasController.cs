using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Semana8dll.Facade;
using Semana8dll.Dominio;


namespace Semana8API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrerasController : ControllerBase
    {

        private IDataAPI api;

        public CarrerasController()
        {
            api = new DataAPI();
        }

        [HttpGet("/carreras")] //EndPoint para consultar las ccarreras
        public IActionResult getCarreras()
        {
            List<Carrera> lst = new List<Carrera>(); 
            try
            {
                DataTable dt = api.getCarreras("msp_consultarCarreras");
                foreach (DataRow dr in dt.Rows)
                {
                    int idC = int.Parse(dr["id_carrera"].ToString());
                    string nombreC = dr["nombre"].ToString();

                    Carrera aux = new Carrera();
                    aux.id = idC;
                    aux.nombre = nombreC;

                    List<DetalleCarrera> lstasig = new List<DetalleCarrera>();

                    DataTable da = api.getDetalles(idC);
                    foreach(DataRow dra in da.Rows)
                    {
                        int idA = int.Parse(dra[0].ToString());
                        string nombreA = "a";

                        DetalleCarrera detalle = new DetalleCarrera();
                        detalle.id = idA;
                        detalle.aniocursado = int.Parse(dra[1].ToString());
                        detalle.cuatrimestre = int.Parse(dra[2].ToString());
                        
                        Asignatura asign = new Asignatura();
                        asign.id_asignatura = int.Parse(dra[3].ToString());
                        asign.nombre = dra[4].ToString();

                        detalle.asignatura = asign;
                        detalle.estado = dra[5].ToString();

                        aux.AgregarDetalle(detalle);
                    }
                    lst.Add(aux);
                }
                return Ok(lst);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("/asignaturas")] // endpoint para recuperar asignaturas
        public IActionResult getAsignaturas()
        {
            List<Asignatura> lasign = new List<Asignatura>();  
            try
            {
                DataTable dt = api.getCarreras("msp_consultarAsignaturas");
                foreach (DataRow dr in dt.Rows)
                {
                    Asignatura asignatura = new Asignatura();
                    asignatura.id_asignatura = int.Parse(dr[0].ToString());
                    asignatura.nombre = dr[1].ToString();
                    lasign.Add(asignatura);
                }
                return Ok(lasign);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("/detalles")]
        public IActionResult getDetalles(int id)
        {
            List<DetalleCarrera> lstd = new List<DetalleCarrera>();

            try
            {
                DataTable dt = api.getDetalles(id);
                foreach (DataRow dr in dt.Rows)
                {
                    DetalleCarrera detalle = new DetalleCarrera();
                    detalle.id = int.Parse(dr[0].ToString());
                    detalle.aniocursado = int.Parse(dr[1].ToString());
                    detalle.cuatrimestre = int.Parse(dr[2].ToString());

                    Asignatura asign = new Asignatura();
                    asign.id_asignatura = int.Parse(dr[3].ToString());
                    asign.nombre = dr[4].ToString();
                    detalle.asignatura = asign;
                    detalle.estado = dr[5].ToString();

                    lstd.Add(detalle);
                }
                return Ok(lstd);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }

        
        [HttpPost("/carreras")]
        public IActionResult postCarreras(Carrera c)
        {
            try
            {
                return Ok(api.NuevaCarrera(c));
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpGet("/users")]
        public IActionResult getUsuarios()
        {

            List<Usuario> lusers = new List<Usuario>();
            try
            {
                DataTable dt = api.getUsuarios("msp_consultarUsers");
                foreach (DataRow dr in dt.Rows)
                {
                    Usuario usuario = new Usuario();
                    usuario.Id = int.Parse(dr[0].ToString());
                    usuario.pass = dr[2].ToString();
                    usuario.user = dr[1].ToString();

                    lusers.Add(usuario);
                }

                return Ok(lusers);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
