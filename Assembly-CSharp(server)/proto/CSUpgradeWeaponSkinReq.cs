using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200096E RID: 2414
	[Token(Token = "0x200096E")]
	[ProtoContract]
	public class CSUpgradeWeaponSkinReq
	{
		// Token: 0x0600267C RID: 9852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600267C")]
		[Address(RVA = "0x21B7D3C", Offset = "0x21B7D3C", VA = "0x7BBC9B7D3C")]
		public CSUpgradeWeaponSkinReq()
		{
		}

		// Token: 0x04002C01 RID: 11265
		[Token(Token = "0x4002C01")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11197D0", Offset = "0x11197D0")]
		public uint weapon_skin;

		// Token: 0x04002C02 RID: 11266
		[Token(Token = "0x4002C02")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11197E4", Offset = "0x11197E4")]
		public uint weapon_set;

		// Token: 0x04002C03 RID: 11267
		[Token(Token = "0x4002C03")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11197F8", Offset = "0x11197F8")]
		public uint weapon_id;
	}
}
