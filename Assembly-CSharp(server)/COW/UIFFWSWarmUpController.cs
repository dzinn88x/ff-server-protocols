using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001376 RID: 4982
	[Token(Token = "0x2001376")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB598", Offset = "0x10EB598")]
	internal class UIFFWSWarmUpController : UIPopupWindowController
	{
		// Token: 0x06004FEE RID: 20462 RVA: 0x000184F8 File Offset: 0x000166F8
		[Token(Token = "0x6004FEE")]
		[Address(RVA = "0x1DB133C", Offset = "0x1DB133C", VA = "0x7BBC5B133C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06004FEF RID: 20463 RVA: 0x00018510 File Offset: 0x00016710
		[Token(Token = "0x6004FEF")]
		[Address(RVA = "0x1DB138C", Offset = "0x1DB138C", VA = "0x7BBC5B138C", Slot = "34")]
		protected override bool UseCustomizedAnimation()
		{
			return default(bool);
		}

		// Token: 0x06004FF0 RID: 20464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FF0")]
		[Address(RVA = "0x1DB1394", Offset = "0x1DB1394", VA = "0x7BBC5B1394", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06004FF1 RID: 20465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FF1")]
		[Address(RVA = "0x1DB18BC", Offset = "0x1DB18BC", VA = "0x7BBC5B18BC", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06004FF2 RID: 20466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FF2")]
		[Address(RVA = "0x1DB1830", Offset = "0x1DB1830", VA = "0x7BBC5B1830")]
		private void PlayEntranceAnim()
		{
		}

		// Token: 0x06004FF3 RID: 20467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FF3")]
		[Address(RVA = "0x1DB1984", Offset = "0x1DB1984", VA = "0x7BBC5B1984")]
		private void OnEntranceAnimFinishing()
		{
		}

		// Token: 0x06004FF4 RID: 20468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FF4")]
		[Address(RVA = "0x1DB18E4", Offset = "0x1DB18E4", VA = "0x7BBC5B18E4")]
		private void CancelDelayCall()
		{
		}

		// Token: 0x06004FF5 RID: 20469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FF5")]
		[Address(RVA = "0x1DB19E0", Offset = "0x1DB19E0", VA = "0x7BBC5B19E0")]
		public UIFFWSWarmUpController()
		{
		}

		// Token: 0x04007680 RID: 30336
		[Token(Token = "0x4007680")]
		[FieldOffset(Offset = "0x98")]
		private UIFFWSWarmUpView m_View;

		// Token: 0x04007681 RID: 30337
		[Token(Token = "0x4007681")]
		[FieldOffset(Offset = "0xA0")]
		private UICountDownController m_CountDownCtrl;

		// Token: 0x04007682 RID: 30338
		[Token(Token = "0x4007682")]
		[FieldOffset(Offset = "0xA8")]
		private uint m_DelayCallID;

		// Token: 0x04007683 RID: 30339
		[Token(Token = "0x4007683")]
		[FieldOffset(Offset = "0xAC")]
		private float m_ShowClickCloseBtnDuration;

		// Token: 0x04007684 RID: 30340
		[Token(Token = "0x4007684")]
		private const int m_CountDownFontSize = 128;
	}
}
