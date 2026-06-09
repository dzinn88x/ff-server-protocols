using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001987 RID: 6535
	[Token(Token = "0x2001987")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6794", Offset = "0x10F6794")]
	internal class UIHudTweenTipsController : UIBaseController
	{
		// Token: 0x06008541 RID: 34113 RVA: 0x00024270 File Offset: 0x00022470
		[Token(Token = "0x6008541")]
		[Address(RVA = "0x15ED700", Offset = "0x15ED700", VA = "0x7BBBDED700")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008542 RID: 34114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008542")]
		[Address(RVA = "0x15ED750", Offset = "0x15ED750", VA = "0x7BBBDED750", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008543 RID: 34115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008543")]
		[Address(RVA = "0x15ED7B4", Offset = "0x15ED7B4", VA = "0x7BBBDED7B4", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06008544 RID: 34116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008544")]
		[Address(RVA = "0x15ED7BC", Offset = "0x15ED7BC", VA = "0x7BBBDED7BC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008545 RID: 34117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008545")]
		[Address(RVA = "0x15ED884", Offset = "0x15ED884", VA = "0x7BBBDED884")]
		public void SetMessage(string message, float duration)
		{
		}

		// Token: 0x06008546 RID: 34118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008546")]
		[Address(RVA = "0x15EDA40", Offset = "0x15EDA40", VA = "0x7BBBDEDA40")]
		private void AutoHide()
		{
		}

		// Token: 0x06008547 RID: 34119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008547")]
		[Address(RVA = "0x15ED7E4", Offset = "0x15ED7E4", VA = "0x7BBBDED7E4")]
		private void CancelDelayCall()
		{
		}

		// Token: 0x06008548 RID: 34120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008548")]
		[Address(RVA = "0x15EDAE8", Offset = "0x15EDAE8", VA = "0x7BBBDEDAE8", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06008549 RID: 34121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008549")]
		[Address(RVA = "0x15EDB10", Offset = "0x15EDB10", VA = "0x7BBBDEDB10")]
		public UIHudTweenTipsController()
		{
		}

		// Token: 0x040094F9 RID: 38137
		[Token(Token = "0x40094F9")]
		[FieldOffset(Offset = "0x58")]
		private UIHudTweenTipsView m_View;

		// Token: 0x040094FA RID: 38138
		[Token(Token = "0x40094FA")]
		[FieldOffset(Offset = "0x60")]
		private uint m_DelayCallID;
	}
}
