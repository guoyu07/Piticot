﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiticotBusiness.Classes.Command
{
    public abstract class UndoableCommand : Command
    {
        public abstract void Undo();
    }
}
