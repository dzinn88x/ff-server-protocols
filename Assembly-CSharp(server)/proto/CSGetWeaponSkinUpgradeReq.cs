using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200096C RID: 2412
	[Token(Token = "0x200096C")]
	[ProtoContract]
	public class CSGetWeaponSkinUpgradeReq
	{
		// Token: 0x0600267A RID: 9850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600267A")]
		[Address(RVA = "0x21B6368", Offset = "0x21B6368", VA = "0x7BBC9B6368")]
		public CSGetWeaponSkinUpgradeReq()
		{
		}

		// Token: 0x04002BFF RID: 11263
		[Token(Token = "0x4002BFF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119780", Offset = "0x1119780")]
		public uint[] weapon_skin;
	}
}
