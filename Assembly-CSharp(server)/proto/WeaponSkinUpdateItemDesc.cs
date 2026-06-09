using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B1D RID: 2845
	[Token(Token = "0x2000B1D")]
	[ProtoContract]
	public class WeaponSkinUpdateItemDesc
	{
		// Token: 0x06002825 RID: 10277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002825")]
		[Address(RVA = "0x24A1930", Offset = "0x24A1930", VA = "0x7BBCCA1930")]
		public WeaponSkinUpdateItemDesc()
		{
		}

		// Token: 0x040035F7 RID: 13815
		[Token(Token = "0x40035F7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BE1C", Offset = "0x112BE1C")]
		public EInventory.MaterialItemType item_type;

		// Token: 0x040035F8 RID: 13816
		[Token(Token = "0x40035F8")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BE30", Offset = "0x112BE30")]
		public uint item_id;

		// Token: 0x040035F9 RID: 13817
		[Token(Token = "0x40035F9")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BE44", Offset = "0x112BE44")]
		public uint item_num;
	}
}
