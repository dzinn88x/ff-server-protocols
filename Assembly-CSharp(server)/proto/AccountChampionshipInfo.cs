using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000910 RID: 2320
	[Token(Token = "0x2000910")]
	[ProtoContract]
	public class AccountChampionshipInfo
	{
		// Token: 0x0600261E RID: 9758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261E")]
		[Address(RVA = "0x21AE3A0", Offset = "0x21AE3A0", VA = "0x7BBC9AE3A0")]
		public AccountChampionshipInfo()
		{
		}

		// Token: 0x04002B07 RID: 11015
		[Token(Token = "0x4002B07")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11180EC", Offset = "0x11180EC")]
		public ulong account_id;

		// Token: 0x04002B08 RID: 11016
		[Token(Token = "0x4002B08")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118100", Offset = "0x1118100")]
		public uint championship_type;

		// Token: 0x04002B09 RID: 11017
		[Token(Token = "0x4002B09")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118114", Offset = "0x1118114")]
		public uint championship_id;

		// Token: 0x04002B0A RID: 11018
		[Token(Token = "0x4002B0A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118128", Offset = "0x1118128")]
		public uint trial_valid_score;

		// Token: 0x04002B0B RID: 11019
		[Token(Token = "0x4002B0B")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111813C", Offset = "0x111813C")]
		public uint trial_pos;

		// Token: 0x04002B0C RID: 11020
		[Token(Token = "0x4002B0C")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118150", Offset = "0x1118150")]
		public bool can_get_trial_reward;

		// Token: 0x04002B0D RID: 11021
		[Token(Token = "0x4002B0D")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118164", Offset = "0x1118164")]
		public uint final_valid_score;

		// Token: 0x04002B0E RID: 11022
		[Token(Token = "0x4002B0E")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118178", Offset = "0x1118178")]
		public uint final_pos;

		// Token: 0x04002B0F RID: 11023
		[Token(Token = "0x4002B0F")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111818C", Offset = "0x111818C")]
		public bool rewarded;

		// Token: 0x04002B10 RID: 11024
		[Token(Token = "0x4002B10")]
		[FieldOffset(Offset = "0x35")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11181A0", Offset = "0x11181A0")]
		public bool is_enter_final;
	}
}
