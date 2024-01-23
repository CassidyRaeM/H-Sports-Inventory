﻿using H_Sports.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;




namespace H_Sports.Interfaces

{
    public interface IUserRepository
    {
        List<User> GetUsers();

        User GetUserByUserName (string userName);  
        
        User CreateUser (User user);    
    }
}
