using CoffeeShop.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet("getcomments")]
        public ActionResult GetComments()
        {
            var comments = _commentService.GetComments();
            return Ok(comments);

        }

        [HttpGet("getcomment/{id}")]
        public ActionResult GetComment(int id)
        {
            var comment = _commentService.GetComment(id);
            return Ok(comment);

        }
    }
}
