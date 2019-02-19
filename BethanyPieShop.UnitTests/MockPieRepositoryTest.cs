using System;
using System.Collections.Generic;
using System.Linq;
using BethanyPieShop.Models;
using FluentAssertions;
using Xunit;

namespace BethanyPieShop.UnitTests
{
    public class MockPieRepositoryShould
    {
        [Fact(DisplayName = nameof(MockPieRepositoryShould) + " _ " + nameof(NotToBe_Empty))]
        public void NotToBe_Empty()
        {
            MockPieRepository pieRepository = new MockPieRepository();
            var pies = pieRepository.GetAllPies().Count();
            pies.Should().BePositive();
        }

        [Fact(DisplayName = nameof(MockPieRepositoryShould) + " _ " + nameof(BeTypeOf_List))]
        public void BeTypeOf_List()
        {
            MockPieRepository pieRepository = new MockPieRepository();
            var pies = pieRepository.GetAllPies();
            pies.Should().BeOfType(typeof(List<Pie>));
        }

        [Fact(DisplayName = nameof(MockPieRepositoryShould) + " _ " + nameof(NotToBe_Null))]
        public void NotToBe_Null()
        {
            MockPieRepository pieRepository = new MockPieRepository();
            var pies = pieRepository.GetAllPies();
            pies.Should().NotBeNull();
        }
        [Fact(DisplayName = nameof(MockPieRepositoryShould) + " _ " + nameof(Have_SomePies))]
        public void Have_SomePies()
        {
            MockPieRepository pieRepository = new MockPieRepository();
            var pies = pieRepository.GetAllPies().Count();
            Assert.Equal(4, pies);
        }
    }
}