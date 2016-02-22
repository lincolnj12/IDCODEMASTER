using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Collections.Generic;

namespace RestTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LibrosPendientesTest()
        {
            // Prueba de obtención de alumnos vía HTTP GET
            HttpWebRequest req1 = (HttpWebRequest)WebRequest
                .Create("http://localhost:4920/LibrosService.svc/LibrosPendientes/2");
            req1.Method = "GET";
            HttpWebResponse res1 = null;
            try
            {
                res1 = (HttpWebResponse)req1.GetResponse();
                StreamReader reader1 = new StreamReader(res1.GetResponseStream());
                string alumnosJson1 = reader1.ReadToEnd();
                JavaScriptSerializer js1 = new JavaScriptSerializer();
                List<LibroPendiente> librosObtenidos = js1.Deserialize<List<LibroPendiente>>(alumnosJson1);
                Assert.AreEqual(1, librosObtenidos.Count);
            }
            catch (WebException e)
            {
                HttpStatusCode code = ((HttpWebResponse)e.Response).StatusCode;
                string statusDescription = ((HttpWebResponse)e.Response).StatusDescription;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                string message = js.Deserialize<string>(error);
                Assert.AreEqual("El alumno no registra Libros Pendientes", message);
                Console.Write("El alumno no registra Libros Pendientes");
            }

        }

        [TestMethod]
        public void LibrosPendientesHorarioTest()
        {
            // Prueba de obtención de alumnos vía HTTP GET
            HttpWebRequest req1 = (HttpWebRequest)WebRequest
                .Create("http://localhost:4920/LibrosService.svc/LibrosPendientes/2");
            req1.Method = "GET";
            HttpWebResponse res1 = null;
            try
            {
                res1 = (HttpWebResponse)req1.GetResponse();
                StreamReader reader1 = new StreamReader(res1.GetResponseStream());
                string alumnosJson1 = reader1.ReadToEnd();
                JavaScriptSerializer js1 = new JavaScriptSerializer();
                List<LibroPendiente> librosObtenidos = js1.Deserialize<List<LibroPendiente>>(alumnosJson1);
                Assert.AreEqual(1, librosObtenidos.Count);
            }
            catch (WebException e)
            {
                HttpStatusCode code = ((HttpWebResponse)e.Response).StatusCode;
                string statusDescription = ((HttpWebResponse)e.Response).StatusDescription;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                string message = js.Deserialize<string>(error);
                Assert.AreEqual("El horario de atención es de Lunes a Sábado hasta las 11 am", message);
                Console.Write("El horario de atención es de Lunes a Sábado hasta las 11 am");
            }

        }

        [TestMethod]
        public void ListarObservacionesAlumno()
        {
            HttpWebRequest req1 = (HttpWebRequest)WebRequest
                .Create("http://localhost:4920/ObservacionService.svc/Observaciones/1");
            req1.Method = "GET";
            HttpWebResponse res1 = (HttpWebResponse)req1.GetResponse();
            StreamReader reader1 = new StreamReader(res1.GetResponseStream());
            string alumnosJson1 = reader1.ReadToEnd();
            JavaScriptSerializer js1 = new JavaScriptSerializer();
            List<Observacion> alumnosObtenidos = js1.Deserialize<List<Observacion>>(alumnosJson1);
            Assert.AreEqual(1, alumnosObtenidos.Count);

        }


    }
}
