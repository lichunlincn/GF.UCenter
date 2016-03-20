﻿using System;
using System.Collections.Generic;

    public class AccountResponse
    {
        public string AccountName { get; set; }

        public string Password { get; set; }

        public string SuperPassword { get; set; }

        public string Token { get; set; }

        public DateTime LastLoginDateTime { get; set; }

        public string Name { get; set; }

        public Sex Sex { get; set; }

        public string IdentityNum { get; set; }

        public string PhoneNum { get; set; }

        public string Email { get; set; }
    }