using System;
using System.Collections.Generic;
using System.Text;
using BethanyPieShop.Controllers;
using BethanyPieShop.Models;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace BethanyPieShop.UnitTests
{
    public class HomeController_should
    {
        [Fact]
        public void Return_ViewModel_from_Index()
        {
            var repository = Mock.Of<IPieRepository>();
            Mock.Get(repository)
                .Setup(r => r.GetAllPies())
                .Returns(
                    new[]
                    {
                        new Pie
                        {
                            Id = 1,
                            Name = "Test Pie"
                        },
                    });

            var sut = new HomeController(repository);

            sut.Index().Should().BeEquivalentTo(
                new {
                    ViewName = (string)null,
                    Model = new {
                        Title = "Welcome to Bethany's Pie Shop",
                        Pies = new[]
                        {
                            new
                            {
                                Id = 1,
                                Name = "Test Pie "
                            }
                        }
                    }
                });
        }
    }
}

