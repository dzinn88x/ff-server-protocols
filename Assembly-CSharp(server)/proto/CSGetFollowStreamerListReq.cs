using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008E5 RID: 2277
	[Token(Token = "0x20008E5")]
	[ProtoContract]
	public class CSGetFollowStreamerListReq
	{
		// Token: 0x060025F3 RID: 9715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F3")]
		[Address(RVA = "0x21B3788", Offset = "0x21B3788", VA = "0x7BBC9B3788")]
		public CSGetFollowStreamerListReq()
		{
		}

		// Token: 0x04002A8D RID: 10893
		[Token(Token = "0x4002A8D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11173B8", Offset = "0x11173B8")]
		public ulong account_id;
	}
}
