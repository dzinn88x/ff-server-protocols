using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200096D RID: 2413
	[Token(Token = "0x200096D")]
	[ProtoContract]
	public class CSGetWeaponSkinUpgradeRes
	{
		// Token: 0x0600267B RID: 9851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600267B")]
		[Address(RVA = "0x21B6370", Offset = "0x21B6370", VA = "0x7BBC9B6370")]
		public CSGetWeaponSkinUpgradeRes()
		{
		}

		// Token: 0x04002C00 RID: 11264
		[Token(Token = "0x4002C00")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11197BC", Offset = "0x11197BC")]
		public List<WeaponSkinUpgradeDesc> weapon_skin_upgrade_desc;
	}
}
