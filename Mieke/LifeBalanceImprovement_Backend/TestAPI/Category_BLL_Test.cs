using LBI_DTO;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using LBI_DAL;
using AutoMapper;
using LBI_DAL.Models;
using LBI_BLL.Helpers;

namespace TestBLL
{
    public class Category_BLL_Test
    {
        private readonly IMapper mapper = new Mapper(new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Category_DTO, Category>();
            cfg.CreateMap<Category, Category_DTO>();
            cfg.CreateMap<UserCategory_DTO, UserCategory>();
            cfg.CreateMap<UserCategory, UserCategory_DTO>();
            cfg.CreateMap<Log, Log_DTO>();
            cfg.CreateMap<Log_DTO, Log>();
            cfg.CreateMap<AgendaItem, AgendaItem_DTO>();
            cfg.CreateMap<AgendaItem_DTO, AgendaItem>();
        }));
        [Fact]
        public void GetCategoriesByUidExpectList()
        {
            //Arrange 
            List<UserCategory_DTO> updateCats = new List<UserCategory_DTO>(); 
            UserCategory_DTO c1 = new UserCategory_DTO();
            c1.Id = 1;
            c1.CategoryId = 1;
            c1.Color = "blauw";
            c1.IdealValue = 20;
            UserCategory_DTO c2 = new UserCategory_DTO();
            c1.Id = 1;
            c1.CategoryId = 1;
            c1.Color = "blauw";
            c1.IdealValue = 20;
            UserCategory_DTO c3 = new UserCategory_DTO();
            c1.Id = 1;
            c1.CategoryId = 1;
            c1.Color = "blauw";
            c1.IdealValue = 20;
            UserCategory_DTO c4 = new UserCategory_DTO();
            c1.Id = 1;
            c1.CategoryId = 1;
            c1.Color = "blauw";
            c1.IdealValue = 20;
            UserCategory_DTO c5 = new UserCategory_DTO();
            c1.Id = 1;
            c1.CategoryId = 1;
            c1.Color = "blauw";
            c1.IdealValue = 20;
            UserCategory_DTO c6 = new UserCategory_DTO();
            c1.Id = 1;
            c1.CategoryId = 1;
            c1.Color = "blauw";
            c1.IdealValue = 20;
            updateCats.Add(c1);
            updateCats.Add(c2);
            updateCats.Add(c3);
            updateCats.Add(c4);
            updateCats.Add(c5);
            updateCats.Add(c6);

            List<UserCategory> mockList = new List<UserCategory>(); 
            foreach(var c in updateCats)
            {
                mockList.Add(mapper.Map<UserCategory_DTO, UserCategory>(c)); 
            }
            int id = 1; 
            Mock<ICategory_DAL> MyMock = new Mock<ICategory_DAL>();
            MyMock.Setup(m => m.GetAll(id)).Returns(mockList); 
            ICategory_DAL category_DAL = MyMock.Object;
            Category_BLL cat_BLL = new Category_BLL(category_DAL);

            //Act
            List<UserCategory_DTO> result = cat_BLL.GetAll(id);

            //Assert
            Assert.NotNull(result);  
        }

        [Fact]
        public void GetAllCategoriesByWrongIdExpectNull()
        {
            int id = 5313;
            Mock<ICategory_DAL> MyMock = new Mock<ICategory_DAL>();
            List<UserCategory> cats = new List<UserCategory>();
            cats = null; 
            MyMock.Setup(m => m.GetAll(id)).Returns(cats);
            ICategory_DAL category_DAL = MyMock.Object;
            Category_BLL cat_BLL = new Category_BLL(category_DAL);

            //Act
            List<UserCategory_DTO> result = cat_BLL.GetAll(id);

            //Assert
            Assert.Null(result);
        }
    }
}
