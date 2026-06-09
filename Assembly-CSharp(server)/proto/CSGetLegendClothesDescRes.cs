using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000793 RID: 1939
	[Token(Token = "0x2000793")]
	[ProtoContract]
	public class CSGetLegendClothesDescRes
	{
		// Token: 0x060024A2 RID: 9378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A2")]
		[Address(RVA = "0x21B4444", Offset = "0x21B4444", VA = "0x7BBC9B4444")]
		public CSGetLegendClothesDescRes()
		{
		}

		// Token: 0x040025A3 RID: 9635
		[Token(Token = "0x40025A3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E3E4", Offset = "0x110E3E4")]
		public List<LegendClothUnlockDesc> legend_clothes;
	}
}
