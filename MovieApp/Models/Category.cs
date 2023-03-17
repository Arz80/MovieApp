﻿using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public List<Movie>? Movies { get; set; }

    }
}
