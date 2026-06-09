using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004B5 RID: 1205
	[Token(Token = "0x20004B5")]
	[ProtoContract]
	public class GetGroupCodeReq
	{
		// Token: 0x06001E8B RID: 7819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E8B")]
		[Address(RVA = "0x24A3070", Offset = "0x24A3070", VA = "0x7BBCCA3070")]
		public GetGroupCodeReq()
		{
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x0000D110 File Offset: 0x0000B310
		// (set) Token: 0x06001E8D RID: 7821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000459")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11568D0", Offset = "0x11568D0")]
		public ulong group_id
		{
			[Token(Token = "0x6001E8C")]
			[Address(RVA = "0x24A3078", Offset = "0x24A3078", VA = "0x7BBCCA3078")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136F04", Offset = "0x1136F04")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001E8D")]
			[Address(RVA = "0x24A3080", Offset = "0x24A3080", VA = "0x7BBCCA3080")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136F14", Offset = "0x1136F14")]
			set
			{
			}
		}

		// Token: 0x0400167E RID: 5758
		[Token(Token = "0x400167E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102D44", Offset = "0x1102D44")]
		private ulong <group_id>k__BackingField;
	}
}
