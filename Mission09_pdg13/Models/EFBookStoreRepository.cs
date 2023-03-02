﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_pdg13.Models
{
    public class EFBookStoreRepository : IBookStoreRepository
    {
        private BookStoreContext context { get; set; }

        public EFBookStoreRepository (BookStoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Book> Books => context.Books;
    }
}