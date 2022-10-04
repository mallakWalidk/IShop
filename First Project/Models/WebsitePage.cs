using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class WebsitePage
    {
        public decimal InfoId { get; set; }
        public decimal? HomeId { get; set; }
        public decimal? AboutUsId { get; set; }
        public decimal? ContactUsId { get; set; }
        public decimal? FirstTestimonial { get; set; }
        public decimal? SecondTestimonial { get; set; }
        public decimal? ThirdTestimonial { get; set; }

        public virtual Testimonial FirstTestimonialNavigation { get; set; }
        public virtual Testimonial SecondTestimonialNavigation { get; set; }
        public virtual Testimonial ThirdTestimonialNavigation { get; set; }
    }
}
