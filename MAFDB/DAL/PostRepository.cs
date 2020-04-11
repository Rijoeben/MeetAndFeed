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

        public Post AddPost(Post post)
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

        public void DeletePost(long postId)
        {
            ctx.Posts.Remove(GetPost(postId));
            ctx.SaveChanges();
        }
        public Post GetPost(long postId)
        {
            return ctx.Posts.Find(postId);
        }

    }
}
