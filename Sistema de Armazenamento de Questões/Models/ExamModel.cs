﻿namespace Sistema_de_Armazenamento_de_Questões.Models
{
    public class ExamModel
    {
        public int Id { get; set; }
        public string Title { get; set; }  // Nome da prova
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
