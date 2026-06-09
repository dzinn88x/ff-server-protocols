using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004A6 RID: 1190
	[Token(Token = "0x20004A6")]
	[ProtoContract]
	public class GroupDismissNtf
	{
		// Token: 0x06001DDC RID: 7644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DDC")]
		[Address(RVA = "0x24A3590", Offset = "0x24A3590", VA = "0x7BBCCA3590")]
		public GroupDismissNtf()
		{
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x0000CBB8 File Offset: 0x0000ADB8
		// (set) Token: 0x06001DDE RID: 7646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000409")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155E80", Offset = "0x1155E80")]
		public ulong leaver_id
		{
			[Token(Token = "0x6001DDD")]
			[Address(RVA = "0x24A3598", Offset = "0x24A3598", VA = "0x7BBCCA3598")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136504", Offset = "0x1136504")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001DDE")]
			[Address(RVA = "0x24A35A0", Offset = "0x24A35A0", VA = "0x7BBCCA35A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136514", Offset = "0x1136514")]
			set
			{
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06001DDF RID: 7647 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
		// (set) Token: 0x06001DE0 RID: 7648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700040A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155E94", Offset = "0x1155E94")]
		public ulong group_id
		{
			[Token(Token = "0x6001DDF")]
			[Address(RVA = "0x24A35A8", Offset = "0x24A35A8", VA = "0x7BBCCA35A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136524", Offset = "0x1136524")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001DE0")]
			[Address(RVA = "0x24A35B0", Offset = "0x24A35B0", VA = "0x7BBCCA35B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136534", Offset = "0x1136534")]
			set
			{
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
		// (set) Token: 0x06001DE2 RID: 7650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700040B")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155EA8", Offset = "0x1155EA8")]
		public EGroup.LeaveReason reason
		{
			[Token(Token = "0x6001DE1")]
			[Address(RVA = "0x24A35B8", Offset = "0x24A35B8", VA = "0x7BBCCA35B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136544", Offset = "0x1136544")]
			get
			{
				return EGroup.LeaveReason.LeaveReason_NORMAL;
			}
			[Token(Token = "0x6001DE2")]
			[Address(RVA = "0x24A35C0", Offset = "0x24A35C0", VA = "0x7BBCCA35C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136554", Offset = "0x1136554")]
			set
			{
			}
		}

		// Token: 0x0400162E RID: 5678
		[Token(Token = "0x400162E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102844", Offset = "0x1102844")]
		private ulong <leaver_id>k__BackingField;

		// Token: 0x0400162F RID: 5679
		[Token(Token = "0x400162F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102854", Offset = "0x1102854")]
		private ulong <group_id>k__BackingField;

		// Token: 0x04001630 RID: 5680
		[Token(Token = "0x4001630")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102864", Offset = "0x1102864")]
		private EGroup.LeaveReason <reason>k__BackingField;
	}
}
