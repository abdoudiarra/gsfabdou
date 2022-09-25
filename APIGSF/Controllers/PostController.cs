using System;
using API.Controllers;
using APIGSF.Data;
using APIGSF.DTOs;
using APIGSF.Entities;
using Microsoft.AspNetCore.Mvc;

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

    }
}

