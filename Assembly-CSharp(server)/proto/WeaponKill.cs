using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200063B RID: 1595
	[Token(Token = "0x200063B")]
	[ProtoContract]
	public class WeaponKill
	{
		// Token: 0x060023A5 RID: 9125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A5")]
		[Address(RVA = "0x24A1850", Offset = "0x24A1850", VA = "0x7BBCCA1850")]
		public WeaponKill()
		{
		}

		// Token: 0x04001F9E RID: 8094
		[Token(Token = "0x4001F9E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108188", Offset = "0x1108188")]
		public uint weapon_id;

		// Token: 0x04001F9F RID: 8095
		[Token(Token = "0x4001F9F")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110819C", Offset = "0x110819C")]
		public uint cnt;

		// Token: 0x04001FA0 RID: 8096
		[Token(Token = "0x4001FA0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11081B0", Offset = "0x11081B0")]
		public uint head_cnt;
	}
}
