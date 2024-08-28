using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CommonsNET8.Identity.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CommonsNET8.Identity
{
    public interface ICommonsDbContext 
    {
        Task SaveChangesAsync();

        DbSet<CommonsRole> Roles { get; }
        DbSet<CommonsFunction> AspNetFunctions { get; }
        DbSet<CommonsRoleFunction> AspNetRoleFunctions { get; }

        List<IWorkSpace> GetIWorkSpaces();
        EntityEntry<T> Entry<T>(T entry) where T : class;
    }
}