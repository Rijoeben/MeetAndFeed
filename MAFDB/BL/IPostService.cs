using System;
using System.Collections.Generic;
using System.Text;
using MAFDB;
using DAL;
namespace BL
{
    public interface IPostService
    {
        IEnumerable<Post> ListOfPosts();
        public Post CreatePost(string title, string dish, string description, DateTime date, int amountOfPeople, double score);

        public void RemovePost(string postID);

        public void ChangePost(Post post);

    }
}
