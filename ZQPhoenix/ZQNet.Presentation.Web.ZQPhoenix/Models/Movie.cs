﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ZQNet.Presentation.Web.ZQPhoenix.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [DisplayName("标题"), StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name ="Release Date"), DataType(DataType.Date)]
        [ DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [Required,RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"), StringLength(30)]
        public string Genre { get; set; }

        [Range(1, 100), DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"), StringLength(5)]
        public string Rating { get; set; }
    }
}