using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000980 RID: 2432
	[Token(Token = "0x2000980")]
	[ProtoContract]
	public class GoliathAFKGroupInfo
	{
		// Token: 0x0600268E RID: 9870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268E")]
		[Address(RVA = "0x21BAEF8", Offset = "0x21BAEF8", VA = "0x7BBC9BAEF8")]
		public GoliathAFKGroupInfo()
		{
		}

		// Token: 0x04002C26 RID: 11302
		[Token(Token = "0x4002C26")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119ADC", Offset = "0x1119ADC")]
		public ulong group_id;

		// Token: 0x04002C27 RID: 11303
		[Token(Token = "0x4002C27")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119AF0", Offset = "0x1119AF0")]
		public ulong captain_id;

		// Token: 0x04002C28 RID: 11304
		[Token(Token = "0x4002C28")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119B04", Offset = "0x1119B04")]
		public List<GoliathAFKGroupMember> members;

		// Token: 0x04002C29 RID: 11305
		[Token(Token = "0x4002C29")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119B18", Offset = "0x1119B18")]
		public uint task_id;

		// Token: 0x04002C2A RID: 11306
		[Token(Token = "0x4002C2A")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119B2C", Offset = "0x1119B2C")]
		public long start_time_stamp;

		// Token: 0x04002C2B RID: 11307
		[Token(Token = "0x4002C2B")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119B40", Offset = "0x1119B40")]
		public long create_time_stamp;
	}
}
