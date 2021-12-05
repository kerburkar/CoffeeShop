using CoffeeShop.Business.Abstract;
using CoffeeShop.DataAccess.Abstract;
using CoffeeShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Business.Concrete
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }
        public IList<Comment> GetComments()
        {
            return _commentRepository.GetAll().ToList();

        }

        public Comment GetComment(int id)
        {
            return _commentRepository.Get(q => q.Id == id);
        }
    }
}
