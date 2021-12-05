using CoffeeShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Business.Abstract
{
    public interface ICommentService
    {
        IList<Comment> GetComments();
        Comment GetComment(int id);
    }
}
