﻿namespace ExaminationSystem
{
    public class Subject
    {
        public string Name { get; set; }

        public Subject(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}