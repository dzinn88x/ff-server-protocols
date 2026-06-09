using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000770 RID: 1904
	[Token(Token = "0x2000770")]
	[ProtoContract]
	public class CSGetHideCollectionsRes
	{
		// Token: 0x0600247D RID: 9341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247D")]
		[Address(RVA = "0x21B41D8", Offset = "0x21B41D8", VA = "0x7BBC9B41D8")]
		public CSGetHideCollectionsRes()
		{
		}

		// Token: 0x0400252D RID: 9517
		[Token(Token = "0x400252D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D890", Offset = "0x110D890")]
		public uint[] item_ids;
	}
}
