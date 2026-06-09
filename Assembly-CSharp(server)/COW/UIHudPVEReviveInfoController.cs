using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200162D RID: 5677
	[Token(Token = "0x200162D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EFD0C", Offset = "0x10EFD0C")]
	internal class UIHudPVEReviveInfoController : UIBaseController
	{
		// Token: 0x0600661F RID: 26143 RVA: 0x0001D280 File Offset: 0x0001B480
		[Token(Token = "0x600661F")]
		[Address(RVA = "0x17C0D40", Offset = "0x17C0D40", VA = "0x7BBBFC0D40")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006620 RID: 26144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006620")]
		[Address(RVA = "0x17C0D90", Offset = "0x17C0D90", VA = "0x7BBBFC0D90", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006621 RID: 26145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006621")]
		[Address(RVA = "0x17C0E88", Offset = "0x17C0E88", VA = "0x7BBBFC0E88", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006622 RID: 26146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006622")]
		[Address(RVA = "0x17C0F54", Offset = "0x17C0F54", VA = "0x7BBBFC0F54")]
		public void OpenFakeHudBtns()
		{
		}

		// Token: 0x06006623 RID: 26147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006623")]
		[Address(RVA = "0x17C1050", Offset = "0x17C1050", VA = "0x7BBBFC1050")]
		public void SetUIData(ulong num = 10UL, bool teamWiped = false, int leftTokenCount = 0, int leftDiamond = 0, int costTokenCount = 0, int costGemsCount = 0)
		{
		}

		// Token: 0x06006624 RID: 26148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006624")]
		[Address(RVA = "0x17C1230", Offset = "0x17C1230", VA = "0x7BBBFC1230")]
		private void SetButtonNumberAndEnabled(UIButton btn, UILabel label, bool enable, int cost)
		{
		}

		// Token: 0x06006625 RID: 26149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006625")]
		[Address(RVA = "0x17C12EC", Offset = "0x17C12EC", VA = "0x7BBBFC12EC", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06006626 RID: 26150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006626")]
		[Address(RVA = "0x17C1530", Offset = "0x17C1530", VA = "0x7BBBFC1530", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06006627 RID: 26151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006627")]
		[Address(RVA = "0x17C1314", Offset = "0x17C1314", VA = "0x7BBBFC1314")]
		private void UpdateAxisTouchingThroughArea()
		{
		}

		// Token: 0x06006628 RID: 26152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006628")]
		[Address(RVA = "0x17C1644", Offset = "0x17C1644", VA = "0x7BBBFC1644")]
		private void OnLocalPlayerAdd(params object[] data)
		{
		}

		// Token: 0x06006629 RID: 26153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006629")]
		[Address(RVA = "0x17C1648", Offset = "0x17C1648", VA = "0x7BBBFC1648")]
		public UIHudPVEReviveInfoController()
		{
		}

		// Token: 0x0400840C RID: 33804
		[Token(Token = "0x400840C")]
		[FieldOffset(Offset = "0x58")]
		private UIHudPVEReviveInfoView m_View;
	}
}
