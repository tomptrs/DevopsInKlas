using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LBI_DAL.Models;
using System.Linq;
using Moq;
using Microsoft.EntityFrameworkCore;
using LBI_DAL;
using LBI_DAL.Helpers;

namespace TestDAL
{
    public class Category_DAL_Test
    {
        [Fact]
        public void GetAllByUidExpectCats()
        {
            var data = new List<UserCategory>
            {
                new UserCategory { CategoryId = 1, Color = "rood" },
                new UserCategory { CategoryId = 2, Color = "appelblauwzeegroen" }
            }.AsQueryable();

            var mockSet = new Mock<DbSet<UserCategory>>();
            mockSet.As<IQueryable<UserCategory>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<UserCategory>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<UserCategory>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<UserCategory>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var uCatContextMock = new Mock<LBIContext>();
            uCatContextMock.Setup(u => u.UserCategoryDb).Returns(mockSet.Object);
            var catDAL = new Category_DAL(uCatContextMock.Object);

            //Act
            var result = catDAL.GetAll(1);

            //Assert
            Assert.NotNull(result); 
        }
    }
}
