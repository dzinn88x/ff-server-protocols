using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B27 RID: 2855
	[Token(Token = "0x2000B27")]
	[ProtoContract]
	public class GoliathSettingDesc
	{
		// Token: 0x0600282F RID: 10287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600282F")]
		[Address(RVA = "0x21BB044", Offset = "0x21BB044", VA = "0x7BBC9BB044")]
		public GoliathSettingDesc()
		{
		}

		// Token: 0x04003620 RID: 13856
		[Token(Token = "0x4003620")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C27C", Offset = "0x112C27C")]
		public uint auto_departure_time;

		// Token: 0x04003621 RID: 13857
		[Token(Token = "0x4003621")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C290", Offset = "0x112C290")]
		public uint web_event_open_time;

		// Token: 0x04003622 RID: 13858
		[Token(Token = "0x4003622")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C2A4", Offset = "0x112C2A4")]
		public uint web_event_end_time;

		// Token: 0x04003623 RID: 13859
		[Token(Token = "0x4003623")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112C2B8", Offset = "0x112C2B8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C2B8", Offset = "0x112C2B8")]
		public string web_event_url;

		// Token: 0x04003624 RID: 13860
		[Token(Token = "0x4003624")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C308", Offset = "0x112C308")]
		public uint token_id;

		// Token: 0x04003625 RID: 13861
		[Token(Token = "0x4003625")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C31C", Offset = "0x112C31C")]
		public uint duo_extra_reward;

		// Token: 0x04003626 RID: 13862
		[Token(Token = "0x4003626")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C330", Offset = "0x112C330")]
		public uint trio_extra_reward;

		// Token: 0x04003627 RID: 13863
		[Token(Token = "0x4003627")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C344", Offset = "0x112C344")]
		public uint squad_extra_reward;
	}
}
