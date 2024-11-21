using CCTV_FrontToBack.Models;

namespace CCTV_FrontToBack.ViewModels
{
    public class HomeVm
    {
        public List<Slider_Header> slider_header { get; set; }
        public List<TeamMembers> team_members { get; set; }
        public List<EmotTest> Emots { get; set; }
    }
}
