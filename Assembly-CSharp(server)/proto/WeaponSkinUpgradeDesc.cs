using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B1E RID: 2846
	[Token(Token = "0x2000B1E")]
	[ProtoContract]
	public class WeaponSkinUpgradeDesc
	{
		// Token: 0x06002826 RID: 10278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002826")]
		[Address(RVA = "0x24A1938", Offset = "0x24A1938", VA = "0x7BBCCA1938")]
		public WeaponSkinUpgradeDesc()
		{
		}

		// Token: 0x040035FA RID: 13818
		[Token(Token = "0x40035FA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BE58", Offset = "0x112BE58")]
		public uint weapon_skin_id;

		// Token: 0x040035FB RID: 13819
		[Token(Token = "0x40035FB")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BE6C", Offset = "0x112BE6C")]
		public uint next_id;

		// Token: 0x040035FC RID: 13820
		[Token(Token = "0x40035FC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BE80", Offset = "0x112BE80")]
		public uint level;

		// Token: 0x040035FD RID: 13821
		[Token(Token = "0x40035FD")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BE94", Offset = "0x112BE94")]
		public List<WeaponSkinUpdateItemDesc> items;

		// Token: 0x040035FE RID: 13822
		[Token(Token = "0x40035FE")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BEA8", Offset = "0x112BEA8")]
		public uint reward_item;

		// Token: 0x040035FF RID: 13823
		[Token(Token = "0x40035FF")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BEBC", Offset = "0x112BEBC")]
		public uint weapon_set;
	}
}
