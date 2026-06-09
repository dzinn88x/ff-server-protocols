using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000831 RID: 2097
	[Token(Token = "0x2000831")]
	[ProtoContract]
	public class CSGetBlockedPlayerRes
	{
		// Token: 0x06002546 RID: 9542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002546")]
		[Address(RVA = "0x21B26C0", Offset = "0x21B26C0", VA = "0x7BBC9B26C0")]
		public CSGetBlockedPlayerRes()
		{
		}

		// Token: 0x04002754 RID: 10068
		[Token(Token = "0x4002754")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111378", Offset = "0x1111378")]
		public ulong[] blocked_list;
	}
}
