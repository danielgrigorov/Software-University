﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarShop.Services
{
    public interface IPasswordHasher
    {
        string HashPassword(string password);
    }
}
