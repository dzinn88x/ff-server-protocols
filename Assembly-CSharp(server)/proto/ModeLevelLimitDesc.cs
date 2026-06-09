using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A0E RID: 2574
	[Token(Token = "0x2000A0E")]
	[ProtoContract]
	public class ModeLevelLimitDesc
	{
		// Token: 0x06002718 RID: 10008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002718")]
		[Address(RVA = "0x21BCB78", Offset = "0x21BCB78", VA = "0x7BBC9BCB78")]
		public ModeLevelLimitDesc()
		{
		}

		// Token: 0x04002EFF RID: 12031
		[Token(Token = "0x4002EFF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E6A4", Offset = "0x111E6A4")]
		public uint map_id;

		// Token: 0x04002F00 RID: 12032
		[Token(Token = "0x4002F00")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E6B8", Offset = "0x111E6B8")]
		public uint game_mode;

		// Token: 0x04002F01 RID: 12033
		[Token(Token = "0x4002F01")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E6CC", Offset = "0x111E6CC")]
		public uint level;
	}
}
