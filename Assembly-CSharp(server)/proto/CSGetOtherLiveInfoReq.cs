using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008D8 RID: 2264
	[Token(Token = "0x20008D8")]
	[ProtoContract]
	public class CSGetOtherLiveInfoReq
	{
		// Token: 0x060025E6 RID: 9702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E6")]
		[Address(RVA = "0x21B5050", Offset = "0x21B5050", VA = "0x7BBC9B5050")]
		public CSGetOtherLiveInfoReq()
		{
		}

		// Token: 0x04002A68 RID: 10856
		[Token(Token = "0x4002A68")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116EF4", Offset = "0x1116EF4")]
		public ulong other_account_id;
	}
}
