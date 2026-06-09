using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020011AB RID: 4523
	[Token(Token = "0x20011AB")]
	public class WereWolvesRoleData : CSVBaseData
	{
		// Token: 0x0600465B RID: 18011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600465B")]
		[Address(RVA = "0x23DF6FC", Offset = "0x23DF6FC", VA = "0x7BBCBDF6FC", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600465C RID: 18012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600465C")]
		[Address(RVA = "0x23DF708", Offset = "0x23DF708", VA = "0x7BBCBDF708", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600465D RID: 18013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600465D")]
		[Address(RVA = "0x23DF914", Offset = "0x23DF914", VA = "0x7BBCBDF914")]
		public WereWolvesRoleData()
		{
		}

		// Token: 0x040057A9 RID: 22441
		[Token(Token = "0x40057A9")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		// Token: 0x040057AA RID: 22442
		[Token(Token = "0x40057AA")]
		[FieldOffset(Offset = "0x14")]
		public ResourceID IconResID;

		// Token: 0x040057AB RID: 22443
		[Token(Token = "0x40057AB")]
		[FieldOffset(Offset = "0x18")]
		public ResourceID RolePrefebResId;

		// Token: 0x040057AC RID: 22444
		[Token(Token = "0x40057AC")]
		[FieldOffset(Offset = "0x1C")]
		public ResourceID BodyPrefebResId;

		// Token: 0x040057AD RID: 22445
		[Token(Token = "0x40057AD")]
		[FieldOffset(Offset = "0x20")]
		public string IdleAnim;

		// Token: 0x040057AE RID: 22446
		[Token(Token = "0x40057AE")]
		[FieldOffset(Offset = "0x28")]
		public string WalkAnim;

		// Token: 0x040057AF RID: 22447
		[Token(Token = "0x40057AF")]
		[FieldOffset(Offset = "0x30")]
		public string KillAnim;

		// Token: 0x040057B0 RID: 22448
		[Token(Token = "0x40057B0")]
		[FieldOffset(Offset = "0x38")]
		public ResourceID WalkSFXResId;
	}
}
