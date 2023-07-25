
namespace FitnessApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;

    using FitnessApp.Data.Models;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder
                .HasOne(p => p.User)
                .WithMany(a => a.Posts)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(p => p.CreatedOn)
                .HasDefaultValue(DateTime.UtcNow);

            builder
                .Property(p => p.IsActive)
                .HasDefaultValue(true);

           //builder.HasData(this.GeneratePosts());
        }

        private Post[] GeneratePosts()
        {
            ICollection<Post> posts = new HashSet<Post>();

            Post post;

            post = new Post()
            {
                Id = 1,
                Title = "Hypertrophy to Grow Muscles",
                CreatedOn = DateTime.UtcNow,
                UserId = Guid.Parse("ED4B6F55-ACF4-453B-A429-08DB7EEF598B"),
                Text = "You've probably heard big guys at the gym tossing around the word \"hypertrophy\" when they talk about their lifting goals — but what does that even mean? Are the principles behind the term just some sketchy bro science, a passing fitness fad, or real, lab tested-and-proven physiology?\r\nRest assured, the hype is real. Hypertrophy is, by definition, the enlargement of an organ or tissue from the increase in size of its cells. Not to be confused with hyperplasia, the process of increasing the number of cells, hypertrophy is the process of increasing the size of the cells that are already there.This occurs through a physiologic process that leads to an increased number of contractile proteins (actin and myosin) in each muscle fiber. With the right training regimen, you can catalyze this process — but helps to understand the science behind it.The body has the amazing potential to adapt to its environment. This includes building more strength when repeated stress to the tissue indicates a need to accommodate the new, higher loads. This is exactly what the process of strength training does.When it comes to building muscle, hypertrophy doesn’t just happen on its own. It has to be triggered by a physiological need. Hypertrophy can be thought of as a thickening of muscle fibers, which occurs when the body has been stressed just the right amount to indicate that it must create larger, stronger muscles that can tolerate this new, increased load. This need causes a cellular response, leading to cells synthesizing more materials.For muscles to grow, two things have to happen: stimulation and repair. Dormant cells called satellite cells, which exist between the outer and basement membranes of a muscle fiber become activated by trauma, damage or injury — all possible responses to the stress of weight training. An immune system response is triggered, leading to inflammation, the natural clean up and repair process that occurs on a cellular level.Concurrently, a hormonal response is triggered, causing the release of growth factor, cortisol, and testosterone. These hormones help regulate cell activity. Growth factors help stimulate muscle hypertrophy while testosterone increases protein synthesis. This process leads to satellite cells multiplying and their daughter cells migrating to the damaged tissue. Here, they fuse with skeletal muscle and donate their nuclei to the muscle fibers helping them thicken and grow.",

            };
            posts.Add(post);

            return posts.ToArray();
        }
    }
}
