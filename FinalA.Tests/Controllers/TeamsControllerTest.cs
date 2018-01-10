using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// additional references
using FinalA.Controllers;
using FinalA.Models;
using Moq;
using System.Linq;
using System.Web.Mvc;

namespace FinalA.Tests.Controllers
{
    [TestClass]
    public class TeamsControllerTest
    {
        TeamsController controller;
        Mock<ITeamRepository> mock;
        List<Team> teams;
        
        [TestInitialize] 
        public void TestInitialize()
        {
            // arrange
            mock = new Mock<ITeamRepository>();

            teams = new List<Team> {
                new Team { Name = "Toronto Maple Leafs", Points = 41 },
                new Team { Name = "Vancouver Canucks", Points = 35 },
                new Team { Name = "Montreal Canadiens", Points = 32 }
            };

            mock.Setup(m => m.Teams).Returns(teams.AsQueryable());

            controller = new TeamsController(mock.Object);
        }

        [TestMethod] 
        public void IndexValidLoadsTeams()
        {
            // act

            // assert
        }

        [TestMethod]
        public void DetailsValidId()
        {
            // act
            var actual = (Team)controller.Details(0).Model;
            // assert   
            Assert.AreEqual(teams.ToList()[0], actual);
        }

        [TestMethod]
        public void DetailsInvalidId()
        { 
            // act
            var actual = (Team)controller.Details(99999999).Model;
            // assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void DetailsMissingId()
        {
            // act
            var actual = (Team)controller.Details(99999999).Model;
            // assert
            Assert.IsNull(actual);
        }



    }
}
