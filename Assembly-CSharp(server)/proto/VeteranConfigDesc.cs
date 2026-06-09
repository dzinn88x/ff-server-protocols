using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A2A RID: 2602
	[Token(Token = "0x2000A2A")]
	[ProtoContract]
	public class VeteranConfigDesc
	{
		// Token: 0x06002734 RID: 10036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002734")]
		[Address(RVA = "0x24A1540", Offset = "0x24A1540", VA = "0x7BBCCA1540")]
		public VeteranConfigDesc()
		{
		}

		// Token: 0x04002F66 RID: 12134
		[Token(Token = "0x4002F66")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F4A0", Offset = "0x111F4A0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111F4A0", Offset = "0x111F4A0")]
		public string region;

		// Token: 0x04002F67 RID: 12135
		[Token(Token = "0x4002F67")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F4F0", Offset = "0x111F4F0")]
		public uint leave_days;

		// Token: 0x04002F68 RID: 12136
		[Token(Token = "0x4002F68")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F504", Offset = "0x111F504")]
		public uint chest_leave_days;

		// Token: 0x04002F69 RID: 12137
		[Token(Token = "0x4002F69")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F518", Offset = "0x111F518")]
		public uint rich_veteran_min_level;

		// Token: 0x04002F6A RID: 12138
		[Token(Token = "0x4002F6A")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F52C", Offset = "0x111F52C")]
		public uint rich_veteran_max_level;

		// Token: 0x04002F6B RID: 12139
		[Token(Token = "0x4002F6B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F540", Offset = "0x111F540")]
		public uint senior_veteran;

		// Token: 0x04002F6C RID: 12140
		[Token(Token = "0x4002F6C")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F554", Offset = "0x111F554")]
		public uint veteran_time;

		// Token: 0x04002F6D RID: 12141
		[Token(Token = "0x4002F6D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F568", Offset = "0x111F568")]
		public uint veteran_switch;
	}
}
