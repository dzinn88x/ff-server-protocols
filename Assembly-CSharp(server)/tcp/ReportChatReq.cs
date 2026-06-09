using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200046C RID: 1132
	[Token(Token = "0x200046C")]
	[ProtoContract]
	public class ReportChatReq
	{
		// Token: 0x06001CA1 RID: 7329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA1")]
		[Address(RVA = "0x24A5BA8", Offset = "0x24A5BA8", VA = "0x7BBCCA5BA8")]
		public ReportChatReq()
		{
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001CA2 RID: 7330 RVA: 0x0000C2E8 File Offset: 0x0000A4E8
		// (set) Token: 0x06001CA3 RID: 7331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700037F")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154D8C", Offset = "0x1154D8C")]
		public ulong target_account_id
		{
			[Token(Token = "0x6001CA2")]
			[Address(RVA = "0x24A5C0C", Offset = "0x24A5C0C", VA = "0x7BBCCA5C0C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11353C4", Offset = "0x11353C4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001CA3")]
			[Address(RVA = "0x24A5C14", Offset = "0x24A5C14", VA = "0x7BBCCA5C14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11353D4", Offset = "0x11353D4")]
			set
			{
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001CA4 RID: 7332 RVA: 0x0000C300 File Offset: 0x0000A500
		// (set) Token: 0x06001CA5 RID: 7333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000380")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154DA0", Offset = "0x1154DA0")]
		public uint reason
		{
			[Token(Token = "0x6001CA4")]
			[Address(RVA = "0x24A5C1C", Offset = "0x24A5C1C", VA = "0x7BBCCA5C1C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11353E4", Offset = "0x11353E4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001CA5")]
			[Address(RVA = "0x24A5C24", Offset = "0x24A5C24", VA = "0x7BBCCA5C24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11353F4", Offset = "0x11353F4")]
			set
			{
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001CA7 RID: 7335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000381")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154DB4", Offset = "0x1154DB4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1154DB4", Offset = "0x1154DB4")]
		public string message
		{
			[Token(Token = "0x6001CA6")]
			[Address(RVA = "0x24A5C2C", Offset = "0x24A5C2C", VA = "0x7BBCCA5C2C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135404", Offset = "0x1135404")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001CA7")]
			[Address(RVA = "0x24A5C04", Offset = "0x24A5C04", VA = "0x7BBCCA5C04")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135414", Offset = "0x1135414")]
			set
			{
			}
		}

		// Token: 0x040014EC RID: 5356
		[Token(Token = "0x40014EC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101FA4", Offset = "0x1101FA4")]
		private ulong <target_account_id>k__BackingField;

		// Token: 0x040014ED RID: 5357
		[Token(Token = "0x40014ED")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101FB4", Offset = "0x1101FB4")]
		private uint <reason>k__BackingField;

		// Token: 0x040014EE RID: 5358
		[Token(Token = "0x40014EE")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101FC4", Offset = "0x1101FC4")]
		private string <message>k__BackingField;
	}
}
