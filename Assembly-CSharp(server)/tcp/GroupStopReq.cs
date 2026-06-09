using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004A3 RID: 1187
	[Token(Token = "0x20004A3")]
	[ProtoContract]
	public class GroupStopReq
	{
		// Token: 0x06001DCF RID: 7631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DCF")]
		[Address(RVA = "0x24A4134", Offset = "0x24A4134", VA = "0x7BBCCA4134")]
		public GroupStopReq()
		{
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x0000CB70 File Offset: 0x0000AD70
		// (set) Token: 0x06001DD1 RID: 7633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000404")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155E1C", Offset = "0x1155E1C")]
		public ulong group_id
		{
			[Token(Token = "0x6001DD0")]
			[Address(RVA = "0x24A413C", Offset = "0x24A413C", VA = "0x7BBCCA413C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136464", Offset = "0x1136464")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001DD1")]
			[Address(RVA = "0x24A4144", Offset = "0x24A4144", VA = "0x7BBCCA4144")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136474", Offset = "0x1136474")]
			set
			{
			}
		}

		// Token: 0x04001629 RID: 5673
		[Token(Token = "0x4001629")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11027F4", Offset = "0x11027F4")]
		private ulong <group_id>k__BackingField;
	}
}
