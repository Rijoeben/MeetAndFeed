using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MAFDB;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class PostRepository : IPostRepository
    {

        private readonly MeetAndFeedDbContext ctx;

        public PostRepository()
        {
            ctx = new MeetAndFeedDbContext();
        }
        //Include(p => p.Participants).ThenInclude(p => p.Allergies) dees is echt nice want hier kunde leuke dingen mee doen 
        public IEnumerable<Post> ReadPosts()
        {
            return ctx.Posts.Include(p => p.Reviews).Include(p => p.Participants).AsEnumerable();
        }
        public Post AddPost(Post post)
        {
            ctx.Posts.Add(post);
            ctx.SaveChanges();
            return post;
        }
        public void UpdatePost(Post post)
        {
            ctx.Posts.Update(post);
            ctx.SaveChanges();
        }
        public void DeletePost(long postId)
        {
            ctx.Posts.Remove(GetPost(postId));
            ctx.SaveChanges();
        }
        public Post GetPost(long postId)
        {
            return ctx.Posts.Include(p => p.Reviews).First(p => p.PostId == postId);
        }
    }
}
