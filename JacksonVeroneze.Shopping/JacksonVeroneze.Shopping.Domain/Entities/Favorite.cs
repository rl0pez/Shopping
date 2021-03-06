﻿using JacksonVeroneze.Shopping.Common;
using LiteDB;
using System;

namespace JacksonVeroneze.Shopping.Domain.Entities
{
    //
    // Summary:
    //     Class responsible for the entity.
    //
    public class Favorite : BaseEntity
    {
        //
        // Summary:
        //     /// Method responsible for initializing the entity. ///
        //
        public Favorite() : base() { }

        //
        // Summary:
        //     /// Method responsible for initializing the entity. ///
        //
        // Parameters:
        //   productId:
        //     The productId param.
        //
        public Favorite(int productId) : base()
            => ProductId = productId;

        public ObjectId Id { get; private set; } = ObjectId.NewObjectId();

        public int ProductId { get; private set; }

        //
        // Summary:
        //     /// Method responsible for returning a string 
        //     representation of the object. ///
        //
        public override string ToString()
            => $"Id: {Id}, ProductId: {ProductId}";
    }
}