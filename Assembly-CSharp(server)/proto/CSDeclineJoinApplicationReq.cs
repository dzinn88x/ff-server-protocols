using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000900 RID: 2304
	[Token(Token = "0x2000900")]
	[ProtoContract]
	public class CSDeclineJoinApplicationReq
	{
		// Token: 0x0600260E RID: 9742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600260E")]
		[Address(RVA = "0x21B0ECC", Offset = "0x21B0ECC", VA = "0x7BBC9B0ECC")]
		public CSDeclineJoinApplicationReq()
		{
		}

		// Token: 0x04002ACB RID: 10955
		[Token(Token = "0x4002ACB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117AC0", Offset = "0x1117AC0")]
		public ulong[] applicant_ids;

		// Token: 0x04002ACC RID: 10956
		[Token(Token = "0x4002ACC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117AFC", Offset = "0x1117AFC")]
		public ulong team_id;
	}
}
