using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200070C RID: 1804
	[Token(Token = "0x200070C")]
	[ProtoContract]
	public class CSGetLinkEquipSetRes
	{
		// Token: 0x06002419 RID: 9241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002419")]
		[Address(RVA = "0x21B45D0", Offset = "0x21B45D0", VA = "0x7BBC9B45D0")]
		public CSGetLinkEquipSetRes()
		{
		}

		// Token: 0x0400240C RID: 9228
		[Token(Token = "0x400240C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BBD0", Offset = "0x110BBD0")]
		public LinkEquipSetTimeDesc equip_set;
	}
}
