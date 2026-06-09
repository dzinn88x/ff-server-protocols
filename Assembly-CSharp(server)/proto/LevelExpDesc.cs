using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A2F RID: 2607
	[Token(Token = "0x2000A2F")]
	[ProtoContract]
	public class LevelExpDesc
	{
		// Token: 0x06002739 RID: 10041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002739")]
		[Address(RVA = "0x21BB954", Offset = "0x21BB954", VA = "0x7BBC9BB954")]
		public LevelExpDesc()
		{
		}

		// Token: 0x04002F95 RID: 12181
		[Token(Token = "0x4002F95")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FAA4", Offset = "0x111FAA4")]
		public uint level;

		// Token: 0x04002F96 RID: 12182
		[Token(Token = "0x4002F96")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FAB8", Offset = "0x111FAB8")]
		public uint exp;
	}
}
