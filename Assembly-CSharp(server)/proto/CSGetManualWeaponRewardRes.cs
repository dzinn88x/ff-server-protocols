using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008ED RID: 2285
	[Token(Token = "0x20008ED")]
	[ProtoContract]
	public class CSGetManualWeaponRewardRes
	{
		// Token: 0x060025FB RID: 9723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025FB")]
		[Address(RVA = "0x21B4AD4", Offset = "0x21B4AD4", VA = "0x7BBC9B4AD4")]
		public CSGetManualWeaponRewardRes()
		{
		}

		// Token: 0x04002A97 RID: 10903
		[Token(Token = "0x4002A97")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11174A8", Offset = "0x11174A8")]
		public AwardData awards;
	}
}
