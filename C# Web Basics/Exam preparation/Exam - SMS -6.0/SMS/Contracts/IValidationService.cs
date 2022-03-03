﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Contracts
{
    public interface IValidationService
    {
        (bool isValid, string error) ValidateModel(object model);
    }
}
