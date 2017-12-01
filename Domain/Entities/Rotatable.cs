using Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public interface Rotatable : Target
    {
        int Rotation { get; }
        void RotateTo(int degrees);
    }
}
