using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009FA RID: 2554
	[Token(Token = "0x20009FA")]
	[ProtoContract]
	public class ActivityEntranceSwitchDesc
	{
		// Token: 0x06002704 RID: 9988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002704")]
		[Address(RVA = "0x21AECD8", Offset = "0x21AECD8", VA = "0x7BBC9AECD8")]
		public ActivityEntranceSwitchDesc()
		{
		}

		// Token: 0x04002E67 RID: 11879
		[Token(Token = "0x4002E67")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D18C", Offset = "0x111D18C")]
		public uint id;

		// Token: 0x04002E68 RID: 11880
		[Token(Token = "0x4002E68")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D1A0", Offset = "0x111D1A0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111D1A0", Offset = "0x111D1A0")]
		public string show_time;

		// Token: 0x04002E69 RID: 11881
		[Token(Token = "0x4002E69")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D1F0", Offset = "0x111D1F0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111D1F0", Offset = "0x111D1F0")]
		public string start_time;

		// Token: 0x04002E6A RID: 11882
		[Token(Token = "0x4002E6A")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D240", Offset = "0x111D240")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111D240", Offset = "0x111D240")]
		public string end_time;

		// Token: 0x04002E6B RID: 11883
		[Token(Token = "0x4002E6B")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D290", Offset = "0x111D290")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111D290", Offset = "0x111D290")]
		public string go_url;

		// Token: 0x04002E6C RID: 11884
		[Token(Token = "0x4002E6C")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D2E0", Offset = "0x111D2E0")]
		public uint go_pos;

		// Token: 0x04002E6D RID: 11885
		[Token(Token = "0x4002E6D")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D2F4", Offset = "0x111D2F4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111D2F4", Offset = "0x111D2F4")]
		public string cdn_url;

		// Token: 0x04002E6E RID: 11886
		[Token(Token = "0x4002E6E")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111D344", Offset = "0x111D344")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D344", Offset = "0x111D344")]
		public string tip_cdn_url;
	}
}
