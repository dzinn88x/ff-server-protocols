using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020010F0 RID: 4336
	[Token(Token = "0x20010F0")]
	internal class EPUnlockData : CsvDataIndexedReading
	{
		// Token: 0x060043B1 RID: 17329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043B1")]
		[Address(RVA = "0x1612BCC", Offset = "0x1612BCC", VA = "0x7BBBE12BCC", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060043B2 RID: 17330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043B2")]
		[Address(RVA = "0x1612BD8", Offset = "0x1612BD8", VA = "0x7BBBE12BD8", Slot = "7")]
		public override string[] GetHeadColNames()
		{
			return null;
		}

		// Token: 0x060043B3 RID: 17331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043B3")]
		[Address(RVA = "0x1613120", Offset = "0x1613120", VA = "0x7BBBE13120", Slot = "8")]
		public override void ParseData(IIndexString ss, int[] index)
		{
		}

		// Token: 0x060043B4 RID: 17332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043B4")]
		[Address(RVA = "0x1613BF4", Offset = "0x1613BF4", VA = "0x7BBBE13BF4")]
		public static void GetUnlockDataListByEventID(uint eventID, out List<EPUnlockData> UnlockList)
		{
		}

		// Token: 0x060043B5 RID: 17333 RVA: 0x00014C28 File Offset: 0x00012E28
		[Token(Token = "0x60043B5")]
		[Address(RVA = "0x1613E80", Offset = "0x1613E80", VA = "0x7BBBE13E80")]
		public bool IsBigAward()
		{
			return default(bool);
		}

		// Token: 0x060043B6 RID: 17334 RVA: 0x00014C40 File Offset: 0x00012E40
		[Token(Token = "0x60043B6")]
		[Address(RVA = "0x1613E94", Offset = "0x1613E94", VA = "0x7BBBE13E94")]
		public bool IsExclusiveAward()
		{
			return default(bool);
		}

		// Token: 0x060043B7 RID: 17335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043B7")]
		[Address(RVA = "0x1613EA8", Offset = "0x1613EA8", VA = "0x7BBBE13EA8")]
		public EPUnlockData()
		{
		}

		// Token: 0x040053A4 RID: 21412
		[Token(Token = "0x40053A4")]
		[FieldOffset(Offset = "0x10")]
		public uint EPEventID;

		// Token: 0x040053A5 RID: 21413
		[Token(Token = "0x40053A5")]
		[FieldOffset(Offset = "0x14")]
		public uint UnlockID;

		// Token: 0x040053A6 RID: 21414
		[Token(Token = "0x40053A6")]
		[FieldOffset(Offset = "0x18")]
		public int RequireItemNum;

		// Token: 0x040053A7 RID: 21415
		[Token(Token = "0x40053A7")]
		[FieldOffset(Offset = "0x1C")]
		public uint FPAwardID;

		// Token: 0x040053A8 RID: 21416
		[Token(Token = "0x40053A8")]
		[FieldOffset(Offset = "0x20")]
		public uint FPAwardNum;

		// Token: 0x040053A9 RID: 21417
		[Token(Token = "0x40053A9")]
		[FieldOffset(Offset = "0x24")]
		public uint FPAwardTime;

		// Token: 0x040053AA RID: 21418
		[Token(Token = "0x40053AA")]
		[FieldOffset(Offset = "0x28")]
		public uint EPAwardID;

		// Token: 0x040053AB RID: 21419
		[Token(Token = "0x40053AB")]
		[FieldOffset(Offset = "0x2C")]
		public uint EPAwardNum;

		// Token: 0x040053AC RID: 21420
		[Token(Token = "0x40053AC")]
		[FieldOffset(Offset = "0x30")]
		public uint DisplayOrder;

		// Token: 0x040053AD RID: 21421
		[Token(Token = "0x40053AD")]
		[FieldOffset(Offset = "0x34")]
		public uint EPAwardTime;

		// Token: 0x040053AE RID: 21422
		[Token(Token = "0x40053AE")]
		[FieldOffset(Offset = "0x38")]
		public EInventory.AwardType FPAwardType;

		// Token: 0x040053AF RID: 21423
		[Token(Token = "0x40053AF")]
		[FieldOffset(Offset = "0x3C")]
		public EInventory.AwardType EPAwardType;

		// Token: 0x020010F1 RID: 4337
		[Token(Token = "0x20010F1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAC24", Offset = "0x10EAC24")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060043B9 RID: 17337 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60043B9")]
			[Address(RVA = "0x1613F14", Offset = "0x1613F14", VA = "0x7BBBE13F14")]
			public <>c()
			{
			}

			// Token: 0x060043BA RID: 17338 RVA: 0x00014C58 File Offset: 0x00012E58
			[Token(Token = "0x60043BA")]
			[Address(RVA = "0x1613F1C", Offset = "0x1613F1C", VA = "0x7BBBE13F1C")]
			internal int <GetUnlockDataListByEventID>b__15_0(EPUnlockData a, EPUnlockData b)
			{
				return 0;
			}

			// Token: 0x040053B0 RID: 21424
			[Token(Token = "0x40053B0")]
			[FieldOffset(Offset = "0x0")]
			public static readonly EPUnlockData.<>c <>9;

			// Token: 0x040053B1 RID: 21425
			[Token(Token = "0x40053B1")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<EPUnlockData> <>9__15_0;
		}
	}
}
