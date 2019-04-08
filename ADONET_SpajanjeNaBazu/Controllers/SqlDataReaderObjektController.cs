using ADONET_SpajanjeNaBazu.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADONET_SpajanjeNaBazu.Controllers
{
    public class SqlDataReaderObjektController : Controller
    {
        // VAŽNA NAPOMENA!!!!
        // OVO RADI AKO IMAMO UPISANE TEČAJEVE U BAZU PODATAKA!!!
        // GET: SqlDataReaderObjekt
        public ActionResult Index()
        {
            //Kreiramo ConnectionString i Connection objekt
            List<Tecaj> lstTecajevi = new List<Tecaj>();
            string connString =
                 ConfigurationManager.ConnectionStrings["dbAlgebraConnStr"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string cmdText = "Select * from tblTecajevi";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Connection.Open();

                // Izvršavamo komandu pozivom ExecuteReader metode
                // koja kreira SqlDataReader objekt
                SqlDataReader reader = cmd.ExecuteReader();

                // ako je pozivom metode kreiran SqlDataReader objekt
                if(reader != null)
                {
                    // i ako ima redaka za čitanje
                    if (reader.HasRows)
                    {
                        // dok ima podataka u readeru, dodajemo ih u listu
                        while (reader.Read())
                        {
                            // Kreiramo novi Tecaj objekt
                            Tecaj tecaj = new Tecaj();

                            // postavljamo mu svojstva
                            tecaj.Id = int.Parse(reader["IdTecaj"].ToString());
                            tecaj.Naziv = reader["Naziv"].ToString();
                            tecaj.Opis = reader["Opis"].ToString();

                            // dodajemo tecaj u listu lstTecajevi
                            lstTecajevi.Add(tecaj);
                        }
                    }
                }
                reader.Close();
            }
                return View(lstTecajevi);
        }
    }
}