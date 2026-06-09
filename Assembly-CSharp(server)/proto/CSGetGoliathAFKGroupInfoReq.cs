using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000983 RID: 2435
	[Token(Token = "0x2000983")]
	[ProtoContract]
	public class CSGetGoliathAFKGroupInfoReq
	{
		// Token: 0x06002691 RID: 9873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002691")]
		[Address(RVA = "0x21B40D0", Offset = "0x21B40D0", VA = "0x7BBC9B40D0")]
		public CSGetGoliathAFKGroupInfoReq()
		{
		}

		// Token: 0x04002C31 RID: 11313
		[Token(Token = "0x4002C31")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119BF4", Offset = "0x1119BF4")]
		public ulong group_id;

		// Token: 0x04002C32 RID: 11314
		[Token(Token = "0x4002C32")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119C08", Offset = "0x1119C08")]
		public bool before_start;
	}
}
