using System;
using System.Xml.Linq;
using API.Controllers;
using APIGSF.Data;
using APIGSF.DTOs;
using APIGSF.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace APIGSF.Controllers
{
    public class PostController : BaseApiController
    {
        private readonly DataContext _context;
        public PostController(DataContext context)
        {
            _context = context;


    }

        [HttpPost("PublishPost")]
        public async Task<ActionResult<PostDto>> PublishPost(PostDto postDto, int userId)
        {
            if (userId == null)
                throw new NotImplementedException("error"); var post = new Posts
            {
                AppUserId = userId,
                Caption = postDto.Caption,
                Liked = postDto.Liked,
                Saved = postDto.Saved,
                Comments = postDto.Comments
            };

           

            _context.Posts.Add(post);

            await _context.SaveChangesAsync();
           
            return new PostDto
            {
                Caption = post.Caption,
                Liked = post.Liked,
                Saved = post.Saved,
                Comments = post.Comments,
                AppUserId = userId
                
            };
        }

        [HttpDelete("delete/{postId}/{userId}")]
        public async Task DeletePost(int postId, int userId)
        {
            var post = _context.Posts.SingleOrDefault(x => x.Id == postId);

            if (post != null)
            {
                var comments = _context.Comments.Where(x => x.PostsId == postId).ToList();
                if(comments != null)
                {
                    for(int i = 0; i < comments.Count(); i++)
                    {
                        _context.Comments.Remove(comments[i]);
                    }
                    _context.Posts.Remove(post);
                }
               
            }

            await _context.SaveChangesAsync();

        }

        [HttpGet("PostsFromUser/{id}")]
        public async Task<ActionResult<IEnumerable<Posts>>> getPostsFromUser(int id)
        {
            var user = _context.Users.SingleOrDefault(x => x.Id == id);
           
            var posts = _context.Posts.Where(x => x.AppUserId == user.Id).ToListAsync();
            
            return await posts;
        }

        [HttpGet("Posts")]
        public async Task<ActionResult<IEnumerable<Posts>>> GetPosts()
        {
            var posts = _context.Posts.ToListAsync();

            return await posts;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Posts>> GetPostById(int id)
        {
            var post = _context.Posts.FindAsync(id);
            return await post;
        }
    }
}

