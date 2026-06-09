using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A42 RID: 2626
	[Token(Token = "0x2000A42")]
	[ProtoContract]
	public class ClanRaceOpeningInfoDesc
	{
		// Token: 0x0600274C RID: 10060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600274C")]
		[Address(RVA = "0x21B89C0", Offset = "0x21B89C0", VA = "0x7BBC9B89C0")]
		public ClanRaceOpeningInfoDesc()
		{
		}

		// Token: 0x04002FE4 RID: 12260
		[Token(Token = "0x4002FE4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11202EC", Offset = "0x11202EC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11202EC", Offset = "0x11202EC")]
		public string region;

		// Token: 0x04002FE5 RID: 12261
		[Token(Token = "0x4002FE5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112033C", Offset = "0x112033C")]
		public uint start_week_day;

		// Token: 0x04002FE6 RID: 12262
		[Token(Token = "0x4002FE6")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120350", Offset = "0x1120350")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1120350", Offset = "0x1120350")]
		public string start_time;

		// Token: 0x04002FE7 RID: 12263
		[Token(Token = "0x4002FE7")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11203A0", Offset = "0x11203A0")]
		public uint end_week_day;

		// Token: 0x04002FE8 RID: 12264
		[Token(Token = "0x4002FE8")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11203B4", Offset = "0x11203B4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11203B4", Offset = "0x11203B4")]
		public string end_time;
	}
}
