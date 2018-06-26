﻿using System.Collections.Generic;

namespace Dashboard.Models.ManageViewModels
{
    public class IndexViewModel
    {
        public User User { get; set; }
        public List<User> Users { get; set; }

        public string StatusMessage { get; set; }
    }
}
