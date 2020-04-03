using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MAFDB;

namespace DAL
{
    public class PostRepository : IPostRepository
    {

        private readonly MeetAndFeedDbContext ctx;

        public IEnumerable<Post> ReadPosts()
        {
            return ctx.Posts.AsEnumerable();
        }

        public Post CreatePost(Post post)
        {
            ctx.Add(post);
            ctx.SaveChanges();
            return post;
        }

        public void UpdatePost(Post post)
        {
            ctx.Add(post);
            ctx.SaveChanges();
        }

        public void DeletePost(Post post)
        {
            ctx.Remove(post);
            ctx.SaveChanges();
        }
        public Post GetPost()

    }
}
