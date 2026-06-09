using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200117D RID: 4477
	[Token(Token = "0x200117D")]
	public class RebateCardNotifyData : CSVBaseData
	{
		// Token: 0x060045AA RID: 17834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045AA")]
		[Address(RVA = "0x1751E24", Offset = "0x1751E24", VA = "0x7BBBF51E24")]
		public static RebateCardNotifyData Get(string region)
		{
			return null;
		}

		// Token: 0x060045AB RID: 17835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045AB")]
		[Address(RVA = "0x1751FA0", Offset = "0x1751FA0", VA = "0x7BBBF51FA0", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060045AC RID: 17836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045AC")]
		[Address(RVA = "0x1751FA8", Offset = "0x1751FA8", VA = "0x7BBBF51FA8", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060045AD RID: 17837 RVA: 0x000152B8 File Offset: 0x000134B8
		[Token(Token = "0x60045AD")]
		[Address(RVA = "0x17520C4", Offset = "0x17520C4", VA = "0x7BBBF520C4")]
		private static int ParseTimeOfDayToSeconds(string timeOfDay)
		{
			return 0;
		}

		// Token: 0x060045AE RID: 17838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045AE")]
		[Address(RVA = "0x175221C", Offset = "0x175221C", VA = "0x7BBBF5221C")]
		public RebateCardNotifyData()
		{
		}

		// Token: 0x040056A9 RID: 22185
		[Token(Token = "0x40056A9")]
		[FieldOffset(Offset = "0x10")]
		public string Region;

		// Token: 0x040056AA RID: 22186
		[Token(Token = "0x40056AA")]
		[FieldOffset(Offset = "0x18")]
		public string TimeOfDay;

		// Token: 0x040056AB RID: 22187
		[Token(Token = "0x40056AB")]
		[FieldOffset(Offset = "0x20")]
		public int TimeOfDay_Seconds;

		// Token: 0x040056AC RID: 22188
		[Token(Token = "0x40056AC")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, RebateCardNotifyData> _Data;

		// Token: 0x040056AD RID: 22189
		[Token(Token = "0x40056AD")]
		private const string REGION_DEFAULT = "default";
	}
}
