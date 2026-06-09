using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000960 RID: 2400
	[Token(Token = "0x2000960")]
	[ProtoContract]
	public class CSGetRampageConfigRes
	{
		// Token: 0x0600266E RID: 9838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266E")]
		[Address(RVA = "0x21B572C", Offset = "0x21B572C", VA = "0x7BBC9B572C")]
		public CSGetRampageConfigRes()
		{
		}

		// Token: 0x04002BE3 RID: 11235
		[Token(Token = "0x4002BE3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11194C4", Offset = "0x11194C4")]
		public CSGetRampageSettingRes rampage_setting;

		// Token: 0x04002BE4 RID: 11236
		[Token(Token = "0x4002BE4")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11194D8", Offset = "0x11194D8")]
		public CSGetProcessRampagePointsRes process_rampage_points;

		// Token: 0x04002BE5 RID: 11237
		[Token(Token = "0x4002BE5")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11194EC", Offset = "0x11194EC")]
		public CSGetRampageRankRes rampage_rank;
	}
}
