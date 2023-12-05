﻿namespace Model
{
    public class PersonModel: BaseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public bool Active { get; set; }
    }
}