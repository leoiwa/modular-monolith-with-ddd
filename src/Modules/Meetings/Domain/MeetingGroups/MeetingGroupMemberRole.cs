﻿using CompanyName.MyMeetings.BuildingBlocks.Domain;

namespace CompanyName.MyMeetings.Modules.Meetings.Domain.MeetingGroups
{
    public class MeetingGroupMemberRole : ValueObject
    {
        public static MeetingGroupMemberRole Organizer => new MeetingGroupMemberRole("Organizer");
        public static MeetingGroupMemberRole Member => new MeetingGroupMemberRole("Member");

        public string Value { get; }

        public MeetingGroupMemberRole(string value)
        {
            this.Value = value;
        }
    }
}