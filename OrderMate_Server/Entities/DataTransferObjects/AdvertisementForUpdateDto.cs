﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class AdvertisementForUpdateDto
    {
        public string AdvertisementName { get; set; }
        public string AdvertisementDescription { get; set; }
        public byte[] AdvertisementFile { get; set; }
    }
}
