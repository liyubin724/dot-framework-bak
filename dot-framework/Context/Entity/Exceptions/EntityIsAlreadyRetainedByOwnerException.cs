﻿namespace Dot.Framework
{
    public class EntityIsAlreadyRetainedByOwnerException : FWException
    {

        public EntityIsAlreadyRetainedByOwnerException(IEntity entity, object owner)
            : base("'" + owner + "' cannot retain " + entity + "!\n" +
                   "Entity is already retained by this object!",
                "The entity must be released by this object first.")
        {
        }
    }
}
