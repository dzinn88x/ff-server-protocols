using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000794 RID: 1940
	[Token(Token = "0x2000794")]
	[ProtoContract]
	public class WeaponRackRes
	{
		// Token: 0x060024A3 RID: 9379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A3")]
		[Address(RVA = "0x24A1858", Offset = "0x24A1858", VA = "0x7BBCCA1858")]
		public WeaponRackRes()
		{
		}

		// Token: 0x040025A4 RID: 9636
		[Token(Token = "0x40025A4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E3F8", Offset = "0x110E3F8")]
		public uint[] weapon_ids;
	}
}
