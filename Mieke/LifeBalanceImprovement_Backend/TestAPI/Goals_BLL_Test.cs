using AutoMapper;
using LBI_BLL.Helpers;
using LBI_DAL;
using LBI_DAL.Models;
using LBI_DTO;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestBLL
{
    public class Goals_BLL_Test
    {
        [Fact]
        public void GetGoalsByWrongIdExpectEmpty()
        {
            int id = 10;
            Mock<IGoals_DAL> myMock = new Mock<IGoals_DAL>();
            List<Goals> goals = new List<Goals>();
            goals = null;
            myMock.Setup(m => m.GetGoals(id)).Returns(goals);
            IGoals_DAL goals_DAL = myMock.Object;
            Goals_BLL goals_BLL = new Goals_BLL(goals_DAL);

            List<Goals_DTO> result = goals_BLL.GetGoals(id);

            Assert.Empty(result);
        }
    }
}
