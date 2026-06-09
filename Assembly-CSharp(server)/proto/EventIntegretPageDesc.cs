using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A00 RID: 2560
	[Token(Token = "0x2000A00")]
	[ProtoContract]
	public class EventIntegretPageDesc
	{
		// Token: 0x0600270A RID: 9994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600270A")]
		[Address(RVA = "0x21B9B8C", Offset = "0x21B9B8C", VA = "0x7BBC9B9B8C")]
		public EventIntegretPageDesc()
		{
		}

		// Token: 0x04002E88 RID: 11912
		[Token(Token = "0x4002E88")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D7CC", Offset = "0x111D7CC")]
		public uint event_id;

		// Token: 0x04002E89 RID: 11913
		[Token(Token = "0x4002E89")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D7E0", Offset = "0x111D7E0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111D7E0", Offset = "0x111D7E0")]
		public string event_name;

		// Token: 0x04002E8A RID: 11914
		[Token(Token = "0x4002E8A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D830", Offset = "0x111D830")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111D830", Offset = "0x111D830")]
		public string event_start_time;

		// Token: 0x04002E8B RID: 11915
		[Token(Token = "0x4002E8B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D880", Offset = "0x111D880")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111D880", Offset = "0x111D880")]
		public string event_end_time;

		// Token: 0x04002E8C RID: 11916
		[Token(Token = "0x4002E8C")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D8D0", Offset = "0x111D8D0")]
		public uint event_start_timestamp;

		// Token: 0x04002E8D RID: 11917
		[Token(Token = "0x4002E8D")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D8E4", Offset = "0x111D8E4")]
		public uint event_end_timestamp;

		// Token: 0x04002E8E RID: 11918
		[Token(Token = "0x4002E8E")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D8F8", Offset = "0x111D8F8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111D8F8", Offset = "0x111D8F8")]
		public string language;

		// Token: 0x04002E8F RID: 11919
		[Token(Token = "0x4002E8F")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D948", Offset = "0x111D948")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111D948", Offset = "0x111D948")]
		public string lobby_icon;

		// Token: 0x04002E90 RID: 11920
		[Token(Token = "0x4002E90")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D998", Offset = "0x111D998")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111D998", Offset = "0x111D998")]
		public string web_mission_url;

		// Token: 0x04002E91 RID: 11921
		[Token(Token = "0x4002E91")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D9E8", Offset = "0x111D9E8")]
		public List<EventMissionDesc> event_missions;

		// Token: 0x04002E92 RID: 11922
		[Token(Token = "0x4002E92")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D9FC", Offset = "0x111D9FC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111D9FC", Offset = "0x111D9FC")]
		public string go_pos;
	}
}
