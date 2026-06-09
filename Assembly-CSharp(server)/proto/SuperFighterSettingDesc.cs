using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B28 RID: 2856
	[Token(Token = "0x2000B28")]
	[ProtoContract]
	public class SuperFighterSettingDesc
	{
		// Token: 0x06002830 RID: 10288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002830")]
		[Address(RVA = "0x24A0AB4", Offset = "0x24A0AB4", VA = "0x7BBCCA0AB4")]
		public SuperFighterSettingDesc()
		{
		}

		// Token: 0x04003628 RID: 13864
		[Token(Token = "0x4003628")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C358", Offset = "0x112C358")]
		public uint big_reward_round;

		// Token: 0x04003629 RID: 13865
		[Token(Token = "0x4003629")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C36C", Offset = "0x112C36C")]
		public AwardDesc big_reward;

		// Token: 0x0400362A RID: 13866
		[Token(Token = "0x400362A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C380", Offset = "0x112C380")]
		public AwardDesc defeat_reward;

		// Token: 0x0400362B RID: 13867
		[Token(Token = "0x400362B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C394", Offset = "0x112C394")]
		public uint mission_start;

		// Token: 0x0400362C RID: 13868
		[Token(Token = "0x400362C")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C3A8", Offset = "0x112C3A8")]
		public uint mission_end;

		// Token: 0x0400362D RID: 13869
		[Token(Token = "0x400362D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C3BC", Offset = "0x112C3BC")]
		public uint web_event_start;

		// Token: 0x0400362E RID: 13870
		[Token(Token = "0x400362E")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C3D0", Offset = "0x112C3D0")]
		public uint web_event_end;

		// Token: 0x0400362F RID: 13871
		[Token(Token = "0x400362F")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C3E4", Offset = "0x112C3E4")]
		public uint sugar_id;

		// Token: 0x04003630 RID: 13872
		[Token(Token = "0x4003630")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C3F8", Offset = "0x112C3F8")]
		public uint token_id;

		// Token: 0x04003631 RID: 13873
		[Token(Token = "0x4003631")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C40C", Offset = "0x112C40C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112C40C", Offset = "0x112C40C")]
		public string web_url;
	}
}
