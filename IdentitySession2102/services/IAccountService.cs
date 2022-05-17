using IdentitySession2102.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentitySession2102.services
{
    public interface IAccountService
    {
        Task<IdentityResult> CreateUser(SignUpModel signUpModel);
        Task<SignInResult> CheckPassword(SignInModel signInModel);

        Task<IdentityResult> NewRole(RoleModel roleModel);

        List<IdentityRole> GetRoles();

        Task Logout();
    }
}
