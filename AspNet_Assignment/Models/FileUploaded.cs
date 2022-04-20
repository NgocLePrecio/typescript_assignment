﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNet_Assignment.Models
{
    public class FileUploaded
    {
        [Key]
        public int FileId { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string? FileName { get; set; }
        public byte[]? FileData { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? CreatedAt { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? CreatedBy { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string? FileType { get; set; }
    }
}