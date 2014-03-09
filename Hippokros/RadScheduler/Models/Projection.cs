using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RadSchedule.Models
{
    public class Projection : ISchedulerEvent
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Description { get; set; }
        public string StartTimezone { get; set; }
        public string EndTimezone { get; set; }
        public bool IsAllDay { get; set; }
        public string Recurrence { get; set; }
        public string RecurrenceRule { get; set; }
        public string RecurrenceException { get; set; }
    }
}