﻿namespace GF.UCenter.MongoDB.Attributes
{
    using System;

    /// <summary>
    /// Provide an attribute to mark collection name.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    internal class CollectionNameAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionNameAttribute" /> class.
        /// </summary>
        /// <param name="collectionName">Indicating the collection name.</param>
        public CollectionNameAttribute(string collectionName)
        {
            this.CollectionName = collectionName;
        }

        /// <summary>
        /// Gets the collection name.
        /// </summary>
        public string CollectionName { get; private set; }
    }
}
