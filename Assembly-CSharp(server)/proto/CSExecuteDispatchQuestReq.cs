using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200081A RID: 2074
	[Token(Token = "0x200081A")]
	[ProtoContract]
	public class CSExecuteDispatchQuestReq
	{
		// Token: 0x06002529 RID: 9513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002529")]
		[Address(RVA = "0x21B1280", Offset = "0x21B1280", VA = "0x7BBC9B1280")]
		public CSExecuteDispatchQuestReq()
		{
		}

		// Token: 0x0400271D RID: 10013
		[Token(Token = "0x400271D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110DEC", Offset = "0x1110DEC")]
		public uint quest_line;

		// Token: 0x0400271E RID: 10014
		[Token(Token = "0x400271E")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110E00", Offset = "0x1110E00")]
		public uint quest_id;

		// Token: 0x0400271F RID: 10015
		[Token(Token = "0x400271F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110E14", Offset = "0x1110E14")]
		public uint[] avatar_ids;
	}
}
