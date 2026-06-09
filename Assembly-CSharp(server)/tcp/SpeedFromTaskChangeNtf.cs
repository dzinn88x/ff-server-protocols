using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004C5 RID: 1221
	[Token(Token = "0x20004C5")]
	[ProtoContract]
	public class SpeedFromTaskChangeNtf
	{
		// Token: 0x06001ECF RID: 7887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ECF")]
		[Address(RVA = "0x24A7154", Offset = "0x24A7154", VA = "0x7BBCCA7154")]
		public SpeedFromTaskChangeNtf()
		{
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001ED0 RID: 7888 RVA: 0x0000D2F0 File Offset: 0x0000B4F0
		// (set) Token: 0x06001ED1 RID: 7889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000475")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156CA4", Offset = "0x1156CA4")]
		public uint deposit
		{
			[Token(Token = "0x6001ED0")]
			[Address(RVA = "0x24A715C", Offset = "0x24A715C", VA = "0x7BBCCA715C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137284", Offset = "0x1137284")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001ED1")]
			[Address(RVA = "0x24A7164", Offset = "0x24A7164", VA = "0x7BBCCA7164")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137294", Offset = "0x1137294")]
			set
			{
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001ED2 RID: 7890 RVA: 0x0000D308 File Offset: 0x0000B508
		// (set) Token: 0x06001ED3 RID: 7891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000476")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156CB8", Offset = "0x1156CB8")]
		public uint current_speed_from_task
		{
			[Token(Token = "0x6001ED2")]
			[Address(RVA = "0x24A716C", Offset = "0x24A716C", VA = "0x7BBCCA716C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11372A4", Offset = "0x11372A4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001ED3")]
			[Address(RVA = "0x24A7174", Offset = "0x24A7174", VA = "0x7BBCCA7174")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11372B4", Offset = "0x11372B4")]
			set
			{
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06001ED4 RID: 7892 RVA: 0x0000D320 File Offset: 0x0000B520
		// (set) Token: 0x06001ED5 RID: 7893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000477")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156CCC", Offset = "0x1156CCC")]
		public uint speed_change_time
		{
			[Token(Token = "0x6001ED4")]
			[Address(RVA = "0x24A717C", Offset = "0x24A717C", VA = "0x7BBCCA717C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11372C4", Offset = "0x11372C4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001ED5")]
			[Address(RVA = "0x24A7184", Offset = "0x24A7184", VA = "0x7BBCCA7184")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11372D4", Offset = "0x11372D4")]
			set
			{
			}
		}

		// Token: 0x040016B4 RID: 5812
		[Token(Token = "0x40016B4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102F04", Offset = "0x1102F04")]
		private uint <deposit>k__BackingField;

		// Token: 0x040016B5 RID: 5813
		[Token(Token = "0x40016B5")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102F14", Offset = "0x1102F14")]
		private uint <current_speed_from_task>k__BackingField;

		// Token: 0x040016B6 RID: 5814
		[Token(Token = "0x40016B6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102F24", Offset = "0x1102F24")]
		private uint <speed_change_time>k__BackingField;
	}
}
