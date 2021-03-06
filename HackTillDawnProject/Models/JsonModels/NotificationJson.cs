﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTillDawnProject.Models.JsonModels
{
    public class NotificationJson
    {
        /* From FootageStorage */
        public string IdFootageStorage { get; set; }
        public DateTime? DateTimeCaptureStartUtc { get; set; }
        public DateTime? DateTimeCaptureEndUtc { get; set; }
        public string Tags { get; set; }
        public string TriggerDescription { get; set; }
        public decimal? TriggerConfidencePercent { get; set; }
        public string FileLocation { get; set; }
        public string FileName { get; set; }

        /* From APIResultType */
        public string IdResultType { get; set; }
        public string APIResultTypeName { get; set; }

        /* From RegisteredDevice */
        public string IdRegisteredDevice { get; set; }
        public string DeviceName { get; set; }

        public bool? is_read { get; set; }
    }
}
