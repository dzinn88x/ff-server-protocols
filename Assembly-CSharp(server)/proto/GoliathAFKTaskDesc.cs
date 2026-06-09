using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B25 RID: 2853
	[Token(Token = "0x2000B25")]
	[ProtoContract]
	public class GoliathAFKTaskDesc
	{
		// Token: 0x0600282D RID: 10285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600282D")]
		[Address(RVA = "0x21BAFC8", Offset = "0x21BAFC8", VA = "0x7BBC9BAFC8")]
		public GoliathAFKTaskDesc()
		{
		}

		// Token: 0x0400361B RID: 13851
		[Token(Token = "0x400361B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C218", Offset = "0x112C218")]
		public uint task_id;

		// Token: 0x0400361C RID: 13852
		[Token(Token = "0x400361C")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C22C", Offset = "0x112C22C")]
		public uint duration;

		// Token: 0x0400361D RID: 13853
		[Token(Token = "0x400361D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C240", Offset = "0x112C240")]
		public List<AwardDesc> awards;
	}
}
