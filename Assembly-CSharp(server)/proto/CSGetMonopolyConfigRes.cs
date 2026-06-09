using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009A4 RID: 2468
	[Token(Token = "0x20009A4")]
	[ProtoContract]
	public class CSGetMonopolyConfigRes
	{
		// Token: 0x060026B2 RID: 9906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B2")]
		[Address(RVA = "0x21B4D28", Offset = "0x21B4D28", VA = "0x7BBC9B4D28")]
		public CSGetMonopolyConfigRes()
		{
		}

		// Token: 0x04002C8C RID: 11404
		[Token(Token = "0x4002C8C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A3C4", Offset = "0x111A3C4")]
		public List<MonopolyNodeDesc> nodes;

		// Token: 0x04002C8D RID: 11405
		[Token(Token = "0x4002C8D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A3D8", Offset = "0x111A3D8")]
		public MonopolySettingDesc setting;

		// Token: 0x04002C8E RID: 11406
		[Token(Token = "0x4002C8E")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A3EC", Offset = "0x111A3EC")]
		public List<MonopolyEventDesc> events;
	}
}
