using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004A7 RID: 1191
	[Token(Token = "0x20004A7")]
	[ProtoContract]
	public class GroupInfoReq
	{
		// Token: 0x06001DE3 RID: 7651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DE3")]
		[Address(RVA = "0x24A375C", Offset = "0x24A375C", VA = "0x7BBCCA375C")]
		public GroupInfoReq()
		{
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x0000CC00 File Offset: 0x0000AE00
		// (set) Token: 0x06001DE5 RID: 7653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700040C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155EBC", Offset = "0x1155EBC")]
		public ulong group_id
		{
			[Token(Token = "0x6001DE4")]
			[Address(RVA = "0x24A3764", Offset = "0x24A3764", VA = "0x7BBCCA3764")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136564", Offset = "0x1136564")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001DE5")]
			[Address(RVA = "0x24A376C", Offset = "0x24A376C", VA = "0x7BBCCA376C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136574", Offset = "0x1136574")]
			set
			{
			}
		}

		// Token: 0x04001631 RID: 5681
		[Token(Token = "0x4001631")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102874", Offset = "0x1102874")]
		private ulong <group_id>k__BackingField;
	}
}
