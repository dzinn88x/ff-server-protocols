using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B35 RID: 2869
	[Token(Token = "0x2000B35")]
	[ProtoContract]
	public class MonopolyNodeDesc
	{
		// Token: 0x0600283D RID: 10301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283D")]
		[Address(RVA = "0x249E4BC", Offset = "0x249E4BC", VA = "0x7BBCC9E4BC")]
		public MonopolyNodeDesc()
		{
		}

		// Token: 0x04003674 RID: 13940
		[Token(Token = "0x4003674")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CB28", Offset = "0x112CB28")]
		public uint id;

		// Token: 0x04003675 RID: 13941
		[Token(Token = "0x4003675")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CB3C", Offset = "0x112CB3C")]
		public EMiniGame.MonopolyNodeType type;
	}
}
