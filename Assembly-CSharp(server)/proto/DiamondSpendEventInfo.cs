using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200078B RID: 1931
	[Token(Token = "0x200078B")]
	[ProtoContract]
	public class DiamondSpendEventInfo
	{
		// Token: 0x0600249A RID: 9370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600249A")]
		[Address(RVA = "0x21B9600", Offset = "0x21B9600", VA = "0x7BBC9B9600")]
		public DiamondSpendEventInfo()
		{
		}

		// Token: 0x0400258F RID: 9615
		[Token(Token = "0x400258F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E254", Offset = "0x110E254")]
		public List<DiamondSpendEventDesc> descs;

		// Token: 0x04002590 RID: 9616
		[Token(Token = "0x4002590")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E268", Offset = "0x110E268")]
		public uint topup_times;
	}
}
