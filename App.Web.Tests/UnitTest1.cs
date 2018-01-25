using App.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace App.Web.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PostIncident()
        {
            IncidentsController api = new IncidentsController();
            var response = api.PostIncident(new Model.Models.Incident()
            {
                Kind = "TEST",
                HappenedAt = DateTime.Now,
                IsArchive = false,
                LocationId = "TEST"
            });

            Assert.IsTrue(response);
        }

        [TestMethod]
        public void GetIncidents()
        {
            IncidentsController api = new IncidentsController();
            var response = api.GetIncidents();

            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void PostIncidentWithArchive()
        {
            IncidentsController api = new IncidentsController();
            var response = api.GetIncidents(1);

            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void GetLocalities()
        {
            LocalitiesController api = new LocalitiesController();
            var response = api.GetLocalities();

            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void GetLocalitiesById()
        {
            LocalitiesController api = new LocalitiesController();
            var response = api.GetLocality(1);

            Assert.IsNotNull(response);
        }
    }
}