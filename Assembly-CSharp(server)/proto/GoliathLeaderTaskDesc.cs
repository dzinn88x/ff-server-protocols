using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B26 RID: 2854
	[Token(Token = "0x2000B26")]
	[ProtoContract]
	public class GoliathLeaderTaskDesc
	{
		// Token: 0x0600282E RID: 10286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600282E")]
		[Address(RVA = "0x21BB03C", Offset = "0x21BB03C", VA = "0x7BBC9BB03C")]
		public GoliathLeaderTaskDesc()
		{
		}

		// Token: 0x0400361E RID: 13854
		[Token(Token = "0x400361E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C254", Offset = "0x112C254")]
		public uint task_id;

		// Token: 0x0400361F RID: 13855
		[Token(Token = "0x400361F")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C268", Offset = "0x112C268")]
		public uint task_weight;
	}
}
