﻿using System;
using System.Collections.Generic;
using System.Text;
using ToddlerScanV2.Models;

namespace ToddlerScanV2.Contracts.Repository.Services.Data
{
    public interface ITeacherService
    {
        Teacher getTeacherById(int id);

    }
}