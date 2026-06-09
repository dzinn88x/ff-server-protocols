using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000982 RID: 2434
	[Token(Token = "0x2000982")]
	[ProtoContract]
	public class CSGetAccountGoliathInfo
	{
		// Token: 0x06002690 RID: 9872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002690")]
		[Address(RVA = "0x21B1624", Offset = "0x21B1624", VA = "0x7BBC9B1624")]
		public CSGetAccountGoliathInfo()
		{
		}

		// Token: 0x04002C2F RID: 11311
		[Token(Token = "0x4002C2F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119BCC", Offset = "0x1119BCC")]
		public List<GoliathAFKGroupInfo> group_list;

		// Token: 0x04002C30 RID: 11312
		[Token(Token = "0x4002C30")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119BE0", Offset = "0x1119BE0")]
		public uint activity_id;
	}
}
