using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200184E RID: 6222
	[Token(Token = "0x200184E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3C54", Offset = "0x10F3C54")]
	public class UIGitfGetRewardController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06007A1C RID: 31260 RVA: 0x00021978 File Offset: 0x0001FB78
		[Token(Token = "0x6007A1C")]
		[Address(RVA = "0x1A6D9C0", Offset = "0x1A6D9C0", VA = "0x7BBC26D9C0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007A1D RID: 31261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A1D")]
		[Address(RVA = "0x1A6DA10", Offset = "0x1A6DA10", VA = "0x7BBC26DA10", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007A1E RID: 31262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A1E")]
		[Address(RVA = "0x1A6DC9C", Offset = "0x1A6DC9C", VA = "0x7BBC26DC9C", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06007A1F RID: 31263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A1F")]
		[Address(RVA = "0x1A6DDD4", Offset = "0x1A6DDD4", VA = "0x7BBC26DDD4")]
		private void ProcessAnimEvent(params object[] data)
		{
		}

		// Token: 0x06007A20 RID: 31264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A20")]
		[Address(RVA = "0x1A6DEA0", Offset = "0x1A6DEA0", VA = "0x7BBC26DEA0")]
		private void ShowContainer()
		{
		}

		// Token: 0x06007A21 RID: 31265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A21")]
		[Address(RVA = "0x1A6DEE0", Offset = "0x1A6DEE0", VA = "0x7BBC26DEE0")]
		public void ShowGiftMessage(GiftRewardPopupData info)
		{
		}

		// Token: 0x06007A22 RID: 31266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A22")]
		[Address(RVA = "0x1A6E234", Offset = "0x1A6E234", VA = "0x7BBC26E234")]
		private void OnOKBtnClick()
		{
		}

		// Token: 0x06007A23 RID: 31267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A23")]
		[Address(RVA = "0x1A6E250", Offset = "0x1A6E250", VA = "0x7BBC26E250")]
		private void OnCloseBtnClick()
		{
		}

		// Token: 0x06007A24 RID: 31268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A24")]
		[Address(RVA = "0x1A6E258", Offset = "0x1A6E258", VA = "0x7BBC26E258", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06007A25 RID: 31269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A25")]
		[Address(RVA = "0x1A6E304", Offset = "0x1A6E304", VA = "0x7BBC26E304", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06007A26 RID: 31270 RVA: 0x00021990 File Offset: 0x0001FB90
		[Token(Token = "0x6007A26")]
		[Address(RVA = "0x1A6E54C", Offset = "0x1A6E54C", VA = "0x7BBC26E54C", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06007A27 RID: 31271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A27")]
		[Address(RVA = "0x1A6E590", Offset = "0x1A6E590", VA = "0x7BBC26E590")]
		public UIGitfGetRewardController()
		{
		}

		// Token: 0x04008F0F RID: 36623
		[Token(Token = "0x4008F0F")]
		[FieldOffset(Offset = "0x98")]
		private UIGiftGetRewardView m_View;

		// Token: 0x04008F10 RID: 36624
		[Token(Token = "0x4008F10")]
		[FieldOffset(Offset = "0xA0")]
		private RewardBtn m_BtnData;
	}
}
