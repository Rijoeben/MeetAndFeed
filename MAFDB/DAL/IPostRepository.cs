using System;
using System.Collections.Generic;
using System.Text;
using MAFDB;

namespace DAL
{
    public interface IPostRepository
    {
        IEnumerable<Post> ReadPosts();

        Post CreatePost(Post post);

        void UpdatePost(Post post);

        void DeletePost(Post post);


    }
}
