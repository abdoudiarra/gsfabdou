using System;
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
        public async Task<ActionResult<PostDto>> PublishPost(PostDto postDto)
        {
            var post = new Post
            {
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
                Comments = post.Comments
            };
        }

        [HttpDelete("delete/{id}")]
        public async Task DeletePost(int id)
        {
            var post = _context.Posts.SingleOrDefault(x => x.Id == id);

            if (post != null)
            {
                _context.Posts.Remove(post);
            }

            await _context.SaveChangesAsync();

        }

        [HttpGet("Posts")]
        public async Task<ActionResult<IEnumerable<Post>>> GePosts()
        {
            var posts = _context.Posts.ToListAsync();

            return await posts;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Post>> GetPostById(int id)
        {
            var post = _context.Posts.FindAsync(id);
            return await post;
        }
    

    }
}

