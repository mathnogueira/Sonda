﻿using System;
using System.Collections.Generic;
using System.Text;
using Domain.Geometry;

namespace Domain.Entities
{
    public interface ISonda : IMoveable, IRotatable
    {
        Point2d Position { get; }
        int Rotation { get; }
    }
}