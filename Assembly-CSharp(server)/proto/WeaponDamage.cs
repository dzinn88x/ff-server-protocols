using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200063F RID: 1599
	[Token(Token = "0x200063F")]
	[ProtoContract]
	public class WeaponDamage
	{
		// Token: 0x060023A9 RID: 9129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A9")]
		[Address(RVA = "0x24A1848", Offset = "0x24A1848", VA = "0x7BBCCA1848")]
		public WeaponDamage()
		{
		}

		// Token: 0x04001FAB RID: 8107
		[Token(Token = "0x4001FAB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11082C8", Offset = "0x11082C8")]
		public uint weapon_id;

		// Token: 0x04001FAC RID: 8108
		[Token(Token = "0x4001FAC")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11082DC", Offset = "0x11082DC")]
		public uint damage;
	}
}
