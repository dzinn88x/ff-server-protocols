using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200096F RID: 2415
	[Token(Token = "0x200096F")]
	[ProtoContract]
	public class CSUpgradeWeaponSkinRes
	{
		// Token: 0x0600267D RID: 9853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600267D")]
		[Address(RVA = "0x21B7D44", Offset = "0x21B7D44", VA = "0x7BBC9B7D44")]
		public CSUpgradeWeaponSkinRes()
		{
		}

		// Token: 0x04002C04 RID: 11268
		[Token(Token = "0x4002C04")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111980C", Offset = "0x111980C")]
		public uint next_weapon_skin;

		// Token: 0x04002C05 RID: 11269
		[Token(Token = "0x4002C05")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119820", Offset = "0x1119820")]
		public uint reward_item;
	}
}
