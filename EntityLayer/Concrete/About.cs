namespace EntityLayer.Concrete
{
    public class About
    {
        public int AboutID { get; set; }
        public string AboutDetails1 { get; set; }
        public string AboutDetails2 { get; set; }
        public string AboutImage1 { get; set; }
        public string AboutImage2 { get; set; }
        public string AboutMapLocation { get; set; }

        public int CompanyID { get; set; }
        public virtual Company Company { get; set; }
    }
}
