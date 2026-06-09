using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AF7 RID: 2807
	[Token(Token = "0x2000AF7")]
	[ProtoContract]
	public class ActivityModeDesc
	{
		// Token: 0x060027FF RID: 10239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027FF")]
		[Address(RVA = "0x21AEE1C", Offset = "0x21AEE1C", VA = "0x7BBC9AEE1C")]
		public ActivityModeDesc()
		{
		}

		// Token: 0x040034EE RID: 13550
		[Token(Token = "0x40034EE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129874", Offset = "0x1129874")]
		public uint activity_id;

		// Token: 0x040034EF RID: 13551
		[Token(Token = "0x40034EF")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129888", Offset = "0x1129888")]
		public uint game_mode;

		// Token: 0x040034F0 RID: 13552
		[Token(Token = "0x40034F0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112989C", Offset = "0x112989C")]
		public bool is_open;
	}
}
