using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.concrete
{
   public class Category:IEntity
    {
        //çıplak kalmasın
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
