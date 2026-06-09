using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200045D RID: 1117
	[Token(Token = "0x200045D")]
	[ProtoContract]
	public class MatchEndInfo
	{
		// Token: 0x06001C63 RID: 7267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C63")]
		[Address(RVA = "0x24A4A14", Offset = "0x24A4A14", VA = "0x7BBCCA4A14")]
		public MatchEndInfo()
		{
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001C64 RID: 7268 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		// (set) Token: 0x06001C65 RID: 7269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000364")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154A44", Offset = "0x1154A44")]
		public uint championship_type
		{
			[Token(Token = "0x6001C64")]
			[Address(RVA = "0x24A4A1C", Offset = "0x24A4A1C", VA = "0x7BBCCA4A1C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135064", Offset = "0x1135064")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001C65")]
			[Address(RVA = "0x24A4A24", Offset = "0x24A4A24", VA = "0x7BBCCA4A24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135074", Offset = "0x1135074")]
			set
			{
			}
		}

		// Token: 0x040014A7 RID: 5287
		[Token(Token = "0x40014A7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101DF4", Offset = "0x1101DF4")]
		private uint <championship_type>k__BackingField;
	}
}
