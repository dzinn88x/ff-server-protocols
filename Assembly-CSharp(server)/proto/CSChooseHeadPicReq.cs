using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200076B RID: 1899
	[Token(Token = "0x200076B")]
	[ProtoContract]
	public class CSChooseHeadPicReq
	{
		// Token: 0x06002478 RID: 9336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002478")]
		[Address(RVA = "0x21B0670", Offset = "0x21B0670", VA = "0x7BBC9B0670")]
		public CSChooseHeadPicReq()
		{
		}

		// Token: 0x04002526 RID: 9510
		[Token(Token = "0x4002526")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D7DC", Offset = "0x110D7DC")]
		public uint head_pic;
	}
}
