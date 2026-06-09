using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000743 RID: 1859
	[Token(Token = "0x2000743")]
	[ProtoContract]
	public class CupBattleRecord
	{
		// Token: 0x06002450 RID: 9296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002450")]
		[Address(RVA = "0x21B90AC", Offset = "0x21B90AC", VA = "0x7BBC9B90AC")]
		public CupBattleRecord()
		{
		}

		// Token: 0x040024C4 RID: 9412
		[Token(Token = "0x40024C4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CCB0", Offset = "0x110CCB0")]
		public ulong team_id;

		// Token: 0x040024C5 RID: 9413
		[Token(Token = "0x40024C5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CCC4", Offset = "0x110CCC4")]
		public bool win;

		// Token: 0x040024C6 RID: 9414
		[Token(Token = "0x40024C6")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CCD8", Offset = "0x110CCD8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110CCD8", Offset = "0x110CCD8")]
		public string name;

		// Token: 0x040024C7 RID: 9415
		[Token(Token = "0x40024C7")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CD28", Offset = "0x110CD28")]
		public uint head_pic;
	}
}
