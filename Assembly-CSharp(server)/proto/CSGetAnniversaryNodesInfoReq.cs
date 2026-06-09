using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006E3 RID: 1763
	[Token(Token = "0x20006E3")]
	[ProtoContract]
	public class CSGetAnniversaryNodesInfoReq
	{
		// Token: 0x060023F1 RID: 9201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F1")]
		[Address(RVA = "0x21B1F9C", Offset = "0x21B1F9C", VA = "0x7BBC9B1F9C")]
		public CSGetAnniversaryNodesInfoReq()
		{
		}

		// Token: 0x04002297 RID: 8855
		[Token(Token = "0x4002297")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109984", Offset = "0x1109984")]
		public ulong account_id;

		// Token: 0x04002298 RID: 8856
		[Token(Token = "0x4002298")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109998", Offset = "0x1109998")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1109998", Offset = "0x1109998")]
		public string lock_region;

		// Token: 0x04002299 RID: 8857
		[Token(Token = "0x4002299")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11099E8", Offset = "0x11099E8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11099E8", Offset = "0x11099E8")]
		public string noti_region;
	}
}
