using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000481 RID: 1153
	[Token(Token = "0x2000481")]
	[ProtoContract]
	public class FreshActivityUpdateInfo
	{
		// Token: 0x06001CEE RID: 7406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CEE")]
		[Address(RVA = "0x24A2E30", Offset = "0x24A2E30", VA = "0x7BBCCA2E30")]
		public FreshActivityUpdateInfo()
		{
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001CEF RID: 7407 RVA: 0x0000C540 File Offset: 0x0000A740
		// (set) Token: 0x06001CF0 RID: 7408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700039E")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155110", Offset = "0x1155110")]
		public uint id
		{
			[Token(Token = "0x6001CEF")]
			[Address(RVA = "0x24A2E38", Offset = "0x24A2E38", VA = "0x7BBCCA2E38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11357A4", Offset = "0x11357A4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001CF0")]
			[Address(RVA = "0x24A2E40", Offset = "0x24A2E40", VA = "0x7BBCCA2E40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11357B4", Offset = "0x11357B4")]
			set
			{
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001CF1 RID: 7409 RVA: 0x0000C558 File Offset: 0x0000A758
		// (set) Token: 0x06001CF2 RID: 7410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700039F")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155124", Offset = "0x1155124")]
		public uint data
		{
			[Token(Token = "0x6001CF1")]
			[Address(RVA = "0x24A2E48", Offset = "0x24A2E48", VA = "0x7BBCCA2E48")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11357C4", Offset = "0x11357C4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001CF2")]
			[Address(RVA = "0x24A2E50", Offset = "0x24A2E50", VA = "0x7BBCCA2E50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11357D4", Offset = "0x11357D4")]
			set
			{
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001CF3 RID: 7411 RVA: 0x0000C570 File Offset: 0x0000A770
		// (set) Token: 0x06001CF4 RID: 7412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155138", Offset = "0x1155138")]
		public uint state
		{
			[Token(Token = "0x6001CF3")]
			[Address(RVA = "0x24A2E58", Offset = "0x24A2E58", VA = "0x7BBCCA2E58")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11357E4", Offset = "0x11357E4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001CF4")]
			[Address(RVA = "0x24A2E60", Offset = "0x24A2E60", VA = "0x7BBCCA2E60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11357F4", Offset = "0x11357F4")]
			set
			{
			}
		}

		// Token: 0x04001525 RID: 5413
		[Token(Token = "0x4001525")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102194", Offset = "0x1102194")]
		private uint <id>k__BackingField;

		// Token: 0x04001526 RID: 5414
		[Token(Token = "0x4001526")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11021A4", Offset = "0x11021A4")]
		private uint <data>k__BackingField;

		// Token: 0x04001527 RID: 5415
		[Token(Token = "0x4001527")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11021B4", Offset = "0x11021B4")]
		private uint <state>k__BackingField;
	}
}
