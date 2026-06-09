using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020014F4 RID: 5364
	[Token(Token = "0x20014F4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EDD7C", Offset = "0x10EDD7C")]
	public class UIEPDailyTaskRewardItemController : UIBaseController
	{
		// Token: 0x06005BED RID: 23533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BED")]
		[Address(RVA = "0x2212728", Offset = "0x2212728", VA = "0x7BBCA12728", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005BEE RID: 23534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BEE")]
		[Address(RVA = "0x2212938", Offset = "0x2212938", VA = "0x7BBCA12938", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06005BEF RID: 23535 RVA: 0x0001AD18 File Offset: 0x00018F18
		[Token(Token = "0x6005BEF")]
		[Address(RVA = "0x2212A58", Offset = "0x2212A58", VA = "0x7BBCA12A58")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005BF0 RID: 23536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BF0")]
		[Address(RVA = "0x2210DB8", Offset = "0x2210DB8", VA = "0x7BBCA10DB8")]
		public void SetData(EPDailyRewardInfo info)
		{
		}

		// Token: 0x06005BF1 RID: 23537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BF1")]
		[Address(RVA = "0x2212D94", Offset = "0x2212D94", VA = "0x7BBCA12D94")]
		public void OnEPDailyProcessAnimDone(params object[] data)
		{
		}

		// Token: 0x06005BF2 RID: 23538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BF2")]
		[Address(RVA = "0x2212FCC", Offset = "0x2212FCC", VA = "0x7BBCA12FCC")]
		private void OnEPDailyRewardClaim(params object[] data)
		{
		}

		// Token: 0x06005BF3 RID: 23539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BF3")]
		[Address(RVA = "0x22130FC", Offset = "0x22130FC", VA = "0x7BBCA130FC")]
		private void OnBtnClick()
		{
		}

		// Token: 0x06005BF4 RID: 23540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BF4")]
		[Address(RVA = "0x2212AA8", Offset = "0x2212AA8", VA = "0x7BBCA12AA8")]
		private void SetButtonState()
		{
		}

		// Token: 0x06005BF5 RID: 23541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BF5")]
		[Address(RVA = "0x22131F4", Offset = "0x22131F4", VA = "0x7BBCA131F4")]
		public UIEPDailyTaskRewardItemController()
		{
		}

		// Token: 0x06005BF6 RID: 23542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BF6")]
		[Address(RVA = "0x22131FC", Offset = "0x22131FC", VA = "0x7BBCA131FC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F71C", Offset = "0x113F71C")]
		private void <OnEPDailyProcessAnimDone>b__7_0()
		{
		}

		// Token: 0x04007E43 RID: 32323
		[Token(Token = "0x4007E43")]
		[FieldOffset(Offset = "0x58")]
		private UIEPDailyTaskRewardItemView m_View;

		// Token: 0x04007E44 RID: 32324
		[Token(Token = "0x4007E44")]
		[FieldOffset(Offset = "0x60")]
		private EPDailyRewardInfo m_Data;

		// Token: 0x04007E45 RID: 32325
		[Token(Token = "0x4007E45")]
		[FieldOffset(Offset = "0x68")]
		private float animTime;
	}
}
