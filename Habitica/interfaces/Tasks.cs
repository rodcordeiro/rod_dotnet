using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Habitica.interfaces
{
    public class HabiticaResponse
    {
        public bool Success { get; set; }
        public List<HabiticaDatum>? Data { get; set; } 
        public List<HabiticaNotification>? Notifications { get; set; }
        public string? AppVersion { get; set; }

    }

    public class HabiticaNotification
    {
        public string? Type { get; set; }
        public HabiticaNotificationData? Data { get; set; }
        public bool Seen { get; set; }
        public string? Id { get; set; }
    }

    public class HabiticaNotificationData
    {
        public string? HeaderText { get; set; }
        public string? BodyText { get; set; }
        public decimal? Hp { get; set; }
        public decimal? Mp { get; set; }

        public HabiticaGroup? Group { get; set; }

    }
    public class HabiticaGroup
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public Dictionary<string, string>? CompletedBy { get; set; }
        public List<string>? AssignedUsers { get; set; }
    }

    public class HabiticaDatum
    {
        public HabiticaChallenge? Challenge { get; set; }
        public HabiticaGroup? Group { get; set; }
        [JsonPropertyName("_id")]
        public string? Id_ { get; set; }
        public bool Complete { get; set; }
        public bool CollapseChecklist { get; set; }
        public string? Type { get; set; }
        public string? Notes { get; set; }
        public List<string>? Tags { get; set; }
        public decimal? Value { get; set; }
        public int Priority { get; set; }
        public string? Attribute { get; set; }
        public bool ByHabitica { get; set; }
        public string? Text { get; set; }
        public List<HabiticaReminder>? Reminders { get; set; } = [];
        public List<HabiticaChecklist>? Checklist { get; set; } = [];
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? UserId { get; set; }
        public string? Id { get; set; }
        public string? Date { get; set; }


    }

    public class HabiticaReminder
    {
        public string? Id { get; set; }
        public DateTime Time { get; set; }
    }
    public class HabiticaChecklist
    {
        public bool Completed { get; set; }
        public string? Text { get; set; }
        public string? Id { get; set; }

    }
    public class HabiticaChallenge
    {
    }

    public class HabiticaTasks
    {
        public int? Id { get; set; }
        public string Text { get; set; }
        public string Notes { get; set; }
        public List<HabiticaCheckListItem> Checklist { get; set; }
        public List<HabiticaTags> Tags { get; set; }
        public int? Priotities { get; set; }
        public string Attribute { get; set; }
        public bool Completed { get; set; }
        public string Type { get; set; }

    }

    public class HabiticaCheckListItem
    {

        public string Id { get; set; }
        public string Text { get; set; }
        public bool Completed { get; set; }

    }
}