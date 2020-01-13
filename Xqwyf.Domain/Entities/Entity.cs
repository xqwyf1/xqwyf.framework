﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Xqwyf.Domain.Entities
{
    public abstract class Entity : IEntity
    {
        public abstract object[] GetKeys();

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"[ENTITY: {GetType().Name}] Keys = {GetKeys().ToString()}";
        }
    }
}