﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using ToDo.Domain.Concrete;
using ToDo.Domain.Entities;

public class ApplicationUserManager : UserManager<User>
{
    public ApplicationUserManager(IUserStore<User> store)
            : base(store)
    {
    }
    public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options,
                                            IOwinContext context)
    {
        ApplicationContext db = context.Get<ApplicationContext>();
        ApplicationUserManager manager = new ApplicationUserManager(new UserStore<User>(db));
        return manager;
    }
}
