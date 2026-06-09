using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000777 RID: 1911
	[Token(Token = "0x2000777")]
	[ProtoContract]
	public class CSOpenBundleReq
	{
		// Token: 0x06002484 RID: 9348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002484")]
		[Address(RVA = "0x21B6C28", Offset = "0x21B6C28", VA = "0x7BBC9B6C28")]
		public CSOpenBundleReq()
		{
		}

		// Token: 0x04002543 RID: 9539
		[Token(Token = "0x4002543")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DA98", Offset = "0x110DA98")]
		public uint item_id;
	}
}
