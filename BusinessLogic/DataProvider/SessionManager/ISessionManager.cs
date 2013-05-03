﻿using BusinessLogic.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DataProvider.SessionManager
{
    public interface ISessionManager
    {
        public List<Session> GetAllSession(); 
    }
}
