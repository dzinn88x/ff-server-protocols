using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000475 RID: 1141
	[Token(Token = "0x2000475")]
	[ProtoContract]
	public class AutoJoinReq
	{
		// Token: 0x06001CC8 RID: 7368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC8")]
		[Address(RVA = "0x24A2644", Offset = "0x24A2644", VA = "0x7BBCCA2644")]
		public AutoJoinReq()
		{
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06001CC9 RID: 7369 RVA: 0x0000C408 File Offset: 0x0000A608
		// (set) Token: 0x06001CCA RID: 7370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038F")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154FBC", Offset = "0x1154FBC")]
		public ulong clan_id
		{
			[Token(Token = "0x6001CC9")]
			[Address(RVA = "0x24A264C", Offset = "0x24A264C", VA = "0x7BBCCA264C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11355C4", Offset = "0x11355C4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001CCA")]
			[Address(RVA = "0x24A2654", Offset = "0x24A2654", VA = "0x7BBCCA2654")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11355D4", Offset = "0x11355D4")]
			set
			{
			}
		}

		// Token: 0x0400150A RID: 5386
		[Token(Token = "0x400150A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11020A4", Offset = "0x11020A4")]
		private ulong <clan_id>k__BackingField;
	}
}
