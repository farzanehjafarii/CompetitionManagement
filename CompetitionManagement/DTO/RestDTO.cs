﻿namespace CompetitionManagement.DTO
{
    public class RestDTO<T>
    {
        public T Data { get; set; } = default!;

        public List<LinkDTO> Links { get; set; } = new List<LinkDTO>();
    }
}
