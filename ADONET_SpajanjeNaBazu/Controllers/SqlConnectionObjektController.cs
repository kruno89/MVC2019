using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADONET_SpajanjeNaBazu.Controllers
{
    public class SqlConnectionObjektController : Controller
    {
        // GET: SqlConnectionObjekt //direktno
        public ActionResult Index()
        {
            // prvo moramo sastaviti ConnectionString
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbAlgebra;Integrated Security=True";

            // instanciramo sqlconnection objekt
            SqlConnection conn = new SqlConnection(connString);

            // otvaramo vezu s bazom
            try
            {
                conn.Open();
                // Ako je veza otvorena, uspjeli smo se spojiti
                if (conn.State == ConnectionState.Open)
                {
                    Response.Write("Konekcija uspjela.");
                }
            }
            catch (SqlException sqlEx)
            {
                // U slučaju da konekcija nije uspjela, ispitujemo poruku o greški
                Response.Write("Greška spajanja na bazu"+sqlEx.Message);
            }
            catch (Exception ex)
            {
                Response.Write("Neka greška: " + ex.ToString());
            }
            finally
            {
                // Kad obavimo sve operacije u bazi, konekciju uvijek trebamo zatvoriti
                conn.Close();
            }


            return View();
        }

        // GET: SqlConnectionObjekt // preko web.configa
        public ActionResult SpojPrekoWebConfig()
        {
            // prvo moramo sastaviti ConnectionString
            // string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbAlgebra;Integrated Security=True";
            string connString = ConfigurationManager.ConnectionStrings["dbAlgebraConnStrSQL"].ConnectionString;
            // instanciramo sqlconnection objekt
            SqlConnection conn = new SqlConnection(connString);

            // otvaramo vezu s bazom
            try
            {
                conn.Open();
                // Ako je veza otvorena, uspjeli smo se spojiti
                if (conn.State == ConnectionState.Open)
                {
                    Response.Write("Konekcija uspjela.");
                }
            }
            catch (SqlException sqlEx)
            {
                // U slučaju da konekcija nije uspjela, ispitujemo poruku o greški
                Response.Write("Greška spajanja na bazu" + sqlEx.Message);
            }
            catch (Exception ex)
            {
                Response.Write("Neka greška: " + ex.ToString());
            }
            finally
            {
                // Kad obavimo sve operacije u bazi, konekciju uvijek trebamo zatvoriti
                conn.Close();
            }


            return View();
        }
    }
}