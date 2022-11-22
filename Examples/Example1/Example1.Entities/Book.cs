﻿using Entities;

namespace Example1.Entities
{
    [HasStronglyTypedId]
    public class Book
    {
        public BookId Id{get;set;}
        public string Name { get; set; }
        public double Price { get; set; }
        public Author Author { get; set; }
    }
}
