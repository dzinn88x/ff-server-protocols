using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200165D RID: 5725
	[Token(Token = "0x200165D")]
	public class GiftRewardPopupData
	{
		// Token: 0x06006767 RID: 26471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006767")]
		[Address(RVA = "0x1D8D8B4", Offset = "0x1D8D8B4", VA = "0x7BBC58D8B4")]
		public GiftRewardPopupData(string receiverName, string message, string senderName)
		{
		}

		// Token: 0x06006768 RID: 26472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006768")]
		[Address(RVA = "0x1D8D8F4", Offset = "0x1D8D8F4", VA = "0x7BBC58D8F4")]
		public GiftRewardPopupData(string receiverName, string message, string senderName, RewardBtn btnData)
		{
		}

		// Token: 0x040084C2 RID: 33986
		[Token(Token = "0x40084C2")]
		[FieldOffset(Offset = "0x10")]
		public string Message;

		// Token: 0x040084C3 RID: 33987
		[Token(Token = "0x40084C3")]
		[FieldOffset(Offset = "0x18")]
		public RewardBtn BtnData;

		// Token: 0x040084C4 RID: 33988
		[Token(Token = "0x40084C4")]
		[FieldOffset(Offset = "0x20")]
		public string ReceiverName;

		// Token: 0x040084C5 RID: 33989
		[Token(Token = "0x40084C5")]
		[FieldOffset(Offset = "0x28")]
		public string SenderName;
	}
}
