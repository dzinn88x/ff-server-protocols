using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000486 RID: 1158
	[Token(Token = "0x2000486")]
	[ProtoContract]
	public class RelatedFriendOnlineNtf
	{
		// Token: 0x06001CFF RID: 7423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CFF")]
		[Address(RVA = "0x24A5AE4", Offset = "0x24A5AE4", VA = "0x7BBCCA5AE4")]
		public RelatedFriendOnlineNtf()
		{
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06001D00 RID: 7424 RVA: 0x0000C5B8 File Offset: 0x0000A7B8
		// (set) Token: 0x06001D01 RID: 7425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A5")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155214", Offset = "0x1155214")]
		public ulong account_id
		{
			[Token(Token = "0x6001D00")]
			[Address(RVA = "0x24A5AEC", Offset = "0x24A5AEC", VA = "0x7BBCCA5AEC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135884", Offset = "0x1135884")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001D01")]
			[Address(RVA = "0x24A5AF4", Offset = "0x24A5AF4", VA = "0x7BBCCA5AF4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135894", Offset = "0x1135894")]
			set
			{
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06001D02 RID: 7426 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
		// (set) Token: 0x06001D03 RID: 7427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A6")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155228", Offset = "0x1155228")]
		public uint relation_type
		{
			[Token(Token = "0x6001D02")]
			[Address(RVA = "0x24A5AFC", Offset = "0x24A5AFC", VA = "0x7BBCCA5AFC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11358A4", Offset = "0x11358A4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D03")]
			[Address(RVA = "0x24A5B04", Offset = "0x24A5B04", VA = "0x7BBCCA5B04")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11358B4", Offset = "0x11358B4")]
			set
			{
			}
		}

		// Token: 0x04001539 RID: 5433
		[Token(Token = "0x4001539")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102204", Offset = "0x1102204")]
		private ulong <account_id>k__BackingField;

		// Token: 0x0400153A RID: 5434
		[Token(Token = "0x400153A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102214", Offset = "0x1102214")]
		private uint <relation_type>k__BackingField;
	}
}
