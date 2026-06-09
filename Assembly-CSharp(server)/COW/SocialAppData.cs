using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200118A RID: 4490
	[Token(Token = "0x200118A")]
	public class SocialAppData : CSVBaseData
	{
		// Token: 0x060045EC RID: 17900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045EC")]
		[Address(RVA = "0x1B3A398", Offset = "0x1B3A398", VA = "0x7BBC33A398", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060045ED RID: 17901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045ED")]
		[Address(RVA = "0x1B3A3A0", Offset = "0x1B3A3A0", VA = "0x7BBC33A3A0", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060045EE RID: 17902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045EE")]
		[Address(RVA = "0x1B3A538", Offset = "0x1B3A538", VA = "0x7BBC33A538")]
		public SocialAppData()
		{
		}

		// Token: 0x040056F4 RID: 22260
		[Token(Token = "0x40056F4")]
		[FieldOffset(Offset = "0x10")]
		public string RegionName;

		// Token: 0x040056F5 RID: 22261
		[Token(Token = "0x40056F5")]
		[FieldOffset(Offset = "0x18")]
		public bool FacebookShareMatchResult;

		// Token: 0x040056F6 RID: 22262
		[Token(Token = "0x40056F6")]
		[FieldOffset(Offset = "0x19")]
		public bool FacebookInviteFriend;

		// Token: 0x040056F7 RID: 22263
		[Token(Token = "0x40056F7")]
		[FieldOffset(Offset = "0x1A")]
		public bool FacebookGroupInvite;

		// Token: 0x040056F8 RID: 22264
		[Token(Token = "0x40056F8")]
		[FieldOffset(Offset = "0x1B")]
		public bool LineShareMatchResult;

		// Token: 0x040056F9 RID: 22265
		[Token(Token = "0x40056F9")]
		[FieldOffset(Offset = "0x1C")]
		public bool LineInviteFriend;

		// Token: 0x040056FA RID: 22266
		[Token(Token = "0x40056FA")]
		[FieldOffset(Offset = "0x1D")]
		public bool LineGroupInvite;
	}
}
