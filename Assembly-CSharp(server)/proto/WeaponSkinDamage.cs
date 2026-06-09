using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200063E RID: 1598
	[Token(Token = "0x200063E")]
	[ProtoContract]
	public class WeaponSkinDamage
	{
		// Token: 0x060023A8 RID: 9128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A8")]
		[Address(RVA = "0x24A1860", Offset = "0x24A1860", VA = "0x7BBCCA1860")]
		public WeaponSkinDamage()
		{
		}

		// Token: 0x04001FA9 RID: 8105
		[Token(Token = "0x4001FA9")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11082A0", Offset = "0x11082A0")]
		public uint weapon_skin_id;

		// Token: 0x04001FAA RID: 8106
		[Token(Token = "0x4001FAA")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11082B4", Offset = "0x11082B4")]
		public uint damage;
	}
}
