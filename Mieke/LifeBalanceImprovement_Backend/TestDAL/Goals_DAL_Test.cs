using LBI_DAL;
using LBI_DAL.Helpers;
using LBI_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace TestDAL
{
    public class Goals_DAL_Test
    {
        [Fact]
        public void GetGoalsByUIdExpectGoals()
        {
            var data = new List<Goals>
            {
                new Goals
                {
                    Goal = "Meer drinken",
                    BeginTime = new DateTime(2019, 10, 30),
                    EndTime = new DateTime(2019, 11, 30),
                    Amount = 5,
                    Progress = 0,
                    Percentage = 0,
                },
                new Goals
                {
                    Goal = "Meer sporten",
                    BeginTime = new DateTime(2020, 01, 05),
                    EndTime = new DateTime(2020, 02, 01),
                    Amount = 10,
                    Progress = 0,
                    Percentage = 0,
                }
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Goals>>();
            mockSet.As<IQueryable<Goals>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Goals>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Goals>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Goals>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var uGoalsContextMock = new Mock<LBIContext>();
            uGoalsContextMock.Setup(u => u.GoalsDb).Returns(mockSet.Object);
            var goalsDal = new Goals_DAL(uGoalsContextMock.Object);

            var result = goalsDal.GetGoals(1);

            Assert.NotNull(result);
        }
    }
}
