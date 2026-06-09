using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009F9 RID: 2553
	[Token(Token = "0x20009F9")]
	[ProtoContract]
	public class ActivityFestivalDesc
	{
		// Token: 0x06002703 RID: 9987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002703")]
		[Address(RVA = "0x21AED3C", Offset = "0x21AED3C", VA = "0x7BBC9AED3C")]
		public ActivityFestivalDesc()
		{
		}

		// Token: 0x04002E58 RID: 11864
		[Token(Token = "0x4002E58")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CE08", Offset = "0x111CE08")]
		public uint event_id;

		// Token: 0x04002E59 RID: 11865
		[Token(Token = "0x4002E59")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CE1C", Offset = "0x111CE1C")]
		public uint table_type;

		// Token: 0x04002E5A RID: 11866
		[Token(Token = "0x4002E5A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CE30", Offset = "0x111CE30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111CE30", Offset = "0x111CE30")]
		public string table_sprite;

		// Token: 0x04002E5B RID: 11867
		[Token(Token = "0x4002E5B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CE80", Offset = "0x111CE80")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111CE80", Offset = "0x111CE80")]
		public string language;

		// Token: 0x04002E5C RID: 11868
		[Token(Token = "0x4002E5C")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111CED0", Offset = "0x111CED0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CED0", Offset = "0x111CED0")]
		public string event_title;

		// Token: 0x04002E5D RID: 11869
		[Token(Token = "0x4002E5D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111CF20", Offset = "0x111CF20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CF20", Offset = "0x111CF20")]
		public string event_lobby_icon;

		// Token: 0x04002E5E RID: 11870
		[Token(Token = "0x4002E5E")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111CF70", Offset = "0x111CF70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CF70", Offset = "0x111CF70")]
		public string start_time;

		// Token: 0x04002E5F RID: 11871
		[Token(Token = "0x4002E5F")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111CFC0", Offset = "0x111CFC0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CFC0", Offset = "0x111CFC0")]
		public string end_time;

		// Token: 0x04002E60 RID: 11872
		[Token(Token = "0x4002E60")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D010", Offset = "0x111D010")]
		public uint festival_item_id;

		// Token: 0x04002E61 RID: 11873
		[Token(Token = "0x4002E61")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111D024", Offset = "0x111D024")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D024", Offset = "0x111D024")]
		public string cdn_url;

		// Token: 0x04002E62 RID: 11874
		[Token(Token = "0x4002E62")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D074", Offset = "0x111D074")]
		public uint affiliate_table;

		// Token: 0x04002E63 RID: 11875
		[Token(Token = "0x4002E63")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D088", Offset = "0x111D088")]
		public uint group_id;

		// Token: 0x04002E64 RID: 11876
		[Token(Token = "0x4002E64")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D09C", Offset = "0x111D09C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111D09C", Offset = "0x111D09C")]
		public string color_value;

		// Token: 0x04002E65 RID: 11877
		[Token(Token = "0x4002E65")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D0EC", Offset = "0x111D0EC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111D0EC", Offset = "0x111D0EC")]
		public string select_line;

		// Token: 0x04002E66 RID: 11878
		[Token(Token = "0x4002E66")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D13C", Offset = "0x111D13C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111D13C", Offset = "0x111D13C")]
		public string event_lobby_vfx;
	}
}
