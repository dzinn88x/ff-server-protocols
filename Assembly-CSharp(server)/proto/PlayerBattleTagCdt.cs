using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B45 RID: 2885
	[Token(Token = "0x2000B45")]
	[ProtoContract]
	public class PlayerBattleTagCdt
	{
		// Token: 0x0600284D RID: 10317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284D")]
		[Address(RVA = "0x249F648", Offset = "0x249F648", VA = "0x7BBCC9F648")]
		public PlayerBattleTagCdt()
		{
		}

		// Token: 0x040036C6 RID: 14022
		[Token(Token = "0x40036C6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D58C", Offset = "0x112D58C")]
		public ESocial.PlayerBattleTagCdtType condition_type;

		// Token: 0x040036C7 RID: 14023
		[Token(Token = "0x40036C7")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D5A0", Offset = "0x112D5A0")]
		public float condition_param;
	}
}
