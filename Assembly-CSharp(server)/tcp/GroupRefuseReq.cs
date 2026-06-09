using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200049F RID: 1183
	[Token(Token = "0x200049F")]
	[ProtoContract]
	public class GroupRefuseReq
	{
		// Token: 0x06001DBF RID: 7615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DBF")]
		[Address(RVA = "0x24A4004", Offset = "0x24A4004", VA = "0x7BBCCA4004")]
		public GroupRefuseReq()
		{
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001DC0 RID: 7616 RVA: 0x0000CAF8 File Offset: 0x0000ACF8
		// (set) Token: 0x06001DC1 RID: 7617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003FE")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155DA4", Offset = "0x1155DA4")]
		public ulong group_id
		{
			[Token(Token = "0x6001DC0")]
			[Address(RVA = "0x24A400C", Offset = "0x24A400C", VA = "0x7BBCCA400C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11363A4", Offset = "0x11363A4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001DC1")]
			[Address(RVA = "0x24A4014", Offset = "0x24A4014", VA = "0x7BBCCA4014")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11363B4", Offset = "0x11363B4")]
			set
			{
			}
		}

		// Token: 0x04001623 RID: 5667
		[Token(Token = "0x4001623")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102794", Offset = "0x1102794")]
		private ulong <group_id>k__BackingField;
	}
}
