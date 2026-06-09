using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000466 RID: 1126
	[Token(Token = "0x2000466")]
	[ProtoContract]
	public class JoinWorldChanNtf
	{
		// Token: 0x06001C83 RID: 7299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C83")]
		[Address(RVA = "0x24A45EC", Offset = "0x24A45EC", VA = "0x7BBCCA45EC")]
		public JoinWorldChanNtf()
		{
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001C84 RID: 7300 RVA: 0x0000C1C8 File Offset: 0x0000A3C8
		// (set) Token: 0x06001C85 RID: 7301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000372")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154C4C", Offset = "0x1154C4C")]
		public ulong channel_id
		{
			[Token(Token = "0x6001C84")]
			[Address(RVA = "0x24A45F4", Offset = "0x24A45F4", VA = "0x7BBCCA45F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135224", Offset = "0x1135224")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001C85")]
			[Address(RVA = "0x24A45FC", Offset = "0x24A45FC", VA = "0x7BBCCA45FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135234", Offset = "0x1135234")]
			set
			{
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001C86 RID: 7302 RVA: 0x0000C1E0 File Offset: 0x0000A3E0
		// (set) Token: 0x06001C87 RID: 7303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000373")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154C60", Offset = "0x1154C60")]
		public uint left_talk_times_default
		{
			[Token(Token = "0x6001C86")]
			[Address(RVA = "0x24A4604", Offset = "0x24A4604", VA = "0x7BBCCA4604")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135244", Offset = "0x1135244")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001C87")]
			[Address(RVA = "0x24A460C", Offset = "0x24A460C", VA = "0x7BBCCA460C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135254", Offset = "0x1135254")]
			set
			{
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001C88 RID: 7304 RVA: 0x0000C1F8 File Offset: 0x0000A3F8
		// (set) Token: 0x06001C89 RID: 7305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000374")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154C74", Offset = "0x1154C74")]
		public uint left_talk_times_fast
		{
			[Token(Token = "0x6001C88")]
			[Address(RVA = "0x24A4614", Offset = "0x24A4614", VA = "0x7BBCCA4614")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135264", Offset = "0x1135264")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001C89")]
			[Address(RVA = "0x24A461C", Offset = "0x24A461C", VA = "0x7BBCCA461C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135274", Offset = "0x1135274")]
			set
			{
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001C8A RID: 7306 RVA: 0x0000C210 File Offset: 0x0000A410
		// (set) Token: 0x06001C8B RID: 7307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000375")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154C88", Offset = "0x1154C88")]
		public uint daily_msg_limit_default
		{
			[Token(Token = "0x6001C8A")]
			[Address(RVA = "0x24A4624", Offset = "0x24A4624", VA = "0x7BBCCA4624")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135284", Offset = "0x1135284")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001C8B")]
			[Address(RVA = "0x24A462C", Offset = "0x24A462C", VA = "0x7BBCCA462C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135294", Offset = "0x1135294")]
			set
			{
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001C8C RID: 7308 RVA: 0x0000C228 File Offset: 0x0000A428
		// (set) Token: 0x06001C8D RID: 7309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000376")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154C9C", Offset = "0x1154C9C")]
		public uint daily_msg_limit_fast
		{
			[Token(Token = "0x6001C8C")]
			[Address(RVA = "0x24A4634", Offset = "0x24A4634", VA = "0x7BBCCA4634")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11352A4", Offset = "0x11352A4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001C8D")]
			[Address(RVA = "0x24A463C", Offset = "0x24A463C", VA = "0x7BBCCA463C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11352B4", Offset = "0x11352B4")]
			set
			{
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001C8E RID: 7310 RVA: 0x0000C240 File Offset: 0x0000A440
		// (set) Token: 0x06001C8F RID: 7311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000377")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154CB0", Offset = "0x1154CB0")]
		public bool enable_custom_msg
		{
			[Token(Token = "0x6001C8E")]
			[Address(RVA = "0x24A4644", Offset = "0x24A4644", VA = "0x7BBCCA4644")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11352C4", Offset = "0x11352C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C8F")]
			[Address(RVA = "0x24A464C", Offset = "0x24A464C", VA = "0x7BBCCA464C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11352D4", Offset = "0x11352D4")]
			set
			{
			}
		}

		// Token: 0x040014D9 RID: 5337
		[Token(Token = "0x40014D9")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101ED4", Offset = "0x1101ED4")]
		private ulong <channel_id>k__BackingField;

		// Token: 0x040014DA RID: 5338
		[Token(Token = "0x40014DA")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101EE4", Offset = "0x1101EE4")]
		private uint <left_talk_times_default>k__BackingField;

		// Token: 0x040014DB RID: 5339
		[Token(Token = "0x40014DB")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101EF4", Offset = "0x1101EF4")]
		private uint <left_talk_times_fast>k__BackingField;

		// Token: 0x040014DC RID: 5340
		[Token(Token = "0x40014DC")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101F04", Offset = "0x1101F04")]
		private uint <daily_msg_limit_default>k__BackingField;

		// Token: 0x040014DD RID: 5341
		[Token(Token = "0x40014DD")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101F14", Offset = "0x1101F14")]
		private uint <daily_msg_limit_fast>k__BackingField;

		// Token: 0x040014DE RID: 5342
		[Token(Token = "0x40014DE")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101F24", Offset = "0x1101F24")]
		private bool <enable_custom_msg>k__BackingField;
	}
}
