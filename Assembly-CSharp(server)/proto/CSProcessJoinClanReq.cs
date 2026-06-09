using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007DF RID: 2015
	[Token(Token = "0x20007DF")]
	[ProtoContract]
	public class CSProcessJoinClanReq
	{
		// Token: 0x060024EE RID: 9454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024EE")]
		[Address(RVA = "0x21B6FD8", Offset = "0x21B6FD8", VA = "0x7BBC9B6FD8")]
		public CSProcessJoinClanReq()
		{
		}

		// Token: 0x04002671 RID: 9841
		[Token(Token = "0x4002671")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FD34", Offset = "0x110FD34")]
		public ulong applicant_id;

		// Token: 0x04002672 RID: 9842
		[Token(Token = "0x4002672")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FD48", Offset = "0x110FD48")]
		public ulong clan_id;
	}
}
