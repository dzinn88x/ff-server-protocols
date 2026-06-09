using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000795 RID: 1941
	[Token(Token = "0x2000795")]
	[ProtoContract]
	public class CSSetWeaponRackReq
	{
		// Token: 0x060024A4 RID: 9380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A4")]
		[Address(RVA = "0x21B768C", Offset = "0x21B768C", VA = "0x7BBC9B768C")]
		public CSSetWeaponRackReq()
		{
		}

		// Token: 0x040025A5 RID: 9637
		[Token(Token = "0x40025A5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E434", Offset = "0x110E434")]
		public uint[] weapon_ids;
	}
}
