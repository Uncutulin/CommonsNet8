using System;
using System.Collections.Generic;
using System.Text;
using CommonsNET8.Models;

namespace CommonsNET8.Identity
{
    public class CommonsRoleFunction : Relational 
    {
        public virtual CommonsRole Role { get; set; }
        public virtual CommonsFunction Function { get; set; }
    }
}
