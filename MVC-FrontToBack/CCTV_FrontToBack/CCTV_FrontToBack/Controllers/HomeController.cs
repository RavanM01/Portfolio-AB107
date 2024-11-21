using CCTV_FrontToBack.Models;
using CCTV_FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CCTV_FrontToBack.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			List<Slider_Header> slider_Head = new List<Slider_Header>();
			Slider_Header slider1 = new Slider_Header()
			{
				Id = 1,
				Title = "Muqemmel kamera",
				Description = "144p full hd",
                ImgUrl = "carousel-1.jpg"
			};
            Slider_Header slider2 = new Slider_Header()
            {
                Id = 2,
                Title = "Ogru govan camera",
                Description = "Blurlu+gece Gorusu",
                ImgUrl = "carousel-2.jpg"
            };
            Slider_Header slider3 = new Slider_Header()
            {
                Id = 3,
                Title = "Fake kamera",
                Description = "Gunes enerjili+wifi",
                ImgUrl = "carousel-3.jpg"
            };
            slider_Head.Add(slider1);
            slider_Head.Add(slider2);
            slider_Head.Add(slider3);

            List<TeamMembers> teamMembers = new List<TeamMembers>();
            TeamMembers teamMembers1 = new TeamMembers()
            {
                Id=1,
                Name="Anar Balajayev",
                Profession="Senior Backçi",
                ImgUrl="AnarMlm-1.jpeg"
            };
            TeamMembers teamMembers2 = new TeamMembers()
            {
                Id = 2,
                Name = "Elvin",
                Profession = "Şəkili",
                ImgUrl = "Elvin.jpeg"
            };
            TeamMembers teamMembers3 = new TeamMembers()
            {
                Id = 3,
                Name = "Anar Balacayev",
                Profession = "Backend Developer",
                ImgUrl = "AnarMlm-2.jpeg"
            };
            teamMembers.Add(teamMembers1);
            teamMembers.Add(teamMembers2);
            teamMembers.Add(teamMembers3);


            List<EmotTest> emotTests = new List<EmotTest>();

            EmotTest emotTest = new EmotTest()
            {
                Id = 1,
                Name = "SOMEONE",
                Description= "loremlwejhfrewofheoferhferf dklfjdlfkj  el erbfler erklfrejb",
                imgUrl="testimonial-1.jpg",
                Prof="Worker"
            };
            EmotTest emotTest2 = new EmotTest()
            {
                Id = 2,
                Name = "SOMEONE",
                Description = "loremlwejhfrewofheoferhferf dklfjdlfkj  el erbfler erklfrejb",
                imgUrl = "testimonial-2.jpg",
                Prof = "Worker"
            };
            EmotTest emotTest3 = new EmotTest()
            {
                Id = 3,
                Name = "SOMEONE",
                Description = "loremlwejhfrewofheoferhferf dklfjdlfkj  el erbfler erklfrejb",
                imgUrl = "testimonial-3.jpg",
                Prof = "Worker"
            };
            EmotTest emotTest4 = new EmotTest()
            {
                Id = 4,
                Name = "SOMEONE",
                Description = "loremlwejhfrewofheoferhferf dklfjdlfkj  el erbfler erklfrejb",
                imgUrl = "testimonial-4.jpg",
                Prof = "Worker"
            };

            emotTests.Add(emotTest);
            emotTests.Add(emotTest2);
            emotTests.Add(emotTest3);
            emotTests.Add(emotTest4);

            HomeVm vm = new HomeVm()
            {
                slider_header=slider_Head,
                team_members=teamMembers,
                Emots=emotTests
            };


            return View(vm);
		}
	}
}
