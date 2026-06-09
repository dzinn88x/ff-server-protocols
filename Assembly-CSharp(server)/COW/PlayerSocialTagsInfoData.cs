using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200116D RID: 4461
	[Token(Token = "0x200116D")]
	public class PlayerSocialTagsInfoData : CSVBaseData
	{
		// Token: 0x06004578 RID: 17784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004578")]
		[Address(RVA = "0x1EFF628", Offset = "0x1EFF628", VA = "0x7BBC6FF628", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004579 RID: 17785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004579")]
		[Address(RVA = "0x1EFF634", Offset = "0x1EFF634", VA = "0x7BBC6FF634", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600457A RID: 17786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600457A")]
		[Address(RVA = "0x1EFF734", Offset = "0x1EFF734", VA = "0x7BBC6FF734")]
		public PlayerSocialTagsInfoData()
		{
		}

		// Token: 0x04005656 RID: 22102
		[Token(Token = "0x4005656")]
		[FieldOffset(Offset = "0x10")]
		public uint SocialTagID;

		// Token: 0x04005657 RID: 22103
		[Token(Token = "0x4005657")]
		[FieldOffset(Offset = "0x14")]
		public uint TagPriority;

		// Token: 0x04005658 RID: 22104
		[Token(Token = "0x4005658")]
		[FieldOffset(Offset = "0x18")]
		public string TagNameKey;

		// Token: 0x04005659 RID: 22105
		[Token(Token = "0x4005659")]
		[FieldOffset(Offset = "0x20")]
		public string TagDescriptionKey;
	}
}
