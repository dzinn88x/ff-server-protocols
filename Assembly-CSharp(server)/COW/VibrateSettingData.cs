using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020011A3 RID: 4515
	[Token(Token = "0x20011A3")]
	public class VibrateSettingData : CSVBaseData
	{
		// Token: 0x06004643 RID: 17987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004643")]
		[Address(RVA = "0x179ABD4", Offset = "0x179ABD4", VA = "0x7BBBF9ABD4", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004644 RID: 17988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004644")]
		[Address(RVA = "0x179ABE0", Offset = "0x179ABE0", VA = "0x7BBBF9ABE0", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004645 RID: 17989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004645")]
		[Address(RVA = "0x179ACC4", Offset = "0x179ACC4", VA = "0x7BBBF9ACC4")]
		public VibrateSettingData()
		{
		}

		// Token: 0x0400577B RID: 22395
		[Token(Token = "0x400577B")]
		public const string MATCHSUCCESS = "1";

		// Token: 0x0400577C RID: 22396
		[Token(Token = "0x400577C")]
		public const string GROUPINVITE = "2";

		// Token: 0x0400577D RID: 22397
		[Token(Token = "0x400577D")]
		public const string PARACHUTING = "3";

		// Token: 0x0400577E RID: 22398
		[Token(Token = "0x400577E")]
		public const string KNOCKDOWNENEMY = "4";

		// Token: 0x0400577F RID: 22399
		[Token(Token = "0x400577F")]
		public const string STARTUPVEHICLE = "5";

		// Token: 0x04005780 RID: 22400
		[Token(Token = "0x4005780")]
		public const string VEHICLEHIT = "6";

		// Token: 0x04005781 RID: 22401
		[Token(Token = "0x4005781")]
		public const string HITED = "7";

		// Token: 0x04005782 RID: 22402
		[Token(Token = "0x4005782")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		// Token: 0x04005783 RID: 22403
		[Token(Token = "0x4005783")]
		[FieldOffset(Offset = "0x18")]
		public uint[] vibrateInfo;

		// Token: 0x04005784 RID: 22404
		[Token(Token = "0x4005784")]
		[FieldOffset(Offset = "0x20")]
		public bool isAsusOnly;
	}
}
