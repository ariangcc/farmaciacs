﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface Entity
    {
        void addToBD();
        void updateInBD();
        void deleteInBD();
    }
}
