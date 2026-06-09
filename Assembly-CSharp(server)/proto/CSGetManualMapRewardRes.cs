using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008EF RID: 2287
	[Token(Token = "0x20008EF")]
	[ProtoContract]
	public class CSGetManualMapRewardRes
	{
		// Token: 0x060025FD RID: 9725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025FD")]
		[Address(RVA = "0x21B4AC4", Offset = "0x21B4AC4", VA = "0x7BBC9B4AC4")]
		public CSGetManualMapRewardRes()
		{
		}

		// Token: 0x04002A99 RID: 10905
		[Token(Token = "0x4002A99")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11174D0", Offset = "0x11174D0")]
		public AwardData awards;
	}
}
