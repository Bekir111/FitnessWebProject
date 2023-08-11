
namespace FitnessApp.Web.Tests
{
    using Microsoft.AspNetCore.Mvc;
    using Moq;

    using FitnessApp.Data.Models;
    using FitnessApp.Web.Controllers;
    using static FitnessApp.Common.GeneralApplicationConstants;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore;
    using FitnessApp.Services.Data.Interfaces;
    using FitnessApp.Web.ViewModels.Program;

    public class ProgramControllerTest
    {
        private ProgramController controller;
        private Mock<IProgramService> mockProgramService;
        private Mock<IProgramReviewService> mockProgramReviewService;

        public ProgramControllerTest()
        {
            this.mockProgramService = new Mock<IProgramService>();
            this.mockProgramReviewService = new Mock<IProgramReviewService>();

            this.controller = new ProgramController(mockProgramService.Object,mockProgramReviewService.Object);
        }
        [Fact]
        public async Task Index_ReturnsCollectionOfPrograms()
        {
            this.mockProgramService
                .Setup(service => service.GetAllPrograms())
                .ReturnsAsync(new List<AllProgramViewModel>());

            var result = await controller.All() as ViewResult;

            Assert.NotNull(result);
            Assert.Equal(typeof(List<AllProgramViewModel>), result.Model.GetType());
        }

    }
}