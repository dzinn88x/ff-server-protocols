using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A27 RID: 2599
	[Token(Token = "0x2000A27")]
	[ProtoContract]
	public class NewPlayerLevelUpLimitTimeDesc
	{
		// Token: 0x06002731 RID: 10033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002731")]
		[Address(RVA = "0x249E958", Offset = "0x249E958", VA = "0x7BBCC9E958")]
		public NewPlayerLevelUpLimitTimeDesc()
		{
		}

		// Token: 0x04002F5B RID: 12123
		[Token(Token = "0x4002F5B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F2D4", Offset = "0x111F2D4")]
		public ulong date_ob19_timestamp;

		// Token: 0x04002F5C RID: 12124
		[Token(Token = "0x4002F5C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F2E8", Offset = "0x111F2E8")]
		public ulong date_cut_apart_timestamp;

		// Token: 0x04002F5D RID: 12125
		[Token(Token = "0x4002F5D")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F2FC", Offset = "0x111F2FC")]
		public ulong new_player_days;

		// Token: 0x04002F5E RID: 12126
		[Token(Token = "0x4002F5E")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F310", Offset = "0x111F310")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111F310", Offset = "0x111F310")]
		public string date_ob19;

		// Token: 0x04002F5F RID: 12127
		[Token(Token = "0x4002F5F")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F360", Offset = "0x111F360")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111F360", Offset = "0x111F360")]
		public string date_cut_apart;
	}
}
