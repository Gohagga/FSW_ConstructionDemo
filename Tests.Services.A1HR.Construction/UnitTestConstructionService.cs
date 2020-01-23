using Domain.Interfaces.Repositories;
using Moq;
using NUnit.Framework;
using Services.A1HR.Construction;
using Services.Interfaces.A1HR.Construction;

namespace Tests.Services.A1HR.Construction
{
    public class UnitTestConstructionService
    {
        private Mock<IConstructionRepository> MockConstructionRepository { get; set; }

        [SetUp]
        public void Setup()
        {
            MockConstructionRepository = new Mock<IConstructionRepository>();
        }

        [Test]
        public void ConstructionService_GetTrailById_returns_not_null()
        {
            var service = new ConstructionService(MockConstructionRepository.Object);
            MockConstructionRepository.Setup(x => x.GetTrailById(It.IsAny<string>())).Returns(new Domain.Entities.Construction.Trail() { Id = "RI:///0.123" });

            var result = service.GetTrailById("123");
            Assert.IsNotNull(result);
        }
    }
}