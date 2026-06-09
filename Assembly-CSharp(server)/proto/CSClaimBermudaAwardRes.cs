using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200097E RID: 2430
	[Token(Token = "0x200097E")]
	[ProtoContract]
	public class CSClaimBermudaAwardRes
	{
		// Token: 0x0600268C RID: 9868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268C")]
		[Address(RVA = "0x21B0788", Offset = "0x21B0788", VA = "0x7BBC9B0788")]
		public CSClaimBermudaAwardRes()
		{
		}

		// Token: 0x04002C23 RID: 11299
		[Token(Token = "0x4002C23")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119AA0", Offset = "0x1119AA0")]
		public AwardData awards;
	}
}
