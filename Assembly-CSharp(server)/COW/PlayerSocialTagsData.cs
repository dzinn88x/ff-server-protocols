using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200116A RID: 4458
	[Token(Token = "0x200116A")]
	public class PlayerSocialTagsData : CSVBaseData
	{
		// Token: 0x0600456E RID: 17774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600456E")]
		[Address(RVA = "0x1EFEE84", Offset = "0x1EFEE84", VA = "0x7BBC6FEE84", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600456F RID: 17775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600456F")]
		[Address(RVA = "0x1EFEE8C", Offset = "0x1EFEE8C", VA = "0x7BBC6FEE8C", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004570 RID: 17776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004570")]
		[Address(RVA = "0x1EFEF68", Offset = "0x1EFEF68", VA = "0x7BBC6FEF68")]
		public PlayerSocialTagsData()
		{
		}

		// Token: 0x04005651 RID: 22097
		[Token(Token = "0x4005651")]
		[FieldOffset(Offset = "0x10")]
		public string m_ShowKey;

		// Token: 0x04005652 RID: 22098
		[Token(Token = "0x4005652")]
		[FieldOffset(Offset = "0x18")]
		public uint typeid;

		// Token: 0x04005653 RID: 22099
		[Token(Token = "0x4005653")]
		[FieldOffset(Offset = "0x1C")]
		public uint sortid;
	}
}
