using LBI_BLL;
using LBI_DTO;
using LifeBalanceImprovement_Backend.Controllers;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace ControllerTests
{
    public class GoalsController_Test
    {
        [Fact]
        public void AddGoalSentGoalExpectGoal()
        {
            Goals_DTO goal = new Goals_DTO()
            {
                Goal = "Meer drinken",
                BeginTime = new DateTime(2019, 11, 22, 8, 30, 0),
                EndTime = new DateTime(2019, 11, 24, 10, 30, 0),
                Progress = 0,
                Amount = 5,
                Percentage = 0
            };
            Mock<IGoals_BLL> myMock = new Mock<IGoals_BLL>();
            myMock.Setup(m => m.AddGoal(goal)).Returns(goal);
            IGoals_BLL goals_BLL = myMock.Object;
            GoalsController goalsController = new GoalsController(goals_BLL);

            var result = goalsController.AddGoal(goal);

            Assert.IsType<CreatedResult>(result);
        }
    }
}
