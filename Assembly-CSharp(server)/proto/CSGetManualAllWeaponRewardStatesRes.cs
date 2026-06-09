using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008EA RID: 2282
	[Token(Token = "0x20008EA")]
	[ProtoContract]
	public class CSGetManualAllWeaponRewardStatesRes
	{
		// Token: 0x060025F8 RID: 9720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F8")]
		[Address(RVA = "0x21B4A40", Offset = "0x21B4A40", VA = "0x7BBC9B4A40")]
		public CSGetManualAllWeaponRewardStatesRes()
		{
		}

		// Token: 0x04002A94 RID: 10900
		[Token(Token = "0x4002A94")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111746C", Offset = "0x111746C")]
		public List<ManualWeaponReward> weapon_rewards;
	}
}
