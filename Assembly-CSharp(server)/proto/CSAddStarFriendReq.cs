using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000833 RID: 2099
	[Token(Token = "0x2000833")]
	[ProtoContract]
	public class CSAddStarFriendReq
	{
		// Token: 0x06002548 RID: 9544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002548")]
		[Address(RVA = "0x21B02E4", Offset = "0x21B02E4", VA = "0x7BBC9B02E4")]
		public CSAddStarFriendReq()
		{
		}

		// Token: 0x04002756 RID: 10070
		[Token(Token = "0x4002756")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11113C8", Offset = "0x11113C8")]
		public ulong addee;
	}
}
