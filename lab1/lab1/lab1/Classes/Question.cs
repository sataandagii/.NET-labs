﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Classes
{
    public class Question
    {
        public string QuestionText { get; set; }
        public List<string> Variants { get; set; }
        public string CorrectAnswer { get; set; }
    }
}
