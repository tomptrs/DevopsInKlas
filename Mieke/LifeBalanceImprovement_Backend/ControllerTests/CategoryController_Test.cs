using LBI_BLL;
using LBI_DTO;
using LifeBalanceImprovement_Backend.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace ControllerTests
{
    public class CategoryController_Test
    {
        [Fact]
        public void GetCatsByUserSendWrongIdExpectNull()
        {
            int id = 5;
            List<UserCategory_DTO> cList = new List<UserCategory_DTO>();
            cList = null;
            Mock<ICategory_BLL> myMock = new Mock<ICategory_BLL>();
            myMock.Setup(m => m.GetAll(id)).Returns(cList);
            ICategory_BLL cat_BLL = myMock.Object;
            CategoryController catController = new CategoryController(cat_BLL);

            var result = catController.GetCategoriesByUser(id);

            Assert.IsType<BadRequestObjectResult>(result); 
        }
    }
}
