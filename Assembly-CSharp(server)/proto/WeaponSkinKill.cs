using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200063D RID: 1597
	[Token(Token = "0x200063D")]
	[ProtoContract]
	public class WeaponSkinKill
	{
		// Token: 0x060023A7 RID: 9127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A7")]
		[Address(RVA = "0x24A1870", Offset = "0x24A1870", VA = "0x7BBCCA1870")]
		public WeaponSkinKill()
		{
		}

		// Token: 0x04001FA7 RID: 8103
		[Token(Token = "0x4001FA7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108278", Offset = "0x1108278")]
		public uint weapon_skin_id;

		// Token: 0x04001FA8 RID: 8104
		[Token(Token = "0x4001FA8")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110828C", Offset = "0x110828C")]
		public uint cnt;
	}
}
