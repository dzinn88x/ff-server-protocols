using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000792 RID: 1938
	[Token(Token = "0x2000792")]
	[ProtoContract]
	public class CSGetLegendClothesDescReq
	{
		// Token: 0x060024A1 RID: 9377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A1")]
		[Address(RVA = "0x21B443C", Offset = "0x21B443C", VA = "0x7BBC9B443C")]
		public CSGetLegendClothesDescReq()
		{
		}

		// Token: 0x040025A2 RID: 9634
		[Token(Token = "0x40025A2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E3D0", Offset = "0x110E3D0")]
		public uint legend_cloth_id;
	}
}
