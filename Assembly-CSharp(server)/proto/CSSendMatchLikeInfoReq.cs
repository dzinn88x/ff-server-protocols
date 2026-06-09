using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006EB RID: 1771
	[Token(Token = "0x20006EB")]
	[ProtoContract]
	public class CSSendMatchLikeInfoReq
	{
		// Token: 0x060023F9 RID: 9209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F9")]
		[Address(RVA = "0x21B7664", Offset = "0x21B7664", VA = "0x7BBC9B7664")]
		public CSSendMatchLikeInfoReq()
		{
		}

		// Token: 0x040022A7 RID: 8871
		[Token(Token = "0x40022A7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109CA4", Offset = "0x1109CA4")]
		public ulong[] account_id_list;

		// Token: 0x040022A8 RID: 8872
		[Token(Token = "0x40022A8")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109CE0", Offset = "0x1109CE0")]
		public ulong match_id;
	}
}
