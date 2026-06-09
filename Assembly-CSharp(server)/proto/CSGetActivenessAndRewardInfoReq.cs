using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200092D RID: 2349
	[Token(Token = "0x200092D")]
	[ProtoContract]
	public class CSGetActivenessAndRewardInfoReq
	{
		// Token: 0x0600263B RID: 9787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600263B")]
		[Address(RVA = "0x21B18DC", Offset = "0x21B18DC", VA = "0x7BBC9B18DC")]
		public CSGetActivenessAndRewardInfoReq()
		{
		}

		// Token: 0x04002B7D RID: 11133
		[Token(Token = "0x4002B7D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118B28", Offset = "0x1118B28")]
		public uint group_id;
	}
}
