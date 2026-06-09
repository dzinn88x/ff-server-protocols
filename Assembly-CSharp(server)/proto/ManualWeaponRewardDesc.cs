using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000ADD RID: 2781
	[Token(Token = "0x2000ADD")]
	[ProtoContract]
	public class ManualWeaponRewardDesc
	{
		// Token: 0x060027E5 RID: 10213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E5")]
		[Address(RVA = "0x21BC480", Offset = "0x21BC480", VA = "0x7BBC9BC480")]
		public ManualWeaponRewardDesc()
		{
		}

		// Token: 0x04003438 RID: 13368
		[Token(Token = "0x4003438")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112812C", Offset = "0x112812C")]
		public uint quantity_period;

		// Token: 0x04003439 RID: 13369
		[Token(Token = "0x4003439")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128140", Offset = "0x1128140")]
		public List<AwardDesc> awards;
	}
}
