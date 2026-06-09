using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000885 RID: 2181
	[Token(Token = "0x2000885")]
	[ProtoContract]
	public class CSEPPurchaseBadgeReq
	{
		// Token: 0x06002593 RID: 9619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002593")]
		[Address(RVA = "0x21B1090", Offset = "0x21B1090", VA = "0x7BBC9B1090")]
		public CSEPPurchaseBadgeReq()
		{
		}

		// Token: 0x040028C1 RID: 10433
		[Token(Token = "0x40028C1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11138E4", Offset = "0x11138E4")]
		public uint count;
	}
}
