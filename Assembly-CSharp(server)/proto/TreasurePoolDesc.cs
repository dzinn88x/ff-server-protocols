using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009F2 RID: 2546
	[Token(Token = "0x20009F2")]
	[ProtoContract]
	public class TreasurePoolDesc
	{
		// Token: 0x060026FC RID: 9980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026FC")]
		[Address(RVA = "0x24A11F0", Offset = "0x24A11F0", VA = "0x7BBCCA11F0")]
		public TreasurePoolDesc()
		{
		}

		// Token: 0x04002DFB RID: 11771
		[Token(Token = "0x4002DFB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C2B4", Offset = "0x111C2B4")]
		public uint id;

		// Token: 0x04002DFC RID: 11772
		[Token(Token = "0x4002DFC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C2C8", Offset = "0x111C2C8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111C2C8", Offset = "0x111C2C8")]
		public string name;

		// Token: 0x04002DFD RID: 11773
		[Token(Token = "0x4002DFD")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C318", Offset = "0x111C318")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111C318", Offset = "0x111C318")]
		public string desc;

		// Token: 0x04002DFE RID: 11774
		[Token(Token = "0x4002DFE")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C368", Offset = "0x111C368")]
		public uint need_daily_score;

		// Token: 0x04002DFF RID: 11775
		[Token(Token = "0x4002DFF")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C37C", Offset = "0x111C37C")]
		public uint need_weekly_score;
	}
}
