using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001672 RID: 5746
	[Token(Token = "0x2001672")]
	public class StandardSubTabItemViewData
	{
		// Token: 0x0600682A RID: 26666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600682A")]
		[Address(RVA = "0x1B3F86C", Offset = "0x1B3F86C", VA = "0x7BBC33F86C")]
		public StandardSubTabItemViewData(string tabName, ETipsType tipType = ETipsType.None, EEventTag eventTag = EEventTag.NONE)
		{
		}

		// Token: 0x04008515 RID: 34069
		[Token(Token = "0x4008515")]
		[FieldOffset(Offset = "0x10")]
		public string tabName;

		// Token: 0x04008516 RID: 34070
		[Token(Token = "0x4008516")]
		[FieldOffset(Offset = "0x18")]
		public ETipsType tipType;

		// Token: 0x04008517 RID: 34071
		[Token(Token = "0x4008517")]
		[FieldOffset(Offset = "0x1C")]
		public EEventTag eventTag;

		// Token: 0x04008518 RID: 34072
		[Token(Token = "0x4008518")]
		[FieldOffset(Offset = "0x20")]
		public Action onClick;

		// Token: 0x04008519 RID: 34073
		[Token(Token = "0x4008519")]
		[FieldOffset(Offset = "0x28")]
		public object extraPara;

		// Token: 0x0400851A RID: 34074
		[Token(Token = "0x400851A")]
		[FieldOffset(Offset = "0x30")]
		public bool hasRedPoint;

		// Token: 0x0400851B RID: 34075
		[Token(Token = "0x400851B")]
		[FieldOffset(Offset = "0x38")]
		public Action onTipChange;
	}
}
