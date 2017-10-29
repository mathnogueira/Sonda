using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public interface IRotatable
    {
        void RotateTo(int degrees);
    }
}
