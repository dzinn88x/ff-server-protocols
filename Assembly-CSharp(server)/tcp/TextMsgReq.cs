using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000465 RID: 1125
	[Token(Token = "0x2000465")]
	[ProtoContract]
	public class TextMsgReq
	{
		// Token: 0x06001C6E RID: 7278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6E")]
		[Address(RVA = "0x24A71F8", Offset = "0x24A71F8", VA = "0x7BBCCA71F8")]
		public TextMsgReq()
		{
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06001C6F RID: 7279 RVA: 0x0000C138 File Offset: 0x0000A338
		// (set) Token: 0x06001C70 RID: 7280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000368")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154AD0", Offset = "0x1154AD0")]
		public ulong sender_id
		{
			[Token(Token = "0x6001C6F")]
			[Address(RVA = "0x24A7274", Offset = "0x24A7274", VA = "0x7BBCCA7274")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11350E4", Offset = "0x11350E4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001C70")]
			[Address(RVA = "0x24A727C", Offset = "0x24A727C", VA = "0x7BBCCA727C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11350F4", Offset = "0x11350F4")]
			set
			{
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06001C71 RID: 7281 RVA: 0x0000C150 File Offset: 0x0000A350
		// (set) Token: 0x06001C72 RID: 7282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000369")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154AE4", Offset = "0x1154AE4")]
		public ulong channel_id
		{
			[Token(Token = "0x6001C71")]
			[Address(RVA = "0x24A7284", Offset = "0x24A7284", VA = "0x7BBCCA7284")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135104", Offset = "0x1135104")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001C72")]
			[Address(RVA = "0x24A728C", Offset = "0x24A728C", VA = "0x7BBCCA728C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135114", Offset = "0x1135114")]
			set
			{
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06001C73 RID: 7283 RVA: 0x0000C168 File Offset: 0x0000A368
		// (set) Token: 0x06001C74 RID: 7284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700036A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154AF8", Offset = "0x1154AF8")]
		public uint channel_type
		{
			[Token(Token = "0x6001C73")]
			[Address(RVA = "0x24A7294", Offset = "0x24A7294", VA = "0x7BBCCA7294")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135124", Offset = "0x1135124")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001C74")]
			[Address(RVA = "0x24A729C", Offset = "0x24A729C", VA = "0x7BBCCA729C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135134", Offset = "0x1135134")]
			set
			{
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06001C75 RID: 7285 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C76 RID: 7286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700036B")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154B0C", Offset = "0x1154B0C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1154B0C", Offset = "0x1154B0C")]
		public string content
		{
			[Token(Token = "0x6001C75")]
			[Address(RVA = "0x24A72A4", Offset = "0x24A72A4", VA = "0x7BBCCA72A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135144", Offset = "0x1135144")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C76")]
			[Address(RVA = "0x24A725C", Offset = "0x24A725C", VA = "0x7BBCCA725C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135154", Offset = "0x1135154")]
			set
			{
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06001C77 RID: 7287 RVA: 0x0000C180 File Offset: 0x0000A380
		// (set) Token: 0x06001C78 RID: 7288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700036C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154B5C", Offset = "0x1154B5C")]
		public ulong send_at
		{
			[Token(Token = "0x6001C77")]
			[Address(RVA = "0x24A72AC", Offset = "0x24A72AC", VA = "0x7BBCCA72AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135164", Offset = "0x1135164")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001C78")]
			[Address(RVA = "0x24A72B4", Offset = "0x24A72B4", VA = "0x7BBCCA72B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135174", Offset = "0x1135174")]
			set
			{
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06001C79 RID: 7289 RVA: 0x0000C198 File Offset: 0x0000A398
		// (set) Token: 0x06001C7A RID: 7290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700036D")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154B70", Offset = "0x1154B70")]
		public ulong group_id
		{
			[Token(Token = "0x6001C79")]
			[Address(RVA = "0x24A72BC", Offset = "0x24A72BC", VA = "0x7BBCCA72BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135184", Offset = "0x1135184")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001C7A")]
			[Address(RVA = "0x24A72C4", Offset = "0x24A72C4", VA = "0x7BBCCA72C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135194", Offset = "0x1135194")]
			set
			{
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001C7B RID: 7291 RVA: 0x0000C1B0 File Offset: 0x0000A3B0
		// (set) Token: 0x06001C7C RID: 7292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700036E")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154B84", Offset = "0x1154B84")]
		public EChannel.MsgType msg_type
		{
			[Token(Token = "0x6001C7B")]
			[Address(RVA = "0x24A72CC", Offset = "0x24A72CC", VA = "0x7BBCCA72CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11351A4", Offset = "0x11351A4")]
			get
			{
				return EChannel.MsgType.MsgType_DEFAULT;
			}
			[Token(Token = "0x6001C7C")]
			[Address(RVA = "0x24A72D4", Offset = "0x24A72D4", VA = "0x7BBCCA72D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11351B4", Offset = "0x11351B4")]
			set
			{
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06001C7D RID: 7293 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C7E RID: 7294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700036F")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1154B98", Offset = "0x1154B98")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154B98", Offset = "0x1154B98")]
		public string extra_info
		{
			[Token(Token = "0x6001C7D")]
			[Address(RVA = "0x24A72DC", Offset = "0x24A72DC", VA = "0x7BBCCA72DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11351C4", Offset = "0x11351C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C7E")]
			[Address(RVA = "0x24A7264", Offset = "0x24A7264", VA = "0x7BBCCA7264")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11351D4", Offset = "0x11351D4")]
			set
			{
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06001C7F RID: 7295 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C80 RID: 7296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000370")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154BE8", Offset = "0x1154BE8")]
		public BriefProfile profile
		{
			[Token(Token = "0x6001C7F")]
			[Address(RVA = "0x24A72E4", Offset = "0x24A72E4", VA = "0x7BBCCA72E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11351E4", Offset = "0x11351E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C80")]
			[Address(RVA = "0x24A72EC", Offset = "0x24A72EC", VA = "0x7BBCCA72EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11351F4", Offset = "0x11351F4")]
			set
			{
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001C81 RID: 7297 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C82 RID: 7298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000371")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154BFC", Offset = "0x1154BFC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1154BFC", Offset = "0x1154BFC")]
		public string channel_lang
		{
			[Token(Token = "0x6001C81")]
			[Address(RVA = "0x24A72F4", Offset = "0x24A72F4", VA = "0x7BBCCA72F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135204", Offset = "0x1135204")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C82")]
			[Address(RVA = "0x24A726C", Offset = "0x24A726C", VA = "0x7BBCCA726C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135214", Offset = "0x1135214")]
			set
			{
			}
		}

		// Token: 0x040014CF RID: 5327
		[Token(Token = "0x40014CF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101E34", Offset = "0x1101E34")]
		private ulong <sender_id>k__BackingField;

		// Token: 0x040014D0 RID: 5328
		[Token(Token = "0x40014D0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101E44", Offset = "0x1101E44")]
		private ulong <channel_id>k__BackingField;

		// Token: 0x040014D1 RID: 5329
		[Token(Token = "0x40014D1")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101E54", Offset = "0x1101E54")]
		private uint <channel_type>k__BackingField;

		// Token: 0x040014D2 RID: 5330
		[Token(Token = "0x40014D2")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101E64", Offset = "0x1101E64")]
		private string <content>k__BackingField;

		// Token: 0x040014D3 RID: 5331
		[Token(Token = "0x40014D3")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101E74", Offset = "0x1101E74")]
		private ulong <send_at>k__BackingField;

		// Token: 0x040014D4 RID: 5332
		[Token(Token = "0x40014D4")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101E84", Offset = "0x1101E84")]
		private ulong <group_id>k__BackingField;

		// Token: 0x040014D5 RID: 5333
		[Token(Token = "0x40014D5")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101E94", Offset = "0x1101E94")]
		private EChannel.MsgType <msg_type>k__BackingField;

		// Token: 0x040014D6 RID: 5334
		[Token(Token = "0x40014D6")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101EA4", Offset = "0x1101EA4")]
		private string <extra_info>k__BackingField;

		// Token: 0x040014D7 RID: 5335
		[Token(Token = "0x40014D7")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101EB4", Offset = "0x1101EB4")]
		private BriefProfile <profile>k__BackingField;

		// Token: 0x040014D8 RID: 5336
		[Token(Token = "0x40014D8")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101EC4", Offset = "0x1101EC4")]
		private string <channel_lang>k__BackingField;
	}
}
