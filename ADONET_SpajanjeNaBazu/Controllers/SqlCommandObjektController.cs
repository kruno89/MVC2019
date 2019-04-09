using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADONET_SpajanjeNaBazu.Controllers
{
    public class SqlCommandObjektController : Controller
    {
        // GET: SqlCommandObjekt
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            //Kreiramo ConnectionString  i Connection objekt
            string connString =
                ConfigurationManager.ConnectionStrings["dbAlgebraConnStrSQL"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                // Kreiramo SQL naredbu za upis u bazu
                string cmdText = "";
                cmdText += "INSERT INTO tblTecajevi ";
                cmdText += "(naziv, opis)" ;
                cmdText += "VALUES ";
                cmdText += "('Web design', 'Naučite dizajnirati web stranice.') ";

                // Kreiramo Command objekt i otvaramo vezu s bazom
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Connection.Open();

                // Komandu izvršavamo metodom ExecuteNonQuery
                // Ako je zapis upisan u bazu, baza vraća 1 (jer je upisan jedan redak)
                int brojDodanihRedaka = cmd.ExecuteNonQuery();
                if (brojDodanihRedaka > 0)
                {
                    ViewBag.Message = "Zapis je upisan u bazu!";
                }
                else
                {
                    ViewBag.Message = "Dogodila se greška!";
                }
            }

            return View("Index");
        }

        public ActionResult Edit()
        {
            // Kreiramo ConnectionString i Connection objekt
            string connString = 
                ConfigurationManager.ConnectionStrings["dbAlgebraConnStrSQL"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //Kreiramo upit za izmjenu zapisa u bazi
                // ako obrišemo id sa brojem 1 svaki idući se mora promijeniti broj ovdje znači idTecaj= neki broj koji zelimo obrisati
                string cmdText = "UPDATE tblTecajevi ";
                cmdText += "SET naziv='Web programiranje' ";
                cmdText += "WHERE idTecaj=1";

                // Kreiramo Command objekt i otvaramo vezu s bazom
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Connection.Open();

                // Komandu izvršavamo metodom ExecuteNonQuery
                // Ako je došlo do izmjene, baza vraća broj izmijenjenih zapisa
                int brojIzmijenjenihRedaka = cmd.ExecuteNonQuery();
                ViewBag.Message = "Broj izmijenjenih redaka:" + brojIzmijenjenihRedaka.ToString();
            }
            return View("Index");
        }

        public ActionResult Delete()
        {
            // Kreiramo ConnectionString i Connection objekt
            string connString
                =
            ConfigurationManager.ConnectionStrings["dbAlgebraConnStrSQL"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                // Kreiramo upit za brisanje zapisa iz baze
                string cmdText = "DELETE FROM tblTecajevi ";
                cmdText += "WHERE idTecaj=21";
             

                // Kreiramo Command objekt i otvaramo vezu s bazom
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Connection.Open();

                // Komandu izvršavamo metodom ExecuteNonQuery
                // Ako je došlo do brisanja, baza vraća broj obrisanih zapisa
                int brojObrisanihRedaka = cmd.ExecuteNonQuery();
                ViewBag.Message = "Broj obrisanih redaka:" + brojObrisanihRedaka.ToString();
                return View("Index");
            }
            
        }

        public ActionResult Count()
        {
            // Kreiramo ConnectionString i Connection objekt
            string connString
                =
            ConfigurationManager.ConnectionStrings["dbAlgebraConnStrSQL"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                // kreiramo sql naredbu za dohvaćanje jedne vrijednosti iz baze
                //(funkcija COUNT vraća broj zapisa)
                string cmdText = "Select COUNT(*) from tblTecajevi";

                // kreiramo command objekt i otvaramo vezu s bazom
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Connection.Open();

                // komandu izvršavamo metodom executeScalar
                // jer očekujemo jednu vrijednost kao rezultat upita
                int brojZapisa = (int)cmd.ExecuteScalar();
                ViewBag.Message = "Broj tečajeva u bazi je: " + brojZapisa.ToString();
            }
            return View("Index");
        }
    }
}