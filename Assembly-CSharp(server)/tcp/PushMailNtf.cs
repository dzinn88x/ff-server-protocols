using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004CF RID: 1231
	[Token(Token = "0x20004CF")]
	[ProtoContract]
	public class PushMailNtf
	{
		// Token: 0x06001EE7 RID: 7911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE7")]
		[Address(RVA = "0x24A5A34", Offset = "0x24A5A34", VA = "0x7BBCCA5A34")]
		public PushMailNtf()
		{
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001EE8 RID: 7912 RVA: 0x0000D3B0 File Offset: 0x0000B5B0
		// (set) Token: 0x06001EE9 RID: 7913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700047E")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156D58", Offset = "0x1156D58")]
		public uint new_mail_cnt
		{
			[Token(Token = "0x6001EE8")]
			[Address(RVA = "0x24A5A3C", Offset = "0x24A5A3C", VA = "0x7BBCCA5A3C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11373A4", Offset = "0x11373A4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001EE9")]
			[Address(RVA = "0x24A5A44", Offset = "0x24A5A44", VA = "0x7BBCCA5A44")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11373B4", Offset = "0x11373B4")]
			set
			{
			}
		}

		// Token: 0x040016C7 RID: 5831
		[Token(Token = "0x40016C7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102F94", Offset = "0x1102F94")]
		private uint <new_mail_cnt>k__BackingField;
	}
}
