using MyNotebooks.Data.AccountServices.Contracts;
using MyNotebooks.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyNotebooks.DataModels.Models;

namespace MyNotebooks.Data.AccountServices
{
    public class UserService : IUserService
    {
        private IUserRepository repository;
        private IUnitOfWork unitOfWork;
        private NotebooksDbContext context;

        public UserService(IUserRepository repository, IUnitOfWork unitOfWork, NotebooksDbContext context)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
            this.context = context;

            this.repository.setContext(context);
            this.unitOfWork.setContext(context);
        }

        public User Find(string username)
        {
            return this.repository.Find(username);
        }

        public bool AddRoleToUser(string username, string roleName)
        {
            this.repository.AddRoleToUser(username, roleName);
            this.repository.AddClaimToUser(username, "Role", roleName);
            this.unitOfWork.Commit();
            return true;
        }

        public bool AddClaimToUser(string username, string claimType, string claimValue)
        {
            this.repository.AddClaimToUser(username, claimType, claimValue);
            this.unitOfWork.Commit();
            return true;
        }

        public bool ContainsClaim(string username, string claimType, string claimValue)
        {
            return this.repository.ContainsClaim(username, claimType, claimValue);
        }
    }
}
