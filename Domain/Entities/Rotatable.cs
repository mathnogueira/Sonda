using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public interface Rotatable
    {
        void RotateTo(int degrees);
    }
}
