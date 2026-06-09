using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200087F RID: 2175
	[Token(Token = "0x200087F")]
	[ProtoContract]
	public class CSEPPurchaseReq
	{
		// Token: 0x0600258D RID: 9613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600258D")]
		[Address(RVA = "0x21B10A0", Offset = "0x21B10A0", VA = "0x7BBC9B10A0")]
		public CSEPPurchaseReq()
		{
		}

		// Token: 0x040028BC RID: 10428
		[Token(Token = "0x40028BC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111381C", Offset = "0x111381C")]
		public bool is_bundle;
	}
}
