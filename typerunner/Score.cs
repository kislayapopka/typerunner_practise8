﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Score
{
    internal class UserScore
    {
        public string username;
        public string scoremin;
        public string scoresec;
        public UserScore(string _username, string _scoremin, string _scoresec)
        {
            username = _username;
            scoremin = _scoremin;
            scoresec = _scoresec;
        }
    }
}
