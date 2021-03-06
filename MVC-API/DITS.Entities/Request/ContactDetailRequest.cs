﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITS.Entities.Request
{
    public class ContactDetailRequest
    {
        public int UserContactId { get; set; }
        public int UserBasicInformationId { get; set; }
        public string Email { get; set; }
        public string AlternateEmail { get; set; }
        public string SkypeId { get; set; }
        public string PermanentAddress { get; set; }
        public int PermanentCity { get; set; }
        public int PermanentState { get; set; }
        public string PermanentZIP { get; set; }
        public int PermanentCountry { get; set; }
        public string CorrespondenceAddress { get; set; }
        public Nullable<int> CorrespondenceCity { get; set; }
        public Nullable<int> CorrespondenceState { get; set; }
        public string CorrespondenceZIP { get; set; }
        public Nullable<int> CorrespondenceCountry { get; set; }
        public string PhoneNumber { get; set; }
        public string AlternatePhoneNumber { get; set; }
    }
}
