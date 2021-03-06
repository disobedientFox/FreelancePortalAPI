﻿using Services.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Models.Reviews
{
    public class ViewModel
    {
        public long Id { get; set; }
        public DateTime DatePostedUTC { get; set; }
        public string Text { get; set; }
        public int Rate { get; set; }
        public string ReviewerId { get; set; }
        public string ReviewerName { get; set; }
        public string ReviewerAvatar { get; set; }
        public string ReviewingUserId { get; set; }
        public string ReviewingUserName { get; set; }

    }

    public class ListViewModel
    {
        public Pager Pager { get; set; }
        public IEnumerable<ViewModel> Reviews { get; set; }
    }
}
